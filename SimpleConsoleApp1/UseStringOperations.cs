using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class UseStringOperations
    {
        /// <summary>
        /// Reverse of the string
        /// input: Hi My name is Andrei
        /// ooutput: ierdnA si eman yM iH
        /// </summary>
        /// <returns></returns>
        public static string ReverseOfTheString(string givenString)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string[] words = givenString.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            char[] letters;

            foreach (var word in words)
            {
                letters = word.ToCharArray();
            }

            return string.Empty;
        }

    }
}
