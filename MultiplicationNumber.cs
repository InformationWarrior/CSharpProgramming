using System;
using static System.Console;
class Program
{
    static void Main()
    {
        Write("Enter number = ");
        int num = int.Parse(ReadLine());
        int i = 1;
        while (i <= 10)
        {
            WriteLine(num + " * " + i + " = " + num * i);
            i++;
        }
        Read();
    }
}
