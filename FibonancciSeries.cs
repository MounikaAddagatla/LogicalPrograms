using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class FibonancciSeries
    {
        int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
        public void SeriesOfNumbers()
        {
            Console.Write("Enter the number of elements to Print : "); // here mention the how many no to print series//
            numberOfElements = Convert.ToInt32(Console.ReadLine());    // covert string to int 
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //do print first and second number
                Console.Write(firstNumber + " " + SecondNumber + " ");
                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i < numberOfElements; i++)                   // i=2,i< 3//
                {
                    nextNumber = firstNumber + SecondNumber; //next=0+1=1
                    Console.Write(nextNumber + " ");//1
                    firstNumber = SecondNumber; //firstno=1
                    SecondNumber = nextNumber;                                /// the o/p will be 0,1,1

                }
            }
            Console.ReadLine();
        }
    }
}

