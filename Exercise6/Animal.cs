using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Animal
    {
        public double Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }// 0=male and 1= female
        public string Sound { get; set; }
        public Animal()
        {

        }
        public Animal(string name,double age,string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"The {Name} made a Sound!");
        }
    }
}
