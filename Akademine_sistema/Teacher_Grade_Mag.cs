using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class Teacher_Grade_Mag : Form
    {
        public Teacher_Grade_Mag()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matas\Desktop\Akademine_sistema\AkademineDB.mdf;Integrated Security=True;Connect Timeout=30");


        void fillStudentGroup()
        {
            string query = "select * from StudentuGrupiuDB";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("StudentuGrupesName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                StudentGroupCB.ValueMember = "StudentuGrupesName";
                StudentGroupCB.DataSource = dt;

                Con.Close();
            }
            catch
            {
            }

        }
        void filterByLesson()
        {
            try
            {
                Con.Open();
                string Myquerry = "SELECT * FROM TeacherMG WHERE LessonTC = @LessonTC";
                SqlDataAdapter da = new SqlDataAdapter(Myquerry, Con);

                // Use parameters to prevent SQL injection
                da.SelectCommand.Parameters.AddWithValue("@LessonTC", SelectLesson.SelectedValue?.ToString() ?? string.Empty);

                DataSet ds = new DataSet();
                da.Fill(ds);
                StudentGV.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        void fillLesson()
        {
            string query = "select * from LessonDB";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Lessons", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                LessonsCB.ValueMember = "Lessons";
                LessonsCB.DataSource = dt;
                SelectLesson.ValueMember = "Lessons";
                SelectLesson.DataSource = dt;
                Con.Close();
            }
            catch
            {
            }

        }
        void fillTeacher()
        {
            string query = "select * from TeacherDB";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("TName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                TeacherCB.ValueMember = "TName";
                TeacherCB.DataSource = dt;
                Con.Close();
            }
            catch
            {
            }

        }
        void fillStudent()
        {
            string query = "select * from StudentDB";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                StudentCB.ValueMember = "Name";
                StudentCB.DataSource = dt;
                Con.Close();
            }
            catch
            {
            }

        }
        void populate()
        {
            try
            {
                Con.Open();
                string Myquerry = "select * from TeacherMg";
                SqlDataAdapter da = new SqlDataAdapter(Myquerry, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                StudentGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch { }
        }
       /*void filterByLesson()
        {
            try
            {
                Con.Open();
                string Myquerry = "select * from StudentDB where SLesson='" + SelectLesson.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquerry, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                StudentGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            { }
        }*/
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TeacherMG values('" + Id.Text + "','" + TeacherCB.SelectedValue.ToString() + "','" + StudentCB.SelectedValue.ToString() + "','" + StudentGroupCB.SelectedValue.ToString() + "','" + LessonsCB.SelectedValue.ToString() + "','" + Grade.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Grade Succesfully Added");
                Con.Close();
                populate();

            }
            catch
            {


            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update TeacherMG set TeacherTC='" + TeacherCB.SelectedValue.ToString() + "',StudentTC='" + StudentCB.SelectedValue.ToString() + "',GroupTC='" + StudentGroupCB.SelectedValue.ToString() + "',LessonTC='" + LessonsCB.SelectedValue.ToString() + "',Grade='" + Grade.Text + "' where Id='" + Id.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Succesfully Updated");
                Con.Close();
                populate();
            }
            catch
            {


            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Id.Text == "")
            {
                MessageBox.Show("Enter the Student ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from TeacherMG where Id='" + Id.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Grade Successfully Deleted");
                Con.Close();
                populate();
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            LecTur madmin = new LecTur();
            madmin.Show();
            Visible = false;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            filterByLesson();   
        }
        private void button7_Click(object sender, EventArgs e)
        {
            populate();

        }
        /// <summary>
        /// //
        /// </summary>

        private void button1_Click(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        { }

        private void button3_Click(object sender, EventArgs e)
        { }

        private void button4_Click(object sender, EventArgs e)
        { }

        private void Teacher_Grade_Mag_Load(object sender, EventArgs e)
        {

            populate();            
            fillTeacher();
            fillStudent();
            fillStudentGroup();
            fillLesson();
        }
    }
}
