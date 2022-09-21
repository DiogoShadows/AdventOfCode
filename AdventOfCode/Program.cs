using AdventOfCode2021.Days;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> lista = new List<List<int>>();

            for(int i = 0; i < INPUT.Length; i++)
            {
                var linha = new List<int>();
                foreach(var caracter in INPUT[i])
                {
                    linha.Add(Int32.Parse(caracter.ToString()));
                }

                lista.Add(linha);
            }

            Console.WriteLine(Day_11.PartOne(lista));
        }
        public static string[] INPUT = new string[] { "1443582148", "6553734851", "1451741246", "8835218864", "1662317262", "1731656623", "1128178367", "5842351665", "6677326843", "7381433267" };
    }

}