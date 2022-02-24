using System;
using System.Web;

namespace PrivateApplication
{
    class Private
    {
        private double length;
        private double width;

    public void AcceptDetails()
        {
            Console.WriteLine("Enter the Length: ");
            length = Convert .ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Width: ");
            width = Convert .ToDouble(Console.ReadLine());
        }
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

    class PrivateExecute
    {
        static void Main(string[] args) { 
          Private r = new Private();
            r.AcceptDetails();
            r.Display();
            Console.ReadLine();

        }
    }

}
