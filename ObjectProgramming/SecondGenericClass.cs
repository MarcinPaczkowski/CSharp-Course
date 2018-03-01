using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProgramming
{
    public class SecondGenericClass<TX, TY, TZ>
    {
        public TX PropX { get; set; }
        public TY PropY { get; set; }
        public TZ PropZ { get; set; }
        public int PropInt { get; set; }
        public string PropString { get; set; }
    }
}
