using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CalCulator
    {
        // Add two integers and returns the sum  
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Multiply two integers and retuns the result  
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        // Subtracts small number from big number  
        public int Subtract(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }

            return num2 - num1;

        }
        //performing Division on two float variables.  
        public float Division(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}
