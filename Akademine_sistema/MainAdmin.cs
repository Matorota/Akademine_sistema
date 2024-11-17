using System;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class MainAdmin : Form
    {
        // Navigation service for managing form transitions
        private class NavigationService
        {
            private readonly Form _currentForm;

            public NavigationService(Form currentForm)
            {
                _currentForm = currentForm;
            }

            public void NavigateTo(Form targetForm)
            {
                targetForm.Show();
                _currentForm.Hide();
            }
        }

        private readonly NavigationService _navigationService;

        public MainAdmin()
        {
            InitializeComponent();
            _navigationService = new NavigationService(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateTo(new Student_Group_Management());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateTo(new Lessons());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateTo(new Teacher_Management_System());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateTo(new Form1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateTo(new Student_Management());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // No functionality provided for label click in original code
        }
    }
}
