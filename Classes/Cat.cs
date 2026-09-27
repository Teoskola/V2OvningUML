using System;
using System.Collections.Generic;
using System.Text;

namespace V2OvningUML.Classes
{
    public class Cat : Animal
    {
        //Attributer
        public string PawColor { get; set; }

        //Metoder
        public override void MakeSound() //Makes the cat meow
        {
            Console.WriteLine($"The cat {Name} meows.");
        }

        public void LickPaw() //Makes the cat lick its paw
        {
            Console.WriteLine($"The cat {Name} licks its {PawColor} paw.");
        }
    }
}
