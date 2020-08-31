using System;
using System.Collections.Generic;
using System.Text;

namespace ClowningAround
{
    interface IScaryClown: IClown
    {
       string ScaryThingsIHave
        {
            get;
        }

        void ScareLittleChildren();
    }
}
