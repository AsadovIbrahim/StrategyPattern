﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class RegularCustomerDiscount:IDiscountStrategy
    {
        public double ApplyDiscount(double amount)
        {
            return amount - (amount * 0.10);
        }
    }
}
