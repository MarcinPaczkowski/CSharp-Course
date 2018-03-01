using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProgramming
{
    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("ChildCLass");
        }
        public int PropChildInt { get; set; }

        public void ChildIntMethod()
        {
            Console.WriteLine("ChildCLass ChildIntMethod");
        }

        public new void ParentMethod()
        {
            Console.WriteLine("ChildCLass ParentMethod");

        }
    }
}
