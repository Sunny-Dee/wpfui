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
using System.Windows.Shapes;

namespace Dart
{
    /// <summary>
    /// Interaction logic for LoadRunSettingsPage.xaml
    /// </summary>
    public partial class LoadRunSettingsPage : Page
    {
        private const string defaultSubtitle = "Choose a source from where to get the run settings";

        public LoadRunSettingsPage()
        {
            InitializeComponent();
            loadRunSettingsPageSubtitle.Content = defaultSubtitle;
        }

        private void LoadFromBuild(object sender, RoutedEventArgs e)
        {

        }

        private async void LoadFromFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Run settings files (*.runsettings)|*.runsettings|All files (*.*)|*.*"
            };
            if (dialog.ShowDialog() == true)
            {
                var filename = dialog.FileName;
                showWorkingOnItScreen();

                await pretendToDoWork();

                var runTestsPage = new RunTestsPage();
                NavigationService.Navigate(runTestsPage);
            }
        }

        private void LoadFromArtifact(object sender, RoutedEventArgs e)
        {

        }

        private RunSettings ProcessRunSettingFromFile(string filename)
        {
            var runsettings = new RunSettings()
            {
                Filename = filename
            };

            return runsettings;
        }

        private void showWorkingOnItScreen()
        {
            chooseSourcePanel.Visibility = Visibility.Collapsed;
            workingOnIt.Visibility = Visibility.Visible;

            var bc = new BrushConverter();
            loadRunSettingsStackPanel.Background = (Brush)bc.ConvertFrom("#fccb99");

            loadRunSettingsPageSubtitle.Content = "working on it";
        }

        private void resetPageStyle()
        {
            chooseSourcePanel.Visibility = Visibility.Visible;
            workingOnIt.Visibility = Visibility.Hidden;

            //var bc = new BrushConverter();
            //loadRunSettingsStackPanel.Background = (Brush)bc.ConvertFrom("#fccb99");

            loadRunSettingsPageSubtitle.Content = defaultSubtitle;
        }

        private async Task pretendToDoWork()
        {
            await Task.Delay(10000);
        }
    }
}


