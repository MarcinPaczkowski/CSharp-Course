using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAPI
{
    public class Square : Rectangle
    {
        public Square(double a, UnitOfMeasureType unitOfMeasure) : base(a, a, unitOfMeasure)
        {
        }
    }
}
