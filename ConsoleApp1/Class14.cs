using System;
using System.ComponentModel;

namespace ConsoleApp1
{
    public class Class14
    {

        public int Summq(int a, int b)
        {
            var s = a + b;
            Console.WriteLine($"{s}");
            return s;
        }

        public int Summq(int a, int b, int c, int d)

        {
            var w = a + b + c + d;
            Console.WriteLine($"{w}");
            return w;
        }

        public int Dif(int a, int b)
        {
            var e = a - b;
            Console.WriteLine($"{e}");
            return e;
        }

        public int Dif(int a, int b, int c, int d)

        {
            var r = a - b - c - d;
            Console.WriteLine($"{r}");
            return r;
        }
    }
}