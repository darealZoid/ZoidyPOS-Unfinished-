namespace Zoidy
{
    partial class adminHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAdminHomeMenu = new System.Windows.Forms.Panel();
            this.panelNavigationButtons = new System.Windows.Forms.Panel();
            this.grpBoxProfile = new System.Windows.Forms.GroupBox();
            this.adminHomeContainer = new System.Windows.Forms.Panel();
            this.lblPounders = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBackupAndRestore = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelAdminHomeMenu.SuspendLayout();
            this.panelNavigationButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdminHomeMenu
            // 
            this.panelAdminHomeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.panelAdminHomeMenu.Controls.Add(this.lblPounders);
            this.panelAdminHomeMenu.Controls.Add(this.pictureBox1);
            this.panelAdminHomeMenu.Controls.Add(this.btnLogout);
            this.panelAdminHomeMenu.Controls.Add(this.grpBoxProfile);
            this.panelAdminHomeMenu.Controls.Add(this.panelNavigationButtons);
            this.panelAdminHomeMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdminHomeMenu.Location = new System.Drawing.Point(0, 0);
            this.panelAdminHomeMenu.Name = "panelAdminHomeMenu";
            this.panelAdminHomeMenu.Size = new System.Drawing.Size(226, 961);
            this.panelAdminHomeMenu.TabIndex = 0;
            this.panelAdminHomeMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelNavigationButtons
            // 
            this.panelNavigationButtons.Controls.Add(this.btnBackupAndRestore);
            this.panelNavigationButtons.Controls.Add(this.btnReports);
            this.panelNavigationButtons.Controls.Add(this.btnCustomers);
            this.panelNavigationButtons.Controls.Add(this.btnItems);
            this.panelNavigationButtons.Controls.Add(this.btnUsers);
            this.panelNavigationButtons.Controls.Add(this.btnDashboard);
            this.panelNavigationButtons.Location = new System.Drawing.Point(-3, 298);
            this.panelNavigationButtons.Margin = new System.Windows.Forms.Padding(5);
            this.panelNavigationButtons.Name = "panelNavigationButtons";
            this.panelNavigationButtons.Size = new System.Drawing.Size(226, 303);
            this.panelNavigationButtons.TabIndex = 0;
            // 
            // grpBoxProfile
            // 
            this.grpBoxProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxProfile.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.grpBoxProfile.Location = new System.Drawing.Point(-2, 623);
            this.grpBoxProfile.Name = "grpBoxProfile";
            this.grpBoxProfile.Size = new System.Drawing.Size(226, 149);
            this.grpBoxProfile.TabIndex = 7;
            this.grpBoxProfile.TabStop = false;
            this.grpBoxProfile.Text = "Profile";
            this.grpBoxProfile.Enter += new System.EventHandler(this.grpBoxProfile_Enter);
            // 
            // adminHomeContainer
            // 
            this.adminHomeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminHomeContainer.Location = new System.Drawing.Point(226, 0);
            this.adminHomeContainer.Name = "adminHomeContainer";
            this.adminHomeContainer.Size = new System.Drawing.Size(1658, 961);
            this.adminHomeContainer.TabIndex = 1;
            // 
            // lblPounders
            // 
            this.lblPounders.AutoSize = true;
            this.lblPounders.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPounders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(80)))), ((int)(((byte)(106)))));
            this.lblPounders.Location = new System.Drawing.Point(86, 34);
            this.lblPounders.Name = "lblPounders";
            this.lblPounders.Size = new System.Drawing.Size(110, 30);
            this.lblPounders.TabIndex = 9;
            this.lblPounders.Text = "Pounders";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zoidy.Properties.Resources.beefburger;
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(183)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(108)))), ((int)(((byte)(100)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.btnLogout.Image = global::Zoidy.Properties.Resources.log_out_solid_24__1_;
            this.btnLogout.Location = new System.Drawing.Point(61, 866);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 68);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = " Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBackupAndRestore
            // 
            this.btnBackupAndRestore.FlatAppearance.BorderSize = 0;
            this.btnBackupAndRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupAndRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupAndRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.btnBackupAndRestore.Image = global::Zoidy.Properties.Resources.hdd_solid_24;
            this.btnBackupAndRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupAndRestore.Location = new System.Drawing.Point(8, 250);
            this.btnBackupAndRestore.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnBackupAndRestore.Name = "btnBackupAndRestore";
            this.btnBackupAndRestore.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBackupAndRestore.Size = new System.Drawing.Size(214, 37);
            this.btnBackupAndRestore.TabIndex = 5;
            this.btnBackupAndRestore.Text = " Backup And Restore";
            this.btnBackupAndRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackupAndRestore.UseVisualStyleBackColor = true;
            this.btnBackupAndRestore.Click += new System.EventHandler(this.btnBackupAndRestore_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.btnReports.Image = global::Zoidy.Properties.Resources.report_solid_24__1_;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(8, 203);
            this.btnReports.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(214, 37);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = " Reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.btnCustomers.Image = global::Zoidy.Properties.Resources.user_plus_solid_24;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(8, 156);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCustomers.Size = new System.Drawing.Size(214, 37);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = " Customers";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnItems
            // 
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.btnItems.Image = global::Zoidy.Properties.Resources.shopping_bag_solid_24;
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.Location = new System.Drawing.Point(8, 109);
            this.btnItems.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnItems.Name = "btnItems";
            this.btnItems.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnItems.Size = new System.Drawing.Size(214, 37);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = " Items";
            this.btnItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.btnUsers.Image = global::Zoidy.Properties.Resources.user_solid_24__2_;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(8, 62);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(214, 37);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = " Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.btnDashboard.Image = global::Zoidy.Properties.Resources.dashboard_solid_24__2_;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(8, 15);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(214, 37);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = " Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // adminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(223)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1884, 961);
            this.Controls.Add(this.adminHomeContainer);
            this.Controls.Add(this.panelAdminHomeMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "adminHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.adminHomeForm_Load);
            this.panelAdminHomeMenu.ResumeLayout(false);
            this.panelAdminHomeMenu.PerformLayout();
            this.panelNavigationButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdminHomeMenu;
        private System.Windows.Forms.Panel adminHomeContainer;
        private System.Windows.Forms.Panel panelNavigationButtons;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBackupAndRestore;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.GroupBox grpBoxProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPounders;
    }
}