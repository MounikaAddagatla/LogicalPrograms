using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class RevesreOfNumber
    {
        int num = 1234, reminder, sum = 0;
        public void RevrsNumber()
        {
            while (num > 0)
            {
                reminder = num % 10;
                sum = (sum * 10) + reminder;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
