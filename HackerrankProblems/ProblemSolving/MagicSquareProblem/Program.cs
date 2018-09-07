using System;
using System.Linq;

namespace HackerrankProblems
{
    partial class Program
    {
        /// <summary>
        /// Solving this problem https://www.hackerrank.com/challenges/magic-square-forming/problem
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int FormingMagicSquare(int[][] s)
        {
            var input = new int[9];

            var index = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    input[index++] = s[i][j];
                }
            }

            int[][] allMagics = new int[][]
                        {
                            new int[] { 8, 1, 6, 3, 5, 7, 4, 9, 2},
                             new int[] { 6, 1, 8, 7, 5, 3, 2, 9, 4},
                             new int[] { 4, 9, 2, 3, 5, 7, 8, 1, 6},
                             new int[] { 2, 9, 4, 7, 5, 3, 6, 1, 8},
                             new int[] { 8, 3, 4, 1, 5, 9, 6, 7, 2},
                             new int[] { 4, 3, 8, 9, 5, 1, 2, 7, 6},
                             new int[] { 6, 7, 2, 1, 5, 9, 8, 3, 4},
                             new int[] { 2, 7, 6, 9, 5, 1, 4, 3, 8}};

            var sums = from ar in allMagics
                       select ar.Zip(input, (a, b) => Math.Abs(a - b)).Sum();

            return sums.Min();
        }
    }
}
