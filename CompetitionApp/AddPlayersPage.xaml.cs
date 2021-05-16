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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompetitionApp
{
    /// <summary>
    /// Logika interakcji dla klasy AddPlayers.xaml
    /// </summary>
    public partial class AddPlayers : Page
    {
        public AddPlayers()
        {
            InitializeComponent();
            var archer = new ArchersDBEntities();
            
            
            this.ComboBoxCategory.Items.Add("Senior");
            this.ComboBoxCategory.Items.Add("Junior");
            
        }

        private void BtnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            var archer = new ArchersDBEntities();
            Archer archerObj = new Archer() 
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                Club = ComboBoxClub.SelectedItem.ToString(),
                Category = ComboBoxCategory.SelectedItem.ToString()

        };
            archer.Archers.Add(archerObj); //adding new Archers to DB
            archer.SaveChanges();   //saving the changes
        }

        private void ComboBoxClub_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

           
        }
    }
}
