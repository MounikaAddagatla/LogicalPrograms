using System;
using System.Collections.Generic;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programs");
            Console.WriteLine(" Enter Y for repeat again else N for quit ");
            char ch = Convert.ToChar(Console.ReadLine());
           
            while (ch == 'Y' || ch == 'y')
            {

                Console.WriteLine("\n1.  Fibonancci Series  \n2.  ArmStrong number   \n3.  Prime Factorial number  \n4. Reverse of  a number  " +
                "    \n5. Coupon Number  \n6. Vending Machine  \n7.  show the Day Of week  \n8.  Temparature converstion \n9. StopWatch ");
                  
                 int v = Convert.ToInt32(Console.ReadLine());
                switch (v)
                {
                    case 1:
                        // fibonancci   Series
                        FibonancciSeries series = new FibonancciSeries();
                        series.SeriesOfNumbers();
                        break;
                    case 2:
                        // Given num is armstrong no or not//
                        ArmStrongNum num = new ArmStrongNum();
                        num.IsPerfectNumber();
                        break;
                    case 3:
                        // given no is a prime factorial or not
                        PrimeNumber prime = new PrimeNumber();
                        prime.IsPrimeNumber();
                        break;
                    case 4:
                        // reverse of a number
                        RevesreOfNumber revesreOf = new RevesreOfNumber();
                        revesreOf.RevrsNumber();
                        break;
                    case 5:
                        // coupon number

                        foreach (int couponNumber in CouponNumber.GenerateCoupons(4))
                        {
                            Console.WriteLine(couponNumber);
                        }
                        break;
                    case 6:
                        // Vending Machine for count change
                        VendingMachine vending = new VendingMachine();
                        vending.CountNumOfNotes();
                        break;
                    case 7:
                        // show the day of week
                        AddDayOfWeek week = new AddDayOfWeek();
                        week.FindWeek(1, 4, 1995);
                        break;
                    case 8:
                        TemparatureUnits units = new TemparatureUnits();
                        units.UnitConvertion(35,"Fahrenheit");
                        break;
                    case 9:
                        StopWatch time = new StopWatch();
                        time.CountTime();
                        /// show pontential fix used PrintElapsedTime for stop watch
                        break;
                    default:
                        Console.WriteLine("U r given wrong option");
                        break;
                }
            }
        }
    }
}