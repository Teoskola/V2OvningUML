using System;
using System.Collections.Generic;
using System.Text;

namespace V2OvningUML.Classes
{
    public abstract class Animal
    {
        //Attributer

        public string Name { get; set; }


        //Metoder
        public abstract void MakeSound(); //Makes the animal make a sound, to be implemented in derived classes

    }
}
