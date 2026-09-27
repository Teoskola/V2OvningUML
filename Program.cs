using V2OvningUML.Classes;
namespace V2OvningUML
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // Create a cat and a dog
            Cat myCat = new Cat { Name = "Whiskers", PawColor = "white" };
            Dog myDog = new Dog { Name = "Buddy", TailColor = "brown" };
            // Make the cat and dog make sounds
            myCat.MakeSound();
            myDog.MakeSound();
            // Make the cat lick its paw and the dog wag its tail
            myCat.LickPaw();
            myDog.WagTail();
        }
    }
}
