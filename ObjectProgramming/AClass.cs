using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProgramming
{
    public class AClass: AbstractClass
    {
        public override void MethodToOverride()
        {
            Console.WriteLine("child method");
            base.MethodToOverride();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
