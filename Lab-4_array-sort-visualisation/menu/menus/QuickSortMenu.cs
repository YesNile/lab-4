using Lab_4_array_sort_visualisation.algorithms;

namespace Lab_4_array_sort_visualisation.menu.menus {
    public class QuickSortMenu : AlgorithmMenu {
        public QuickSortMenu(bool isSelected = false) : base(algorithm: new QuickSort(), title: "Quick sort",
            isSelected) { }
    }
}