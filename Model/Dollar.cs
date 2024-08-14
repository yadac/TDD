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
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public Dollar(int amount)
        {
            Amount = amount;
        }
        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}
