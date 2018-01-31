using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public class TestService
    {
        public void Start()
        {
            var soberCar = new Car("Sober");
            var kubaCar = new Car();

            var x = StaticClass.Method1(1);
            x = StaticClass.Method1(1);
            x = StaticClass.Method1(1);
            x = StaticClass.Method1(1);
            x = StaticClass.Method1(1);

            var y = "xyz";


            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine(y[i]);
            }

        }
    }
}
