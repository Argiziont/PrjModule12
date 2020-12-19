using System;
using System.Collections.Generic;
using Xunit;

namespace ProjectLibrary.Tests
{
    public class ComparatorTests
    {
        #region snippet_ToCompare_Passes_InputIsCorrect

        [Fact]
        public void ToCompare_Passes_InputIsCorrect()
        {
            // Arrange
            var list1 = new LinkedList<string>() { };
            var list2 = new LinkedList<string>() { };

            var comparator = new Comparator();

            // Act
            var result=comparator.ToCompare(list1,list2);

            // Assert
            Assert.Equal(0, result);

        }

        #endregion

        #region snippet_ToCompare_ThrowsArgumentNullException_InputIsNull

        [Fact]
        public void ToCompare_ThrowsArgumentNullException_InputIsNull()
        {
            // Arrange

            var comparator = new Comparator();

            // Act
            void Result() => comparator.ToCompare(null, null);

            // Assert
            Assert.Throws<ArgumentNullException>(Result);

        }

        #endregion
    }
}