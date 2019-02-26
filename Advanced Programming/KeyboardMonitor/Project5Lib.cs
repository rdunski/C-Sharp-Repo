using System;

/*

Library for Keyboard Monitor project thats uses
the ConsoleKeyInfo struct to get info about keys that
are pressed.

When user presses enter, the string is analyzed
to find a sequence of numbers or by length to
determine if it contains sensitive info

*/
namespace KeyboardLibrary {
  public class EventPass : EventArgs
  {
    string line;
    public bool passKey(ConsoleKeyInfo c)
    {
      if (c.Key == ConsoleKey.Enter)
      {
        string [] nums = line.Split("D");
        if(line.Length >= 8)
          Console.WriteLine("This line seems long enough to be a password");
        if(nums.Length >= 9)
          Console.WriteLine("This line might be a CCN or SSN");
        Console.WriteLine("The full line of input is: {0}", line);
        return false;
      }
      else
      {
        line += c.Key.ToString();
        return true;
      }
    }
  }
}
