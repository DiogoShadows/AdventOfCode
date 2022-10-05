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

        public static int Program()
        {
            for (int i = 0; i < INPUTTEST2.Length; i++)
            {
                var palavras = INPUTTEST2[i].Split(" - ");

                var item = PATHS.FirstOrDefault(x => x.FirstOrDefault().Split(" - ")[0] == palavras[0]);

                if (item != null)
                    item.Add(INPUTTEST2[i]);

                else
                    PATHS.Add(new List<string> { INPUTTEST2[i] });

                item = PATHS.FirstOrDefault(x => x.FirstOrDefault().Split(" - ")[0] == palavras[1]);

                if (item != null)
                {
                    item.Add(palavras[1] + " - " + palavras[0]);
                }

                else
                    PATHS.Add(new List<string> { palavras[1] + " - " + palavras[0] });
            }

            RecursionDayTwo("start", "");

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

        public static void RecursionDayTwo(string cave, string path)
        {
            List<string> connectedCaves = PATHS.First(x => x[0].Split(" - ")[0].Equals(cave));

            if (cave.Equals("end"))
            {
                endPaths.Add(path + "|" + cave);
                return;
            }

            foreach (string connectedCave in connectedCaves)
            {
                var groupOfLowerCaves = path.Split("|").Where(x => x.Equals(x.ToLower())).GroupBy(x => x).ToList();
                var cavesVisitedMoreThanOneTime = groupOfLowerCaves.Where(x => x.Count() > 1).Count();
                var groupOfLowerCavesDiferentThanCurrentCave = path.Split("|").Where(x => x.Equals(x.ToLower()) && x != cave).GroupBy(x => x).ToList();
                var cavesVisitedMoreThanOneTimeDiferentThanCurrentCave = groupOfLowerCavesDiferentThanCurrentCave.Where(x => x.Count() > 1).Count();

                if (cavesVisitedMoreThanOneTime >= 2 || (cavesVisitedMoreThanOneTimeDiferentThanCurrentCave >= 1 && 
                    cave.Equals(cave.ToLower()) && path.Split("|").Any(x => x.Equals(cave))) || 
                    (cave.Equals(cave.ToLower()) && path.Split("|").Where(x => x.Equals(cave)).Count() >= 2) || 
                    (cave.Equals("start") && path.Split("|").Any(x => x.Equals("start"))))
                {
                    return;
                }

                else
                    RecursionDayTwo(connectedCave.Split(" - ")[1], path + "|" + cave);
            }
        }

        public static string[] INPUTTEST1 = { "start - A", "start - b", "A - c", "A - b", "b - d", "A - end", "b - end" };
        public static string[] INPUTTEST2 = { "by - TW", "start - TW", "fw - end", "QZ - end", "JH - by", "ka - start", "ka - by", "end - JH", "QZ - cv", "vg - TI", "by - fw", "QZ - by", "JH - ka", "JH - vg", "vg - fw", "TW - cv", "QZ - vg", "ka - TW", "ka - QZ", "JH - fw", "vg - hu", "cv - start", "by - cv", "ka - cv" };

    }
}
