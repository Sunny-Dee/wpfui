using Dart.Classes;
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
    /// Interaction logic for LoadingRunSettingsPage.xaml
    /// </summary>
    public partial class ProcessRunSettingsPage : Page
    {
        public ProcessRunSettingsPage(RunSettings runSettings)
        {
            InitializeComponent();

            var success = ProcessRunSettings(runSettings);
  // if success make gif invisible. 
            //if (success)
            //{
            //    var runTestsPage = new RunTestsPage();
            //    NavigationService.Navigate(runTestsPage);
            //}
            //else
            //{
            //    // Go back -- display error message. 
            //    //var loadPage = new LoadRunSettingsPage();
            //    //NavigationService.Navigate(loadPage);
            //    NavigationService.GoBack();
            //}
        }


        private bool ProcessRunSettings(RunSettings runSettings)
        {
            Task.Delay(10000).ContinueWith(_ =>
            {
                var runTestsPage = new RunTestsPage();
                NavigationService.Navigate(runTestsPage);
            }
            );
            return true;
        }
    }
}
