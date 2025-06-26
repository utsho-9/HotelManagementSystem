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

        private void SignUp()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtFullName.Text) || string.IsNullOrEmpty(this.txtEmailRegister.Text) ||
                    string.IsNullOrEmpty(this.cmbUserType.Text) || string.IsNullOrEmpty(this.txtPasswordRegister.Text))
                {
                    MessageBox.Show("Please fill in all mandatory fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int result = this.dataAccess.ExecuteDMLQuery($"INSERT INTO UserInfo(FullName, Email, JoinDate, Phone, UserType, Password) VALUES('{this.txtFullName.Text}', '{this.txtEmailRegister.Text}', '{this.dtpJoinDate.Text}', {this.numudPhone.Value}, '{this.cmbUserType.Text}', '{this.txtPasswordRegister.Text}');");
                if (result != 1)
                {
                    MessageBox.Show("Registration failed. Please try again.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Registration Successful", "Sign Up Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ClearAllFields();
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred during registration: {e.Message}", "SignUp() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Login()
        {
            try
            {
                this.dataTable = this.dataAccess.ExecuteQueryTable(
                    $"SELECT * FROM UserInfo WHERE Email = '{this.txtEmailLogin.Text}' AND Password = '{this.txtPasswordLogin.Text}';");
                if (this.dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid Email or Password", "Login Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }

                MessageBox.Show("Login Successful", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.dataTable.Rows[0][4].ToString().Contains("admin") || this.dataTable.Rows[0][4].ToString().Contains("Manager"))
                {
                    FormAdmin formAdmin = new FormAdmin();
                    this.Visible = false;
                    formAdmin.Visible = true;
                }
                else if(this.dataTable.Rows[0][4].ToString().Contains("employee"))
                {
                    FormBooking formBooking = new FormBooking();
                    this.Visible = false;
                    formBooking.Visible = true;
                }
            }
            catch (Exception e)
            {                                   
                MessageBox.Show($"An error occurred during login: {e.Message}", "Login() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            this.SignUp();
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
