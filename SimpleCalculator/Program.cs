﻿using System;
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
                    Console.WriteLine("Enter the operation that you need(+, -, * or /): ");
                    string operation = Console.ReadLine();


                    Console.WriteLine();


                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                    StringBuilder resultPrint = new StringBuilder();
                    resultPrint.Append(String.Format("The value {0:.00} " + operation + " {1:.00} is equal to {2:.00}.", firstNumber, secondNumber, result));
                    Console.WriteLine(resultPrint.ToString());


                    

                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
