using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProgramming
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass");
        }

        public int PropParentX { get; set; }
        public string PropParentY { get; set; }

        public void ParentMethod()
        {
            Console.WriteLine("ParentClass ParentMethod");
        }

        protected void TestParentMethod()
        {
            
        }
        public void PrivateMethod()
        {
            
        }
    }
}
