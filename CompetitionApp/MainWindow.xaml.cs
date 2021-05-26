using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompetitionApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            buttonOpenMenu.Visibility = Visibility.Collapsed;
            buttonCloseMenu.Visibility = Visibility.Visible;
        }

        private void buttonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            buttonOpenMenu.Visibility = Visibility.Visible;
            buttonCloseMenu.Visibility = Visibility.Collapsed;
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAddPlayer(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new AddPlayers();
        }

        private void BtnMyPlayers(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new MyPlayersPage();
        }

        private void BtnScoreBoard(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new ScoreBoardPage();
        }

        private void BtnNotifications(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new NotificationsPage();
        }

        private void BtnReportPlayer(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new ReportPlayerPage();
        }
    }
}
