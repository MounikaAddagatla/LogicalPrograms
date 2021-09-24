using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class MonthlyPayment
    {

        public void CompoundInterest()
        {
            Console.WriteLine("Enter principal amount");
            double principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no of year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate of interest");
            double rate = Convert.ToDouble(Console.ReadLine());
            double rateOfInterestMonthly = rate / (12 * 100);
            double n = 12 * year;//year in monthly
            double payment = (principal * rateOfInterestMonthly) / (1 - Math.Pow((1 + rateOfInterestMonthly), (-n)));
            Console.WriteLine("Monthly payment " + payment);
        }
    }
}
