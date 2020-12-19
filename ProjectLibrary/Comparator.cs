#nullable enable
using System;
using System.Collections.Generic;
using ProjectLibrary.Interfaces;

namespace ProjectLibrary
{
    public class Comparator : IListComparator<string>
    {
        public int Compare(LinkedList<string>? x, LinkedList<string>? y)
        {
            return ToCompare(x, y);
        }

        /// <summary>
        ///     Compares Linked lists
        /// </summary>
        /// <param name="comparable">Object with what we will compare</param>
        /// <param name="comparate">Object that is compared</param>
        public int ToCompare(LinkedList<string>? comparable, LinkedList<string>? comparate)
        {
            if (comparable == null) throw new ArgumentNullException(nameof(comparable));
            if (comparate == null) throw new ArgumentNullException(nameof(comparate));

            if (comparable.Count < comparate.Count)
                return 1;

            if (comparable.Count > comparate.Count)
                return -1;

            return 0;
        }
    }
}