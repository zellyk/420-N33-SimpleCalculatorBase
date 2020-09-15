using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEngine
{
    public class Engine

      {

        private string operation = "";


        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;
            StringBuilder printout = new StringBuilder(); 

            switch (argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    printout.Append(String.Format("The value {0:f2} plus the value {1:f2} is equal to {2:f2}", argFirstNumber, argSecondNumber, result));
                    Console.WriteLine(printout.ToString());
                    break;
                case "subtract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    printout.Append(String.Format("The value {0:f2} minus the value {1:f2} is equal to {2:f2}", argFirstNumber, argSecondNumber, result));
                    Console.WriteLine(printout.ToString());
                    break;
                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    printout.Append(String.Format("The value {0:f2} multiplied by the value {1:f2} is equal to {2:f2}", argFirstNumber, argSecondNumber, result));
                    Console.WriteLine(printout.ToString());
                    break;
                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    printout.Append(String.Format("The value {0:f2} divided by the value {1:f2} is equal to {2:f2}", argFirstNumber, argSecondNumber, result));
                    Console.WriteLine(printout.ToString());
                    break;
                case "square root":
                case "\u221A":
                    result = Math.Sqrt(argFirstNumber);
                    printout.Append(String.Format("The square root of the value {0:f2} is equal to {1:f2}", argFirstNumber, result));
                    Console.WriteLine(printout.ToString());
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized.");
            }
            return result;
        }

        public string getOperator()
        {
            return operation;

        }
    }
}
