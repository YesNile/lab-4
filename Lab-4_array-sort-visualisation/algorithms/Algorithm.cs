using Lab_4_array_sort_visualisation.utils;

namespace Lab_4_array_sort_visualisation.algorithms {
    public abstract class Algorithm {
        protected Logger Logger;
        protected int[] Data;
        protected int SortDelay;
        protected Algorithm(int[] data, int sortDelay) {
            Logger = new Logger();
            Data = data;
            SortDelay = sortDelay;
        }

        public abstract void Sort();
    }
}