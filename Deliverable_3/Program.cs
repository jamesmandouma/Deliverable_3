/*
Author: James Mandouma
Date: 1/31/2023
Description: C# app to demonstrate iterative statements.
*/

using System.Runtime.CompilerServices;

namespace Deliverable_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    Console.WriteLine("Enter an integer value between 1 and 100");
                    int integer = int.Parse(Console.ReadLine());

                    Console.WriteLine("Specify a series of integer numbers: even or odd");
                    string seriesType = Console.ReadLine();
                    int count = 1;

                    if (seriesType == "odd" || seriesType == "Odd")
                    {
                        count = -1;
                        do
                        {
                            Console.WriteLine("You have selected the " + seriesType + " series. The numbers between 0 and " + integer + " are:");
                            count = count + 2;
                            Console.WriteLine(count);
                        }
                        while (count < integer);
                    }
                    else if (seriesType == "even" || seriesType == "Even")
                    {
                        count = -2;
                        do
                        {
                        Console.WriteLine("You have selected the " + seriesType + " series. The numbers between 0 and " + integer + " are:");
                        count = count + 2;
                        Console.WriteLine(count);
                        }
                        while (count < integer);
                    }
                    else
                    {
                    Console.WriteLine("Error: incorrect entry");
                    }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Write valid integer, or 'even' or 'odd' when prompted.");
            }
        }
    }
}