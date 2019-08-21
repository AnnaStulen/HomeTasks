using System;
using System.ComponentModel.Design;
using System.Linq;

namespace ConsoleApp1
{
    public class task13
    {
        public static string Jen13(string str1)
        {
            return $" {str1}";
        }


        public static int Jen14(int a, int b, int c, int d, int f)
        {
            var sum = a + b + c + d + f;
            return sum;
        }

        public static int Jen15(int q, int w, int e, int r, int t)
        {
            var dif = q - w - e - r - t;
            return dif;
        }

        public static void Jen16()
        {
            int[] qq = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (var variable in qq)
            {
                Console.WriteLine(variable);
            }
        }

        public static void Jen17()
        {
            int[] ar = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            int max = ar.Max();
            Console.WriteLine(max);
        }

        public static void Jen18()
        {
            int a = 2;
            int b = 3;
            int c = 4;
            Console.WriteLine(Math.Max(a, b));
        }

        public static void Jen19()
        {
            int a = 25;
            int b = 8;
            int c = 4;
            int max = 0;
            if ((a > b) && (a > c))
                max = a;
            else if ((b > a) && (b > c))
                max = b;
            else if ((c > a) && (c > b))
                max = c;
            Console.WriteLine(+max);
        }

        public static void Randarray()
        {
            int min = 5;
            int max = 10;
            int[] test = new int[10];
            Random test2 = new Random();
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = test2.Next(min, max);
                Console.WriteLine(test [i]);
            }
            
        }
    }
}