using static System.Console;
using System;
class Program
{
    static void Main()
    {
        WriteLine("Enter order = ");
        int n = int.Parse(ReadLine());

        WriteLine("Input Matrix A");
        int[,] matrixA = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            int[] temp = Array.ConvertAll(ReadLine().Split(), int.Parse);
            for (int j = 0; j < n; j++)
            {
                matrixA[i, j] = temp[j];
            }
        }

        WriteLine("Input Matrix B");
        int[,] matrixB = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            int[] temp = Array.ConvertAll(ReadLine().Split(), int.Parse);
            for (int j = 0; j < n; j++)
            {
                matrixB[i, j] = temp[j];
            }
        }

        //Multiplication
        int[,] matrixC = new int[n,n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrixC[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        WriteLine("Multiplication Output");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Write(matrixC[i, j] + " ");
            }
            WriteLine();
        }
    }
}
