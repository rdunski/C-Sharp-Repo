using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
  public class Ranking {
    /// SuperHero rankings.
    ///
    /// Define a SuperHero class, including members representing at least:
    ///     first name,
    ///     last name,
    ///     height,
    ///     power
    /// (If you would like to use or include other members, that's fine.)
    ///
    /// Instances of your SuperHero class are going to be stored in
    /// a generic List<T> of SuperHeroes (List<SuperHero>).
    ///
    /// In order to sort you List<T> of SuperHeroes, or to find an individual SuperHero,
    /// You will need to inherit from the following classes or interfaces:
    ///     IComparable<T> and
    ///     IEquatable<T>
    /// (See
    ///     List<T> Class https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.7.2,
    ///     IComparable<T> Interface https://docs.microsoft.com/en-us/dotnet/api/system.icomparable-1?view=netframework-4.7.2,
    ///     IEquatable<T> Interface https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netframework-4.7.2)
    ///
    /// You will need to implement the methods required by these classes
    /// or interfaces in order to be able to compare or equate two SuperHero objects.
    /// This is how you will form your ranking of SuperHeroes.
    /// Also implement a ToString() method to output a representation
    /// of your SuperHero.
    ///
    /// With your new SuperHero class, write a simple user interface
    /// to collect and populate SuperHero instances and store them in
    /// a List<T> collection.  (Again, this project might best
    /// be designed as two classes in separate files or projects.
    /// Try to not mix user interface and functionality.)
    ///
    /// Finally, sort your list of SuperHeroes and display your
    /// ranking of SuperHeroes.  Who's the best SuperHero?
    ///
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the SuperHero Data System");

			/// Declare a generic list (List<T>) of SuperHeroes

			/// User interface to collect data about SuperHeroes
			/// and add SuperHero to List.

			/// Display unranked SuperHeroes

			/// Sort SuperHeroes to form ranking

			/// Display SuperHeroes in order of greatness


            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
  }
}
