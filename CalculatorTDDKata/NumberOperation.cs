using System;
using System.Collections.Generic;

namespace CalculatorTDDKata
{
    public class NumberOperation
    {
        NumberParser _numberParser;

        /// <summary>
        /// Constructor to inject dependencies
        /// </summary>
        public NumberOperation(NumberParser numberParser)
        {
            _numberParser = numberParser;
        }

        public int Add(string numbers)
        {
            List<int> lstNumbers = _numberParser.ParseSumNumbers(numbers);

            string errorMessage = "List of negativeNumbers is:";
            bool negativeFound = false;
            bool addCommaInError = false;

            int sum = 0;
            foreach (var item in lstNumbers)
            {
                if(item < 0 )
                {
                    negativeFound = true;
                    if (addCommaInError == true)
                    {
                        errorMessage += ", " + item;
                    }
                    else
                    {
                        errorMessage += " " + item;
                    }
                    addCommaInError = true;

                }
                sum += item;
            }
            if (negativeFound == true)
            {
                throw new ArgumentException(errorMessage);
            }
            return sum;
        }
    }
}
