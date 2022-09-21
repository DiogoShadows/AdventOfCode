using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Days
{
    public class Day_11
    {
        public static List<List<int>> Matrix = new List<List<int>>();
        public static List<string> Flashed = new List<string>();

        public static int PartOne(List<List<int>> matrix)
        {
            int result = 0;
            Matrix = matrix;

            for(int i = 1; i <= 100; i++)
            {
                Flashed = new List<string>();

                for (int row = 0; row < Matrix.Count; row++)
                {
                    for(int column = 0; column < Matrix[row].Count; column++)
                    {
                        result += Recursion(row, column, 0);
                    }
                }
            }

            return result;
        }

        public static int Recursion(int row, int column, int flashed)
        {
            if (row < 0 || row >= Matrix.Count() || column < 0 || column >= Matrix[0].Count() || Flashed.Any(x => x == $"{row}|{column}"))
                return flashed;

            Matrix[row][column]++;

            if (Matrix[row][column] <= 9)
                return flashed;

            flashed++;
            Matrix[row][column] = 0;
            Flashed.Add($"{row}|{column}");

            flashed = Recursion(row + 1, column, flashed);
            flashed = Recursion(row - 1, column, flashed);
            flashed = Recursion(row, column + 1, flashed);
            flashed = Recursion(row, column - 1, flashed);

            flashed = Recursion(row + 1, column + 1, flashed);
            flashed = Recursion(row - 1, column - 1, flashed);
            flashed = Recursion(row + 1, column - 1, flashed);
            flashed = Recursion(row - 1, column + 1, flashed);

            return flashed;
        }
    }
}
