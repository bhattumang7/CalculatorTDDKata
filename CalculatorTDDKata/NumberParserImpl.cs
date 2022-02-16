﻿using System;
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
            List<char> delimeters = new List<char>() { ',', '\n' };
            List<int> listNumbers = new List<int>();
            if ("".Equals(numbers))
            {
                return listNumbers;
            }
            if (StringHasCustomDelimeters(numbers))
            {
                delimeters.Add(numbers[2]);
                numbers = numbers.Substring(4);
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

        private bool StringHasCustomDelimeters(string numbers)
        {
            return numbers.StartsWith("//") && numbers.Contains("\n");
        }
    }
}
