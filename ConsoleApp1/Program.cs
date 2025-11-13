using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Task1()
        {
            Console.Write("enter number: ");
            int Num = int.Parse(Console.ReadLine());
            string type;


            if (Num > 0)
            {
                if (Num % 2 == 0)
                    type = "even";
                else
                    type = "odd";
            }
            else if (Num < 0)
                type = "negative";
            else
                type = "0";

            Console.WriteLine("the number is:" + type);
        }

        static void Task2()
        {
            double price;
            bool isBuisness;
            Console.Write("is it a buisness? ");
            isBuisness = bool.Parse(Console.ReadLine());
            Console.Write("enter usage: ");
            int usage = int.Parse(Console.ReadLine());
            if (usage <= 300)
                price = usage * 0.5;
            else if (usage >= 301 && usage <= 600)
                price = usage * 0.7;
            else
                price = usage;
  
            if (isBuisness == true)
                price = price * 1.15;
            else price = price * 1.05;
            Console.WriteLine("total price is: " + price);



        }
        static void Main(string[] args)
        {
            Task2();
        }
    }
}
