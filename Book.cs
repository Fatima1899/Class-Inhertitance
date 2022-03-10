using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Inheritance.Models
{
    internal class Book : Product
    {
        public string authorName;
        public int pagecount;
        public double discountPercent;

        public void GetInfo()
        {
            Console.WriteLine($"{name}{authorName}{pagecount}{discountPercent}{costPrice}");
        }
        public double GetDiscountedPrice()
        {
            return salePrice - ((salePrice * discountPercent) / 100);
        }
    }
}
