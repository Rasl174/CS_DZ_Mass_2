using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Mass_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matrix = new int[10, 10];
            
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            int maxValue = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                    }
                }
            }

            Console.WriteLine("\nМаксимальное значение: " + maxValue);
            Console.WriteLine("\nНовый массив: \n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == maxValue) 
                        matrix[i, j] = 0;
                    Console.Write("{0}", matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
