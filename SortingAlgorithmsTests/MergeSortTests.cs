using NUnit.Framework;
using SortingAlgorithms;
using SortingCommonLib;

namespace SortingAlgorithmsTests
{
    [TestFixture]
    public class MergeSortTests
    {
        [Test]
        public void MergeSortAscendingTest()
        {
            var mergeSort = new MergeSort();
            var array = new[] { 5, 2, 4, 7, 1, 3, 1, 6 };
            mergeSort.Run(array, 0, array.Length-1);
            Assert.IsTrue(array.IsSortedAscending());
        }
    }
}
