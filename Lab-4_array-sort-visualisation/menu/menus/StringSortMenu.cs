﻿using System.Collections.Generic;

namespace Lab_4_array_sort_visualisation.menu.menus
{
    public class StringSortMenu : Menu
    {
        public StringSortMenu(bool isSelected = false) : base(title: "Сортировка слов", items: new List<MenuItem>()
        {
            new ShakerSortMenu(),
            new ABCSortMenu()
        }, isSelected) { }
    }
}