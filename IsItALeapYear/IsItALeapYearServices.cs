using System;

namespace IsItALeapYear
{
    public class IsItALeapYearServices
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public bool IsItALeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }else if(year % 4 == 0)
            { 
                return year % 100 != 0;
            }
            else
            {
                return false;
            }
        }
    }
}
