using System.Windows;

namespace WPFTutorial
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbHello.Text = "Hello World";
            btnRun.Content = "Stop";
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}