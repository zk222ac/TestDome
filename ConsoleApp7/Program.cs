using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
       static List<string> _noDuplicate = new List<string>();
        static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            UniqueNames(names1, names2); 
            UniqueNames(names2 , names1);

            foreach (var d in _noDuplicate)
            {
                Console.WriteLine(d);
            }

            Console.Read();
        }
       
        public static void UniqueNames(string[] array1, string[] array2)
        {
            foreach (var n1 in array1)
            {
                foreach (var n2 in array2)
                {
                    if (n1 != n2)
                    {
                        if (!_noDuplicate.Contains(n1))
                        {
                            _noDuplicate.Add(n1);
                        }
                    }
                }
            }
        }
    }
}
