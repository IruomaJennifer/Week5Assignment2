using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Tomcat:Animal
    {
        public Tomcat(string sound,string name,double age,string gender):base(name,age,gender)
        {
            Sound = sound;
        }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine($"The sound is a {Sound}!");
        }
    }
}
