using System;

namespace ConsoleApp1
{
    public class task8
    {
        public static void Jen8()
        {
            int[] numb = {-4, -3, -2, -1, 0, 1, 2, 3, 4};
            int a = 0;
            foreach (var variable in numb)
            {
                if (variable > 0)
                    a++;
            }
            Console.WriteLine($" Количество положительных чисел: {a}");
        }
    }
}