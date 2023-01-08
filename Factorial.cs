using System;
using static System.Console;
class Program
{
    static void Main()
    {
        Write("Enter number = ");
        int num = int.Parse(ReadLine());
        int factorial = 1;
        int count = 1;
        while (count <= num)
        {
            factorial *= count;
            count++;
        }
        WriteLine("Factorial = " + factorial);
        Read();
    }
}
