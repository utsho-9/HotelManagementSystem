using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void SetInterface(UserControl userControl)
        {
            this.panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Logout()
        {
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.Show();
            this.Hide();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Logout();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.SetInterface(new UserControlEmployee());
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            this.SetInterface(new UserControlRoom());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.SetInterface(new UserControlDashboard());
        }
    }
}
