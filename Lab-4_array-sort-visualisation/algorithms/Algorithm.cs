using Lab_4_array_sort_visualisation.utils;

namespace Lab_4_array_sort_visualisation.algorithms
{
    public abstract class Algorithm<T>
    {
        protected readonly Logger Logger = new Logger();
        public T[] Data { get; set; }
        public int SortDelay { get; set; }

        protected Algorithm(T[] data, int sortDelay)
        {
            Data = data;
            SortDelay = sortDelay;
        }

        protected Algorithm() { }

        public abstract void Sort();
    }
}