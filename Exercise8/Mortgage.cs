using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Mortgage : Account, IDeposit
    {
        protected override double CalculateInterest(int noOfMonths)
        {
            if(customer is Company)
            {
                var buffer = noOfMonths - 12;
                if (buffer < 0)
                {
                    return noOfMonths * (0.5 * InterestRate);
                }
                else 
                {
                    return 12 * (0.5 * InterestRate) + (buffer * InterestRate);
                }
            }
            else
            {
                var buffer = noOfMonths - 6;
                if(buffer<=0)
                {
                    InterestRate = 0;
                    return base.CalculateInterest(noOfMonths);
                }else 
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
