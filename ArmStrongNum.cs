using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ArmStrongNum
    {
        private int number, sum = 0;
        public void IsPerfectNumber()
        {
            Console.Write("enter  the Perfectnumber : ");  // taking variable   // 6 taken
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)     // i=1 i<6 // 2. i=2,2<6  // 3. i=3,3<6
            {
                if (number % i == 0)             // 6%1 = 0 // 6%2=0 //  6%3 =0
                {
                    sum += i;  // 0+1=1 // 2. s=1+2==>3 /// s=3+3
                }
            }
            if (sum == number)
            {
                Console.WriteLine(sum + " Entered number is perfect number");
            }
            else
            {
                Console.WriteLine("\n Entered number is not  perfect number");

            }
        }

    }
}

