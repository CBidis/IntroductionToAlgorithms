using System.Linq;

namespace SortingInLinearTime
{
    public class CountingSort
    {
        public int[] Run(int[] numbers)
        {
            var sortedNumbers = new int[numbers.Length];
            var k = numbers.Max();
            var c = Enumerable.Repeat(0, k + 1).ToArray();

            foreach (var number in numbers)
            {
                c[number] = c[number] + 1;
            }

            // C[i] now contains the number of elements equal to i.

            for (var i = 1; i <= k; i++)
            {
                c[i] = c[i] + c[i - 1];
            }
            // C[i] now contains the number of elements less than or equal to i.

            for (var j = numbers.Length - 1; j >= 1; j--)
            {
                var number = numbers[j];
                sortedNumbers[c[number]-1] = number;
                c[number] = c[number] - 1;
            }
            return sortedNumbers;
        }
    }
}