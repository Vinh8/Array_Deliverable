// Name: Vinh Huynh
// Date: 09/15/2022
using System;

internal class Program
{
    private static void Main(string[] args)

    {
        int count = 25;
        int[] fibonacci = new int[count];
        fibonacci[0] = 0;
        fibonacci[1] = 1;

        for (int i = 0; i < count; i++)
        {
            if (i >= 2)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }
            
            Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
        }
    }
}