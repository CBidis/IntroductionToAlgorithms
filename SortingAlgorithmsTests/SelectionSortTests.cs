using NUnit.Framework;
using SortingAlgorithms;
using System;
using SortingCommonLib;

namespace SortingAlgorithmsTests
{
    [TestFixture]
    public class SelectionSortTests
    {
        [Test]
        public void SelectionSortAscendingTest()
        {
            var selectionSort = new SelectionSort<int>();
            var array = new[] { 5, 2, 4, 7, 1, 3, 1, 6 };
            selectionSort.Run(array);
            Assert.IsTrue(array.IsSortedAscending());
        }

        [Test]
        public void NullArraySelectionSortTest()
        {
            var selectionSort = new SelectionSort<int>();
            int[] array = null;
            Assert.Throws<ArgumentException>(() => selectionSort.Run(array));
        }
    }
}