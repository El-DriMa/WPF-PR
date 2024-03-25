using Microsoft.Win32;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.DataContracts;
using System.Windows;

namespace WPFTutorial
{
  
    public partial class MainWindow : Window
    {
        //bool running = false;
        public MainWindow()
        {
           // DataContext = this;
            InitializeComponent();
           
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "C# Source Files | *.cs";//Sve sto zavrsava sa .cs
         // fd.InitialDirectory = "C:\\temp"; -ako folder ne postoji,otvori na zadnjem
            fd.Title = "Pweaseeeeee";
            fd.Multiselect = true;

            //?-3 states,null,true false,zato treba == true
            bool? success= fd.ShowDialog();
            if (success==true)
            {
                //[] kolekcija vise fajlova
                string path = fd.FileName;//citava putanja
                string fileName = fd.SafeFileName;//samo ime fajla
                tbInfo.Text = fileName;
            }
        }


        /* public event PropertyChangedEventHandler? PropertyChanged;


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
         }*/

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