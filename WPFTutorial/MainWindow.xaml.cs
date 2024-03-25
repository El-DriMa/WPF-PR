using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.DataContracts;
using System.Windows;

namespace WPFTutorial
{
  
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        //bool running = false;
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
           
        }

        
        public event PropertyChangedEventHandler? PropertyChanged;


        private string boundText;
        public string BoundText   
        {
            get { return boundText; }
            set { 
                boundText = value;
                OnPropertyChanged();
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "set from code";
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /*private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {
            if(running)
            {
                //Stop
                tbStatus.Text = "Stopped";
                btnToggleRun.Content = "Run";
            }
            else
            {
                //Run
                tbStatus.Text = "Running";
                btnToggleRun.Content = "Stop";
            }
            running = !running;
        }*/
    }
}