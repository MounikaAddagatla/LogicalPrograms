using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class BinaryToConversion
    {
        public void ToBinary()
        {
           int sum = 0,number=106;
            int place = 1;
            while (number>0)
            {
                sum += (number % 2) * place;
                number /= 2;
                place *= 10;
                
            }
            Console.WriteLine(sum);
        }
    }
}
