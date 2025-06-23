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
    public partial class UserControlEmployee : UserControl
    {
        private DataAccess dataAccess = new DataAccess();
        private DataTable dataTable;

        public UserControlEmployee()
        {
            InitializeComponent();
            this.PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            try
            {
                this.dataTable = this.dataAccess.ExecuteQueryTable("SELECT * FROM UserInfo;");
                this.dgvEmployee.DataSource = this.dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "PopulateDataGridView() Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
