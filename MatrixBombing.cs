using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBombing
{
    class MatrixBombing
    {
        static void Main(string[] args)
        {

            Console.Write("Number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Number of cols: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Enter the cells of the matrix: ");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                input.ToCharArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            BombMat(matrix);
        }
        private static void BombMat(int [,] matrix)
        {
            int rowBoom = int.Parse(Console.ReadLine());
            int colBoom = int.Parse(Console.ReadLine());
            int bombVal = matrix[rowBoom, colBoom];
            for (int i = rowBoom-1; i <= rowBoom+1; i++)
            {
                for (int j = colBoom-1; j <= colBoom+1; j++)
                {
                    if ((i<0||i>=matrix.GetLength(0))||(j<0||j>=matrix.GetLength(1)))
                    {
                        continue;
                        if (i == rowBoom && j == colBoom)
                        {
                            continue;
                        }
                        if ((matrix[i, j] - bombVal) < 0)
                        {
                            matrix[i, j] = 0;
                        }
                        else
                        {
                            matrix[i, j] = matrix[i, j] - bombVal;
                        }
                    }
                }
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        Console.Write(" " + matrix[j,k]);
                    }
                    Console.WriteLine();
                
                }
            }
        }
    }
}