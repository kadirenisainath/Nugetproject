using System;

        namespace RectangleApplication
{
    class Rectangle
    {
         double length;
         double width;
    public void Mydetails()
        {
            length = 6.8;
            width  = 8.9;

        }
    public double  GetArea() 
        {
            return length + width;

        }
    public void Visible()
        {
          Console.WriteLine("length:{0}", length);
          Console.WriteLine("width:{0}", width);
          Console.WriteLine("Area:{0}", GetArea());

        }

    }
class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Mydetails();
            r.Visible();
            Console.ReadLine();
        }
    }
}
