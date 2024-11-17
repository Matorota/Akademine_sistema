using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class Lecturers : Form
    {
        // Lecturer service to handle database operations
        private class LecturerService
        {
            private readonly string _connectionString;

            public LecturerService(string connectionString)
            {
                _connectionString = connectionString;
            }

            public bool AuthenticateLecturer(string name, string password)
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT * FROM TeacherDB WHERE TName = @name AND TPassword = @password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@password", password);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dTable = new DataTable();
                        sda.Fill(dTable);

                        return dTable.Rows.Count > 0;
                    }
                }
            }
        }

        private readonly LecturerService _lecturerService;

        public Lecturers()
        {
            InitializeComponent();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matas\Desktop\Akademine_sistema\AkademineDB.mdf;Integrated Security=True;Connect Timeout=30";
            _lecturerService = new LecturerService(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text; // Name textbox
            string userPassword = textBox2.Text; // Password textbox

            try
            {
                // Authenticate lecturer
                if (_lecturerService.AuthenticateLecturer(name, userPassword))
                {
                    // If login is successful, open the next form
                    LecTur madmin = new LecTur();
                    madmin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bad login details");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
