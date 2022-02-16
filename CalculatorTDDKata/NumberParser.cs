using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDDKata
{
    public interface NumberParser
    {
        List<int> ParseSumNumbers(string numbers);
    }
}
