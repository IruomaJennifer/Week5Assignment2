using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Human
    {
        public string FirstName { get;protected set; }
        public string LastName { get; protected set; }

        public Human()
        {

        }
        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
