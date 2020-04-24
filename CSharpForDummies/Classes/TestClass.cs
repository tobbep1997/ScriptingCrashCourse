using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpForDummies.Classes
{
    class TestClass : Base, IInterface
    {
        public TestClass(uint unsingedInteger) : base(unsingedInteger)
        {

        }

        public int Number
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override uint GetInteger()
        {
            throw new NotImplementedException();
        }

        public void SetNumber(int number)
        {
            throw new NotImplementedException();
        }

        public void TestClassFunction()
        {

        }
    }
}
