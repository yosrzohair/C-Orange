using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTask1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 
            string name=Console.ReadLine();
            Console.WriteLine(name);

            //2
            double num = 1.22222;
            string data = "Yosr";
            char num2 = 'a';
            bool var = true;
            int num3 = 242;
            const int num4 = 2001;

            Console.WriteLine(num + " " +  data + " "+ num2 + " "+ var + " "+ num3 +" "+ num4  );


            //3
            string[] cars = { "Audi", "Ford", "Range Rover" };
            Console.WriteLine(cars.Length);
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //4 
            Console.WriteLine( "First Name : ");
            string firstname = Console.ReadLine();
            Console.WriteLine(firstname);
            Console.WriteLine("Last Name : ");
            string lastname = Console.ReadLine();
            Console.WriteLine(lastname);
            Console.WriteLine("Year : ");
            int YearOfBirth = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(YearOfBirth);
            Console.WriteLine(firstname + " " + lastname +" "+ YearOfBirth);


            //5
            int[] array = new int[10];
            Console.WriteLine("Enter array elements:");
            for(int i = 0;i < array.Length; i++)
            {
                Console.Write($"element - {i} : ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nElements in array are:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            //6
            int[] array1 = new int[3];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"element - {i} : ");
                array1[i] = int.Parse(Console.ReadLine());

            }
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];  
            }
            Console.WriteLine("\nSum of all elements stored in the array is : " + sum);
        }




    }
    }

