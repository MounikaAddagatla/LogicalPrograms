using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class AddDayOfWeek
    {
       
        public int FindWeek(int month, int day, int year)
        {
            //Gregorian calendar
            year -= (14 - month) / 12;
            int x = year + year / 4 - year / 100 + year / 400;
            month = month + 12 * ((14 - month) / 12) - 2;
            day = (day + x + (31 * month) / 12) % 7;
            switch (day)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;
            }
            Console.WriteLine("Day of Week is:" + day);
            return 1;
        }

        internal void FindWeek()
        {
            throw new NotImplementedException();
        }
    }
    
}
