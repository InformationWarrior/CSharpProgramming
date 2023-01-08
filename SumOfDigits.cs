using System;
using static System.Console;
class Program
{
    static void Main()
    {
        WriteLine("Number : ");
        int n = int.Parse(ReadLine());
        int sum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            n /= 10;
            sum += digit;
        }
        WriteLine(sum);
        Read();
    }
}
