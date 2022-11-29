namespace Lab_4_array_sort_visualisation.algorithms {
    public class CoctailSort : Algorithm {
        /* Шейкер-сортировка */
        private void ShakerSort(int[] data) {
            int left = 0,
                right = data.Length - 1;

            while (left < right) {
                for (int i = left; i < right; i++) {
                    if (data[i] > data[i + 1]) {
                        Swap(data, i, i + 1);
                    }
                }

                right--;

                for (int i = right; i > left; i--) {
                    if (data[i - 1] > data[i]) {
                        Swap(data, i - 1, i);
                    }
                }

                left++;
            }
        }

        /* Поменять элементы местами */
        static void Swap(int[] array, int i, int j) {
            (array[i], array[j]) = (array[j], array[i]);
        }

        public CoctailSort(int[] data, int delay) : base(data, delay) { }
        public override void Sort() {
            ShakerSort(Data);
        }
    }
}