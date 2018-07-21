using PropertyChanged;

namespace WpfApplication1.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public  class RadialMenuViewModel
    {
        public ButtonViewModel B1 { set; get; }

        public ButtonViewModel B2 { set; get; }

        public ButtonViewModel B3 { set; get; }

        public ButtonViewModel B4 { set; get; }

        public ButtonViewModel B5 { set; get; }
    }
}
