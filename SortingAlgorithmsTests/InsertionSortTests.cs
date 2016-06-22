using NUnit.Framework;
using SortingAlgorithms;

namespace SortingAlgorithmsTests
{
    [TestFixture]
    public class InsertionSortTests
    {
        [Test]
        public void InsertionSortAscendingTest()
        {
            var insertionSort = new InsertionSort<int>();
            var array = new[] { 5, 2, 4, 6, 1, 3 };
            insertionSort.Run(array);
            Assert.IsTrue(array.IsSortedAscending());
        }

        [Test]
        public void InsertionSortDescendingTest()
        {
            var insertionSort = new InsertionSort<int>();
            var array = new[] { 5, 2, 4, 6, 1, 3 };
            insertionSort.RunNonIncreasing(array);
            Assert.IsTrue(array.IsSortedDescending());
        }
    }
}