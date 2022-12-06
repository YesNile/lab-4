namespace Lab_4_array_sort_visualisation.menu
{
    public abstract class MenuItem
    {
        public readonly string Title;
        public abstract void Execute();
        public bool IsSelected { get; set; }

        public MenuItem(string title, bool isSelected = false)
        {
            Title = title;
            IsSelected = isSelected;
        }
    }
}