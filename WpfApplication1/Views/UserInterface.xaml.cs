using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApplication1.Models;
using WpfApplication1.ViewModels;

namespace WpfApplication1.Views
{
    public partial class UserInterface : Window
    {
        readonly ObservableCollection<UserInterfaceViewModel> ViewModelCollection;
        readonly UserInterfaceViewModel ViewModel;

        public UserInterface()
        {
            InitializeComponent();

            ViewModelCollection = new ObservableCollection<UserInterfaceViewModel>
            {
                new UserInterfaceViewModel()
            };
            ViewModel = ViewModelCollection.ElementAt(0);

            var profileIndex = 0;
            ProfileBox.ItemsSource = App.Profiles.Select(s => new KeyValuePair<string, string>(s.ProfileId, "Profile " + (++profileIndex).ToString()));

            ViewModel.SelectedProfileId = App.Profiles.ElementAt(0).ProfileId;

            DataContext = ViewModel;
        }

        private void SearchIcon_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            var fileDialog = new OpenFileDialog
            {
                // Set filter for file extension and default file extension 
                DefaultExt = ".png",
                Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
            };


            // Display OpenFileDialog by calling ShowDialog method 
            var result = fileDialog.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                var filename = fileDialog.FileName;
                ViewModel.CurrentEditingButton.IconPath = Path.GetFileName(fileDialog.FileName);

                var iconSavePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Icons");

                if (!Directory.Exists(iconSavePath))
                    Directory.CreateDirectory(iconSavePath);

                if (!File.Exists(Path.Combine(iconSavePath, Path.GetFileName(fileDialog.FileName))))
                    File.Copy(fileDialog.FileName, Path.Combine(iconSavePath, Path.GetFileName(fileDialog.FileName)));
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.CurrentEditingButton = ViewModel.CurrentButtonOne;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.CurrentEditingButton = ViewModel.CurrentButtonTwo;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.CurrentEditingButton = ViewModel.CurrentButtonThree;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.CurrentEditingButton = ViewModel.CurrentButtonFour;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.CurrentEditingButton = ViewModel.CurrentButtonFive;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            InterOpsLibrary.SaveConfig(App.Profiles);
        }

        private void ProfileBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var profileId = ((KeyValuePair<string, string>)e.AddedItems[0]).Key;

            var profile = App.Profiles.FirstOrDefault(w => w.ProfileId == profileId);

            ViewModel.CurrentButtonOne = profile.Buttons[0];
            ViewModel.CurrentButtonTwo = profile.Buttons[1];
            ViewModel.CurrentButtonThree = profile.Buttons[2];
            ViewModel.CurrentButtonFour = profile.Buttons[3];
            ViewModel.CurrentButtonFive = profile.Buttons[4];

            ViewModel.CurrentEditingButton = ViewModel.CurrentButtonOne;
        }
    }
}
