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
        public static int sumVersions = 0;

        public static void Program()
        {
            string binary = "";

            foreach(var item in INPUT1)
            {
                binary += HEXABINARY[item];
            }

            Recursion(binary);

            Console.WriteLine(sumVersions);
        }

        public static void Recursion(string packet)
        {
            if (packet.Length <= 0)
                return;

            var version = packet.Substring(0, 3);
            var type = HEXABINARY.FirstOrDefault(x => x.Value == $"0{packet.Substring(3, 3)}").Key;
            sumVersions += Int32.Parse(type.ToString());

            if (type == '4')
            {
                var restString = packet.Substring(6);
                int i = 0;

                for (; i < restString.Length; i += 5)
                {
                    if (restString[i] == 0)
                        break;
                }

                if (i + 5 > restString.Length)
                    return;

                Recursion(restString.Substring(i));
            }

            else
            {
                var lenghtTypeId = HEXABINARY.FirstOrDefault(x => x.Value == $"0{packet.Substring(6, 1)}").Key;

                int size = lenghtTypeId == '1' ? 11 : 15;
            }
        }
    }
}
