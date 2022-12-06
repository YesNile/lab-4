using Lab_4_array_sort_visualisation.algorithms;

namespace Lab_4_array_sort_visualisation.menu.menus
{
    public class CocktailSortMenu : AlgorithmMenu
    {
        public CocktailSortMenu(bool isSelected = false) : base(algorithm: new CocktailSort(), title: "Cocktail sort",
            isSelected) { }
    }
}