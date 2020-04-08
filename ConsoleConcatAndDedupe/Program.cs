using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleConcatAndDedupe
{
    class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            string[] namesResult = names1.Concat(names2).ToArray();
            IEnumerable<string> distinctNames = namesResult.Distinct();
            return distinctNames.ToArray();
        }
        
        public static void Main(string[] args)
        {
            string[] names1 = new string[] {"Ava", "Emma", "Olivia", "Ava"};
            string[] names2 = new string[] {"Olivia", "Sophia", "Emma", "Julie", "Julie"};
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        }
    }
}
