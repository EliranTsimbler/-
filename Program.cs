using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        static void Task3()
        {
            Console.Write("is he riding in the city: ");
            bool isCity = bool.Parse(Console.ReadLine());
            Console.Write("what are you?(student/pensioner/ordinary) :");
            string status = Console.ReadLine();
            double price;

            if (isCity == true)
                price = 6;
            else price = 12;
            if (status == "student")
                price -= price * 0.2;
            else if (status == "pensioner")
                price = price * 0.3;
            Console.WriteLine("total price is: " + price);
        }

        static void Task4()
        {
            Console.WriteLine("what is your age");
            int age = int.Parse(Console.ReadLine());
            double basePrice;
            double total;
            Console.Write("whats your status: (student/VIP/IDF retirees/ordinary):  ");
            string status = Console.ReadLine();
            if (age <= 18)
            {
                basePrice = 120;
                if (status == "student")
                    total = basePrice * 0.2;
                else total = basePrice;
            }

            else if (age >= 19 && age <= 60)
            {
                basePrice = 180;
                if (status == "VIP")
                    total = basePrice + basePrice * 0.3;
                else total = basePrice * 1;

            }

            else
            {
                basePrice = 150;
                if (status == "IDF retirees")
                    total = basePrice - basePrice * 0.15;
                else total = basePrice * 1;

            }
            Console.WriteLine("total price is: " + total);
        }

        static void Task5()
        {
            Console.Write("is it a suite?: ");
            bool suite = bool.Parse(Console.ReadLine());
            Console.Write("is it at the weekend?: ");
            bool weekend = bool.Parse(Console.ReadLine());
            Console.Write("do you have a membership");
            bool membership = bool.Parse(Console.ReadLine());
            double basePrice;
            double total;
            if (suite == true)
                basePrice = 700;
            else basePrice = 400;
            if (weekend == true)
                total = basePrice + basePrice * 0.1;
            else if (weekend == false)
                total = basePrice;
            else if (membership == true)
                total = basePrice - basePrice * 0.15;
            else total = basePrice;
            Console.WriteLine("total price is:" + total);
        }

        static void Task6()
        {
            Console.Write("enter age: ");
            int age = int.Parse(Console.ReadLine());
            double basePrice, total;
            
            if (age <= 12)
            {
                basePrice = 50;
                Console.Write("is it a saturday?: ");
                bool saturday = bool.Parse(Console.ReadLine());
                if (saturday == true)
                    total = basePrice + 10;
                else total = basePrice;
            }

            else if (age >= 13 && age<=17)
            {
                basePrice = 70;
                Console.Write("are you a member?: ");
                bool isMember = bool.Parse(Console.ReadLine());
                if (isMember == true)
                    total = basePrice - basePrice * 0.2;
                else total = basePrice;
            }

            else
            {
                basePrice = 70;
                Console.Write("is it a saturday?: ");
                bool isVIP = bool.Parse(Console.ReadLine());
                if (isVIP == true)
                    total = basePrice + basePrice * 0.3;
                else total = basePrice;
            }
            Console.WriteLine("total price is: " + total);


        }

            static void Main(string[] args)
        {
            Task3();
        }
    }
}
