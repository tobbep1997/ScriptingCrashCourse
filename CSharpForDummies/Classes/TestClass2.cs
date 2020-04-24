using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpForDummies.Classes
{
    class TestClass2 : Base
    {
        public TestClass2(uint unsingedInteger) : base(unsingedInteger)
        {

        }

        public override uint GetInteger()
        {
            return base.UnsingedInteger;
        }

        public void TestClass2Function()
        {

        }
    }
}
