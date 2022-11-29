using System.Collections.Generic;

namespace Lab_4_array_sort_visualisation.menu.menus {
    public sealed class MainMenu : Menu {
        public MainMenu() : base(title: "", items: new List<MenuItem>()
        {
            new BubbleSortMenu(),
            new CocktailSortMenu(),
            new QuickSortMenu()
        }) { }
    }
}