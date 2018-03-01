using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(3, 6, UnitOfMeasureType.m);

            Console.WriteLine(rectangle.Area);
            Console.WriteLine(rectangle.Circumference);

            var square = new Square(4, UnitOfMeasureType.cm);

            Console.WriteLine(square.Area);
            Console.WriteLine(square.Circumference);

            Console.ReadKey();
        }
    }
}
