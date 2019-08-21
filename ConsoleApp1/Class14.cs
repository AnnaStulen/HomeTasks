using System;
using System.ComponentModel;

namespace ConsoleApp1
{
    public class Class14
    {
        public int Add(int a, int b)
        {
            var qa = a + b;
            Console.WriteLine($"{qa}");
            return qa;
        }

        public void Add(int a, int b, int c)
        {
            var qw = a + b + c;
            Console.WriteLine(qw);
        }

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