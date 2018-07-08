using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.ViewModels
{
    public class ButtonViewModel: ObservableObject
    {

        private string _name;

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    return "Copy";
                }

                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }

        }

        private string _shortcut;

        public string Shortcut
        {
            get
            {
                if (string.IsNullOrEmpty(_shortcut))
                    return "CO";
                return _shortcut;
            }
            set
            {
                _shortcut = value;
                OnPropertyChanged("Shortcut");
            }

        }

        private String _IconPath;

        public string IconPath
        {
            get
            {
                return _IconPath;
            }
            set
            {
                _IconPath = value;
                OnPropertyChanged("IconPath");
            }
        }

        private string _tooltip;

        public string Tooltip
        {
            get
            {
                if (string.IsNullOrEmpty(_tooltip))
                {
                    return "Copiar Elemento";
                }

                return _tooltip;
            }
            set
            {
                _tooltip = value;
                OnPropertyChanged("Tooltip");
            }
        }

    }
}
