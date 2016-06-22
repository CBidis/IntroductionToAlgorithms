namespace SortingAlgorithms
{
    public class Search<T>
    {
        public int Linear(T[] sequence, T element)
        {
            var index = -1;
            for (var i = 0; i < sequence.Length; i++)
            {
                if (sequence[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}