using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class Student_Group_Management : Form
    {
        // Student Group Model
        private class StudentGroup
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        // Student Group Service
        private class StudentGroupService
        {
            private readonly string _connectionString;

            public StudentGroupService(string connectionString)
            {
                _connectionString = connectionString;
            }

            public DataTable GetAllGroups()
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT * FROM StudentuGrupiuDB";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

            public void AddGroup(StudentGroup group)
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO StudentuGrupiuDB (Id, StudentuGrupesName) VALUES (@Id, @Name)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", group.Id);
                        cmd.Parameters.AddWithValue("@Name", group.Name);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void UpdateGroup(StudentGroup group)
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE StudentuGrupiuDB SET StudentuGrupesName = @Name WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", group.Id);
                        cmd.Parameters.AddWithValue("@Name", group.Name);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void DeleteGroup(int groupId)
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM StudentuGrupiuDB WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", groupId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Student Group Management Form
        private readonly StudentGroupService _studentGroupService;

        public Student_Group_Management()
        {
            InitializeComponent();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matas\Desktop\Akademine_sistema\AkademineDB.mdf;Integrated Security=True;Connect Timeout=30";
            _studentGroupService = new StudentGroupService(connectionString);
        }

        private void PopulateGrid()
        {
            GrupesGV.DataSource = _studentGroupService.GetAllGroups();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var group = new StudentGroup
                {
                    Id = int.Parse(GrupesID.Text),
                    Name = GrupesName.Text
                };

                _studentGroupService.AddGroup(group);
                MessageBox.Show("Group successfully added!");
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
                var group = new StudentGroup
                {
                    Id = int.Parse(GrupesID.Text),
                    Name = GrupesName.Text
                };

                _studentGroupService.UpdateGroup(group);
                MessageBox.Show("Group successfully updated!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GrupesID.Text))
            {
                MessageBox.Show("Please enter the Group ID.");
                return;
            }

            try
            {
                int groupId = int.Parse(GrupesID.Text);
                _studentGroupService.DeleteGroup(groupId);
                MessageBox.Show("Group successfully deleted!");
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

        private void Student_Group_Management_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
