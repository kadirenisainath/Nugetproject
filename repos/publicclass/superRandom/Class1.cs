using System;

namespace superRandom
{
    class PublicApp1
    {
        public double length;
        public double width;
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class PublicApp2
    {
        static void Main(string[] args)
        {
            PublicApp1 a = new PublicApp1();
            a.length = 3.5;
            a.width = 9.3;
            a.Display();
            Console.ReadLine();
        }
    }
}