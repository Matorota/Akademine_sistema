using System;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class Form1 : Form
    {
        // Navigation service to handle form transitions
        private class NavigationService
        {
            public void NavigateToForm(Form currentForm, Form targetForm)
            {
                targetForm.Show();
                currentForm.Hide();
            }
        }

        private readonly NavigationService _navigationService;

        public Form1()
        {
            InitializeComponent();
            _navigationService = new NavigationService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Navigate to Admin Login
            _navigationService.NavigateToForm(this, new Admin());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Navigate to Lecturers Login
            _navigationService.NavigateToForm(this, new Lecturers());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Navigate to Student Login
            _navigationService.NavigateToForm(this, new Student());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Exit Application
            Application.Exit();
        }
    }
}
