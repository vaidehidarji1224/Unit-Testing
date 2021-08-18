using System;

namespace IsItALeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public bool IsItALeapYear(int year)
        {
            if ((year % 4 == 0) && ( year % 100 != 0))
            { 
                return false;
            }
            else if (year % 400 == 0)
            {
                return true;
            }

            else
            {
                return true;
            }
        }
    }
}
