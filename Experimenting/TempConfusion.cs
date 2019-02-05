using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Confusion
{
    public class Class1
    {
        public static void main()
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] split = line.Split(new char[] { '/' }, StringSplitOptions.None);
                long a = Int64.Parse(split[0]);
                long b = Int64.Parse(split[1]);
                if (a >= 0 && a <= 1000000 && b > 0 && b <= 1000000)
                {
                    
                }

            }
        }
    }
}
