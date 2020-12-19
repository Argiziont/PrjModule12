using System;
using System.Diagnostics;
using ProjectLibrary.Interfaces;

namespace ProjectLibrary
{
    public class AdvancedStringUtils : SimpleStringUtils, IPrintable
    {
        /// <summary>
        ///     Prints last search entries to screen
        /// </summary>
        public void PrintToScreen()
        {
            Debug.Assert(LastSearchIntArray != null, nameof(LastSearchIntArray) + " != null");

            for (var i = 0; i < LastSearchIntArray.Length; i++)
                Console.WriteLine(
                    $"Entries of substring was found {LastSearchIntArray[i].Length} entries in {i} element");
        }
    }
}