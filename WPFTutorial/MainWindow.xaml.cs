using Microsoft.Win32;
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntries.Text);
            txtEntries.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            //int index = lvEntries.SelectedIndex; //first selected
            object item = lvEntries.SelectedItem;
            var result = System.Windows.MessageBox.Show($"Are you sure you want to delete : {(string)item}", "Sure", MessageBoxButtons.YesNo);
           if(result==MessageBoxResult.Yes)
                lvEntries.Items.Remove(item);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}