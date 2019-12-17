using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AdvancedCalc : CalCulator
    {
        public double number1;

        //Note that the constructor name must match the class name, and it cannot have a return type (like void or int).
        //Also note that the constructor is called when the object is created.
        public AdvancedCalc(double aNumber1)
        {
            aNumber1 = number1;
        }
        public double Square(double number1)
        {
            return Math.Sqrt(number1);
        }
    }
}
