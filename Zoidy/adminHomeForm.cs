using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoidy.User_Control;
using static System.Windows.Forms.LinkLabel;

namespace Zoidy
{
    public partial class adminHomeForm : Form
    {
        public adminHomeForm()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            adminHomeContainer.Controls.Clear();
            adminHomeContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void NavigationButtonsOnClicked(Object sender, EventArgs e)
        {


            foreach(Control button in panelNavigationButtons.Controls)
            {
                button.BackColor = Color.FromArgb(231, 213, 221);
            }

            Control click = (Control)sender;
            click.BackColor = Color.FromArgb(186, 135, 183);


        }

        private void adminHomeForm_Load(object sender, EventArgs e)
        {


            DashboardUC Dashboard = new DashboardUC();
            addUserControl(Dashboard);
            btnDashboard.BackColor = Color.FromArgb(186, 135, 183);


        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {


            DashboardUC Dashboard = new DashboardUC();
            addUserControl(Dashboard);
            NavigationButtonsOnClicked(btnDashboard, null);


        }

        private void btnUsers_Click(object sender, EventArgs e)
        {


            UsersUC Users = new UsersUC();
            addUserControl(Users);
            NavigationButtonsOnClicked(btnUsers, null);



        }

        private void btnItems_Click(object sender, EventArgs e)
        {


            ItemsUC Items = new ItemsUC();
            addUserControl(Items);
            NavigationButtonsOnClicked(btnItems, null);


        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {


            CustomersUC Customers = new CustomersUC();
            addUserControl(Customers);
            NavigationButtonsOnClicked(btnCustomers, null);


        }

        private void btnReports_Click(object sender, EventArgs e)
        {


            ReportsUC Reports = new ReportsUC();
            addUserControl(Reports);
            NavigationButtonsOnClicked(btnReports, null);


        }

        private void btnBackupAndRestore_Click(object sender, EventArgs e)
        {


            BackupAndRestoreUC BackupAndRestore = new BackupAndRestoreUC();
            addUserControl(BackupAndRestore);
            NavigationButtonsOnClicked(btnBackupAndRestore, null);


        }

        private void grpBoxProfile_Enter(object sender, EventArgs e)
        {





        }

        private void btnLogout_Click(object sender, EventArgs e)
        {





        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {





        }
    }
}
