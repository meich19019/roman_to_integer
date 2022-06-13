using System;
using System.Collections.Generic;

namespace roman_to_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.RomanToInt("MCMXCIV"));
        }
    }

    public class Solution
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, string> romanTable = new Dictionary<string, string>(){
            {"CM", "+900"},
            {"CD", "+400"},
            {"XC", "+90"},
            {"XL", "+40"},
            {"IX", "+9"},
            {"IV", "+4"},
            {"M", "+1000"},
            {"D", "+500"},
            {"C", "+100"},
            {"L", "+50"},
            {"X", "+10"},
            {"V", "+5"},
            {"I", "+1"}
        };
            foreach (KeyValuePair<string, string> keyValuePair in romanTable)
            {
                s = s.Replace(keyValuePair.Key, keyValuePair.Value);
            }
            string[] number = s.Split('+');
            int sum = 0;
            for (int i = 1; i < number.Length; i++)
            {
                sum += int.Parse(number[i]);
            }
            return sum;
        }
    }
}
