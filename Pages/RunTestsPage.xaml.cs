using Dart.Pages;
using System;
using System.Collections.Generic;
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

namespace Dart
{
    /// <summary>
    /// Interaction logic for RunTestsPage.xaml
    /// </summary>
    public partial class RunTestsPage : Page
    {
        public RunTestsPage()
        {
            InitializeComponent();
        }

        private async void RunTestsButtonClick(object sender, RoutedEventArgs e)
        {
            showRunningTestsScreen();
            await pretendToDoWork(3);
            NavigationService.Navigate(new TestRunResultPage());
        }

        private void EditsRunSettingsButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void showRunningTestsScreen()
        {
            runTestsButtons.Visibility = Visibility.Collapsed;
            runningTests.Visibility = Visibility.Visible;

            var bc = new BrushConverter();
            runSettingsPanel.Background = (Brush)bc.ConvertFrom("#b0d2e7");

            runTestsSubtitle.Content = "running your tests...";
        }

        private async Task pretendToDoWork(int seconds)
        {
            await Task.Delay(seconds * 1000);
        }
    }
}
