﻿using System;
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
using System.Windows.Shapes;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for TrinneWindow.xaml
    /// </summary>
    public partial class TrinneWindow : Window
    {
        public TrinneWindow()
        {
            InitializeComponent();
            brithDateDatePicker.DisplayDateEnd = DateTime.Now.AddYears(BE.Configuration.Trainee_MIN_AGE* -1);
            
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource traineeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("traineeViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // traineeViewSource.Source = [generic data source]
        }

        private void idTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = !((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
               || (e.Key >= Key.D0 && e.Key <= Key.D9));
        }

        private void phoneNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = !((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
               || (e.Key >= Key.D0 && e.Key <= Key.D9));
        }

        private void numberOfLessonsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = !((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
               || (e.Key >= Key.D0 && e.Key <= Key.D9));
        }
    }
}
