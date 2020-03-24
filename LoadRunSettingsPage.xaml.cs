﻿using Dart.Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
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
        public LoadRunSettingsPage()
        {
            InitializeComponent();
        }

        private void LoadFromBuild(object sender, RoutedEventArgs e)
        {

        }

        private void LoadFromFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Run settings files (*.runsettings)|*.runsettings|All files (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                var filename = dialog.FileName;
                var runSettings = ProcessRunSettingFromFile(filename);
                var loadingPage = new ProcessRunSettingsPage(runSettings);
                NavigationService.Navigate(loadingPage);
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
    }
}
