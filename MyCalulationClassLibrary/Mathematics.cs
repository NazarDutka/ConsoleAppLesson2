using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalulationClassLibrary
{
    public class Mathematics
    {
        public static int Sum(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }
    }
}
