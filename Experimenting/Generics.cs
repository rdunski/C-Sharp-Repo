using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNotes_Generics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// Generics are classes or collections that allow you
    /// to specify the underlying types used at the time of declaration.
    /// These allow strongly typed classes and collections that are flexible.
    ///
    /// See Generics (C# Programming Guide)
    /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/index
    /// and Introduction to Generics (C# Programming Guide)
    /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/introduction-to-generics
    /// and List<T> Class
    /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.7.2,

    /// Type Parameters - a class definition may specify a set of type parameters
    /// by following the class name with angle brackets enclosing a list of type parameter names
    /// A class type that is declared to take type parameters is called a generic class type.

    /*-----------------------------------------------------*/

    public enum Sides { Zero, One, Two, Three, Four, Five };

    /// Non-abstract class representing a Circle shape (from Interfaces_More example).
    /// IComparable is an interface that guarantees that there is a method
    /// with which I can compare two objects of a class in order to sort them.
    /// See IComparable Interface
    /// https://docs.microsoft.com/en-us/dotnet/api/system.icomparable?view=netframework-4.7.2
    class Circle : IComparable
    {
        // Note missing access modifier, making these private by default
        const double pi = 3.1415;
        double radius;
        public Sides sides = Sides.Zero;

        public Circle(double r)
        {
            this.radius = r;
        }

        public double Area()
        {
            return pi * radius * radius;
        }

        // How would I order a collection of circles?  By radius?
        public int CompareTo(object obj)
        {
            /// CompareTo(Object), that indicates whether the position
            /// of the current instance in the sort order is before, after,
            /// or the same as a second object of the same type.
            if (obj == null) return 1;
            Circle otherCircle = (Circle)obj;

            if (otherCircle != null)
                return this.radius.CompareTo(otherCircle.radius);
            else
                return 1;
        }

        public override string ToString()
        {
            return "Circle with radius " + radius;
        }
    }

    /*-----------------------------------------------------*/

    /// Our next example is a generic class that will hold a pair of items.
    /// We can specify the types of each element of the pair.
    /// Types are passed inside angle brackets (<>)
    /// as we declare an instance of the generic type.
    public class Pair<TFirst, TSecond>
    {
        // TFirst is the type of the first item, TSecond is the type of the second
        public TFirst First;
        public TSecond Second;

        /// The non-inherited members of a constructed type are obtained by
        /// substituting, for each type parameter, the corresponding type parameter
        /// of the constructed type.
        public Pair(TFirst _first, TSecond _second)
        {
            First = _first;
            Second = _second;
        }

        public override string ToString()
        {
            /// Each class declaration has an associated bound type (4.4.3)
            /// known as the instance type
            string ret =
                "Instance (constructed) type is " + this.GetType().ToString() +
                "\nValue is " + First.ToString() + " - " + Second.ToString();
            return ret;
        }
    }

    /*-----------------------------------------------------*/

    class Program
    {
        static void Main(string[] args)
        {
            string generics =
                "Generics introduce to the .NET Framework the concept of type parameters," +
                "which make it possible to design classes and methods that defer" +
                "the specification of one or more types until the class or method" +
                "is declared and instantiated by client code.";

            /// Generic list of non-generic type
            /// Could be any type or class that you define
            /// (Your defined class will need to support
            /// List operations like sort and equality
            /// by implementing IComparable and IEquatable
            /// IComparable<T> Interface https://docs.microsoft.com/en-us/dotnet/api/system.icomparable-1?view=netframework-4.7.2,
            /// IEquatable<T> Interface https://docs.microsoft.com/en-us/dotnet/api/system.iequatable-1?view=netframework-4.7.2)

            string[] genericStringArray = generics.Split("., ".ToCharArray());

            List<string> genericStringList = new List<string>();
            genericStringList.AddRange(genericStringArray);

            // Or, in one statement, I could do
            //List<string> genericStringList = new List<string>(genericStrings);

            // Sorting built in to List<T> as long as T implements IComparable<T>
            genericStringList.Sort();

            foreach (string s in genericStringList)
                Console.WriteLine(s);

            /*-----------------------------------------------------*/

            /// DOY - similar to what we just did with strings,
            /// declare a generic list of Circles,
            /// declare and initialize an array of 3 circles
            /// (or just 3 individual circles),
            /// add the circles to the generic list of circles,
            /// sort the generic list of circles,
            /// and, finally, the circles in sorted order.
            ///
            /// After you complete that once successfully,
            /// see what happens when you comment out
            /// the CompareTo() method in Circle and then
            /// rebuild and rerun?

			/* Your code for a generic list of circles here */

            List<Circle> circleList = new List<Circle>();
            Circle[] circleArray = new Circle[3];
            Circle circle1 = new Circle(1);
            Circle circle2 = new Circle(3);
            Circle circle3 = new Circle(2);
            circleArray[0] = circle1;
            circleArray[1] = circle2;
            circleArray[2] = circle3;
            circleList.AddRange(circleArray);
            circleList.Sort();
            foreach (Circle s in circleList)
                Console.WriteLine(s);

            /*-----------------------------------------------------*/

            // Declare a Pair consisting of a String and a DateTime
            Pair<String, Double> ConstantPi =
                new Pair<String, Double>("Pi", 3.14159);

            Console.WriteLine(ConstantPi);


            /// Declare a generic list of generic Pair<String, DateTime>
            List<Pair<String, DateTime>> listOfPairs =
                new List<Pair<String, DateTime>>
                {
                    new Pair<String, DateTime>("Thanksgiving", new DateTime(2019, 11, 28)),
                    new Pair<string, DateTime>("Baseball Opening Day", new DateTime(2019, 3, 28)),
                    new Pair<String, DateTime>("End of First Mod", new DateTime(2019, 3, 15))
                };

            foreach (Pair<String, DateTime> p in listOfPairs)
                Console.WriteLine(p);

            /// There is a difficulty in doing some operations
            /// on a generic list of a generic type
            /// because difficult to implement IComparable and IEquatable
            //listOfPairs.Sort();

            //foreach (Pair<String, DateTime> p in listOfPairs)
            //    Console.WriteLine(p);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }




}
