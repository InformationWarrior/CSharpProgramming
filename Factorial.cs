//1.

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

//2. Making Factorial Method

using System;
using static System.Console;
class Program
{
    static void Main()
    {
        Write("Enter number = ");
        int num = int.Parse(ReadLine());
        WriteLine("Factorial = {0}", Factorial(num));
        Read();
    }
    static int Factorial(int num)
    {
        int fact = 1;
        if (num == 0 || num == 1)
            return fact;

        for (int i = 2; i <= num; i++)
            fact *= i;
        return fact;
    }
}

//3. Using Recursion

using System;
using static System.Console;
class Program
{
    static void Main()
    {
        Write("Enter number = ");
        int num = int.Parse(ReadLine());
        WriteLine("Factorial = {0}", Factorial(num));
        Read();
    }
    static int Factorial(int num)
    {
        int factorial;

        if (num == 0 || num == 1)
            return 1;
        else
            factorial = num * Factorial(num - 1);

        return factorial;
    }
}
