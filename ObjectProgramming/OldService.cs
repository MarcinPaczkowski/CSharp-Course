using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProgramming
{
    public class OldService : IService
    {
        public int X { get; set; }

        public void FirstMethod()
        {
            Console.WriteLine("old firstmethod");
        }

        public int SecondMethod()
        {
            Console.WriteLine("old SecondMethod");
            return 0;
        }

        public string ThirdMethod()
        {
            Console.WriteLine("old ThirdMethod");
            return "0";
        }
    }
}
