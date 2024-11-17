using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class Lessons : Form
    {
        // Lesson model representing the entity
        private class LessonModel
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        // Service to handle lesson-related database operations
        private class LessonService
        {
            private readonly string _connectionString;

            public LessonService(string connectionString)
            {
                _connectionString = connectionString;
            }

            public DataTable GetAllLessons()
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT * FROM LessonDB";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

            public void AddLesson(LessonModel lesson)
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO LessonDB VALUES(@Id, @Name)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", lesson.Id);
                        cmd.Parameters.AddWithValue("@Name", lesson.Name);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void UpdateLesson(LessonModel lesson)
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE LessonDB SET Lessons = @Name WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", lesson.Id);
                        cmd.Parameters.AddWithValue("@Name", lesson.Name);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void DeleteLesson(string lessonId)
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM LessonDB WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", lessonId);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private readonly LessonService _lessonService;

        public Lessons()
        {
            InitializeComponent();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matas\Desktop\Akademine_sistema\AkademineDB.mdf;Integrated Security=True;Connect Timeout=30";
            _lessonService = new LessonService(connectionString);
        }

        private void Lessons_Load(object sender, EventArgs e)
        {
            PopulateLessons();
        }

        private void PopulateLessons()
        {
            try
            {
                GrupesGV.DataSource = _lessonService.GetAllLessons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading lessons: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var lesson = new LessonModel
                {
                    Id = LessonID.Text,
                    Name = LessonName.Text
                };
                _lessonService.AddLesson(lesson);
                MessageBox.Show("Lesson successfully added.");
                PopulateLessons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding lesson: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var lesson = new LessonModel
                {
                    Id = LessonID.Text,
                    Name = LessonName.Text
                };
                _lessonService.UpdateLesson(lesson);
                MessageBox.Show("Lesson successfully updated.");
                PopulateLessons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating lesson: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LessonID.Text))
            {
                MessageBox.Show("Enter the lesson ID.");
                return;
            }

            try
            {
                _lessonService.DeleteLesson(LessonID.Text);
                MessageBox.Show("Lesson successfully deleted.");
                PopulateLessons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while deleting lesson: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainAdmin mainAdmin = new MainAdmin();
            mainAdmin.Show();
            this.Hide();
        }
    }
}
