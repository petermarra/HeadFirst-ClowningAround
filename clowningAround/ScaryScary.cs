using System;
using System.Collections.Generic;
using System.Text;

namespace ClowningAround
{
    class ScaryScary:FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThingsIHave)
            :base(funnyThingIHave)
        {
            this.numberOfScaryThingsIHave = numberOfScaryThingsIHave;
        }
        
        private int numberOfScaryThingsIHave = 0;
        public string ScaryThingsIHave
        {
            get
            {
                return $"{numberOfScaryThingsIHave} spiders";
            }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Boo! Gotcha!");
        }

     
    }
}
