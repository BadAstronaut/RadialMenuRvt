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

    class Menu
    {
        public List<Button> RadialMenu { get; set; }

        public List<Button> _radialMenu()
        {
            var init =new  List<Button>();
            var counter = 0;
            while (counter<5)
            {
                var _button = new Button();
                _button.Name = "Copy";
                _button.KeyboardShortcut = "CO";
                _button.Tooltip = "Copiar Elementos";
                RadialMenu.Add(_button);
                counter += 1;

            }

            return init;

        }
    }
}
