using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Loan : Account, IDeposit
    {
        protected override double CalculateInterest(int noOfMonths)
        {
            if(customer is Individual)
            {
                var buffer = noOfMonths - 3;
                if (buffer <= 0)
                {
                    InterestRate = 0;
                    return base.CalculateInterest(noOfMonths);
                }
                else
                {
                    return buffer * InterestRate;
                }
                
            }
            else
            {
                var buffer = noOfMonths - 2;
                if (buffer <= 0)
                {
                    InterestRate = 0;
                    return base.CalculateInterest(noOfMonths);
                }
                else
                {
                    return buffer * InterestRate;
                }
            }
        }
        public void DepositMoney()
        {
            throw new NotImplementedException();
        }
    }
}
