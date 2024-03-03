using System;

namespace MyCalulationClassLibrary
{
    public class Converters
    {
        public static int[] ToInt(params string[] strings)
        {
            int [] result = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                string str = strings[i];
                int.TryParse(str, out var number);
                result[i] = number;
            }
            return result;
        }
    }
}
