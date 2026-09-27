using System;
using System.Collections.Generic;
using System.Text;

namespace V2OvningUML.Classes
{
    public class Dog : Animal
    {
        //Attributer
        public string TailColor { get; set; }

        //Metoder
        public override void MakeSound() //Makes the dog bark
        {
            Console.WriteLine($"The dog {Name} barks.");
        }

        public void WagTail() //Makes the dog wag its tail

        {
            Console.WriteLine($"The dog {Name} wags its {TailColor} tail.");
        }
    }
}
