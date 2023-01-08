using System;
using static System.Console;
class Program
{
    static void Main()
    {
        WriteLine("Enter number: ");
        int binary = int.Parse(ReadLine());
        int deci=0;
        int count = 0;
        while (binary > 0)
        {
            int digit = binary % 10;
            deci += digit * (int)Math.Pow(2, count);
            binary /= 10;
            count++;
        }
        WriteLine("Decimal equivalent = {0}", deci);
        Read();
    }
}
