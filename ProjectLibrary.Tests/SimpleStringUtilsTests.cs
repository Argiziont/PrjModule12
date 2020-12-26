using System;
using System.Collections.Generic;
using Xunit;

namespace ProjectLibrary.Tests
{
    public class SimpleStringUtilsTests
    {
        #region snippet_MultipleDictionaryStringSearchResults_Passes_InputIsCorrect

        [Fact]
        public void MultipleDictionaryStringSearchResults_Passes_InputIsCorrect()
        {
            // Arrange
            var dict = new Dictionary<int, string> { { 0, "hello world       hi everyone    " }, { 1, "hello world hello    " }};
            var stringUtils = new SimpleStringUtils<int>();
            
            // Act
            var result = stringUtils.MultipleDictionaryStringSearchResults(dict, "hi");

            // Assert
            Assert.NotNull(result);

        }

        #endregion

        #region snippet_MultipleDictionaryStringSearchResults_ThrowsArgumentNullException_InputIsNull

        [Fact]
        public void MultipleDictionaryStringSearchResults_ThrowsArgumentNullException_InputIsNull()
        {
            // Arrange
            var stringUtils = new SimpleStringUtils<int>();

            // Act
            void Result() => stringUtils.MultipleDictionaryStringSearchResults(null, null);

            // Assert
            Assert.Throws<ArgumentNullException>(Result);

        }

        #endregion

        #region snippet_StringCompleteEntriesSearch_Passes_InputIsCorrect

        [Fact]
        public void StringCompleteEntriesSearch_Passes_InputIsCorrect()
        {

            // Arrange&&Act
            var result = SimpleStringUtils<int>.StringCompleteEntriesSearch("hi", "hi","hello");

            // Assert
            Assert.NotNull(result);

        }

        #endregion

        #region snippet_StringCompleteEntriesSearch_ThrowsArgumentNullException_InputIsNull

        [Fact]
        public void StringCompleteEntriesSearch_ThrowsArgumentNullException_InputIsNull()
        {

            // Arrange&&Act
            static void Result() => SimpleStringUtils<int>.StringCompleteEntriesSearch(null, null);

            // Assert
            Assert.Throws<ArgumentNullException>(Result);

        }

        #endregion

        #region snippet_MultipleListQuickSearch_Passes_InputIsCorrect

        [Fact]
        public void MultipleListQuickSearch_Passes_InputIsCorrect()
        {
            // Arrange
            var list = new List<string>() { "hello world       hi everyone    ", "hello world hello    "};


            // Act
            var result = SimpleStringUtils<int>.MultipleListQuickSearch(list, "hi");

            // Assert
            Assert.NotNull(result);

        }

        #endregion

        #region snippet_MultipleListQuickSearch_ThrowsArgumentNullException_InputIsNull

        [Fact]
        public void MultipleListQuickSearch_ThrowsArgumentNullException_InputIsNull()
        {

            // Arrange&&Act
            static void Result() => SimpleStringUtils<int>.MultipleListQuickSearch(null, null);

            // Assert
            Assert.Throws<ArgumentNullException>(Result);

        }

        #endregion

        #region snippet_MultipleQuickSearch_Passes_InputIsCorrect

        [Fact]
        public void MultipleQuickSearch_Passes_InputIsCorrect()
        {
            // Arrange&&Act
            var result = SimpleStringUtils<int>.MultipleQuickSearch("hello world       hi everyone  hello world hello    ", "hi");

            // Assert
            Assert.NotNull(result);

        }

        #endregion

        #region snippet_MultipleQuickSearch_ThrowsArgumentNullException_InputIsNull

        [Fact]
        public void MultipleQuickSearch_ThrowsArgumentNullException_InputIsNull()
        {

            // Arrange&&Act
            static void Result() => SimpleStringUtils<int>.MultipleQuickSearch(null, null);

            // Assert
            Assert.Throws<ArgumentNullException>(Result);

        }

        #endregion
    }
}