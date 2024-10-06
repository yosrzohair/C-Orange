namespace Task2C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Enter Two numbers :");
            int num1 =Convert.ToInt32( Console.ReadLine());
            int num2 = Convert.ToInt32( Console.ReadLine());
            if (num1 < num2) {
                Console.WriteLine("the smaller:" + " " + num1);
            }
            else if (num1 > num2) { Console.WriteLine("the smaller:" + " " + num2);
            }
            else { Console.WriteLine("num1=num2"); }



            //2 
            Console.WriteLine("Enter the number:");
            int num3=Convert.ToInt32( Console.ReadLine());
            if (num3 < 0)
            {
                Console.WriteLine("-");
            }
            else if (num3 >0) { Console.WriteLine("the Sign is +"); }

            else { Console.WriteLine("the number is zero"); }

            //3 
            Console.WriteLine("Enter three numbers to sort: ");
            string[] input = Console.ReadLine().Split(',');
            int num4 = int.Parse(input[0]);
            int num5 = int.Parse(input[1]);
            int num6 = int.Parse(input[2]);
            int[] arr = { num4, num5, num6 };
            Array.Sort(arr);
            Console.WriteLine("Sorted numbers : " + string.Join(", ", arr));



            //4
            Console.WriteLine("Enter five numbers : ");
            String[] inMax = Console.ReadLine().Split(',');
            int[] nums = Array.ConvertAll(inMax, int.Parse);
            Console.WriteLine("Max number is : " + nums.Max());

            //5
            Console.WriteLine("Enter the number to convert ");
            double kiloperhour = Convert.ToDouble(Console.ReadLine());
            double mileperhour = kiloperhour * 0.621371;
            Console.WriteLine($"{kiloperhour} km/hr = {mileperhour}miles per hour ");

            //6
            Console.WriteLine("input hours :");
            int hour = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("input minutes:");
            int minutes = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Total" + " " +hour*60 + minutes);

            //7
            Console.WriteLine("input minutes :");
            int minute = Convert.ToInt32(Console.ReadLine());
            int hrs = minute / 60;
            Console.WriteLine(hrs);

            //8
            string[] sentences = { "Hello World", "I am Engineer ", " I love C#", "I love UX/UI", "Yosr^^" };
            foreach (var sentence in sentences)
            {
                Console.WriteLine(sentence.PadRight(20)); 
            }


            //9
            Console.WriteLine("Enter a sentence to reverse odd-length words: ");
            string sentenceInput = Console.ReadLine();
            Console.WriteLine("Reversed odd-length words: " + ReverseOdd(sentenceInput));
        }

        static string ReverseOdd(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    char[] chars = words[i].ToCharArray();
                    Array.Reverse(chars);
                    words[i] = new string(chars);
                }
            }
            return string.Join(" ", words);
        }

    }
   

    






}
