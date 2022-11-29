using Lab_4_array_sort_visualisation.algorithms;

namespace Lab_4_array_sort_visualisation.menu.menus {
    public class BubbleSortMenu : AlgorithmMenu {
        public BubbleSortMenu(bool isSelected = false) : base(algorithm: new BubbleSort(),title: "Bubble sort", isSelected) { }
    }
}