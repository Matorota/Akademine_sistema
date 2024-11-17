using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class Student_Management : Form
    {
        private readonly IDatabaseEntity _studentDAO;
        private readonly IDatabaseEntity _lessonDAO;
        private readonly IDatabaseEntity _groupDAO;

        public Student_Management()
        {
            InitializeComponent();
            _studentDAO = new StudentDAO();
            _lessonDAO = new LessonDAO();
            _groupDAO = new GroupDAO();
        }

        private void PopulateStudents()
        {
            StudentGV.DataSource = _studentDAO.GetAll();
        }

        private void FillStudentGroups()
        {
            var dt = _groupDAO.GetAll();
            StudentGroupCB.ValueMember = "StudentuGrupesName";
            StudentGroupCB.DataSource = dt;

            SelectGroupSearch.ValueMember = "StudentuGrupesName";
            SelectGroupSearch.DataSource = dt;
        }

        private void FillLessons()
        {
            var dt = _lessonDAO.GetAll();
            LessonsCB.ValueMember = "Lessons";
            LessonsCB.DataSource = dt;

            SelectLesson.ValueMember = "Lessons";
            SelectLesson.DataSource = dt;
        }

        private void FilterByGroup()
        {
            StudentGV.DataSource = _studentDAO.Filter("SClass", SelectGroupSearch.SelectedValue?.ToString() ?? string.Empty);
        }

        private void FilterByLesson()
        {
            StudentGV.DataSource = _studentDAO.Filter("SLessons", SelectLesson.SelectedValue?.ToString() ?? string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _studentDAO.Add(new
                {
                    Id = StudentID.Text,
                    Name = StudentName.Text,
                    Surname = StudentSurname.Text,
                    Password = StudentPassword.Text,
                    Phone = StudentPhone.Text,
                    Group = StudentGroupCB.SelectedValue.ToString(),
                    Lesson = LessonsCB.SelectedValue.ToString()
                });
                MessageBox.Show("Student successfully added");
                PopulateStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _studentDAO.Update(new
                {
                    Id = StudentID.Text,
                    Name = StudentName.Text,
                    Surname = StudentSurname.Text,
                    Password = StudentPassword.Text,
                    Phone = StudentPhone.Text,
                    Group = StudentGroupCB.SelectedValue.ToString(),
                    Lesson = LessonsCB.SelectedValue.ToString()
                });
                MessageBox.Show("Student successfully updated");
                PopulateStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StudentID.Text))
            {
                MessageBox.Show("Enter the Student ID");
                return;
            }

            try
            {
                _studentDAO.Delete(StudentID.Text);
                MessageBox.Show("Student successfully deleted");
                PopulateStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainAdmin madmin = new MainAdmin();
            madmin.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FilterByGroup();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PopulateStudents();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PopulateStudents();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FilterByLesson();
        }

        private void Student_Management_Load(object sender, EventArgs e)
        {
            FillStudentGroups();
            FillLessons();
            PopulateStudents();
        }

        // Abstract Base Class or Interface for Database Operations
        public interface IDatabaseEntity
        {
            DataTable GetAll();
            DataTable Filter(string columnName, string value);
            void Add(object entity);
            void Update(object entity);
            void Delete(string id);
        }

        private class DatabaseConnection
        {
            private readonly string _connectionString;

            public DatabaseConnection()
            {
                _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matas\Desktop\Akademine_sistema\AkademineDB.mdf;Integrated Security=True;Connect Timeout=30";
            }

            public SqlConnection GetConnection()
            {
                return new SqlConnection(_connectionString);
            }
        }

        // Student Data Access Object
        private class StudentDAO : IDatabaseEntity
        {
            private readonly DatabaseConnection _db;

            public StudentDAO()
            {
                _db = new DatabaseConnection();
            }

            public DataTable GetAll()
            {
                using (var con = _db.GetConnection())
                {
                    var query = "SELECT * FROM StudentDB";
                    var da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

            public DataTable Filter(string columnName, string value)
            {
                using (var con = _db.GetConnection())
                {
                    var query = $"SELECT * FROM StudentDB WHERE {columnName} = @Value";
                    var da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@Value", value);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

            public void Add(object entity)
            {
                dynamic student = entity;
                using (var con = _db.GetConnection())
                {
                    con.Open();
                    var query = "INSERT INTO StudentDB VALUES (@Id, @Name, @Surname, @Password, @Phone, @Group, @Lesson)";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", student.Id);
                        cmd.Parameters.AddWithValue("@Name", student.Name);
                        cmd.Parameters.AddWithValue("@Surname", student.Surname);
                        cmd.Parameters.AddWithValue("@Password", student.Password);
                        cmd.Parameters.AddWithValue("@Phone", student.Phone);
                        cmd.Parameters.AddWithValue("@Group", student.Group);
                        cmd.Parameters.AddWithValue("@Lesson", student.Lesson);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void Update(object entity)
            {
                dynamic student = entity;
                using (var con = _db.GetConnection())
                {
                    con.Open();
                    var query = "UPDATE StudentDB SET Name=@Name, Surname=@Surname, Password=@Password, Phone=@Phone, SClass=@Group, SLessons=@Lesson WHERE Id=@Id";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", student.Id);
                        cmd.Parameters.AddWithValue("@Name", student.Name);
                        cmd.Parameters.AddWithValue("@Surname", student.Surname);
                        cmd.Parameters.AddWithValue("@Password", student.Password);
                        cmd.Parameters.AddWithValue("@Phone", student.Phone);
                        cmd.Parameters.AddWithValue("@Group", student.Group);
                        cmd.Parameters.AddWithValue("@Lesson", student.Lesson);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void Delete(string id)
            {
                using (var con = _db.GetConnection())
                {
                    con.Open();
                    var query = "DELETE FROM StudentDB WHERE Id=@Id";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Lesson Data Access Object
        private class LessonDAO : IDatabaseEntity
        {
            private readonly DatabaseConnection _db;

            public LessonDAO()
            {
                _db = new DatabaseConnection();
            }

            public DataTable GetAll()
            {
                using (var con = _db.GetConnection())
                {
                    var query = "SELECT * FROM LessonDB";
                    var da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

            public DataTable Filter(string columnName, string value)
            {
                throw new NotImplementedException();
            }

            public void Add(object entity)
            {
                throw new NotImplementedException();
            }

            public void Update(object entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(string id)
            {
                throw new NotImplementedException();
            }
        }

        // Group Data Access Object
        private class GroupDAO : IDatabaseEntity
        {
            private readonly DatabaseConnection _db;

            public GroupDAO()
            {
                _db = new DatabaseConnection();
            }

            public DataTable GetAll()
            {
                using (var con = _db.GetConnection())
                {
                    var query = "SELECT * FROM StudentuGrupiuDB";
                    var da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

            public DataTable Filter(string columnName, string value)
            {
                throw new NotImplementedException();
            }

            public void Add(object entity)
            {
                throw new NotImplementedException();
            }

            public void Update(object entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(string id)
            {
                throw new NotImplementedException();
            }
        }
    }
}
