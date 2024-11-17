using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class Admin : Form
    {
        // Database connection and authentication service
        private class AuthenticationService
        {
            private readonly SqlConnection _connection;

            public AuthenticationService(string connectionString)
            {
                _connection = new SqlConnection(connectionString);
            }

            public bool AuthenticateAdmin(string name, string password)
            {
                try
                {
                    string query = "SELECT * FROM AdminDB WHERE Name = @name AND Password = @password";
                    SqlDataAdapter sda = new SqlDataAdapter(query, _connection);
                    sda.SelectCommand.Parameters.AddWithValue("@name", name);
                    sda.SelectCommand.Parameters.AddWithValue("@password", password);

                    DataTable dTable = new DataTable();
                    sda.Fill(dTable);

                    return dTable.Rows.Count > 0;
                }
                catch
                {
                    MessageBox.Show("Error while authenticating.");
                    return false;
                }
            }
        }

        // Navigation service to handle form transitions
        private class NavigationService
        {
            public void NavigateToForm(Form currentForm, Form targetForm)
            {
                targetForm.Show();
                currentForm.Hide();
            }
        }

        private readonly AuthenticationService _authenticationService;
        private readonly NavigationService _navigationService;

        public Admin()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matas\Desktop\Akademine_sistema\AkademineDB.mdf;Integrated Security=True;Connect Timeout=30");
            _navigationService = new NavigationService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string userPassword = textBox2.Text;

            if (_authenticationService.AuthenticateAdmin(name, userPassword))
            {
                MainAdmin mainAdmin = new MainAdmin();
                _navigationService.NavigateToForm(this, mainAdmin);
            }
            else
            {
                MessageBox.Show("Bad login details");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
        private void Admin_Load(object sender, EventArgs e)
        {
        }
        }
}
