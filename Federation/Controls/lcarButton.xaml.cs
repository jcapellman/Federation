using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Federation.Controls {
    public partial class lcarButton : UserControl {
        public lcarButton() {
            InitializeComponent();
        }

        public string TextContent {
            get { return tbContent.Text; }
            set { tbContent.Text = value; }
        }

        private void BtnMain_OnClick(object sender, RoutedEventArgs e) { meBeep.Play(); }
    }
}
