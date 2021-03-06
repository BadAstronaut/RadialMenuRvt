﻿using PropertyChanged;

namespace WpfApplication1.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ButtonViewModel
    {
        public string Name { set; get; }

        public string Shortcut { set; get; }

        public string IconPath { set; get; }

        public string Tooltip { set; get; }
    }
}
