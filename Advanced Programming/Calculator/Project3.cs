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
            Function f = null;
            double answer = 0.0;

            Console.WriteLine(
                "Welcome to the C# calculator app!\n" +
                "Please enter your calculation in the form\n" +
                "number operator number");
            string[] numbers;
            string[] operators;
            while (true)
            {
                // Read user request for calculation
                string request = Console.ReadLine();
                // Parse requested calculation
                numbers = request.Split("/+-*".ToCharArray());
                operators = request.Split("1234567890".ToCharArray());
                foreach(string op in operators)
                {
                  if (op == "+")
                  {
                    Function add = Functions.Add;
                    answer = add((double)numbers[Array.IndexOf(operators,"+")-1], (double)numbers[Array.IndexOf(operators, "+")]);
                  }
                }
                // Assign the function requested to your delegate
                break;
                // Invoke the delegate function to get the answer

                // Display answer

            }

            Console.WriteLine("Press any key to continue");
            Console.Write("{0} {1}", answer, operators[2]);
            Console.ReadKey();
        }
    }
}
