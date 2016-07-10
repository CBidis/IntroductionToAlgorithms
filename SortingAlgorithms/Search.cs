using System;

namespace SortingAlgorithms
{
    public class Search<T> where T : IComparable<T>
    {
        /// <summary>
        /// Takes an array and it does a linear search to find the first elelemt in the array that is 
        /// equal to the provided element. If such an element is found, then it returns the corresponding index.
        /// Otherwise it returns -1.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="element">The element.</param>
        /// <returns></returns>
        public int LinearSearch(T[] array, T element)
        {
            if (array == null) throw new ArgumentException("array cannot be null");
            if (element.Equals(null)) throw new ArgumentException("element cannot be null");
            var index = -1;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        /// <summary>
        /// Takes an array that is sorted in ascending order and it does a binary search to find the index of the first
        /// element whose value is equals to the provided element. If such an element is found the index
        /// is returned. Otherwise it returns -1.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="element">The element.</param>
        /// <returns>The index.</returns>
        public int BinarySearch(T[] array, T element)
        {
            if (array == null) throw new ArgumentException("array cannot be null");
            if (element.Equals(null)) throw new ArgumentException("element cannot be null");
            if (!array.IsSortedAscending()) throw new ArgumentException("array must be sorted in ascending order");
            return BinarySearchInternal(array, element, 0, array.Length - 1);
        }

        private int BinarySearchInternal(T[] array, T element, int left, int right)
        {
            if (left == right)
            {
                return array[left].Equals(element) ? left : -1;
            }
            // calculate the index of the mid element.
            var mid = right - left / 2;
            if (array[mid].Equals(element))
            {
                // The element found at the mid of the array.
                return mid;
            }
            if (array[mid].CompareTo(element) < 0)
            {
                // We should look to the upper half of the array.
                return BinarySearchInternal(array, element, mid + 1, right);
            }
            // We should look to the lower half of the array. 
            return BinarySearchInternal(array, element, left, mid - 1);
        }
    }
}