using System;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class LecTur : Form
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

        public LecTur()
        {
            InitializeComponent();
            _navigationService = new NavigationService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Navigate to Teacher Grade Management
            _navigationService.NavigateToForm(this, new Teacher_Grade_Mag());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Navigate to Login Form
            _navigationService.NavigateToForm(this, new Form1());
        }
    }
}
