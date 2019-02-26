using System;
using KeyboardLibrary;

/*

Project 5 for Advanced Programming: C#

Made by: Robert Dunski

This program prompts the user to enter a random string
of text

An event is raised when the user presses enter, and then
the string that they have been typing is analyzed and returned

*/
namespace KeyboardMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
          ConsoleKeyInfo c = new ConsoleKeyInfo();
          EventPass handler = new EventPass();
          Console.WriteLine("Start typing!");
          while(handler.passKey(c))
          {
            c = Console.ReadKey();
          }
          Console.WriteLine("Press any key to exit");
          Console.ReadKey();
        }
    }
}
