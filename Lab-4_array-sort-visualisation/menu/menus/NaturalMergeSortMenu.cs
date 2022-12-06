using Lab_4_array_sort_visualisation.task_2;

namespace Lab_4_array_sort_visualisation.menu.menus
{
    public class NaturalMergeSortMenu : MergeSort
    {
        public NaturalMergeSortMenu(bool isSelected = false) : base(sortType: SortType.Natural, title: "Естественная сортировка слиянием", isSelected) { }
    }
}