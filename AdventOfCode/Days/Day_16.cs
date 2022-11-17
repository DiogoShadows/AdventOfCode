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
                binary += HEXABINARY[item];
            }

            var typeId = binary.Substring(3, 3);
            var type = HEXABINARY.FirstOrDefault(x => x.Value == $"0{typeId}").Key;
            string result = "";

            //TODO - For now, the first packet has other packets inside
            if(type == '4')
            {
                var restString = binary.Substring(6);

                for(int i = 0; i < restString.Length; i += 5)
                {
                    if (restString.Length - 1 - i < 5)
                        break;

                    result += restString.Substring(i + 1, 4);
                }

            }

            else
            {
                var lengthTypeId = binary.Substring(4, 1);

                if(lengthTypeId == "0")
                {

                }

                else
                {

                }
            }


            Console.WriteLine(result.Equals("011111100101"));
        }
    }
}
