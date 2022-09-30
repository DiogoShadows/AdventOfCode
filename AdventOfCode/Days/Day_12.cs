using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Days
{
    public class Day_12
    {
        public static List<string> endPaths = new List<string>();
        public static List<List<string>> PATHS = new List<List<string>>();

        public static int PartOne(List<List<string>> path)
        {
            PATHS = path;
            Recursion("start", "");

            return endPaths.Count();
        }

        public static void Recursion(string cave, string path)
        {
            List<string> connectedCaves = PATHS.First(x => x[0].Split(" - ")[0].Equals(cave));

            if(cave.Equals("end"))
            {
                endPaths.Add(path + "|" + cave);
                return;
            }

            foreach(string connectedCave in connectedCaves)
            {
                if (cave.Equals(cave.ToLower()) && path.Split("|").Any(x => x == cave))
                    continue;

                else
                    Recursion(connectedCave.Split(" - ")[1], path + "|" + cave);
            }
        }
    }
}
