using System;
using System.Collections.Generic;

namespace TD1cli
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choice the mode :\n1) Add 2 integers\n2) Convert Fahrenheit to Celsius" +
                              "\n3) Convert seconds to date" +
                              "\n4) Sorting 3 integers" +
                              "\n5) Lot price" +
                              "\n6) Lot price automatic");
            int choice = Convert.ToInt32(Console.ReadLine());
            int first, second, third;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the first integer :");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second integer :");
                    second = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(first + " + " + second + " = " + Addition.sum(first, second));
                    break;
                
                case 2:
                    Console.WriteLine("Enter the temperature in Fahrenheit :");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(temp + "°F = " + Math.Round(Temperature.fahrenheit_to_celsius(temp), 3) + "°C.");
                    break;
                case 3:
                    Console.WriteLine("Enter the number of the seconds :");
                    second = Convert.ToInt32(Console.ReadLine());
                    List<int> date = Date.second_to_date(second);
                    Console.WriteLine(second + " secondes = " + date[0] + " jours, " + date[1] + " heures, " +
                                      date[2] + " minutes et " + date[3] + " secondes.");
                    break;
                
                case 4:
                    Console.WriteLine("Enter the first integer :");
                    first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second integer :");
                    second = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the third integer :");
                    third = Convert.ToInt32(Console.ReadLine());
                    Sorting new_list = new Sorting();
                    new_list.add_list(first);
                    new_list.add_list(second);
                    new_list.add_list(third);
                    Console.WriteLine("List in order :" + new_list.get_lower() + " " + new_list.get_lower() +
                                      " " + new_list.get_lower());
                    break;
                
                case 5:
                    Console.WriteLine("Enter the range for the random integer :");
                    first = Convert.ToInt32(Console.ReadLine());
                    LotGame game = new LotGame(first);
                    Console.WriteLine("Enter a number :");
                    second = Convert.ToInt32(Console.ReadLine());
                    while (game.Testing(second))
                    {
                        Console.WriteLine("Enter a number :");
                        second = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                
                case 6:
                    game = new LotGame(1000);
                    game.AI_Testing(game, 0, 1000);
                    break;
                
                default:
                    Console.WriteLine("Wrong choice, program end.");
                    break;
            }
        }
    }
}