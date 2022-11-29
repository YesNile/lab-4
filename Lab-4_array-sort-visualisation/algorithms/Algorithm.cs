using Lab_4_array_sort_visualisation.utils;

namespace Lab_4_array_sort_visualisation.algorithms {
    public abstract class Algorithm {
        protected readonly Logger Logger = new Logger();
        public int[] Data { get; set; }
        public int SortDelay { get; set; }

        protected Algorithm(int[] data, int sortDelay) {
            Data = data;
            SortDelay = sortDelay;
        }

        protected Algorithm() { }

        public abstract void Sort();
    }
}