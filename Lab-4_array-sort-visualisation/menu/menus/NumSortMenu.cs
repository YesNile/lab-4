using System.Collections.Generic;

namespace Lab_4_array_sort_visualisation.menu.menus
{
    public class NumSortMenu : Menu
    {
        public NumSortMenu(bool isSelected = false) : base(title: "Сортировки последовательности чисел",
            items: new List<MenuItem>()
            {
                new BubbleSortMenu(),
                new CocktailSortMenu(),
                new QuickSortMenu()
            }, isSelected) { }
    }
}