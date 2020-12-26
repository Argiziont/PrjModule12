using System;
using System.Diagnostics;
using ProjectLibrary.Interfaces;

namespace ProjectLibrary
{
    public class AdvancedStringUtils<TKey> : SimpleStringUtils<TKey>, IPrintable
    {
        /// <summary>
        ///     Prints last search entries to screen
        /// </summary>
        public void PrintToScreen()
        {
            Debug.Assert(LastSearch != null, nameof(LastSearch) + " != null");

            for (var i = 0; i < LastSearch.IndexesOfElements.Length; i++)
                Console.WriteLine(
                    $"Entries of substring was found {LastSearch.IndexesOfElements[i].Length} entries in {i} element");
            Console.WriteLine($"Time of search start {LastSearch.TimeOfSearchStart}");
            Console.WriteLine($"Search time {LastSearch.SearchTime}");
        }
    }
}