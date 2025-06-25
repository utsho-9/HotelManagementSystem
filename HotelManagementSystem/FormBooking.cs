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
    public partial class FormBooking : Form
    {
        private DataAccess dataAccess = new DataAccess();
        private DataTable dataTable;

        public FormBooking()
        {
            InitializeComponent();
            this.PopulateDataGridview("SELECT * FROM RoomInfo;");
        }

        private void PopulateDataGridview(string query)
        {
            try
            {
                this.dataTable = this.dataAccess.ExecuteQueryTable(query);
                this.dgvRoom.DataSource = this.dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "PopulateDataGridView() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookRoom()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtGuestName.Text) || this.numudNid.Value == 0 || this.numudGuestPhone.Value == 1000000000)
                {
                    MessageBox.Show("Please fill in all mandatory fields.", "BookRoom() Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to book this room?", "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                MessageBox.Show("Booking successful!", "BookRoom() Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "BookRoom() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Logout()
        {
            FormWelcome formWelcome = new FormWelcome();
            this.Visible = false;
            formWelcome.Visible = true;
        }

        private void FormBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           this.Logout();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.PopulateDataGridview($"SELECT * FROM RoomInfo WHERE RoomNumber LIKE '%{this.txtSearch.Text}%' OR Description LIKE '%{this.txtSearch.Text}%';");
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            this.BookRoom();
        }
    }
}