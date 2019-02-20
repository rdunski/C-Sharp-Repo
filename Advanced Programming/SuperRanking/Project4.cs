using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Project 4: SuperHero Rankings

// Made by: Robert Dunski
// For: Advanced Programming: C# with John Dobbs

// This program takes user-entered superhero information and ranks them based on shortness
// (smallest heros are on the top)

*/

namespace SuperHero
{
  public class SuperHero : IComparable {
    string fname;
    string lname;
    double height;
    string power;

    public SuperHero (string f, string l, double h, string p)
    {
      fname = f;
      lname = l;
      height = h;
      power = p;
    }
    public int CompareTo (object obj){
      if (obj == null) return 1;
      SuperHero secondHero = (SuperHero)obj;

      if (secondHero != null)
          return this.height.CompareTo(secondHero.height);
      else
          return 1;
    }

    public override string ToString() {
      return fname + " " + lname + " has " + power + " and is " + height + " meters tall.";
    }
  }

  public class Ranking {
      static void Main(string[] args)
      {
        List<SuperHero> sList = new List<SuperHero>();
        SuperHero hero;

        Console.WriteLine("Welcome to the SuperHero Data System");

        while(true){

          Console.WriteLine("Enter a superhero's first name");
          string first = Console.ReadLine();

          Console.WriteLine("Enter the superhero's last name");
          string last = Console.ReadLine();

          Console.WriteLine("Enter the superhero's height in meters");
          double height = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Enter the superhero's power");
          string power = Console.ReadLine();

          hero = new SuperHero(first,last,height,power);
          sList.Add(hero);

          Console.WriteLine("Would you like to add another superhero?");
          string decision = Console.ReadLine();

          if (decision == "y" || decision == "yes")
            continue;
          else
            break;

          }
        Console.WriteLine("Unranked Heros:");

        foreach (SuperHero superhero in sList) {
          Console.WriteLine(superhero.ToString());
        }

        sList.Sort();

        Console.WriteLine("Ranked Heros, Smallest is Best:");

        int counter = 1;

        foreach (SuperHero superhero in sList) {
          Console.WriteLine("{0}: {1}",counter, superhero.ToString());
          counter++;
        }

          Console.WriteLine("Press any key to continue");
          Console.ReadKey();
      }
    }
}
