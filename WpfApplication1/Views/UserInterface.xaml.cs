using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApplication1.Models;
using WpfApplication1.ViewModels;

namespace WpfApplication1.Views
{
    /// <summary>
    /// Interaction logic for UserInterface.xaml
    /// </summary>
    public partial class UserInterface : Window
    {
        MainViewModel _main = new MainViewModel();

        public UserInterface()
        {
            InitializeComponent();
            DataContext = _main;
            if (ProfileBox.SelectedIndex==0)
            {
                _main.RadialMenuProfile1();
            }
        }

        private void SearchIcon_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
               
            }

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            _main.CallButton1();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            _main.CallButton2();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //InterOpsLibrary.SendProfile();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            _main.CallButton3();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            _main.CallButton4();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            _main.CallButton5();
        }

    }

}
