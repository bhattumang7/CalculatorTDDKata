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
            if("".Equals(numbers))
            {
                return 0;
            }
            return int.Parse(numbers);
        }
    }
}
