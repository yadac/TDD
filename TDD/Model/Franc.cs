using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Model
{
    public class Franc
    {
        private int _amount;

        public Franc(int amount)
        {
            _amount = amount;
        }
        public Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return _amount == ((Franc)obj)._amount;
        }
    }
}
