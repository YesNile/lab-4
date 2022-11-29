using System;

namespace Lab_4_array_sort_visualisation.algorithms {
    public class QuickSort : Algorithm {
        public int[] Calculate(int[] Data) {
            if (Data.Length <= 1) return Data;
            var randomNum = Data[new Random().Next(0, Data.Length)];

            int bigCount = 0;
            int lowCount = 0;
            int equalCount = 0;

            foreach (var element in Data) {
                if (element > randomNum)
                    bigCount++;
                else if (element < randomNum)
                    lowCount++;
                else
                    equalCount++;
            }

            int[] bigElements = new int[bigCount];
            int[] lowElements = new int[lowCount];
            int[] equalElements = new int[equalCount];

            int lowindex = 0;
            int bigindex = 0;
            int equalindex = 0;

            for (int i = 0; i < Data.Length; i++) {
                var element = Data[i];
                if (element > randomNum)
                    bigElements[bigindex++] = element;
                else if (element < randomNum)
                    lowElements[lowindex++] = element;
                else
                    equalElements[equalindex++] = element;
            }

            Calculate(lowElements);
            Calculate(bigElements);

            for (int i = 0; i < Data.Length; i++) {
                if (i < lowElements.Length)
                    Data[i] = lowElements[i];
                else if (i - lowElements.Length < equalElements.Length)
                    Data[i] = equalElements[i - lowElements.Length];
                else
                    Data[i] = bigElements[i - lowElements.Length - equalElements.Length];
            }

            return Data;
        }

        public QuickSort(int[] data, int delay) : base(data, delay) { }
        public override void Sort() {
            Calculate(Data);
        }
    }
}