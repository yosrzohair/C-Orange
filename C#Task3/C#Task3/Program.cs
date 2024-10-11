using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 3 //3
            string[] favfood = { "Pizza", "Mansaf", "Shawarmeh", "Kabseh", "Burger" };
            foreach (string fav in favfood) { Console.WriteLine(fav); }
            string[] favsport = { "Fotball", "Tennis", "Golf" };
            foreach (string fav2 in favsport) { Console.WriteLine(fav2); }
            string[] favMovie = { "Hacksaw ridge", "Shutter Island", "All the bright places", " " };
            foreach (string fav3 in favMovie) { Console.WriteLine(fav3); }

            /*4-	Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
•	Expected Output:
•	Input three numbers separated by comma: 5,10,15
•	The sum of three numbers: 30.*/


            Console.Write("Input three numbers separated by comma: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int num1 = int.Parse(numbers[0].Trim());
            int num2 = int.Parse(numbers[1].Trim());
            int num3 = int.Parse(numbers[2].Trim());
            int sum = num1 + num2 + num3;
            Console.WriteLine(sum);

            /// 5 
            int[] numbers2 = new int[100];
            int sum2 = 0;

            for (int i = 0; i < numbers2.Length; i++)
            {
                if (numbers2[i] % 2 != 0)
                {
                    Console.WriteLine("The odd numbers:" + numbers2[i]);
                    Console.WriteLine(sum += i);
                }
            }

            ///6 
            Console.WriteLine("Enter number of rows : ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                // Move to the next line
                Console.WriteLine();

            }


            //7

            Console.WriteLine("Enter number of rows : ");
            int rows2 = int.Parse(Console.ReadLine());
            int numb = 1;
            for (int i = 1; i <= rows2; i++)
            {
                // Print leading spaces for alignment
                for (int j = 1; j <= rows2 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(numb + " ");
                    numb++;
                }
                Console.WriteLine();


            }



        }
    }
}