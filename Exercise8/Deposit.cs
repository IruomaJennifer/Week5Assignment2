using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Deposit : Account, IDeposit, IWithdraw
    {
        protected override double CalculateInterest(int noOfMonths)
        {
            if (Balance > 0 && Balance < 1000)
            {
                InterestRate = 0;
                return base.CalculateInterest(noOfMonths);
            }
            else 
            {
                return base.CalculateInterest(noOfMonths);
            }
            
        }
        public void DepositMoney()
        {
            throw new NotImplementedException();
        }

        public void WithdrawMoney()
        {
            throw new NotImplementedException();
        }
    }
}
