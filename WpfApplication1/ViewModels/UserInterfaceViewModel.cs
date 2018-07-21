using PropertyChanged;
using System.Collections.Generic;
using WpfApplication1.Models;

namespace WpfApplication1.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class UserInterfaceViewModel
    {
        public string ProfileId { get; set; }

        public string SelectedProfileId { get; set; }

        public RadialMenuButton CurrentButtonOne { get; set; } = null;
        public RadialMenuButton CurrentButtonTwo { get; set; } = null;
        public RadialMenuButton CurrentButtonThree { get; set; } = null;
        public RadialMenuButton CurrentButtonFour { get; set; } = null;
        public RadialMenuButton CurrentButtonFive { get; set; } = null;

        public RadialMenuButton CurrentEditingButton { get; set; } = null;

        public IList<RadialMenuConfig> Profiles { get; set; } = null;
    }
}
