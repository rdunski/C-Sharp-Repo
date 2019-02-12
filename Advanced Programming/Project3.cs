using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLib;

/// Calculator app project.
///
/// This is a two-part project,
/// One part is a console app user interface
/// allowing the user to enter operands (values) and operators.
/// The console app will perform the requested operation
/// and display the results.
/// (The user should be able to do multiple calculations
/// without restarting the app.)
///
/// The other part is a class library assembly
/// exposing static methods that implement the operations
/// needed to support the calculator user interface.
/// (This will require two projects in your solution,
/// and you will have two .cs.txt files to turn in.)
///
/// The calculator user interface console app will use a delegate
/// to refer to the various operations in the class library.
///
/// In the console app project, you will need to include
/// a reference to the class library and you will need to
/// include a using namespace.
namespace CalculatorApp
{
    delegate double Function(double x, double y);

    class Program
    {
        static void Main(string[] args)
        {
            Function calc = null;
            double answer = 0.0;
            string[] numbers = null;
            string[] operators = null;

            Console.WriteLine(
                "Welcome to the C# calculator app!\n" +
                "Please enter your calculation in the form:\n" +
                "number operator number   Ex. 1*2/3+4-5\n" +
                "Type 'exit' anytime to close the calculator\n");

            while (true)
            {
                int counter = 0; //Counter to iterate through expression, needs to be reset after every expression
                string request = Console.ReadLine();
                if (request == "exit")
                  break;

                numbers = request.Split("/+-* ".ToCharArray()); //Remove operators to get numbers
                operators = request.Split("1234567890".ToCharArray()); //Remove numbers to get operators
                answer = Convert.ToDouble(numbers[counter]);  //Start with first number in expression
                foreach(string op in operators) //For every operator in the expression, allowing for multiple operations in one expression
                {
                  if (op == "*")            //Emulating PEMDAS (without the parentheses/exponents for now)
                    calc = Functions.Mult;
                  else if (op == "/")
                    calc = Functions.Div;
                  else if (op == "+")
                    calc = Functions.Add;
                  else if (op == "-")
                    calc = Functions.Sub;
                  else                      //If no operator found, continue until one is found or it's the end of expression
                    continue;

                  answer = calc(answer,Convert.ToDouble(numbers[counter+1])); //The heavy lifting

                  counter++;

                  continue;                 //Keep finding operators
                }

                Console.WriteLine("The answer is: {0}", answer);
                // Assign the function requested to your delegate

                // Invoke the delegate function to get the answer

                // Display answer

            }

            Console.WriteLine("Press any key to continue");

            Console.ReadKey();
        }
    }
}
