using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class Student_view : Form
    {
        private readonly IDatabaseEntity _teacherDAO;

        public Student_view()
        {
            InitializeComponent();
            _teacherDAO = new TeacherDAO();
        }

        private void PopulateGroups()
        {
            GrupesGV.DataSource = _teacherDAO.GetAll();
        }

        private void FillStudents()
        {
            var dt = _teacherDAO.GetDistinct("StudentTC");
            SelectStudent.ValueMember = "StudentTC";
            SelectStudent.DataSource = dt;
        }

        private void FilterByStudent()
        {
            GrupesGV.DataSource = _teacherDAO.Filter("StudentTC", SelectStudent.SelectedValue?.ToString() ?? string.Empty);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FilterByStudent();
        }

        private void Student_view_Load(object sender, EventArgs e)
        {
            PopulateGroups();
            FillStudents();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PopulateGroups();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentMain madmin = new StudentMain();
            madmin.Show();
            Visible = false;
        }

        // Abstract Base Class or Interface for Database Operations
        public interface IDatabaseEntity
        {
            DataTable GetAll();
            DataTable Filter(string columnName, string value);
            DataTable GetDistinct(string columnName);
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

        // Teacher Data Access Object
        private class TeacherDAO : IDatabaseEntity
        {
            private readonly DatabaseConnection _db;

            public TeacherDAO()
            {
                _db = new DatabaseConnection();
            }

            public DataTable GetAll()
            {
                using (var con = _db.GetConnection())
                {
                    var query = "SELECT * FROM TeacherMG";
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
                    var query = $"SELECT * FROM TeacherMG WHERE {columnName} = @Value";
                    var da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@Value", value);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

            public DataTable GetDistinct(string columnName)
            {
                using (var con = _db.GetConnection())
                {
                    var query = $"SELECT DISTINCT {columnName} FROM TeacherMG";
                    var da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
