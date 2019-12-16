using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool IsTrue = true;
                Console.WriteLine("Welcome to better calculator 1.2");
                while (IsTrue == true)
                {
                    //implement option to calculate more than 2 number like for example 5+5+5+5
                    try
                    {
                        Console.WriteLine("Your current time is " + DateTime.Now);

                        Calculation();
                        Console.Write("Press 'y' to continue, press anything else to close this app:");
                        string proceed = Console.ReadLine();
                        if (proceed != "y")
                        {
                            Console.WriteLine("Thanks for using this calculator");
                            Environment.Exit(0);
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            static void Calculation()
            {
                Console.Write("Enter your number: ");
                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the operator: ");
                string Operator = Console.ReadLine();

                Console.Write("Enter your second number: ");
                double number2 = Convert.ToDouble(Console.ReadLine());


                CalCulator calculate = new CalCulator();

                if (Operator == "+")
                {
                    Console.WriteLine(calculate.Add(number1, number2));
                }
                else if (Operator == "-")
                {
                    Console.WriteLine(calculate.Subtract(number1, number2));
                }
                else if (Operator == "*")
                {
                    Console.WriteLine(calculate.Multiply(number1, number2));
                }
                else if (Operator == "*")
                {
                    Console.WriteLine(calculate.Division(number1, number2));
                }
                else
                {
                    Console.WriteLine("Invalid operator");
                }
            }
        }
    }
}
