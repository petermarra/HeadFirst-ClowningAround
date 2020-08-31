using System;

namespace ClowningAround
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Jimmy" };
            tallGuy.TalkAboutYourself();
            tallGuy.Honk();

            ScaryScary fingersTheClown = new ScaryScary("Big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            someOtherScaryClown.ScareLittleChildren();
            Console.ReadKey();        }
    }
}
