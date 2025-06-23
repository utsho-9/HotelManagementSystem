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
    public partial class UserControlRoom : UserControl
    {
        private DataAccess dataAccess = new DataAccess();
        private DataTable dataTable;

        public UserControlRoom()
        {
            InitializeComponent();
            this.PopulateDataGridView(); ;
        }

        private void PopulateDataGridView()
        {
            try
            {
                this.dataTable = this.dataAccess.ExecuteQueryTable("SELECT * FROM RoomInfo;");
                this.dgvRoom.DataSource = this.dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "PopulateDataGridView() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckMandatoryFields()
        {
            if (string.IsNullOrWhiteSpace(this.txtRoomNumber.Text) || this.cmbRoomType.SelectedIndex == -1 ||
                this.cmbBedType.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void Add()
        {
            try
            {
                if (!this.CheckMandatoryFields())
                {
                    MessageBox.Show("Please fill in all mandatory fields.", "Add() Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int result = this.dataAccess.ExecuteDMLQuery($"INSERT INTO RoomInfo(RoomNumber, RoomType, BedType, FloorNumber, PersonCapacity, PricePerDay, Description) VALUES('{this.txtRoomNumber.Text}', '{this.cmbRoomType.Text}', '{this.cmbBedType.Text}', {this.numudFloorNumber.Value}, {this.numudPersonCapacity.Value}, {this.numudPricePerDay.Value}, '{this.txtDescription.Text}');");

                if (result != 1)
                {
                    MessageBox.Show("Failed to add room. Please try again.", "Add() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Room added successfully.", "Add() Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Clear();
                this.PopulateDataGridView();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "Add() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete()
        {
            try
            {
                if (this.dgvRoom.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select a single room to delete.", "Delete() Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult= MessageBox.Show("Are you sure you want to delete this room?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                int result= this.dataAccess.ExecuteDMLQuery($"DELETE FROM RoomInfo WHERE RoomNumber = '{this.dgvRoom.SelectedRows[0].Cells[0].Value.ToString()}';");
                if(result != 1)
                {
                    MessageBox.Show("Failed to delete room. Please try again.", "Delete() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Room deleted successfully.", "Delete() Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Clear();
                this.PopulateDataGridView();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "Delete() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update()
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "Update() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Clear()
        {
            try
            {
                this.txtRoomNumber.Clear();
                this.cmbRoomType.SelectedIndex = -1;
                this.cmbBedType.SelectedIndex = -1;
                this.numudFloorNumber.Value = 0;
                this.numudPersonCapacity.Value = 1;
                this.numudPricePerDay.Value = 1;
                this.txtDescription.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "Clear() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Update();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
    }
}