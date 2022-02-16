using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDDKata
{
    /// <summary>
    /// Number parser implementatino
    /// </summary>
    public class NumberParserImpl : NumberParser
    {
        private const int IndexOfDelimiterInString = 2;
        private const int CustomDelimeterLineLastCharIndexPlusOne = 4;

        public List<int> ParseSumNumbers(string numbers)
        {
            List<char> delimeters = new List<char>() { ',', '\n' }; // pre popualate the list of delimiters

            List<int> listNumbers = new List<int>();
            if ("".Equals(numbers))
            {
                return listNumbers;
            }

            if (StringHasCustomDelimiters(numbers))
            {
                // if a custom delimiter is present, over ride other delimiters
                delimeters = new List<char>() { ExtractDelimiterFromString(numbers) };

                numbers = RemoveDelimeterLineFromString(numbers);
            }

            string[] numberPieces = numbers.Split(delimeters.ToArray());
            foreach (var number in numberPieces)
            {
                listNumbers.Add(int.Parse(number));
            }

            return listNumbers;
        }


        /// <summary>
        /// Method returns true if the numbers string has custom delimiter in beginnning 
        /// </summary>
        private bool StringHasCustomDelimiters(string numbers)
        {
            return numbers.StartsWith("//") && numbers.Contains("\n");
        }

        /// <summary>
        /// Extrcts delimiter character from string
        /// </summary>
        private char ExtractDelimiterFromString(string numbers)
        {
            return numbers[IndexOfDelimiterInString];
        }

        /// <summary>
        /// Removes delimeter line from the numbers string
        /// </summary>
        private string RemoveDelimeterLineFromString(string numbers)
        {
            // If numbers is
            // //;\n1;2
            // then we remove upto \n and return rest of the string
            return numbers.Substring(CustomDelimeterLineLastCharIndexPlusOne);
        }
    }
}
