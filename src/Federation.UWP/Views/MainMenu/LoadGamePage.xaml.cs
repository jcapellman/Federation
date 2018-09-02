﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Federation.UWP.Views.MainMenu
{
    public sealed partial class LoadGamePage : Page
    {
        public LoadGamePage()
        {
            this.InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}