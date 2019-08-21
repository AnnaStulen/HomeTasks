using System;

namespace ConsoleApp1
{
    public class Class15
    {
        public static void Ifelse()
        {   Console.Title = "Условие в С#";
            int a;
            bool b;
            Console.WriteLine("Введите numbers");
            a = int.Parse(Console.ReadLine());
            b = false;
            if (a % 3 == 0)
            {
                b = true;
            }

            if (b == true)
            {
                Console.WriteLine(a + " Кратно 3");
            }
            else
            {
                Console.WriteLine(a + " Не кратно 3");
            }

            Console.ReadKey();
        }
    }
}