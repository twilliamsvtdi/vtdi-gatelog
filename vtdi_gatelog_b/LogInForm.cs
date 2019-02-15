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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // You can always use the variable types that 
            // you are familair with. (string, int, etc...)
            string username = tbUsername.Text;
            var password = tbPassword.Text;

            ///String.IsNullOrEmpty(string value) allows you to check
            /// if a string variable is empty or null. 
            if (String.IsNullOrEmpty(username) || 
                String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter values!");
            }
            // You can use the String.Equals() function to compare
            // two string values and see if they are equal. 
            else if(username == "admin" && 
                String.Equals("admin", password))
            {
                MessageBox.Show($"Welcome {username}");
            }
            else
            {
                MessageBox.Show("Invalid Credentials Entered");
            }
        }
    }
}
