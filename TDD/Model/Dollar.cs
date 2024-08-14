using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Model
{
    public class Dollar
    {
        private int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }
        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return _amount == ((Dollar)obj)._amount;
        }
    }
}
