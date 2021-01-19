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
            //TODO add to db names of the clubs
            this.ComboBoxClub.Items.Add("LKS Zamek Suski");
            this.ComboBoxClub.Items.Add("Plas");            
            this.ComboBoxCategory.Items.Add("Senior");
            this.ComboBoxCategory.Items.Add("Junior");
            
        }

        private void BtnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=PAWEŁ-KOMPUTER\SQLEXPRESS; Initial Catalog=ArrowBase; Integrated Security=True"); //connection data
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                var query = "INSERT INTO ArcherTable VALUES(11,@Name,@Surname,@Club, 'dd')";   //sql command
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@Name", TxtName.Text);
                sqlCommand.Parameters.AddWithValue("@Surname", TxtSurname.Text);
                sqlCommand.Parameters.AddWithValue("@Club", ComboBoxClub.SelectedItem);
                              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();  //closing database connection
            }
        }

        private void ComboBoxClub_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
        }
    }
}
