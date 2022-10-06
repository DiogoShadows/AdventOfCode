using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Days
{
    public class Day_13
    {
        public static string INPUTTEST1 = "6,10|0,14|9,10|0,3|10,4|4,11|6,0|6,12|4,1|0,13|10,12|3,4|3,0|8,4|1,10|2,14|8,10|9,0" ;
        public static List<List<string>> PATHS = new List<List<string>>();

        public static void Program()
        {
            var input = INPUTTEST1.Split("|");
            int xSize = input.Max(x => Int32.Parse(x.Split(",")[0]));
            int ySize = input.Max(x => Int32.Parse(x.Split(",")[1]));

            for(int y = 0; y <= ySize; y++)
            {
                List<string> row = new List<string>();

                for (int x = 0; x <= xSize; x++)
                {
                    string xAndY = $"{x},{y}";

                    if (input.Any(x => x.Equals(xAndY)))
                        row.Add("#");

                    else
                        row.Add(".");
                }

                PATHS.Add(row);
            }

            Console.WriteLine(PATHS.Sum(x => x.Where(y => y.Equals("#")).Count()));
        }
    }
}
