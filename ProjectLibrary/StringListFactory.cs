using System;
using System.Collections.Generic;

namespace ProjectLibrary
{
    public class StringListFactory
    {
        public SortedSet<LinkedList<string>> SortedLists { get; set; } =
            new(new Comparator());

        /// <summary>
        ///     Adds strings arrays to SortedSet
        /// </summary>
        /// <param name="strings">String arrays</param>
        public void AddStrings(params string[] strings)
        {
            if (strings == null) throw new ArgumentNullException(nameof(strings));

            foreach (var singleString in strings) SortedLists.Add(StringsToLists(singleString));
        }

        /// <summary>
        ///     Prints Result to console
        /// </summary>
        public void PrintStrings()
        {
            if (SortedLists.Count <= 0)
                Console.WriteLine("There is not enough string to print");
            else
                foreach (var list in SortedLists)
                {
                    foreach (var word in list) Console.Write(word + ' ');
                    Console.WriteLine("\n");
                }
        }

        /// <summary>
        ///     Removes all multiple-spaces in string
        /// </summary>
        public static string RemoveMultipleSpaces(string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            var finalString = str;

            while (finalString.Contains("  ")) finalString = finalString.Replace("  ", " ");

            return finalString;
        }

        private static LinkedList<string> StringsToLists(string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            var splitedString = RemoveMultipleSpaces(str).Split(' ');
            var list = new LinkedList<string>();

            foreach (var word in splitedString)
                list.AddLast(word);
            return list;
        }
    }
}