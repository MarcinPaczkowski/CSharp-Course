using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProgramming
{
    public interface IService
    {
        int X { get; set; }
        void FirstMethod();
        int SecondMethod();
        string ThirdMethod();
    }
}
