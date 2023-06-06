using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Action
    {
        public double ErrorHandling()
        {
            while (true)
            {
                string str = Console.ReadLine();

                try
                {
                    return double.Parse(str);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter numeric values");
                }
            }
        }
        public void Addition(double a, double b)
        {
            Console.WriteLine( a + b );
        }
        public void Subtraction(double a, double b)
        {
            Console.WriteLine( a - b );
        }
        public void Multiplication(double a, double b)
        {
            Console.WriteLine(a * b);
        }
        public void Division(double a, double b)
        {
            Console.WriteLine(a / b);
        }
        public void Modulus(double a, double b)
        {
            Console.WriteLine(a % b);
        }
        public void Calculation()
        {
            try
            {

                double num1 = 0;
                double num2 = 0;

                Console.WriteLine("********** \nCalculator \n**********");

                Console.WriteLine("Enter first number:");

                num1 = ErrorHandling();
            

                Console.WriteLine("Enter second number:");
                num2 = ErrorHandling();

                Console.WriteLine("Enter an option: ");

                Console.WriteLine("\t Add : +");
                Console.WriteLine("\t Subtract : -");
                Console.WriteLine("\t Multiply : *");
                Console.WriteLine("\t Divide : /");
                Console.WriteLine("\t Modulus : %");
                Console.WriteLine("\t Square : ^");

                switch (Console.ReadLine())
                {
                    case "+" :
                        Addition(num1, num2); 
                        break;
                    case "-" :
                        Subtraction(num1, num2);
                        break;
                    case "*" :
                        Multiplication(num1, num2);
                        break;
                    case "/" :
                        Division(num1, num2);
                        break;
                    case "%" :
                        Modulus(num1, num2);
                        break;
                    default:
                        throw new ArgumentException("Invalid operator.");
                }

            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
