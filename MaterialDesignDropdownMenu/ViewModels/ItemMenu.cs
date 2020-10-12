﻿using MaterialDesignThemes.Wpf;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MaterialDesignDropdownMenu.ViewModels
{
    public class ItemMenu
    {
        public string Header { get; private set; }
        public PackIconKind Icon { get; private set; }
        public List<SubItem> SubItems { get; private set; }
        //public UserControl Screen { get; private set; }
        public ItemMenu(string header, List<SubItem> subItems, PackIconKind icon)
        {
            Header = header;
            SubItems = subItems;
            Icon = icon;
        }
    }
}
