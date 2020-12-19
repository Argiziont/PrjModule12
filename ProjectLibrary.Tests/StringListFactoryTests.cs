using System;
using System.Collections.Generic;
using Xunit;

namespace ProjectLibrary.Tests
{
    public class StringListFactoryTests
    {
        #region snippet_AddStrings_Passes_InputIsCorrect

        [Fact]
        public void AddStrings_Passes_InputIsCorrect()
        {
            // Arrange
            var slf = new StringListFactory();

            // Act
            slf.AddStrings("Hello world");

            // Assert
            Assert.Single(slf.SortedLists);

        }

        #endregion

        #region snippet_ToCompare_ThrowsArgumentNullException_InputIsNull

        [Fact]
        public void ToCompare_ThrowsArgumentNullException_InputIsNull()
        {
            // Arrange
            var slf = new StringListFactory();

            // Act
            void Result() => slf.AddStrings(null);

            // Assert
            Assert.Throws<ArgumentNullException>(Result);

        }

        #endregion

        #region snippet_AddStrings_Passes_InputIsCorrect

        [Fact]
        public void RemoveMultipleSpaces_Passes_InputIsCorrect()
        {
            // Arrange
            const string expected = "Hello world";

            // Act
            var result=StringListFactory.RemoveMultipleSpaces("Hello     world");

            // Assert
            Assert.Equal(result, expected);

        }

        #endregion

        #region snippet_RemoveMultipleSpaces_ThrowsArgumentNullException_InputIsNull

        [Fact]
        public void RemoveMultipleSpaces_ThrowsArgumentNullException_InputIsNull()
        {
            // Arrange&Act
            static void Result() => StringListFactory.RemoveMultipleSpaces(null);

            // Assert
            Assert.Throws<ArgumentNullException>(Result);

        }

        #endregion
    }
}