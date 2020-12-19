using System;

namespace ProjectLibrary.Miscellaneous
{
    public class DictionarySearchResults<TKey>
    {
        public DateTime TimeOfSearchStart { get; init; }
        public long SearchTime { get; init; }
        public int[][] IndexesOfElements { get; init; }
        public TKey[] KeysOfElements { get; init; }
    }
}