using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProgramming
{
    public class NewService : IService
    {
        public int X { get; set; }

        public void FirstMethod()
        {
            Console.WriteLine("new firstmethod");
        }

        public int SecondMethod()
        {
            Console.WriteLine("new SecondMethod");
            return 1;
        }

        public string ThirdMethod()
        {
            Console.WriteLine("new ThirdMethod");
            return "1";
        }
    }
}
