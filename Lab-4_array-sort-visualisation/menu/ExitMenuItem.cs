using System;

namespace Lab_4_array_sort_visualisation.menu {
    public sealed class ExitMenuItem : MenuItem {
        public ExitMenuItem() : base("Выход") { }

        public override void Execute() {
            Console.WriteLine("Выход");
        }
    }
}