using AdventOfCode2021.Days;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> lista = new List<List<int>>();

            for(int i = 0; i < INPUT2.Length; i++)
            {
                var linha = new List<int>();
                foreach(var caracter in INPUT2[i])
                {
                    linha.Add(Int32.Parse(caracter.ToString()));
                }

                lista.Add(linha);
            }

            Console.WriteLine(Day_11.PartOne(lista));
        }
        public static string[] INPUT2 = new string[] { "1443582148", "6553734851", "1451741246", "8835218864", "1662317262", "1731656623", "1128178367", "5842351665", "6677326843", "7381433267" };
        public static string[] INPUT = new string[] { "5483143223", "2745854711", "5264556173", "6141336146", "6357385478", "4167524645", "2176841721", "6882881134", "4846848554", "5283751526" };
    }

}