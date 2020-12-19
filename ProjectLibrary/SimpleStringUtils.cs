using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ProjectLibrary.Miscellaneous;

namespace ProjectLibrary
{
    public class SimpleStringUtils
    {
        protected int[][] LastSearchIntArray;

        /// <summary>
        ///     Search all entry substring in IDictionary
        /// </summary>
        /// <typeparam name="TKey">Key of your dictionary</typeparam>
        /// <param name="dictionary">Dictionary where we'll search</param>
        /// <param name="substring">Substring</param>
        public DictionarySearchResults<TKey> MultipleDictionaryStringSearchResults<TKey>(
            IDictionary<TKey, string> dictionary,
            string substring)
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));
            if (substring == null) throw new ArgumentNullException(nameof(substring));

            var dateNow = DateTime.Now;
            var timeWatch = Stopwatch.StartNew();
            var entriesList = new List<int[]>();
            var keysList = new List<TKey>();

            foreach (var (key, value) in dictionary)
            {
                var results = MultipleQuickSearch(value, substring);
                entriesList.Add(results);
                if (results.Length >= 1)
                    keysList.Add(key);
            }

            LastSearchIntArray = entriesList.ToArray();
            return new DictionarySearchResults<TKey>
            {
                IndexesOfElements = entriesList.ToArray(), KeysOfElements = keysList.ToArray(),
                SearchTime = timeWatch.ElapsedMilliseconds, TimeOfSearchStart = dateNow
            };
        }

        /// <summary>
        ///     Filters all elements where string equals substring
        /// </summary>
        /// <param name="substring">Substring for search</param>
        /// <param name="strings">String where we'll search</param>
        /// <returns></returns>
        public static string[] StringCompleteEntriesSearch(string substring, params string[] strings)
        {
            if (substring == null) throw new ArgumentNullException(nameof(substring));
            if (strings == null) throw new ArgumentNullException(nameof(strings));

            return strings.Where(str => str == substring).ToArray();
        }

        /// <summary>
        ///     Search all entries of substring in list of strings
        /// </summary>
        /// <param name="searchList">List where entries will be searched</param>
        /// <param name="substring">Substring for search</param>
        /// <returns></returns>
        public static int[][] MultipleListQuickSearch(IList<string> searchList, string substring)
        {
            if (searchList == null) throw new ArgumentNullException(nameof(searchList));
            if (substring == null) throw new ArgumentNullException(nameof(substring));

            return searchList.Select(singleString => MultipleQuickSearch(singleString, substring)).ToArray();
        }

        /// <summary>
        ///     Search all entries of substring in given string
        /// </summary>
        /// <param name="searchString">String what we'll use for search</param>
        /// <param name="substring">Substring for search</param>
        /// <returns></returns>
        public static int[] MultipleQuickSearch(string searchString, string substring)
        {
            if (searchString == null) throw new ArgumentNullException(nameof(searchString));
            if (substring == null) throw new ArgumentNullException(nameof(substring));

            var entriesList = new List<int>();

            var entry = 0;
            while (entry != -1)
            {
                entry = QuickSearch(searchString, substring, entry == 0 ? 0 : entry + 1);

                if (entry != -1)
                    entriesList.Add(entry);
            }

            return entriesList.ToArray();
        }

        private static int QuickSearch(string searchString, string substring, int startShift = 0)
        {
            var shiftIndex = startShift;

            while (shiftIndex + substring.Length <= searchString.Length)
                for (var i = 0; i < substring.Length; i++)
                    if (searchString[i + shiftIndex] == substring[i])
                    {
                        if (i == substring.Length - 1) return shiftIndex;
                    }
                    else
                    {
                        shiftIndex++;
                        break;
                    }

            return -1;
        }
    }
}