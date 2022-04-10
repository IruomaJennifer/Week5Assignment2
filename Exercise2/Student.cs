using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Student:Human
    {
        public double Mark { get; private set; }

        public Student():base()
        {

        }
        public Student(double mark,string firstName,string lastName) : base(firstName, lastName)
        {
            Mark = mark;
        }
    }
}
