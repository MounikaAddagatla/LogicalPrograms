using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public static HashSet<int> GenerateCoupons(int n)
        {
            HashSet<int> coupons = new HashSet<int>();
            Random rand = new Random();
            while (coupons.Count < n)
            {
                int num = rand.Next(100, 1000);
                coupons.Add(num);
            }
            return coupons;
        }
    }
}

