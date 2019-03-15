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
    public partial class Form1 : Form
    {
        public bool isLoggedIn = true;
        public string userLoggedIn = "";

        public Form1()
        {
            InitializeComponent();
        }
        private string btn_clicked(object sender)
        {
            var ctrl = (ToolStripMenuItem)sender;
            return ctrl.Text;
        }

        private void logInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();
        }

        private void userManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                //MessageBox.Show($"{btn_clicked(sender)} Clicked");
                var usermng = new UserManagement();
                usermng.MdiParent = this;
                usermng.Show();
            }
            else
            {
                ShowLoginForm();
            }
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
                MessageBox.Show($"{btn_clicked(sender)} Clicked");
            else
            {
                ShowLoginForm();
            }
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
                MessageBox.Show($"{btn_clicked(sender)} Clicked");
            else
            {
                ShowLoginForm();
            }
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.isLoggedIn)
            {
                GateLogForm gateInOut = new GateLogForm();
                gateInOut.MdiParent = this;
                gateInOut.Show();
            }
            else
            {
                ShowLoginForm();
            }
        }

        private void gateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
                MessageBox.Show($"{btn_clicked(sender)} Clicked");
            else
            {
                ShowLoginForm();
            }
        }

        private void userLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
                MessageBox.Show($"{btn_clicked(sender)} Clicked");
            else
            {
                ShowLoginForm();
            }
        }

        private void ShowLoginForm()
        {
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowLoginForm();
        }
    }
}
