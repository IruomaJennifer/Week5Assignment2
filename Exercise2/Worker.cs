using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Worker:Human
    {
        public decimal Wage { get;private set; }
        public double HoursWorked { get;private set; }

        public Worker():base()
        {

        }
        public Worker(decimal wage, double hoursWorked,string firstName,string lastName):base(firstName,lastName)
        {
            Wage = wage;
            HoursWorked = hoursWorked;
        }
        public decimal CalculateHourlyWage()
        {
            return Wage / (decimal)HoursWorked;
        }
    }
}
