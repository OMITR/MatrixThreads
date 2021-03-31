using System;

namespace MatrixThreads
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int Size = 3;
            int[,] FirstMatrix = new int[Size, Size];
            int[,] SecondMatrix = new int[Size, Size];

            Random rnd = new Random();
            Console.WriteLine("Матрица A:");

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    FirstMatrix[i, j] = rnd.Next(0, 10);
                    Console.Write(FirstMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nМатрица B:");

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    SecondMatrix[i, j] = rnd.Next(0, 10);
                    Console.Write(SecondMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }


            Console.WriteLine("\nМатрица A * B:");
            Multiplication(FirstMatrix, SecondMatrix);
        }

        static void Multiplication(int[,] firstMatrix, int[,] secondMatrix)
        {
            int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < secondMatrix.GetLength(0); k++)
                    {
                        resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", resultMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
