using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Models
{
    class Button
    {
        public string Name { get; set; }
        public string KeyboardShortcut { get; set; }
        public string Tooltip { get; set; }
        public Image Icon { get; set; }

        public Button()
        {
            Name = "Copy";
            KeyboardShortcut = "CO";
            Tooltip = "Copiar Elementos";
        }
    }
}
