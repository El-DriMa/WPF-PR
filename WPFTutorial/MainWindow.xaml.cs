﻿using Microsoft.Win32;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.DataContracts;
using System.Windows;
using WinForms=System.Windows.Forms;

namespace WPFTutorial
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            //radi i bez ovog
            WinForms.FolderBrowserDialog dialog1 = new FolderBrowserDialog();
            dialog1.InitialDirectory = "C:\\Users\\HOME\\Documents\\WPF Projects\\WPFTutorial\\WPFTutorial";
            WinForms.DialogResult result= dialog1.ShowDialog();
            if(result==WinForms.DialogResult.OK)
            {
                string folder = dialog1.SelectedPath;
            }
        }
    }
}