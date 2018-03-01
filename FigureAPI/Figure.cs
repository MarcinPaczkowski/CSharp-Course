using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAPI
{
    public abstract class Figure
    {
        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Circumference
        {
            get { return CalculateCircumference(); }
        }
        public UnitOfMeasureType UnitOfMeasureType { get; set; }

        protected abstract double CalculateArea();
        protected abstract double CalculateCircumference();

        protected Figure(UnitOfMeasureType unitOfMeasure)
        {
            this.UnitOfMeasureType = unitOfMeasure;
        }


    }
}
