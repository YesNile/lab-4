using Lab_4_array_sort_visualisation.menu;
using Lab_4_array_sort_visualisation.menu.menus;
using Lab_4_array_sort_visualisation.task_2;
using lab4;

namespace Lab_4_array_sort_visualisation {
    class Program {
        static void Main(string[] args) {
            // Menu menu = new MainMenu();
            // menu.Start();
            TableWorker worker = new TableWorker("..\\..\\..\\files\\countries.csv");
            worker.GetSortedTable(outputPath:"..\\..\\..\\files\\countries_sorted.csv", ascending:true, time:1000, attribute:"Country", sortType: SortType.Natural);
        }
    }
}