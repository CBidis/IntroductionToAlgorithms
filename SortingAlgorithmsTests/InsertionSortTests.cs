using NUnit.Framework;
using SortingAlgorithms;

namespace SortingAlgorithmsTests
{
    [TestFixture]
    public class InsertionSortTests
    {
        [Test]
        public void Test()
        {
            var insertionSort = new InsertionSort<int>();
            var array = new[] { 5, 2, 4, 6, 1, 3 };
            array = insertionSort.Run(array);
            Assert.IsTrue(array.IsSorted());
        }
    }
}