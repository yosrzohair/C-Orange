using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        //1
        //static double SumAndAverage(double sum , double average)
        //{
        //    sum = 0;
        //    const int totalnumbers = 10;
        //    for (int i=1; i < totalnumbers; i++)
        //    {
        //        Console.Write($"Number-{i}: ");
        //        int number = int.Parse(Console.ReadLine());
        //        sum += number; // Add each number to the sum
        //         average = (double)sum / totalnumbers;
        //    }

        //return (sum, average);
        //}



        //2
        static int cube (int x)
        {
            return x * x * x;
        }

        //3




        static void Main(string[] args)
        {
            // Task4+5+6+7

            //task4- Methods 
            //1 
            // Call the function and get the result
            //(int sum, double average) = SumAndAverage();

            //Display the sum and average
            //Console.WriteLine(sum);
            //Console.WriteLine(average);


            int z = int.Parse(Console.ReadLine());
            Console.WriteLine(z);

            cube(z);

        }
    }
}
