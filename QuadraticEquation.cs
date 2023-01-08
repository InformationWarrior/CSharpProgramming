using System;
using static System.Console;
class Program
{
    static void Main()
    {
        WriteLine("Enter a, b, c : ");
        float[] arr = Array.ConvertAll(ReadLine().Split(), float.Parse);
        float a = arr[0];
        float b = arr[1];
        float c = arr[2];
        float root1, root2;
        float determinant = b * b - 4 * a * c;
        if (determinant > 0)
        {
            WriteLine("Real and distinct roots");
            root1 = (-b + (float)Math.Sqrt(determinant)) / (2 * a);
            root2 = (-b - (float)Math.Sqrt(determinant)) / (2 * a);
            WriteLine("Roots are : {0} and {1}", root1, root2);
        }
        else if (determinant == 0)
        {
            WriteLine("Roots are real and equal.");
            root1 = -b / (2 * a);
            WriteLine("Roots are : {0} and {1}", root1, root1);
        }
        else
        {
            WriteLine("Roots are imagimary.");
        }
        Read();
    }
}
