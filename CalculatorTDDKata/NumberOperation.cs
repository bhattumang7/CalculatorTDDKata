using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDDKata
{
    public class NumberOperation
    {
        NumberParser _numberParser;
        public NumberOperation(NumberParser numberParser)
        {
            _numberParser = numberParser;
        }
        public int Add(string numbers)
        {
            List<int> lstNumbers = _numberParser.ParseSumNumbers(numbers);
            int sum = 0;
            foreach (var item in lstNumbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}
