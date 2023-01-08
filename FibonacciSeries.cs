using System;
using static System.Console;
class Program
{
    static void Main()
    {
        WriteLine("Enter number: ");
        int n = int.Parse(ReadLine());
        int a = 0; int b = 1;
        Write(a + " " + b + " ");
        for (int i = 2; i < n; i++)
        {
            int c = a + b;
            Write(c + " ");
            a = b;
            b = c;
        }
        Read();
    }
}
