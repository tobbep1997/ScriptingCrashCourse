using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpForDummies.Classes
{
    abstract class Base
    {
        protected uint UnsingedInteger;
        public Base(uint unsingedInteger)
        {
            this.UnsingedInteger = unsingedInteger;
        }

        public abstract uint GetInteger();
    }
}
