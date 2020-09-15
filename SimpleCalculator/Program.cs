using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CalculatorEngine;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is a simple calculator, enter 2 values and an operator. For square root enter the same number twice.");
            Console.WriteLine();


            try
            {


                while (true)
                {

                    //Class to convert user input
                    InputConverter inputConverter = new InputConverter();

                    //Class to perform actual calculations
                    Engine calculatorEngine = new Engine();

                    // Asking user to enter first number
                    Console.WriteLine("Enter first number: ");
                    double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());


                    Console.WriteLine();


                    // Asking user to enter second number
                    Console.WriteLine("Enter second number: ");
                    double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());


                    Console.WriteLine();


                    // Asking for the operation
                    Console.WriteLine("Enter the operation that you need(+ or add, - or subtract, * or multiply, / or divide and square root or \u221A): ");
                    string operation = Console.ReadLine();


                    Console.WriteLine();

                    // Calculation object
                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                   


                    Console.WriteLine();


                    // Asking to go again
                    Console.WriteLine("Would you like to do another operation? (Y/N)");
                    string option = Console.ReadLine().ToLower();
                    while (!option.Equals("y") && !option.Equals("n"))
                    {
                        Console.WriteLine("Enter (Y/N)");
                        option = Console.ReadLine();
                        Console.WriteLine();
                    }

                    if (option.Equals("n"))
                    {

                        break;
                    }


                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

