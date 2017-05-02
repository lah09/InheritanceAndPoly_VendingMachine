using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Eat : Drink
    {
        public static int optionB { get; set; }
        public static int Choco { get; set; }
        public static int Biscuit { get; set; }
        public static int Sweets { get; set; }

        public void SnackMenu()
        {
            Console.WriteLine("\n1. Chocolate");  //display menu for Snacks
            Console.WriteLine("2. Biscuit");
            Console.WriteLine("3. Sweets");
            Console.Write("\nEnter your choice: ");
            optionB = Convert.ToInt32(Console.ReadLine());  //input from user, choosing from snacks

            switch (optionB)
            {
                case 1:
                    Console.WriteLine("Chocolate: 22kr");
                    Console.Write("How many? ");
                    num = Convert.ToInt32(Console.ReadLine());  //number of order per item
                    break;
                case 2:
                    Console.WriteLine("Biscuit: 25kr");
                    Console.Write("How many? ");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Sweets: 15kr");
                    Console.Write("How many? ");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid input. Please, try again!");
                    break;
            }
        }

        public void BuySnacks() //function for Snacks - (calculating change)
        {
            if (optionB == 1)
            {
                Choco = 22 * num;
                change = payment - Choco;
                Console.WriteLine($"Your total purchase is: {Choco}kr");

                if (Choco > payment)
                {
                    Console.WriteLine("Ooops! your money is not enough. Please, try again!");
                    Console.ReadKey();
                    Environment.Exit(0); //exit when money is not enough, preventing from reading and displaying another function
                }
                else
                {
                    Console.WriteLine($"Here is your change: {change}kr. Thank you!\n");
                }
            }
            else if (optionB == 2)
            {
                Biscuit = 25 * num;
                change = payment - Biscuit;
                Console.WriteLine($"Your total purchase is: {Biscuit}kr");

                if (Biscuit > payment)
                {
                    Console.WriteLine("Ooops! your money is not enough. Please, try again!");
                    Console.ReadKey();
                    Environment.Exit(0); //exit when money is not enough, preventing from reading and displaying another function
                }
                else
                {
                    Console.WriteLine($"Here is your change: {change}kr. Thank you!\n");
                }
            }
            else if (optionB == 3)
            {
                Sweets = 15 * num;
                change = payment - Sweets;
                Console.WriteLine($"Your total purchase is: {Sweets}kr");
                if (Sweets > payment)
                {
                    Console.WriteLine("Ooops! your money is not enough. Please, try again!");
                    Console.ReadKey();
                    Environment.Exit(0); //exit when money is not enough, preventing from reading and displaying another function
                }
                else
                {
                    Console.WriteLine($"Here is your change: {change}kr. Thank you!\n");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }

        public void BuyAgainSnacks() //if the user has >= 15kr remaining, the user can buy again
        {
            if (optionB == 1)
            {
                Choco = 22 * num;
                change -= Choco;

                if (Choco > change) //if item price is more than the change
                {
                    Console.WriteLine("Ooops! your money is not enough. Please, try again!");
                    Console.ReadKey();
                    Environment.Exit(0); //exit when money is not enough, preventing from reading and displaying another function
                }
                else
                {
                    Console.WriteLine($"Here is your change: {change}kr. Thank you!\n");
                }
            }
            else if (optionB == 2)
            {
                Biscuit = 25 * num;
                change -= Biscuit;

                if (Biscuit > change)
                {
                    Console.WriteLine("Ooops! your money is not enough. Please, try again!");
                    Console.ReadKey();
                    Environment.Exit(0); //exit when money is not enough, preventing from reading and displaying another function
                }
                else
                {
                    Console.WriteLine($"Here is your change: {change}kr. Thank you!\n");
                }
            }
            else if (optionB == 3)
            {
                Sweets = 15 * num;
                change -= Sweets;

                if (Sweets > change)
                {
                    Console.WriteLine("Ooops! your money is not enough. Please, try again!");
                    Console.ReadKey();
                    Environment.Exit(0); //exit when money is not enough, preventing from reading and displaying another function
                }
                else
                {
                    Console.WriteLine($"Here is your change: {change}kr. Thank you!\n");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }

        public override void Do()
        {
            Console.WriteLine("eating...");
        }
    }
}