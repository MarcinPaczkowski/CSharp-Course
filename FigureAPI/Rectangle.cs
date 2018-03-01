using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FigureAPI
{
    public class Rectangle : Figure
    {
        private readonly double _a;
        private readonly double _b;

        public Rectangle(double a, double b, UnitOfMeasureType unitOfMeasure) : base(unitOfMeasure)
        {
            _a = a;
            _b = b;
        }

        protected override double CalculateArea()
        {
            return _a * _b;
        }

        //protected override double CalculateArea()
        //{
        //    return 0;
        //}

        protected override double CalculateCircumference()
        {
            return _a * 2 + _b * 2;
        }
    }
}
