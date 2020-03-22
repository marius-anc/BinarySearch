using System;
using Xunit;

namespace BinarySearch.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void BinarySearchWorksWhenSearchedNumberNotPresent()
        {
            int[] numbers = new int[] { 0, 2, 4, 6, 7, 13, 14 };
            Assert.Equal(-1, Program.BinarySearch(numbers, 10));
        }

        [Theory]
        [InlineData(new int[] { 0, 2, 4, 6, 7, 13, 14 }, 0, 0)]  //test first element
        [InlineData(new int[] { 0, 2, 4, 6, 7, 13, 14 },6, 14)] //tests last element
        [InlineData(new int[] { 0, 2, 4, 6, 7, 13, 14 },3, 6)] //tests an element from inside the array
        public void BinarySearchReturnCorrectIndexWhenSearchedNumberPresent(int[] numbers, int index, int searchedElement)
        {
            Assert.Equal(index, Program.BinarySearch(numbers, searchedElement));
        }

        [Fact]
        public void BinarySearchWorksWhenArrayHasLenght1()
        {
            int[] numbers = new int[] { 2 };
            Assert.Equal(0, Program.BinarySearch(numbers, 2));
        }

    }
}
