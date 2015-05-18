using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Federation.WindowsUniversal.Controls {
    public partial class lcarButton : UserControl {
        public lcarButton() {
            InitializeComponent();
        }

        protected string TextContent {
            get { return tbContent.Text; }
            set { tbContent.Text = value; }
        }

        private void BtnMain_OnClick(object sender, RoutedEventArgs e) { meBeep.Play(); }

        public void Connect(int connectionId, object target)
        {
            
        }
    }
}
