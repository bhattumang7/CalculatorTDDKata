using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDDKata
{
    public class NumberParserImpl : NumberParser
    {
        private const int IndexOfDelimiterInString = 2;
        private const int CustomDelimeterLineLastCharIndexPlusOne = 4;
        public List<int> ParseSumNumbers(string numbers)
        {
            List<char> delimeters = new List<char>() { ',', '\n' };
            List<int> listNumbers = new List<int>();
            if ("".Equals(numbers))
            {
                return listNumbers;
            }
            if (StringHasCustomDelimiters(numbers))
            {
                delimeters.Add(ExtractDelimiterFromString(numbers));
                numbers = RemoveDelimeterLineFromString(numbers);
            }
            if (StringContainsDelimeters(numbers, delimeters))
            {
                string[] numberPieces = numbers.Split(delimeters.ToArray());
                foreach (var number in numberPieces)
                {
                    listNumbers.Add(int.Parse(number));
                }
            }
            else
            {
                listNumbers.Add(int.Parse(numbers));
            }
            return listNumbers;
        }

        private bool StringContainsDelimeters(string numbers, List<char> delimeters)
        {
            bool contains = false;

            foreach (var delimeter in delimeters)
            {
                if (numbers.Contains(delimeter))
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        private bool StringHasCustomDelimiters(string numbers)
        {
            return numbers.StartsWith("//") && numbers.Contains("\n");
        }

        private char ExtractDelimiterFromString(string numbers)
        {
            return numbers[IndexOfDelimiterInString];
        }

        private string RemoveDelimeterLineFromString(string numbers)
        {
            // If numbers is
            // //;\n1;2
            // then we remove upto \n and return rest of the string
            return numbers.Substring(CustomDelimeterLineLastCharIndexPlusOne);
        }
    }
}
