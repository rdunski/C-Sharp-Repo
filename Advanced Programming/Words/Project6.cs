using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/* Advanced Programming: C# Project 6
              Words

  Made by: Robert Dunski

  This program takes a file (words.txt) and analyzes the words within by finding

  Amount of Words
  Longest Word
  Shortest Word
  Average Length of Words
  First Word
  Last Word

  Results are then written to a file (report.txt)

*/

namespace Words
{
    public class Input
    {
      public static List<string> lines;

      public Input()
      {
        lines = new List<string>();
      }

      public void readFile(string filename)
      {
        using (System.IO.StreamReader sr =
             new System.IO.StreamReader(@filename))
         {

             string line = String.Empty;
             line = sr.ReadLine();
             while (line != null)                  //Add lines from file to list
             {
                 lines.Add(line);
                 line = sr.ReadLine();
             }

         }

      }

    }

    public class Analyzer : Input
    {

      public static int wordCount {get;set;}
      public static double avLeng {get;set;}
      public static string firstWord {get;set;}
      public static string lastWord {get;set;}
      public static string shortWord {get;set;}
      public static string longWord {get;set;}

      public Analyzer()                           //Initialize
      {
        wordCount = 0;
        avLeng = 0;
        firstWord = "";
        lastWord = "";
        shortWord = "";
        longWord = "";
      }

      public void analyze()
      {

        if (lines != null)                        //Make sure lines isn't empty
        {
          firstWord = lines.ElementAt(0);         //First element is first word
          shortWord = firstWord;                  //Arbitrary word for comparison
          foreach (string line in lines)
          {

            if (line.Length > longWord.Length)
              longWord = line;
            if (line.Length < shortWord.Length)
              shortWord = line;

            avLeng += line.Length;
            wordCount++;
          }

          try {
            lastWord = lines.ElementAt(wordCount-1);
          }
          catch (IndexOutOfRangeException e){         //If element doesn't exist
            Console.WriteLine("Could not \
            find the last word, {0}", e);
          }

          try{
            avLeng = avLeng / wordCount;
          }
          catch (DivideByZeroException e){            //If wordCount is zero
            Console.WriteLine("Could not calcualate \
            average length of words, {0}", e);
          }
        }

      }

    }

    public class Output : Analyzer
    {

      public void write()
      {
        //Output analysis data to report.txt
        using (StreamWriter sw = new StreamWriter(@"report.txt"))
        {
          sw.WriteLine("There are {0} words in the file", wordCount);
          sw.WriteLine("The longest word is {0}", longWord);
          sw.WriteLine("The shortest word is {0}", shortWord);
          sw.WriteLine("The average length is {0}", avLeng);
          sw.WriteLine("The first word is {0}", firstWord);
          sw.WriteLine("The last word is {0}", lastWord);
        }
      }

    }

    class WordsProgram : Input
    {

        public static void Main(string[] args)
        {

          Input reader = new Input();
          Analyzer analysis = new Analyzer();
          Output writer = new Output();

          try {
            reader.readFile("words.txt");                     //Read the file
          }
          catch (FileNotFoundException e) {                   //Can't find file
            Console.WriteLine("Could not open file, {0}", e);
            Environment.Exit(0);
          }

          analysis.analyze();                                 //Analyze
          writer.write();                                     //Write report

          Console.WriteLine("Processing...");
          Console.WriteLine("Analysis Complete! See report.txt for details");
          Console.WriteLine("Press any key to continue");
          Console.ReadKey();

        }

    }

}
