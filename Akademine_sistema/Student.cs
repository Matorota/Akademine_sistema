using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class Student : Form
    {
        // Model for Student
        private class StudentModel
        {
            public string Name { get; set; }
            public string Password { get; set; }
        }

        // Service for Student-related operations
        private class StudentService
        {
            private readonly string _connectionString;

            public StudentService(string connectionString)
            {
                _connectionString = connectionString;
            }

            public bool Authenticate(StudentModel student)
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT * FROM StudentDB WHERE Name = @name AND Password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", student.Name);
                        cmd.Parameters.AddWithValue("@password", student.Password);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dTable = new DataTable();
                        sda.Fill(dTable);

                        return dTable.Rows.Count > 0; // Login is successful if rows are found
                    }
                }
            }
        }

        // Main Form for Student
        private readonly StudentService _studentService;

        public Student()
        {
            InitializeComponent();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matas\Desktop\Akademine_sistema\AkademineDB.mdf;Integrated Security=True;Connect Timeout=30";
            _studentService = new StudentService(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text; // Name textbox
            string password = textBox2.Text; // Password textbox

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            var student = new StudentModel
            {
                Name = name,
                Password = password
            };

            try
            {
                if (_studentService.Authenticate(student))
                {
                    // Open the next form on successful login
                    StudentMain studentMain = new StudentMain();
                    studentMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details. Please try again.");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
