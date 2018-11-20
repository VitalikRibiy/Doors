using System;
using System.Collections.Generic;
using System.Text;

namespace Plug_1
{
    public abstract class Door
    {
        public Door(){}
        public abstract bool Fit(object item);
        public abstract string Print();
    }
}
