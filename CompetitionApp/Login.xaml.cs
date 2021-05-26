
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace CompetitionApp
{
    /// <summary>
    /// Logika interakcji dla klasy Login.xaml
    /// </summary>
    public partial class Login : Window
    {
       

        public Login()
        {
            InitializeComponent();
            
        } 

        private void logButton_Click(object sender, RoutedEventArgs e)
        {
            RefereeDB referee = new RefereeDB();
            if (referee.Login.Equals(loginBox.Text) && referee.Login.Equals(passwordBox.Password.ToString()))
            {
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();

            }
                


        }
        public int IdSuccesfullyLogged()
        {
            return 1;
        }
    }
}
