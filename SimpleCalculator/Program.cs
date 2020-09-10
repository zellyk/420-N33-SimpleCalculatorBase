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


            Console.WriteLine("Enter first number: ");

            string num1 = Console.ReadLine();

            Console.WriteLine("Enter second number: ");

            string num2 = Console.ReadLine();

            Console.WriteLine("Enter operation, (+, -, *, / ): ");

            string operation = Console.ReadLine();

           


            try
            {
                //Class to convert user input
                InputConverter inputConverter = new InputConverter();

                //Class to perform actual calculations
                Engine calculatorEngine = new Engine();

                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
