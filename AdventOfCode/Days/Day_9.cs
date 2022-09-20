using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Days
{
    public class Day_9
    {

        public static int PartTwo(List<List<int>> matrix)
        {
            List<int> biggest = new List<int> { 0, 0, 0 };
            
            for (int i = 0; i < matrix.Count(); i++)
            {
                for(int a = 0; a < matrix[0].Count(); a++)
                {
                    if(matrix[i][a] != 9)
                    {
                        var total = Recursion(i, a, 0, matrix);

                        if (total >= biggest.First())
                        {
                            biggest[0] = total;
                            biggest = biggest.OrderBy(x => x).ToList();
                        }
                    }
                }
            }

            return biggest[0] * biggest[1] * biggest[2];
        }

        public static int Recursion(int row, int column, int total, List<List<int>> matrix)
        {
            if (row < 0 || row >= matrix.Count() || column < 0 || column >= matrix[0].Count() || matrix[row][column] == 9 || matrix[row][column] == -3 )
                return total;

            total++;
            matrix[row][column] = - 3;

            total = Recursion(row + 1, column, total, matrix);
            total = Recursion(row - 1 , column, total, matrix);
            total = Recursion(row, column + 1, total, matrix);
            total = Recursion(row, column - 1, total, matrix);

            return total;
        }
    }
}
