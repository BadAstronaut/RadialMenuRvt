using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Media;
using System.Windows;
using WpfApplication1.Models;
using WpfApplication1.ViewModels;
using WinForms = System.Windows.Forms;

namespace WpfApplication1
{
    public partial class MainWindow : Window
    {
        readonly ObservableCollection<MainViewModel> ViewModelCollection;
        readonly MainViewModel ViewModel;

        public MainWindow()
        {
            InitializeComponent();

            ViewModelCollection = new ObservableCollection<MainViewModel>
            {
                new MainViewModel()
            };
            ViewModel = ViewModelCollection.ElementAt(0);

            var profile = App.Profiles.FirstOrDefault() ?? new RadialMenuConfig();

            ViewModel.CurrentButtonOne = profile.Buttons[0];
            ViewModel.CurrentButtonTwo = profile.Buttons[1];
            ViewModel.CurrentButtonThree = profile.Buttons[2];
            ViewModel.CurrentButtonFour = profile.Buttons[3];
            ViewModel.CurrentButtonFive = profile.Buttons[4];

            DataContext = ViewModel;
        }
        private void PlayOpeningSound()
        {
            var soundUrl = new Uri(@"pack://application:,,,/RadialApplication;component/icons/opensound.wav");
            var sri = Application.GetResourceStream(soundUrl);
            var startSoundPlayer = new SoundPlayer(sri.Stream);
            startSoundPlayer.Play();

        }

        private void RadialMenuCentralItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public static Point GetMousePositionWindowsForms()
        {
            var point = WinForms.Control.MousePosition;
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
