#nullable enable
using System.Collections.Generic;

namespace ProjectLibrary.Interfaces
{
    public interface IListComparator<T>:IComparer<LinkedList<T>>
    {
        public int ToCompare(LinkedList<T>? comparable, LinkedList<T>? comparate);
    }
}