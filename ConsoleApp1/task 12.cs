using System;

namespace ConsoleApp1
{
    public class task12
    {
        public static void Jen15()
        {
            int[] aarr = {1, 2, 3};
            foreach (int VARIABLE in aarr)

            {
                Console.WriteLine(VARIABLE);
            }
        }

        public static string Jen12(string str1, string str2)
        {
            return $"{str1} {str2}";

        }

        public static string Jen14(int w, int e, int r)
        {
            return $"{Math.Pow(w,4)} {e*e} {r*r}";
        }
    }
}