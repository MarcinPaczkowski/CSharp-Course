using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProgramming
{
    public abstract class AbstractClass
    {
        public int X { get; set; }
        public string Y { get; set; }

        public virtual void MethodToOverride()
        {
            Console.WriteLine("Base methode");
        }
    }
}
