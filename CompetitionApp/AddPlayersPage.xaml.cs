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
        }

        private void BtnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=PAWEŁ-KOMPUTER\SQLEXPRESS; Initial Catalog=RegistredUsers; Integrated Security=True"); //connection data
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                var query = "SELECT COUNT(1) FROM tblClub WHERE Login=@Login AND Password=@Password";   //sql command
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@Login", TxtName.Text);
                sqlCommand.Parameters.AddWithValue("@Password", TxtSurname.Text);
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (count == 1)
                {

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login or Password is incorrect");
                }
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
    }
}
