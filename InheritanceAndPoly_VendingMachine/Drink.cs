using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Drink
    {
        public static int optionA { get; set; }
        public static int num { get; set; }
        public static int Soda { get; set; }
        public static int otherDrink { get; set; }
        public static int payment { get; set; }
        public static int change { get; set; }

        public void DrinkMenu()
        {
            Console.WriteLine("\n1. Coke");  //display menu to choose from
            Console.WriteLine("2. Pepsi");
            Console.WriteLine("3. 7Up");
            Console.WriteLine("4. Smoothie");
            Console.WriteLine("5. Red Bull");
            Console.Write("\nEnter your choice: ");
            optionA = Convert.ToInt32(Console.ReadLine());  //input from user, choosing item

            switch (optionA)
            {
                case 1:
                    Console.WriteLine("Coke: 20kr");
                    Console.Write("How many? ");
                    num = Convert.ToInt32(Console.ReadLine()); //number of item/coke
                    break;
                case 2:
                    Console.WriteLine("Pepsi: 20kr");
                    Console.Write("How many? ");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("7Up: 20kr");
                    Console.Write("How many? ");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Smoothie: 50kr");
                    Console.Write("How many? ");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("Red Bull: 50kr");
                    Console.Write("How many? ");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }

        public void BuyDrinks()  // drink function - (calculting change)
        {
            if (optionA == 1)
            {
                Soda = 20 * num;
                change = payment - Soda;
                Console.WriteLine($"Your total purchase is: {Soda}kr");

                if (Soda > payment) //product price is more than the money
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
            else if (optionA == 2)
            {
                Soda = 20 * num;
                change = payment - Soda;
                Console.WriteLine($"Your total purchase is: {Soda}kr");

                if (Soda > payment)
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
            else if (optionA == 3)
            {
                Soda = 20 * num;
                change = payment - Soda;
                Console.WriteLine($"Your total purchase is: {Soda}kr");

                if (Soda > payment)
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
            else if (optionA == 4)
            {
                otherDrink = 50 * num;
                change = payment - otherDrink;
                Console.WriteLine($"Your total purchase is: {otherDrink}kr");

                if (otherDrink > payment)
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
            else if (optionA == 5)
            {
                otherDrink = 50 * num;
                change = payment - otherDrink;
                Console.WriteLine($"Your total purchase is: {otherDrink}kr");

                if (otherDrink > payment)
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

        public void BuyAgainDrink() //if the user has >= 15kr remaining, the user can buy again
        {
            if (optionA == 1)
            {
                Soda = 20 * num;
                change -= Soda;

                if (Soda > change) //if item is more than the change
                {
                    Console.WriteLine("\nOoops! your money is not enough. Please, try again!");
                    Console.ReadKey();
                    Environment.Exit(0); //exit when money is not enough, preventing from reading and displaying another function
                }
                else
                {
                    Console.WriteLine($"Here is your change: {change}kr. Thank you!\n");
                }
            }
            else if (optionA == 2)
            {
                Soda = 20 * num;
                change -= Soda;

                if (Soda > change)
                {
                    Console.WriteLine("\nOoops! your money is not enough. Please, try again!");
                    Console.ReadKey();
                    Environment.Exit(0); //exit when money is not enough, preventing from reading and displaying another function
                }
                else
                {
                    Console.WriteLine($"Here is your change: {change}kr. Thank you!\n");
                }
            }
            else if (optionA == 3)
            {
                Soda = 20 * num;
                change -= Soda;

                if (Soda > change)
                {
                    Console.WriteLine("\nOoops! your money is not enough. Please, try again!");
                    Console.ReadKey();
                    Environment.Exit(0); //exit when money is not enough, preventing from reading and displaying another function
                }
                else
                {
                    Console.WriteLine($"Here is your change: {change}kr. Thank you!\n");
                }
            }
            else if (optionA == 4)
            {
                otherDrink = 50 * num;
                change -= otherDrink;

                if (otherDrink > change)
                {
                    Console.WriteLine("\nOoops! your money is not enough. Please, try again!");
                    Console.ReadKey();
                    Environment.Exit(0); //exit when money is not enough, preventing from reading and displaying another function
                }
                else
                {
                    Console.WriteLine($"Here is your change: {change}kr. Thank you!\n");
                }
            }
            else if (optionA == 5)
            {
                otherDrink = 50 * num;
                change -= otherDrink;

                if (otherDrink > change)
                {
                    Console.WriteLine("\nOoops! your money is not enough. Please, try again!");
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

        public virtual void Do()
        {
            Console.WriteLine("drinking...");
        }
    }
}