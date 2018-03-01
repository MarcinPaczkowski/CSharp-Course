using System;
using System.Security.Principal;

namespace TddProgramming
{
    public class ComplexNumbersService
    {
        public ComplexNumber Add(ComplexNumber number1, ComplexNumber number2)
        {
            if (number1 == null || number2 == null)
            {
                throw new Exception( );
            }
            var newComplexNumber1 = new ComplexNumber();
            newComplexNumber1.A = number1.A + number2.A;
            newComplexNumber1.Bi = number1.Bi + number2.Bi;
            return newComplexNumber1;
        }

    }
}