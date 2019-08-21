using System;

namespace ConsoleApp1
{
    public class task4
    {
        public static void Jen4()
        {
            Console.WriteLine("Ввести z x y t");
            string aza = Console.ReadLine();
            switch (aza)
            {
                case "z":
                    Console.WriteLine("this is z");
                    break;
                case "x":
                    Console.WriteLine("this is x");
                    break;
                case "y":
                    Console.WriteLine("this is y");
                    break;
                case "t":
                    Console.WriteLine("this is t");
                    break;
                default:
                    Console.WriteLine("this is else");
                    break;
            }
        }
    }
}