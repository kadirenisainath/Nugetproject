using System;
namespace Apppolym
{
    class Printdata
    {
        void Print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        void Print(double f)
        {
            Console.WriteLine("printing flot:{0}",f);

        }
        void Print(string s)
        {
            Console.WriteLine("Printing string: {0}",s);
        }

        static void Main(string[] args)
        {
            Printdata p = new Printdata();
            p.Print(5);

            p.Print(10.44);

            p.Print("Hello C++");
            Console.ReadKey();
        }
    }
}
