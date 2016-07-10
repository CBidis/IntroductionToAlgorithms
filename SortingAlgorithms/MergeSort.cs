using System;

namespace SortingAlgorithms
{
    public class MergeSort
    {
        public void Run(int[] array, int p, int r)
        {
            if (array == null) throw new ArgumentException("array canno be null");
            MergeSortAlgorithm(array, p, r);
        }

        private void MergeSortAlgorithm(int[] A, int p, int r)
        {
            if (p < r)
            {
                var q = (p + r) / 2;
                MergeSortAlgorithm(A, p, q);
                MergeSortAlgorithm(A, q + 1, r);
                Merge(A, p, q, r);
            }
        }

        private void Merge(int[] A, int left, int mid, int right)
        {
            // compute the length of the subarray A[left..mid]
            var n1 = mid - left + 1;
            // compute the length if the subarray A[mid+1..right]
            var n2 = right - mid;

            // create two arrays one left and one right of lengths n1+1 and n2+1
            // the extra position in each array will hold the sentinel.
            var L = new int[n1 + 1];
            var R = new int[n2 + 1];

            // copy the subarray A[left..mid] into the L[0..n1]
            for (var i = 0; i < n1; i++)
            {
                L[i] = A[left + i];
            }

            // copy the subarray A[mid+1..right] into the R[0..n2]
            for (var j = 0; j < n2; j++)
            {
                R[j] = A[mid + j + 1];
            }

            // put the sentinels at te end of the arrays L and R
            L[n1] = int.MaxValue;
            R[n2] = int.MaxValue;

            // At the start of each iteration the subarray A[p..k-1] contains the k-p smallest elements of L[1..n1+1]
            // and R[1..n2+1], in sorted order. Morover, L[i] and R[j] are the smallest elements of their arrays that
            // have not been copied back into A.
            int ix = 0;
            int jx = 0;
            for (var k = left; k <= right; k++)
            {
                if (L[ix] <= R[jx])
                {
                    A[k] = L[ix];
                    ix = ix + 1;
                }
                else
                {
                    A[k] = R[jx];
                    jx = jx + 1;
                }
            }
        }
    }
}