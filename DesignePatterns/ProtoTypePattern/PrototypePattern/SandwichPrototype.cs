using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExersize
{
    public abstract class SandwichPrototype<T>
    {
        public abstract T ShallowCopy();
        public abstract T DeapCopy();
    }
}
