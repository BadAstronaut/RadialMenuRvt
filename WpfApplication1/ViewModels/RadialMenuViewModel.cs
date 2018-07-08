using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.ViewModels
{
    public  class RadialMenuViewModel: ObservableObject

    {
        private ButtonViewModel _b1;

        public ButtonViewModel B1
        {
            get { return _b1; }
            set
            {
                _b1 = value;
                OnPropertyChanged("B1");
            }
        }

        private ButtonViewModel _b2;

        public ButtonViewModel B2
        {
            get
            {
                return _b2;

            }
            set
            {
                _b2 = value;
                OnPropertyChanged("B2");
            }
        }

        private ButtonViewModel _b3;

        public ButtonViewModel B3
        {
            get
            {
                return _b3;

            }
            set
            {
                _b3 = value;
                OnPropertyChanged("B3");
            }
        }

        private ButtonViewModel _b4;

        public ButtonViewModel B4
        {
            get
            {
                return _b4;

            }
            set
            {
                _b4 = value;
                OnPropertyChanged("B4");
            }
        }

        private ButtonViewModel _b5;

        public ButtonViewModel B5
        {
            get
            {
                return _b5;

            }
            set
            {
                _b5 = value;
                OnPropertyChanged("B5");
            }
        }
    }
}
