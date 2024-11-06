using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class StringSearch
    {

        /// <summary>
        /// FindSubstringOccurrences
        /// </summary>
        /// <param name="input"></param>
        /// <param name="substring"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        ///------------------------------
        ///  string input = "abcabcabc";
        /// string substring = "abc"; response
        /// Indices: 0, 3, 6
        public static List<int> FindSubstringOccurrences(string input, string substring)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(substring))
            {
                throw new ArgumentException("Input and substring cannot be null or empty.");
            }

            List<int> indices = new List<int>();
            int index = 0;

            while ((index = input.IndexOf(substring, index)) != -1)
            {
                indices.Add(index);
                index += substring.Length; // Move past the current match
            }

            return indices;
        }
    }
}
