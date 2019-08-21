using System;

namespace ConsoleApp1
{
    public class task3
    {
        public static void Jen3()

        {
            int a = 2;
            int b = 5;
            bool x1 = (a < b) && (b > a);
            Console.WriteLine(x1);
            Console.WriteLine("ВВести z или n");
            string asa = Console.ReadLine();
            switch (asa)
            {
                case "z":
                    Console.WriteLine("this is z");
                    break;
                case "n":
                    Console.WriteLine("this is n");
                    break;
                default:
                    Console.WriteLine("this is else");
                    break;
            }
            
            
            
        }
    }
}