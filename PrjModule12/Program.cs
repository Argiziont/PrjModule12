using System;
using System.Collections.Generic;
using ProjectLibrary;

namespace PrjModule12
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var slf = new StringListFactory();
            
            const string str1 = "hello world       hi everyone    ";
            const string str2 = "hello world hello    ";
            const string str3 = "hello world  hi hi hi ";
            const string str4 = "hello world";
            
            slf.AddStrings(str1,str2,str3,str4);
            slf.PrintStrings();

            var dict = new Dictionary<int, string> {{0, str1}, {1, str2}, {2, str3}, {3, str4}};
            var stringUtils = new AdvancedStringUtils();


            var entries = SimpleStringUtils.MultipleQuickSearch(str3, "hi");
            var entries2= SimpleStringUtils.MultipleListQuickSearch(new List<string>(){ str1 ,str2,str3,str4}, "hi");
            var dictResult = stringUtils.MultipleDictionaryStringSearchResults(dict, "hi");
            
            stringUtils.PrintToScreen();


        }
    }
}
