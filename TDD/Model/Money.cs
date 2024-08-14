using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Model
{
    public class Money
    {
        protected int _amount;
        public override bool Equals(object? obj)
        {
            if (!(obj is Money money)) return false;
            return _amount == money._amount;
        }

    }
}
