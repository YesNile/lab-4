using Lab_4_array_sort_visualisation.algorithms;

namespace Lab_4_array_sort_visualisation.menu.menus
{
    public class ShakerSortMenu : AlgorithmStringSortMenu
    {
        public ShakerSortMenu(bool isSelected = false) : base(sort: new ShakerSort(),
            title: "Shaker Сортировка текста", isSelected) { }
    }
}