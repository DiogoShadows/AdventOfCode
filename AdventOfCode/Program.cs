using AdventOfCode2021.Days;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> list = new List<List<string>>();

            for(int i = 0; i < INPUTTEST2.Length; i++)
            {
                var palavras = INPUTTEST2[i].Split(" - ");

                var item = list.FirstOrDefault(x => x.FirstOrDefault().Split(" - ")[0] == palavras[0]);

                if (item != null)
                    item.Add(INPUTTEST2[i]);

                else
                    list.Add(new List<string> { INPUTTEST2[i] });

                item = list.FirstOrDefault(x => x.FirstOrDefault().Split(" - ")[0] == palavras[1]);

                if (item != null)
                {
                    item.Add(palavras[1] + " - " + palavras[0]);
                }

                else
                    list.Add(new List<string> { palavras[1] + " - " + palavras[0] });
            }

            Console.WriteLine(Day_12.PartOne(list));
        }

        public static string[] INPUTTEST1 = { "start - A", "start - b", "A - c", "A - b", "b - d", "A - end", "b - end" };
        public static string[] INPUTTEST2 = { "by - TW","start - TW","fw - end","QZ - end","JH - by","ka - start","ka - by","end - JH","QZ - cv","vg - TI","by - fw","QZ - by","JH - ka","JH - vg","vg - fw","TW - cv","QZ - vg","ka - TW","ka - QZ","JH - fw","vg - hu","cv - start","by - cv","ka - cv" };


    }

}