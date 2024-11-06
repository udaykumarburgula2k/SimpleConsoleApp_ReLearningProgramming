using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class RepeatedSubstringFinder
    {
        public static string FindLargestRepeatedSubstring(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            string largestRepeated = string.Empty;
            int n = input.Length;

            // Use a HashSet to track substrings we've already seen
            HashSet<string> seenSubstrings = new HashSet<string>();

            // Check all substrings
            for (int length = 1; length <= n / 2; length++)
            {
                seenSubstrings.Clear();
                for (int i = 0; i <= n - length; i++)
                {
                    string substring = input.Substring(i, length);

                    if (seenSubstrings.Contains(substring))
                    {
                        if (substring.Length > largestRepeated.Length)
                        {
                            largestRepeated = substring;
                        }
                    }
                    else
                    {
                        seenSubstrings.Add(substring);
                    }
                }
            }

            return largestRepeated;
        }
    }
}
