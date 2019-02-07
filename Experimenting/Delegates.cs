using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalysisLib;

/// This is a two-part class lab,
/// One part is a console app user interface
/// allowing the user to enter text.
/// The console app will perform several text analysis
/// operations and display the results.
///
/// The other part is a class library assembly
/// exposing static methods that implement the
/// text analysis functions.
/// (This will require two projects in your solution.)
///
/// The text analysis user interface will use a delegate
/// to refer to the various operations in the class library.
///
/// In the text analysis console app project,
/// you will need to include
/// a reference to the class library and you will need to
/// include a using namespace.
namespace TextAnalysis
{
    /// Delegate taking a string and returning an int
    delegate int TextCountFuncs(string s);

    /// Delegate taking a string and returning a string array
    delegate string[] TextWordFuncs(string s);

    class TextAnalysisApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the text analysis app!");

            Console.WriteLine(
                "Please enter a line of text to analyze, " +
                "you can copy and paste from a web page.");
            string text = Console.ReadLine();

            Console.WriteLine("\nYou entered:  \n{0}\n", text);

            /// Declare a variable of type TextCountFuncs
            /// and initialize with TextAnalysisClass.WordCount
            TextCountFuncs wordCount = TextAnalysisClass.WordCount;
            /// Call your TextCountFuncs delegate and display results
            Console.WriteLine("Number of words = {0}\n", wordCount(text));

            /// re-initialize delegate variable with
            /// TextAnalysisClass.LetterCount
            TextCountFuncs letterCount = TextAnalysisClass.LetterCount;
            /// Call your TextCountFuncs delegate and display results
            Console.WriteLine("Number of letters = {0}\n", letterCount(text));

            /// Declare a variable of type TextWordFuncs
            /// and initialize with TextAnalysisClass.Words

            /// Call your Words delegate with text parameter
			/// and display words of text in a foreach loop
            //string[] words = twf("");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
