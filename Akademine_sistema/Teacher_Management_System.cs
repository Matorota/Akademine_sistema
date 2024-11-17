using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class Teacher_Management_System : Form
    {
        // Teacher Model
        private class Teacher
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Password { get; set; }
            public string Phone { get; set; }
        }

        // Teacher Service
        private class TeacherService
        {
            private readonly string _connectionString;

            public TeacherService(string connectionString)
            {
                _connectionString = connectionString;
            }

            public DataTable GetAllTeachers()
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT * FROM TeacherDB";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

            public void AddTeacher(Teacher teacher)
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO TeacherDB (Id, Tname, TSurname, TPassword, TPhone) VALUES (@Id, @Name, @Surname, @Password, @Phone)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", teacher.Id);
                        cmd.Parameters.AddWithValue("@Name", teacher.Name);
                        cmd.Parameters.AddWithValue("@Surname", teacher.Surname);
                        cmd.Parameters.AddWithValue("@Password", teacher.Password);
                        cmd.Parameters.AddWithValue("@Phone", teacher.Phone);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void UpdateTeacher(Teacher teacher)
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE TeacherDB SET Tname = @Name, TSurname = @Surname, TPassword = @Password, TPhone = @Phone WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", teacher.Id);
                        cmd.Parameters.AddWithValue("@Name", teacher.Name);
                        cmd.Parameters.AddWithValue("@Surname", teacher.Surname);
                        cmd.Parameters.AddWithValue("@Password", teacher.Password);
                        cmd.Parameters.AddWithValue("@Phone", teacher.Phone);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void DeleteTeacher(int teacherId)
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM TeacherDB WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", teacherId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Teacher Management Form
        private readonly TeacherService _teacherService;

        public Teacher_Management_System()
        {
            InitializeComponent();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matas\Desktop\Akademine_sistema\AkademineDB.mdf;Integrated Security=True;Connect Timeout=30";
            _teacherService = new TeacherService(connectionString);
        }

        private void PopulateGrid()
        {
            TeacherGV.DataSource = _teacherService.GetAllTeachers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = new Teacher
                {
                    Id = int.Parse(TeacherId.Text),
                    Name = TeacherName.Text,
                    Surname = TeacherSurname.Text,
                    Password = TeacherPassword.Text,
                    Phone = TeacherPhone.Text
                };

                _teacherService.AddTeacher(teacher);
                MessageBox.Show("Teacher successfully added!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = new Teacher
                {
                    Id = int.Parse(TeacherId.Text),
                    Name = TeacherName.Text,
                    Surname = TeacherSurname.Text,
                    Password = TeacherPassword.Text,
                    Phone = TeacherPhone.Text
                };

                _teacherService.UpdateTeacher(teacher);
                MessageBox.Show("Teacher successfully updated!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TeacherId.Text))
            {
                MessageBox.Show("Please enter the Teacher ID.");
                return;
            }

            try
            {
                int teacherId = int.Parse(TeacherId.Text);
                _teacherService.DeleteTeacher(teacherId);
                MessageBox.Show("Teacher successfully deleted!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainAdmin madmin = new MainAdmin();
            madmin.Show();
            Visible = false;
        }

        private void Teacher_Management_System_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
