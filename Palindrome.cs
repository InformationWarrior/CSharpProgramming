using System;
using static System.Console;
class Program
{
    static void Main()
    {
        WriteLine("Enter number: ");
        int num = int.Parse(ReadLine());
        int z = num;
        int rev = 0;
        while (z>0)
        {
            int digit = z % 10;
            z /= 10;
            rev = (rev*10) + digit;
        }
        if (rev == num)
            WriteLine("Palindrome");
        else
            WriteLine("Not Palindrome");
        Read();
    }
}
