using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Days
{
    public class Day_16
    {
        public static string INPUT1 = "D2FE28";
        public static Dictionary<char, string> HEXABINARY = new Dictionary<char, string>()
        {
            {'0',"0000"},
            {'1',"0001"},
            {'2',"0010"},
            {'3',"0011"},
            {'4',"0100"},
            {'5',"0101"},
            {'6',"0110"},
            {'7',"0111"},
            {'8',"1000"},
            {'9',"1001"},
            {'A',"1010"},
            {'B',"1011"},
            {'C',"1100"},
            {'D',"1101"},
            {'E',"1110"},
            {'F',"1111"}
        }; 

        public static void Program()
        {
            string binary = "";

            foreach(var item in INPUT1)
            {
                binary += HEXABINARY.GetValueOrDefault(item);
            }

            Console.WriteLine(binary.Equals("110100101111111000101000"));
        }
    }
}
