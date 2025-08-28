using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GenAI_MarkovTextGenerator
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Markov Text Generator (C#) ===\n");

            // 1) Provide or paste your training corpus here.
            // Tip: Replace this with your own text—lyrics, essays, fairy tales, etc.
            string corpus = @"
        Once upon a time there was a small village by the sea. Every morning the sun rose
        like a golden coin tossed across the sky, and the waves told stories to the shore.
        The villagers baked bread, mended nets, and traded rumors with the gulls.
        Sometimes, when the wind turned thoughtful, the lighthouse hummed a tune.
        ";

            // 2) Basic interactive knobs
            int order = AskInt("Order (1-5 recommended)", 2, min: 1, max: 8);
            int length = AskInt("Generate how many words", 120, min: 10, max: 2000);
            double temperature = AskDouble("Temperature (0.2-1.5, lower = safer)", 0.9, 0.1, 3.0);
            int topK = AskInt("Top-k (0 = disabled; typical 20-100)", 40, 0, 500);

            // Optional seed prompt to steer the first few words
            Console.Write("Seed (optional, press Enter to skip): ");
            string seed = Console.ReadLine() ?? "";

            // 3) Train & generate
            var tokenizer = new SimpleTokenizer();
            var tokens = tokenizer.Tokenize(corpus);

            if (tokens.Count < order + 1)
            {
                Console.WriteLine("Corpus too small for the chosen order. Add more text or lower the order.");
                return;
            }

            var model = new MarkovModel(order);
            model.Train(tokens);

            var rnd = new Random(42);
            var generated = model.Generate(
                length: length,
                temperature: temperature,
                topK: topK,
                seed: tokenizer.Tokenize(seed),
                rng: rnd
            );

            string text = tokenizer.Detokenize(generated);
            Console.WriteLine("\n--- Generated Text ---\n");
            Console.WriteLine(text);
            Console.WriteLine("\nDone.");
        }

        // ===== Utilities for console input =====
        static int AskInt(string label, int def, int min, int max)
        {
            while (true)
            {
                Console.Write($"{label} [{def}]: ");
                var s = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(s)) return def;
                if (int.TryParse(s, out int v) && v >= min && v <= max) return v;
                Console.WriteLine($"Enter an integer between {min} and {max}.");
            }
        }

        static double AskDouble(string label, double def, double min, double max)
        {
            while (true)
            {
                Console.Write($"{label} [{def}]: ");
                var s = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(s)) return def;
                if (double.TryParse(s, out double v) && v >= min && v <= max) return v;
                Console.WriteLine($"Enter a number between {min} and {max}.");
            }
        }
    }

    // ===== Tokenizer =====
    // Simple word/punctuation tokenizer that keeps punctuation as separate tokens
    // so detokenization can reconstruct readable sentences.
    class SimpleTokenizer
    {
        // Splits on word boundaries, keeps punctuation as tokens
        private static readonly Regex TokenRegex = new Regex(
            @"\w+|[^\s\w]",
            RegexOptions.Compiled | RegexOptions.CultureInvariant);

        public List<string> Tokenize(string text)
        {
            return TokenRegex.Matches(text)
                             .Select(m => m.Value)
                             .ToList();
        }

        public string Detokenize(List<string> tokens)
        {
            var sb = new StringBuilder();
            string prev = "";
            foreach (var tok in tokens)
            {
                // No space before punctuation; space before words
                if (IsPunct(tok) || prev == "" || IsOpenQuote(tok) || prev == "“" || prev == "‘")
                {
                    sb.Append(tok);
                }
                else
                {
                    // Add a space before non-punct tokens
                    if (!IsClosePunct(prev)) sb.Append(' ');
                    sb.Append(tok);
                }
                prev = tok;
            }
            return sb.ToString()
                     .Replace(" ,", ",")
                     .Replace(" .", ".")
                     .Replace(" !", "!")
                     .Replace(" ?", "?")
                     .Replace(" ;", ";")
                     .Replace(" :", ":");
        }

        private bool IsPunct(string t) =>
            t.Length == 1 && char.IsPunctuation(t[0]);

        private bool IsOpenQuote(string t) => t == "“" || t == "‘";
        private bool IsClosePunct(string t) => IsPunct(t) && t != "(" && t != "[" && t != "{";
    }

    // ===== Markov Model =====
    class MarkovModel
    {
        private readonly int _order;

        // Map: context tuple -> (nextToken -> count)
        private readonly Dictionary<string, Dictionary<string, int>> _table =
            new Dictionary<string, Dictionary<string, int>>();

        public MarkovModel(int order) => _order = Math.Max(1, order);

        public void Train(List<string> tokens)
        {
            for (int i = 0; i + _order < tokens.Count; i++)
            {
                var context = string.Join("\u241F", tokens.Skip(i).Take(_order)); // unit separator
                var next = tokens[i + _order];

                if (!_table.TryGetValue(context, out var dist))
                {
                    dist = new Dictionary<string, int>();
                    _table[context] = dist;
                }
                if (!dist.ContainsKey(next)) dist[next] = 0;
                dist[next]++;
            }
        }

        public List<string> Generate(int length, double temperature, int topK, List<string> seed, Random rng)
        {
            // Seed handling: use last _order tokens of seed if available; otherwise pick random context
            var contextTokens = new Queue<string>();
            if (seed != null && seed.Count >= _order)
            {
                foreach (var t in seed.Skip(seed.Count - _order)) contextTokens.Enqueue(t);
            }
            else
            {
                // random starting context for diversity
                var keys = _table.Keys.ToList();
                var startKey = keys[rng.Next(keys.Count)];
                foreach (var t in startKey.Split('\u241F')) contextTokens.Enqueue(t);
            }

            var output = new List<string>(contextTokens);

            for (int i = 0; i < Math.Max(0, length - _order); i++)
            {
                var key = string.Join("\u241F", contextTokens);
                if (!_table.TryGetValue(key, out var dist))
                {
                    // If we hit an unseen context, restart from a random state
                    var keys = _table.Keys.ToList();
                    key = keys[rng.Next(keys.Count)];
                    dist = _table[key];
                    contextTokens.Clear();
                    foreach (var t in key.Split('\u241F')) contextTokens.Enqueue(t);
                }

                string next = Sample(dist, temperature, topK, rng);
                output.Add(next);

                // Slide the context window
                contextTokens.Enqueue(next);
                while (contextTokens.Count > _order) contextTokens.Dequeue();
            }

            return output;
        }

        private string Sample(Dictionary<string, int> counts, double temperature, int topK, Random rng)
        {
            // Convert counts to probabilities
            var items = counts.Select(kv => (token: kv.Key, p: (double)kv.Value)).ToList();

            // Normalize
            double sum = items.Sum(i => i.p);
            if (sum <= 0) return items[rng.Next(items.Count)].token;
            items = items.Select(i => (i.token, i.p / sum)).ToList();

            // Top-k filtering
            if (topK > 0 && topK < items.Count)
            {
                items = items.OrderByDescending(i => i.p).Take(topK).ToList();
                double s2 = items.Sum(i => i.p);
                items = items.Select(i => (i.token, i.p / s2)).ToList();
            }

            // Temperature scaling (softmax with temperature)
            temperature = Math.Max(0.05, temperature);
            var scaled = items.Select(i => (i.token, p: Math.Pow(i.p, 1.0 / temperature))).ToList();
            double z = scaled.Sum(i => i.p);
            var probs = scaled.Select(i => (i.token, p: i.p / z)).ToList();

            // Sample
            double r = rng.NextDouble();
            double acc = 0;
            foreach (var (token, p) in probs)
            {
                acc += p;
                if (r <= acc) return token;
            }
            return probs.Last().token; // fallback
        }
    }

}
