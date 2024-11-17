using System;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class StudentMain : Form
    {
        private readonly IFormNavigator _formNavigator;

        public StudentMain()
        {
            InitializeComponent();
            _formNavigator = new FormNavigator(); // Dependency injection for easier testing and flexibility
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _formNavigator.NavigateToStudentView();
            Hide();  // Hide the current form, instead of making it invisible.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _formNavigator.NavigateToForm1();
            Hide();  // Hide the current form.
        }
    }

    // Interface for form navigation to allow flexibility and polymorphism
    public interface IFormNavigator
    {
        void NavigateToStudentView();
        void NavigateToForm1();
    }

    // Implementation of the IFormNavigator interface
    public class FormNavigator : IFormNavigator
    {
        public void NavigateToStudentView()
        {
            Student_view studentView = new Student_view();
            studentView.Show();
        }

        public void NavigateToForm1()
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
