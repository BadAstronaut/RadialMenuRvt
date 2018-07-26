using PropertyChanged;

namespace WpfApplication1.Models
{
    [AddINotifyPropertyChangedInterface]
    public class RadialMenuButton
    {
        public string Name { set; get; }

        public string Shortcut { set; get; }

        public string IconPath { set; get; }

        public string Tooltip { set; get; }
    }
}
