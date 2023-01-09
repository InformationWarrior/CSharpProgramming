//1.

using System;
using static System.Console;
class Program
{
    static void Main()
    {
        Write("Enter number = ");
        int n = int.Parse(ReadLine());
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                count++;
        }
        if (count==2)
            WriteLine("Prime");
        else
            WriteLine("Not Prime");
    }
}
