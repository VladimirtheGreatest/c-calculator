using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CalCulator
    {
        // Add two integers and returns the sum  
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Multiply two integers and retuns the result  
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        // Subtracts small number from big number  
        public double Subtract(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }

            return num2 - num1;

        }
        //performing Division on two float variables.  
        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
