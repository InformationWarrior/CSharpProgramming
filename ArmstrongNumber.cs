//1.

using System;
using static System.Console;
class Program
{
    static void Main()
    {
        WriteLine("Range: ");
        int range = int.Parse(ReadLine());
        for (int i = 1; i <= range; i++)
        {            
            int number = i;
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                sum += (int)Math.Pow(digit, 3);
            }
            if (sum == i) 
                WriteLine("Armstrong: " + i);
        }
    } 
}

//2.

using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int num = int.Parse(ReadLine());
        int n = num;
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            num /= 10;
            sum += (int)Math.Pow(digit, 3);
        }
        if (sum == n) 
            WriteLine("Armstrong");
        else 
            WriteLine("Not");
        WriteLine(sum);
    }
}
