using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysisLib
{
    /// How to create and use a Class Library
    /// (reference assembly or .dll)
    /// Right-click on Solution
    /// Select Add -> New Project
    /// Select Class Library
    /// Name it and click Ok to create
    /// Add your library classes and interfaces, then build.
    /// Go back to your console app project,
    /// expand References,
    /// right-click References and select Add Refernce,
    /// expand Projects and select the class library reference.
    public class TextAnalysisClass
    {
        public static int WordCount(string text)
        {
            /// See String.Split Method
            /// https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=netframework-4.7.2
            /// To convert a string into an array of individual words (delineated by " ")
            string[] words = text.Split(",.: ".ToCharArray());

            /// Return length of array resulting from Split
            /// See Array Class
            /// https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netframework-4.7.2
            /// For length of array

            return words.Length;
        }

        public static int LetterCount(string text)
        {
          string[] letters = text.Split(",.: ".ToCharArray());
          int let = 0;
          foreach(string x in letters)
          {
            let += x.Length;
          }
            /// Return length of array
            /// See Array Class
            /// https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netframework-4.7.2
            /// For length of array

            return let;
        }

        public static string[] Words(string text)
        {
            /// See String.Split Method
            /// https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=netframework-4.7.2
            /// To convert a string into an array of individual words (delineated by " ")
            /// string[] words =

            //return new string[0];



            /// For extra fun, you could try to sort the words alphabetically.
            /// Start by creating a new ArrayList from the string array of words
            /// See ArrayList Class
            /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=netframework-4.7.2
            /// and ArrayList Constructors
            /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist.-ctor?view=netframework-4.7.2
            /// ArrayList wordList =

            /// Then use ArrayList.Sort()
            /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist.sort?view=netframework-4.7.2


            /// and finally use ArrayList.ToArray() Method
            /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist.toarray?view=netframework-4.7.2
            /// To convert back to array of strings
            /// words =

            return new string[0];
        }
    }
}
