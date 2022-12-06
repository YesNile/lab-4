using Lab_4_array_sort_visualisation.task_2;

namespace Lab_4_array_sort_visualisation.menu.menus
{
    public class MultiPathMergeSortMenu : MergeSort
    {
        public MultiPathMergeSortMenu(bool isSelected = false) : base(sortType: SortType.Multipath, title: "Многопутевая сортировка слиянием", isSelected) { }
    }
}