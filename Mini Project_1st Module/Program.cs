using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_1st_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool exit = false;

            do
            {
                Console.WriteLine("Please, pick an option: \n" +
                "1- Ask for the menu. \n" +
                "2- Order a hamburger. \n" +
                "3- Order a drink. \n" +
                "4- Exit.");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                switch (option)
                {
                    case 1:
                        Console.WriteLine("You have asked for the menu ");
                        exit = OrderMenu(exit);
                        break;

                    case 2:
                        Console.WriteLine("Thank you for ordering a hamburger!");
                        exit = OrderHamburguer(exit);
                        break;

                    case 3:
                        Console.WriteLine("Thank you for ordering a drink!");
                        exit = OrderDrink(exit);
                        break;

                    case 4:
                        Console.WriteLine("You have decided to exit.");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("This is not an option.");
                        break;
                }

            } while (exit != true);
        }

        static bool OrderMenu(bool exit)
        {
            int option;
            string[] foodMenu = new string[5] { "1- Grand Big Boot", "2- Big Boot", "3- BootPollo", "4- Quarter Pounder", "5- BootRoyal Deluxe" };
            Console.WriteLine("Choose one of our delicious menues: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(foodMenu[i]);
            }
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Thank you! Here you have your: " + foodMenu[option - 1]);

            exit = true;
            return exit;
        }

        static bool OrderHamburguer(bool exit)
        {
            int option;
            string[] hamburgerMenu = new string[5] { "1- Grand Big Boot", "2- Big Boot", "3- BootPollo", "4- Quarter Pounder", "5- BootRoyal Deluxe" };
            Console.WriteLine("Choose one of our delicious hamburgers: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(hamburgerMenu[i]);

            }
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Thank you! Here you have your: " + hamburgerMenu[option - 1]);

            OrderFries();

            exit = true;
            return exit;
        }

        static void OrderFries()
        {
            string answer; // declaramos una variable de carácteres a la que llamamos -answer-, 
                           // ya que necesitamos que esté fuera del while para que este la reconozca.
            do
            {
                Console.WriteLine("Would you like to have some fries? (s/n)");
                answer = Console.ReadLine();
                if (answer.ToLower() == "s")
                {

                    Console.WriteLine("Perfect, with fries will be!");

                }
                else if (answer.ToLower() == "n")
                {

                    Console.WriteLine("Okay. Here you have your hamburger without fries.");
                }
                else
                {
                    Console.WriteLine("Please, answer s/n to have your menu with fries or without them.");
                }

            } while (answer != "s" & answer != "n"); // con ampersand el programa evalua los dos strings y se asegura de que mientras la respuesta del usuaio no sea "s" y "n", debe volver a preguntarle sin entrar en un bucle infinito.
        }
                    
        static bool OrderDrink(bool exit)
        {
            int option;
            string[] drinkMenu = new string[4] { "1- Coca Cola", "2- Fanta", "3- Water", "4- Beer" };
            Console.WriteLine("Choose one of our refreshing drinks: ");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(drinkMenu[i]);

            }
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Thank you! Here you have your: " + drinkMenu[option - 1]);

            OrderBigdrink();

            exit = true;
            return exit;
        }

        static void OrderBigdrink()
        {
            string answerDrink;

            do
            {
                Console.WriteLine("Would you like to have the big size drink? (s/n)");
                answerDrink = Console.ReadLine();
                if (answerDrink.ToLower() == "s")
                {
                    Console.WriteLine("Perfect, here you have your menu with the big drink.");
                }
                else if (answerDrink.ToLower() == "n")
                {
                    Console.WriteLine("Okay, the menue with the regular size drink.");
                }
                else
                {
                    Console.WriteLine("Please, answer s/n to have your menu with big drink or the regular one.");
                }

            } while (answerDrink != "s" & answerDrink != "n");
        }
    }
}
