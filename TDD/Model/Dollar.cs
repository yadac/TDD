﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Model
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            _amount = amount;
        }
        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }
    }
}
