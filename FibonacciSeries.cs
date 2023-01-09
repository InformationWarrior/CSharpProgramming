//1.

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

//2. Using recursion

using System;
using static System.Console;
class Program
{
    static void Main()
    {
        Write("Enter number: ");
        int num = int.Parse(ReadLine());
        for (int i = 1; i <= num; i++)
            Write(Fibonacci(i) + " ");
        Read();
    }

    static int Fibonacci(int num)
    {
        if (num == 1 || num == 2)
            return 1;
        else
            return (Fibonacci(num - 1) + Fibonacci(num - 2));
    }
}
