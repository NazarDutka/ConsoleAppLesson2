using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalculationClassLibrary
{
    public class LinqDemo
    {
        public static int TryParseAndSum(string? input)
        {
            return input?.Split(' ')
                .Select((string str) =>
                {
                    int.TryParse(str, out var number);
                    return number;
                })
                .Sum() ?? 0;
        }
    }
}
