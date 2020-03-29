using Dart.Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.IO;

namespace Dart
{
    /// <summary>
    /// Interaction logic for LoadRunSettingsPage.xaml
    /// </summary>
    public partial class LoadRunSettingsPage : Page
    {
        private const string defaultSubtitle = "Choose a source from where to get the run settings";
        private const string runsettingsExtension = ".runsettings";

        public LoadRunSettingsPage()
        {
            InitializeComponent();
            loadRunSettingsPageSubtitle.Content = defaultSubtitle;
        }

        public LoadRunSettingsPage(string subtitle)
        {
            InitializeComponent();
            loadRunSettingsPageSubtitle.Content = subtitle;
        }

        private void LoadFromBuildHandler(object sender, RoutedEventArgs e)
        {
            // TODO
            var runTestsPage = new RunTestsPage();
            NavigationService.Navigate(runTestsPage);
        }

        private async void LoadFromFileHandler(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Run settings files (*.runsettings)|*.runsettings|All files (*.*)|*.*"
            };
            if (dialog.ShowDialog() == true)
            {
                var filename = dialog.FileName;
                var success = await ProcessRunSettingFromFile(filename);
                if (success)
                {
                    var runTestsPage = new RunTestsPage();
                    NavigationService.Navigate(runTestsPage);
                    return;
                }
            } 
                
            //reset the page to try again          
            var newLoadSettingsPage = new LoadRunSettingsPage($"Load run settings failed. Try again.");
            NavigationService.Navigate(newLoadSettingsPage);            
        }

        private void LoadFromArtifactHandler(object sender, RoutedEventArgs e)
        {
            //TODO 
            var runTestsPage = new RunTestsPage();
            NavigationService.Navigate(runTestsPage);
        }

        private async Task<bool> ProcessRunSettingFromFile(string filename)
        {
            showWorkingOnItScreen();

            await pretendToDoWork(3);

            var ext = Path.GetExtension(filename);
            if (ext != runsettingsExtension)
            {
                return false;
            }

            return true;
        }

        private void showWorkingOnItScreen()
        {
            chooseSourcePanel.Visibility = Visibility.Collapsed;
            workingOnIt.Visibility = Visibility.Visible;

            var bc = new BrushConverter();
            loadRunSettingsStackPanel.Background = (Brush)bc.ConvertFrom("#fccb99");

            loadRunSettingsPageSubtitle.Content = "working on it";
        }

        private async Task pretendToDoWork(int seconds)
        {
            await Task.Delay(seconds * 1000);
        }
    }
}


