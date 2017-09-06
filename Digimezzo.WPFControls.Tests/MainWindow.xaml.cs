﻿using Digimezzo.WPFControls.Tests.Tests;
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

namespace Digimezzo.WPFControls.Tests
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BorderlessWindows8WindowTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new BorderlessWindows8WindowTest();
            win.Show();
        }

        private void BorderlessWindows10WindowTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new BorderlessWindows10WindowTest();
            win.Show();
        }

        private void LabelTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new LabelTest();
            win.Show();
        }

        private void Windows8SliderTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new Windows8SliderTest();
            win.Show();
        }

        private void Windows10SliderTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new Windows10SliderTest();
            win.Show();
        }

        private void UWPSliderTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new UWPSliderTest();
            win.Show();
        }

        private void MultiPanePanelTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new MultiPanePanelTest();
            win.Show();
        }

        private void MultiSelectListBoxTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new MultiSelectListBoxTest();
            win.Show();
        }

        private void ProgressRingTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new ProgressRingTest();
            win.Show();
        }

        private void SlidingContentControlTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new SlidingContentControlTest();
            win.Show();
        }

        private void ToggleSwitchTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new ToggleSwitchTest();
            win.Show();
        }

        private void VirtualizingWrapPanelTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new VirtualizingWrapPanelTest();
            win.Show();
        }

        private void PivotTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new PivotTest();
            win.Show();
        }

        private void RippleTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new RippleTest();
            win.Show();
        }

        private void SplitViewTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new SplitViewTest();
            win.Show();
        }

        private void MaterialControlsTestButton_Click(object sender, RoutedEventArgs e)
        {
            var win = new MaterialControlsTest();
            win.Show();
        }
    }
}
