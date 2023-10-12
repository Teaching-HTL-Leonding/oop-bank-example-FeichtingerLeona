using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.logic
{
    public class Savings : Account
    {
        public override bool IsAllowed(decimal currandBalance, decimal amount)
        {
            if (currandBalance - amount < 0 && currandBalance + amount > 100000000)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public override bool TryExecute(bool isAllowed, decimal amount,ref decimal currendBalance)
        {
            if (isAllowed)
            {
                currendBalance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}