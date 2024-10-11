using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task6
{
    internal class Program
    {

//        1.	Implement a Car class which has fields to store the car's make, year, Type, Price, model, Pallet No, and color
//2.	Implement a constructor for the car class which takes parameters corresponding to each of the fields above and constructs an object with these values
//3.	 Implement a method to start and stop engine.
//4.	Test to return a string containing full information about the car
//5.	Write a test class which constructs a Car and prints its details to the console
//6.	Apply inheritance for the base class
          

     public class car
        {
            public string carMake;
           


    public int carYear;
    public  string carType;
    public  int carPrice;
    public     string carModel;
    public     int palletNo;
    public     string carColor;



            public car(string carmake, int caryear,string cartype, int carprice, string carmodel, int palletno, string carcolor)    
            {
                carMake = carmake;
                carYear = caryear;
                carType = cartype;
                carPrice = carprice;
                carModel = carmodel;
                palletNo = palletno;
                carColor = carcolor;
            }

            public void start()
            {
                Console.WriteLine("The car start.");
            }
            public void stop()
            {
                Console.WriteLine("The car stop.");
            }

            public string carInfo()
            {
                return "Car Year : " + carYear + "\nCar type : " + carMake + "\nCar price : "
                + carPrice + "\nCar model : " + carModel +
                       "\nCar color : " + carColor +
                       "\npalletNo : " + palletNo;
            }


        }

        static void Main(string[] args)
        {
            car audi = new car("audi", 2020, "A8", 20000, "A8", 2000, "black");
            Console.WriteLine(audi.carMake + audi.carYear + audi.carType + audi.carPrice + audi.carModel + audi.carColor + audi.carColor);

        }
    }
}
