using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Versioning;

namespace dateandtime
{
    class date1
    {
        static void Main(string[] args)
        {
            string firstname, lastname;
            firstname = "sainath";
            lastname = "kadireni";

            string fullname = firstname + lastname;
            Console.WriteLine("fullname: {0}",fullname);

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            String[] num = { "1 ", "2 ", "3 ","4 ","5 "};
            string[] sarray = { "Welcome ", "Tothe ", "Sainath ", "Tutorial ", "Point " };
            string[] sarray2 = { "Clickon ", "thebelow ", "youwill ","get ", "firstvideo ", "link " };

            string rank = String.Join("", num);
            Console.WriteLine("num: {0}",rank);

            string Greeting = new string(letters);
            Console.WriteLine("Greeting: {0}",Greeting);

            string Message = String.Join("",sarray);
            Console.WriteLine("Message: {0}", Message);

            string getLink = String.Join("", sarray2);
            Console.WriteLine("getLink: {0}", getLink);

            DateTime Now= DateTime.Now;
            Console.WriteLine("show the current date at {0:D},{0:T}", Now);



        }
    }
}
