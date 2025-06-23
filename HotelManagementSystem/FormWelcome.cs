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
    public partial class FormWelcome : Form
    {
        private DataAccess dataAccess = new DataAccess();
        private DataTable dataTable;

        public FormWelcome()
        {
            InitializeComponent();
            this.SetLoginInterface();
        }

        private void SetRegistrationInterface() 
        {
            this.panelSignup.BringToFront();

            this.btnSignUp.Visible = true;
            this.btnLogin.Visible = false;
        }

        private void SetLoginInterface()
        {
            this.panelSignin.BringToFront();

            this.btnLogin.Visible = true;
            this.btnSignUp.Visible = false;
        }

        private void ShowPassword(CheckBox cb, TextBox txt)
        {
            if (cb.Checked)
            {
                txt.UseSystemPasswordChar = false;
            }
            else
            {
                txt.UseSystemPasswordChar = true;
            }
        }

        private void Login()
        {
            //try
            //{
            //    this.dataTable = this.dataAccess.ExecuteQueryTable($"SELECT * FROM UserInfo WHERE Email = '{this.txtEmailLogin.Text}' AND Password = '{this.txtPasswordLogin.Text}';");
            //    if (this.dataTable.Rows.Count == 0)
            //    {
            //        MessageBox.Show("Invalid Email or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }

            //    MessageBox.Show("Login Successful", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception e)
            //{

            //}

            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }

        private void ClearAllFields()
        {
            try
            {
                this.txtFullName.Clear();
                this.txtEmailRegister.Clear();
                this.dtpJoinDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                this.numudPhone.Value = 1000000000;
                this.cmbUserType.SelectedIndex = -1;
                this.txtPasswordRegister.Clear();

                this.txtEmailLogin.Clear();
                this.txtPasswordLogin.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred while clearing fields: {e.Message}", "ClearAllFields() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetRegistrationPanel_Click(object sender, EventArgs e)
        {
            this.SetRegistrationInterface();
        }

        private void btnSetLoginPanel_Click(object sender, EventArgs e)
        {
            this.SetLoginInterface();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.SetLoginInterface();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAllFields();
        }

        private void cbShowPasswordRegister_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowPassword(this.cbShowPasswordRegister, this.txtPasswordRegister);
        }

        private void cbShowPasswordLogin_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowPassword(this.cbShowPasswordLogin, this.txtPasswordLogin);
        }

        private void FormWelcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
