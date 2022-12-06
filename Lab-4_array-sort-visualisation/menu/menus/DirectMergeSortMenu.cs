using Lab_4_array_sort_visualisation.task_2;

namespace Lab_4_array_sort_visualisation.menu.menus
{
    public class DirectMergeSortMenu : MergeSort
    {
        public DirectMergeSortMenu(bool isSelected = false) : base(sortType: SortType.Direct, title: "Прямая сортировка слиянием", isSelected) { }
    }
}