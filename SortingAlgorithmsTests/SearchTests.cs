using NUnit.Framework;
using SortingAlgorithms;
using System;

namespace SortingAlgorithmsTests
{
    [TestFixture]
    public class SearchTests
    {
        [Test]
        public void FoundLinearSearchTest()
        {
            var elements = new[] { 5, 2, 4, 3, 2, 6, 7 };
            var search = new Search<int>();
            var index = search.LinearSearch(elements, 2);
            Assert.IsTrue(index == 1);
        }

        [Test]
        public void NotFoundLinearSearchTest()
        {
            var elements = new[] { 5, 2, 4, 3, 2, 6, 7 };
            var search = new Search<int>();
            var index = search.LinearSearch(elements, 1);
            Assert.IsTrue(index == -1);
        }

        [Test]
        public void NullArrayLinearSearchTest()
        {
            int[] elements = null;
            var search = new Search<int>();
            Assert.Throws<ArgumentException>(() => search.LinearSearch(elements, 2));
        }

        [Test]
        public void FoundBinarySearchTest()
        {
            var elements = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var search = new Search<int>();
            var index = search.BinarySearch(elements, 2);
            Assert.IsTrue(index == 1);
        }

        [Test]
        public void NotFoundBinarySearchTest()
        {
            var elements = new[] { 2, 3, 4, 5, 6, 7, 8 };
            var search = new Search<int>();
            var index = search.BinarySearch(elements, 1);
            Assert.IsTrue(index == -1);
        }

        [Test]
        public void NullArrayBinarySearchTest()
        {
            int[] elements = null;
            var search = new Search<int>();
            Assert.Throws<ArgumentException>(() => search.BinarySearch(elements, 2));
        }   
    }
}
