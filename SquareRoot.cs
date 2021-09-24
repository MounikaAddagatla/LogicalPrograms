using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class SquareRoot
    {
        public double Sqrt(double a)
        {
            if (a < 0)
                throw new Exception("Can not sqrt a negative number");
            double error = 0.00001;
            double x = 1;
            while (true)
            {
                double val = x * x;
                if (Math.Abs(val - a) <= error)
                    return x;
                x = x / 2 + a / (2 * x);
            }
            
        }
    }
}
