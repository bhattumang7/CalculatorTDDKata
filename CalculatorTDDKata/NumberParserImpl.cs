using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDDKata
{
    public class NumberParserImpl : NumberParser
    {
        public List<int> ParseSumNumbers(string numbers)
        {
            List<int> listNumbers = new List<int>();
            if ("".Equals(numbers))
            {
                return listNumbers;
            }
            if (numbers.Contains(','))
            {
                string[] numberPieces = numbers.Split(',');
                foreach (var number in numberPieces)
                {
                    listNumbers .Add(int.Parse(number));
                }
            }
            else
            {
                listNumbers.Add(int.Parse(numbers));
            }
            return listNumbers;
        }
    }
}
