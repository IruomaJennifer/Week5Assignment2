using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal abstract class Account
    {
        public Customer customer { get; set; }
        public decimal Balance { get; set; }
        public double InterestRate { get; set; }
        protected virtual double CalculateInterest(int noOfMonths)
        {
            return noOfMonths * InterestRate;
        }
    }
}
