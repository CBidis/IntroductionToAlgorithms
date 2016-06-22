using NUnit.Framework;
using SortingAlgorithms;

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
            var index = search.Linear(elements, 2);
            Assert.IsTrue(index == 1);
        }

        [Test]
        public void NotFoundLinearSearchTest()
        {
            var elements = new[] { 5, 2, 4, 3, 2, 6, 7 };
            var search = new Search<int>();
            var index = search.Linear(elements, 1);
            Assert.IsTrue(index == -1);
        }
    }
}
