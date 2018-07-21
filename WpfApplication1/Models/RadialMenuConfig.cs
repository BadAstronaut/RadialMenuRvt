using System;
using System.Collections.Generic;

namespace WpfApplication1.Models
{
    public class RadialMenuConfig
    {
        public RadialMenuConfig()
        {
            this.Buttons = new List<RadialMenuButton>();
            this.ProfileId = Guid.NewGuid().ToString();
        }

        public string ProfileId { get; set; }

        public List<RadialMenuButton> Buttons { get; set; }
    }
}
