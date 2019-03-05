using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// Read each line (word) of the file into a generic List of strings.
/// Use a StreamReader object in a using statement to perform the reading.
///
/// You will need to copy and paste the file words.txt
/// into your project folder and
/// then add the file to the project.
///
/// In order for this word text file to be included in your
/// runtime directory (Words\bin\Debug\),
/// the text file needs to be copied to the Output Directory.
/// Right-click words.txt in the Solution,
/// select Properties,
/// find Copy to Output Directory property,
/// select "Copy if newer" value.
///
/// Analyze the file words.txt:
///     - How many words are there?
///     - What is the longest word?
///     - What is the shortest word?
///     - What is the average length of all words?
///     - What is the first word?
///     - What is the last word?
///
/// Your program will output this analytic information report into a text file.
/// Use a StreamWriter object in a using statement to write your data.
///
/// Add appropriate exception handling.
///
/// Turn in your program file as a text file (program.cs.txt)
/// and your words analysis report output file (wordsanalysis.txt).
///
namespace Words
{
    class WordsProgram
    {
        public static void Main(string[] args)
        {
          int wordCount = 0;
          string longWord = "";
          string shortWord;
          Console.WriteLine("Welcome to Words!");
          string[] lines = File.ReadAllLines("words.txt");
          foreach (string line in lines)
            {
              if (line.Length > longWord.Length)
                longWord = line;
              wordCount++;
                // Use a tab to indent each line of the file.
            }
          Console.WriteLine("There are {0} words in the file", wordCount);
          Console.WriteLine("The longest word is {0}", longWord);
          Console.WriteLine("The shortest word is {0}", shortWord);
            // try { } catch () { }


            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
