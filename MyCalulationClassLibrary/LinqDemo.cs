using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalulationClassLibrary
{
    public class LinqDemo
    {
        public static int TryParseAndSum(string? intput)
        {
            return intput?.Split(' ')
                .Select((string str) =>
                {
                    int.TryParse(str, out var number);
                    return number;
                })
                .Sum() ?? 0;
        }
    }
}
