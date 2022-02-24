using System;
using System.Net;

namespace EmunsApp
{
    class EnumProgram
    {
        enum Days { Sun, Mon, Tue, Wen, Thu, Fri, sat };

        static void Main (string[] args)
        {
            int WeekDayStart = (int)Days.Mon;
            int WeekDayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}",WeekDayStart);
            Console.WriteLine("Friday: {0}",WeekDayEnd);

        }
    }
}

