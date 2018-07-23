using System.Collections.Generic;
using System.Windows;
using WpfApplication1.Models;

namespace WpfApplication1
{
    public partial class App : Application
    {
        public static IList<RadialMenuConfig> Profiles { get; private set; } = InterOpsLibrary.ReadMenuConfig();
    }
}
