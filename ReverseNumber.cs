using System;
using static System.Console;
class Program
{
    static void Main()
    {
        Write("Enter number = ");
        int num = int.Parse(ReadLine());
        int reverse = 0;
        while (num > 0)
        {
            reverse = (reverse * 10) + (num % 10);
            num /= 10;
        }
        WriteLine("Reverse = " + reverse);
        Read();
    }
}
