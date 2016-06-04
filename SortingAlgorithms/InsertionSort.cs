using System;

namespace SortingAlgorithms
{
    public class InsertionSort<T> where T : struct, IComparable<T>
    {
        public T[] Run(T[] elements)
        {
            for (int j = 1; j < elements.Length; j++)
            {
                var key = elements[j];
                // Insert elements[j] into the sorted sequence A[1..j-1]
                var i = j - 1;
                while (i >= 0
                    && elements[i].CompareTo(key) > 0)
                {
                    elements[i + 1] = elements[i];
                    i = i - 1;
                }
                elements[i + 1] = key;
            }
            return elements;
        }
    }
}