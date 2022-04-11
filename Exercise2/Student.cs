using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Student:Human,IComparable<Student>
    {
        public double Mark { get; private set; }

        public Student():base()
        {

        }
        public Student(double mark,string firstName,string lastName) : base(firstName, lastName)
        {
            Mark = mark;
        }

        public int CompareTo(Student? other)
        {
            if (other == null) return 1; 
            return Mark.CompareTo(other.Mark);
        }
    }
}
