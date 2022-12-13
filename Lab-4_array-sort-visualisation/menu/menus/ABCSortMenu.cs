using Lab_4_array_sort_visualisation.algorithms;

namespace Lab_4_array_sort_visualisation.menu.menus
{
    public class ABCSortMenu : AlgorithmStringSortMenu
    {
        public ABCSortMenu(bool isSelected = false) : base(sort: new ABCSort(), title: "ABC Сортировка текста",
            isSelected) { }
    }
}