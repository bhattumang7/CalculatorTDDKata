using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDDKata
{
    public class NumberOperation
    {
        public int Add(string numbers)
        {
            if ("".Equals(numbers))
            {
                return 0;
            }
            if (numbers.Contains(','))
            {
                string[] numberPieces = numbers.Split(',');
                int sum = 0;
                foreach (var number in numberPieces)
                {
                    sum += int.Parse(number);
                }
                return sum;
            }
            return int.Parse(numbers);
        }
    }
}
