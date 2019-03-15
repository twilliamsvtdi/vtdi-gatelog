using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtdi_gatelog_b
{
    public partial class UserManagement : Form
    {
        private vtdi_gate_log_dbEntities1 _dbContext;
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            _dbContext = new vtdi_gate_log_dbEntities1();

            //Populate the Gender Dropdown
            //Get The Genders from 
            var genders = _dbContext.Genders.ToList();
            //Set the datasource of the combobox to the records
            //being retrieved from the database
            cbGenders.DataSource = genders;
            //Set the data member and value member to the values
            //that correspond with the columns coming back from 
            //our data source. 
            cbGenders.DisplayMember = "name";
            cbGenders.ValueMember = "id";

            //Populate The Grid View
            var users = _dbContext.Users.Select(q => new {
                q.Id,
                q.FirstName,
                q.LastName,
                q.Gender.Name,
                q.Email,
                q.Username
            }).ToList();

            gvUsers.DataSource = users;
            gvUsers.Columns[0].Visible = false;
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var fname = tbFirstName.Text;
            var lname = tbLastName.Text;
            var email = tbEmailAddress.Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedRowId = (int)gvUsers.SelectedRows[0].Cells[0].Value;
            MessageBox.Show($"{selectedRowId}");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        
        private void gvUsers_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
