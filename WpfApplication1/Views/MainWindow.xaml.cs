using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RadialMenu;
using System.Windows.Resources;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            #region "Sound"
            #endregion
            var point = GetMousePositionWindowsForms();
            this.Left = point.X - 175;
            this.Top = point.Y - 175;
            InitializeComponent();

        }
        private void PlayOpeningSound()
        {
            Uri soundUrl = new Uri(@"pack://application:,,,/RadialApplication;component/icons/opensound.wav");
            StreamResourceInfo sri = Application.GetResourceStream(soundUrl);
            System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(sri.Stream);
            startSoundPlayer.Play();

        }

        private void RadialMenuCentralItem_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
        public static Point GetMousePositionWindowsForms()
        {
            var point = System.Windows.Forms.Control.MousePosition;
            return new Point(point.X, point.Y);
        }
        public void Dispose()
        {
            this.Close();
        }
        #region "Base Commands"
        #endregion
    }
}
