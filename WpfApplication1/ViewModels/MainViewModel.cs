using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using WpfApplication1.Models;

namespace WpfApplication1.ViewModels
{
    public class MainViewModel
    {
        public RadialMenuViewModel RadialMenuP1 { get; private set; }
        public ButtonViewModel Button { get; private  set; }
        public ButtonViewModel Button1 { get; private set; }
        public ButtonViewModel Button2 { get; private set; }
        public ButtonViewModel Button3 { get; private set; }
        public ButtonViewModel Button4 { get; private set; }
        public ButtonViewModel Button5 { get; private set; }

        public MainViewModel()
        {
            Button = new ButtonViewModel();
        }
        public void CallButton1()
        {
            Button.Name = Button1.Name;
            Button.Shortcut = Button1.Shortcut;
            Button.Tooltip = Button1.Tooltip;
        }
        public void CallButton2()
        {
            Button.Name = Button2.Name;
            Button.Shortcut = Button2.Shortcut;
            Button.Tooltip = Button2.Tooltip;
        }

        public void CallButton3()
        {
            Button.Name = Button3.Name;
            Button.Shortcut = Button3.Shortcut;
            Button.Tooltip = Button3.Tooltip;
        }

        public void CallButton4()
        {
            Button.Name = Button4.Name;
            Button.Shortcut = Button4.Shortcut;
            Button.Tooltip = Button4.Tooltip;
        }

        public void CallButton5()
        {
            Button.Name = Button5.Name;
            Button.Shortcut = Button5.Shortcut;
            Button.Tooltip = Button5.Tooltip;
        }

        public void RadialMenuProfile1()
        {
            RadialMenuP1 = InterOpsLibrary.getProfile1();
            Button1 = RadialMenuP1.B1;
            Button2 = RadialMenuP1.B2;
            Button3 = RadialMenuP1.B3;
            Button4 = RadialMenuP1.B4;
            Button5 = RadialMenuP1.B5;


        }

    }

}
