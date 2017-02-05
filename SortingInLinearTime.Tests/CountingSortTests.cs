using NUnit.Framework;
using SortingCommonLib;

namespace SortingInLinearTime.Tests
{
    [TestFixture]
    public class CountingSortTests
    {
        [Test]
        public void SortArrayInAscendingOrderWintCountingSortTest()
        {
            var numbers = new[] {2, 5, 3, 0, 2, 3, 0, 3};
            var countingSort = new CountingSort();
            var sortedNumbers = countingSort.Run(numbers);
            Assert.IsTrue(sortedNumbers.IsSortedAscending());
        }
    }
}