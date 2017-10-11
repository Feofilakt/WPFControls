﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Digimezzo.WPFControls.Tests.Tests
{
    public partial class SlidingContentControlTest : Window
    {
        public SlidingContentControlTest()
        {
            InitializeComponent();
        }

        private void Content1Button_Click(object sender, RoutedEventArgs e)
        {
            var border = new Border();
            border.Background = Brushes.Red;

            ContentControl.SlideDirection = Enums.SlideDirection.LeftToRight;
            ContentControl.Content = border;
        }

        private void Content2Button_Click(object sender, RoutedEventArgs e)
        {
            var border = new Border();
            border.Background = Brushes.Green;

            ContentControl.SlideDirection = Enums.SlideDirection.RightToLeft;
            ContentControl.EasingAmplitude = 0;
            ContentControl.Content = border;
        }

        private void Content3Button_Click(object sender, RoutedEventArgs e)
        {
            var border = new Border();
            border.Background = Brushes.Blue;

            ContentControl.SlideDirection = Enums.SlideDirection.LeftToRight;
            ContentControl.EasingAmplitude = 0;
            ContentControl.Duration = 1.0;
            ContentControl.SlideFadeIn = true;
            ContentControl.SlideFadeInDuration = 1;
            ContentControl.Content = border;
        }
    }
}
