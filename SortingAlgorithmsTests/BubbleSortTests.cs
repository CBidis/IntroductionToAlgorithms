using NUnit.Framework;
using SortingAlgorithms;

namespace SortingAlgorithmsTests
{
    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        public void BubbleSortAscendingTest()
        {
            var bubbleSort = new BubbleSort<int>();
            var array = new[] { 5, 2, 4, 6, 1, 3 };
            bubbleSort.Run(array);
            Assert.IsTrue(array.IsSortedAscending());
        }
    }
}