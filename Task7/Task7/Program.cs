using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task7
{
    internal class Program
    {



        static void Main(string[] args)
        {
            //1
            string lines = "";
            string path = @"C:\Users\LENOVO\Documents\Orange-C#\yosr.txt";


            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Yosr Dirani");
                sw.WriteLine("Computer engineer");
                sw.WriteLine("I'm 23 years old ");
                sw.WriteLine("I'm trainig in Orange Coding School");
            }


            //2
            using (StreamReader sr = new StreamReader(path))
            {
                string l;
                while ((l = sr.ReadLine()) != null)
                {
                    lines += l + "\n";
                }
            }
            Console.WriteLine("File content:\n" + lines);


            //3
            int sum = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (char.IsLetter(lines[i]))
                {
                    sum++;

                }
            }
            Console.WriteLine($"The Total Number of letter in file is : {sum}");
            Console.WriteLine("--------------------------------------");
            string[] word = lines.Split(' ');
            int wordCounter = 0;

            foreach (var item in word)
            {
                ++wordCounter;
            }

            Console.WriteLine("The Total Number of Word in file is " + wordCounter);


        }
    }
    }
