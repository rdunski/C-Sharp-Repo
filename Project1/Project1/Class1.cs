using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 // Main is down \|/ \|/ \|/ \|/
{
    public class protect
    {
        protected void test()
        {
            Console.WriteLine("Success");
        }
    }
    public class inherit : protect
    {
        public void test1()
        {
            test();
        }
    }
    public class Person1
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
    }
    public class Person2
    {
        public Person2(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public string getFullName()
        {
            return FirstName + " " + LastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Class1 // <-----------------------------------------------------------Start here
    {
        public static void Main()
        {

            //fileUtilities(); //Tests file utilities such as date modified, file name, directory listing etc.
            //safeStreams(); //Tests the IDisposable interface with file streams
            //streams(); //Tests file streams and StreamUser
            //directory(); //Tests directory class
            //file(); // Tests reading/writing into file
            //linkedList(); // Tests linked list structure
            //stack(); //Tests stack structure
            //queue(); //Tests queue structure
            //dictionary(); // Tests dictionary structure and KeyValuePair
            //forEachLoop(); //Tests foreach loop and List structure
            //classTest1(); //Tests custom class
            //classTest2(); //Tests inheritance classes
            //alphaConversion(); //Converts int to alpha
            //alphabet(); //Prints letters of alphabet through int conversion to char
        }

        public static void classTest1()
        {
            Person2 person = new Person2("John", "Doe");
            Console.WriteLine(person.getFullName());
        }

        public static void classTest2()
        {
            var inherit = new inherit();
            inherit.test1();
        }

        public static void alphabet()
        {
            for (int i = 0; (i + 65) <= 90; i++)
            {
                int j = 65 + i;
                char letter = (char)j;
                Console.Write(letter);
                Console.Write(" ");
            }
        }

        public static void forEachLoop()
        {
            List<int> intList = new List<int>();
            intList.Add(6);
            intList.Add(8);
            intList.Add(9);

            foreach (int num in intList)
            {
                Console.WriteLine(num);
            }
        }

        public static void dictionary()
        {
            Dictionary<string, bool> test = new Dictionary<string, bool>();
            test.Add("test1", false);
            test.Add("test2", true);
            foreach (KeyValuePair<string, bool> pair in test)
            {
                if (pair.Value)
                    Console.WriteLine(pair.Key + " is true.");
                else
                    Console.WriteLine(pair.Key + " is not true.");
            }
        }

        public static void alphaConversion()
        {
            var boolean = true;
            Console.WriteLine("Enter a number between 65 and 90");
            string input = Console.ReadLine();
            int num = System.Convert.ToInt32(input);
            if (num >= 65 && num <= 90)
            {
                char letter = (char)num;
                Console.WriteLine("Your number is: " + letter);
            }
            else
            {
                while (boolean)
                {
                    Console.WriteLine("Invalid input, try again");
                    input = Console.ReadLine();
                    num = System.Convert.ToInt32(input);
                    if (num >= 65 && num <= 90)
                        boolean = false;
                }
                char letter1 = (char)num;
                Console.WriteLine("Your number is: " + letter1);
            }
        }

        public static void queue()
        {
            Queue<string> test = new Queue<string>();
            test.Enqueue("test1");
            test.Enqueue("test2");
            test.Enqueue("test3");

            while (test.Count > 0)
            {
                string test1 = test.Dequeue();
                Console.WriteLine(test1);
            }
        }

        public static void stack()
        {
            Stack<string> months = new Stack<string>();
            months.Push("January");
            months.Push("February");
            months.Push("March");
            months.Push("April");
            months.Push("May");
            months.Push("June");

            while (months.Count > 0)
            {
                string month = months.Pop();
                Console.WriteLine(month);
            }
        }

        public static void linkedList()
        {
            LinkedList<string> months = new LinkedList<string>();
            months.AddLast("March");
            months.AddFirst("January");

            var march = months.Find("March");

            months.AddBefore(march, "February");
            months.AddAfter(march, "April");

            foreach (string month in months)
            {
                Console.WriteLine(month);
            }
        }

        public static void file()
        {
            System.IO.File.WriteAllText(@".\hello.txt", "Test");

            string content = System.IO.File.ReadAllText(@".\hello.txt");
            Console.WriteLine(content);
            System.IO.File.Delete(@".\hello.txt");
        }

        public static void directory()
        {
            System.IO.File.WriteAllText(@".\hello.txt", "Hello World");

            foreach (string file in System.IO.Directory.GetFiles(@".\"))
            {
                Console.WriteLine(file);
            }
        }

        public static void streams()
        {
            using (var writer = new System.IO.StreamWriter(
                new System.IO.FileStream(@".\streamtest.txt", System.IO.FileMode.Create)))
            {
                writer.Write("Testing testing");
            }

            using (var reader = new System.IO.StreamReader(
                new System.IO.FileStream(@".\streamtest.txt", System.IO.FileMode.Open)))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }

        public static void safeStreams()
        {
            using (var writer = new System.IO.StreamWriter(new System.IO.FileStream(@".\safestreamtest.txt", System.IO.FileMode.Create)))
            {
                writer.WriteLine("Test1");
                writer.WriteLine("Test2");
                writer.WriteLine("Test3");
            }

            using (var reader = new System.IO.StreamReader(new System.IO.FileStream(@".\safestreamtest.txt", System.IO.FileMode.Open)))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }

        public static void fileUtilities()
        {
            const string DirectoryPath = @".\";
            const string FilePath = @".\HelloWorld.txt";

            // Create a sub-directory 
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(DirectoryPath, "sub-dir"));
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(DirectoryPath, "sub-dir2"));

            // Create a file
            System.IO.File.WriteAllText(FilePath, "Hello World");

            System.IO.FileInfo file = new System.IO.FileInfo(FilePath);

            Console.WriteLine(file.Exists);
            Console.WriteLine(file.Name);
            Console.WriteLine(file.LastWriteTime);

            string directoryPath = System.IO.Path.GetDirectoryName(FilePath);

            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(directoryPath);

            Console.WriteLine(directory.Exists);
            Console.WriteLine(directory.LastWriteTime);

            foreach (string childDirectory in System.IO.Directory.GetDirectories(directoryPath))
            {
                Console.WriteLine(childDirectory);
            }
        }
    }
}