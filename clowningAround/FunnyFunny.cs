using System;
using System.Collections.Generic;
using System.Text;

namespace ClowningAround
{
    class FunnyFunny: IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        private string funnyThingIHave;
        public string FunnyThingIHave
        {
            get
            {
                return $"Hi kids! I have {funnyThingIHave}";
            }
        }
public void Honk()
        {
            Console.WriteLine($"Hi kids! I have a {funnyThingIHave}", "The Clown says...");

        }

    }
}
