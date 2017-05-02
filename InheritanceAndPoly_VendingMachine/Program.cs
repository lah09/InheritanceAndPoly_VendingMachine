using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Program : Drink
    {
        public static char yORn { get; set; }
        public static int option { get; set; }

        static void Main(string[] args)
        {
            try
            {
                Drink drink = new Drink(); //object for class Drink
                Eat eat = new Eat();  //object for class Eat

                Console.WriteLine("Vending Machine");  //main menu
                Console.WriteLine("\n1. Drinks");
                Console.WriteLine("2. Snacks");
                Console.Write("\nEnter your choice: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        drink.DrinkMenu();
                        break;
                    case 2:
                        eat.SnackMenu();
                        break;
                    default:
                        Console.WriteLine("Thats not a valid option!!!");
                        break;
                }
                MoneyMenu();

                while (true)
                {
                    if (change < 15 || change < 0) //smallest price of the product is 15kr
                    {
                        Console.WriteLine("Thank you for your purchase\n");

                        if (option == 1)  // choosing either 1. Drinks or 2. Snacks (main menu)
                        {
                            drink.Do();
                        }
                        else if (option == 2)
                        {
                            eat.Do();
                        }
                        break;
                    }
                    else if (change > 15)
                    {
                        Console.WriteLine($"Your remaining money is: {change}kr");
                        Console.Write("\nDo you want to buy more? (y / n): ");
                        yORn = Console.ReadKey().KeyChar;

                        if (yORn == 'y' || yORn == 'Y')
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Choose again");
                            Console.WriteLine("\n1. Drinks");  //main menu
                            Console.WriteLine("2. Snacks");
                            Console.Write("\nEnter your choice: ");
                            option = Convert.ToInt32(Console.ReadLine());

                            switch (option)
                            {
                                case 1:
                                    drink.DrinkMenu(); //main menu
                                    drink.BuyAgainDrink(); //use the remaining money (change)                                
                                    break;
                                case 2:
                                    eat.SnackMenu(); //main menu
                                    eat.BuyAgainSnacks(); //use the remaining money (change)
                                    break;
                                default:
                                    Console.WriteLine("Thats not a valid option!!!");
                                    break;
                            }
                        }
                        else if (yORn == 'N' || yORn == 'n')
                        {
                            Console.WriteLine("\nThank you for your purchase!\n");
                            if (option == 1)
                            {
                                drink.Do();
                            }
                            else if (option == 2)
                            {
                                eat.Do();
                            }
                            else
                            {
                                break;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nWrong input! Please, try again!");
                            break;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Wrong input! Please try again!");
            }
            Console.ReadKey();
        }

        static void MoneyMenu()
        {
            Drink drink = new Drink(); //object for class Drink
            Eat eat = new Eat();  //object for class Eat

            int[] money = new int[8];
            {
                money[0] = 1;
                money[1] = 5;
                money[2] = 10;
                money[3] = 20;
                money[4] = 50;
                money[5] = 100;
                money[6] = 500;
                money[7] = 1000;
            }
            Console.WriteLine("\nPlease, insert your money");
            Console.Write("This machine can only accept: 1kr, 5kr, 10kr, 50kr, 100kr, 500kr, 1000kr: ");
            payment = Convert.ToInt32(Console.ReadLine());

            switch (payment)
            {
                case 1: //value of money
                    if (option == 1)
                    {
                        drink.BuyDrinks();
                    }
                    else
                    {
                        eat.BuySnacks();
                    }
                    break;
                case 5:
                    if (option == 1)
                    {
                        drink.BuyDrinks();
                    }
                    else
                    {
                        eat.BuySnacks();
                    }
                    break;
                case 10:
                    if (option == 1)
                    {
                        drink.BuyDrinks();
                    }
                    else
                    {
                        eat.BuySnacks();
                    }
                    break;
                case 20:
                    if (option == 1)
                    {
                        drink.BuyDrinks();
                    }
                    else
                    {
                        eat.BuySnacks();
                    }
                    break;
                case 50:
                    if (option == 1)
                    {
                        drink.BuyDrinks();
                    }
                    else
                    {
                        eat.BuySnacks();
                    }
                    break;
                case 100:
                    if (option == 1)
                    {
                        drink.BuyDrinks();
                    }
                    else
                    {
                        eat.BuySnacks();
                    }
                    break;
                case 500:
                    if (option == 1)
                    {
                        drink.BuyDrinks();
                    }
                    else
                    {
                        eat.BuySnacks();
                    }
                    break;
                case 1000:
                    if (option == 1)
                    {
                        drink.BuyDrinks();
                    }
                    else
                    {
                        eat.BuySnacks();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input. Please, try again!");
                    break;
            }
        }
    }
}