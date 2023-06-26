namespace Zoidy.User_Control
{
    partial class ItemsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenuForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewMenuList = new System.Windows.Forms.DataGridView();
            this.dB_POSZOIDYDataSet = new Zoidy.DB_POSZOIDYDataSet();
            this.mENUDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mENU_DETAILSTableAdapter = new Zoidy.DB_POSZOIDYDataSetTableAdapters.MENU_DETAILSTableAdapter();
            this.menuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblMenuDetail = new System.Windows.Forms.Label();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.lblMenuPrice = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.pctrBoxMenuPicture = new System.Windows.Forms.PictureBox();
            this.lblMenuPicture = new System.Windows.Forms.Label();
            this.btnUpdateMenu = new System.Windows.Forms.Button();
            this.btnClearAllMenuDetails = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.UpdateMenuNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.DeleteMenuNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.AddMenuNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlMenuForm.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_POSZOIDYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxMenuPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuForm
            // 
            this.pnlMenuForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.pnlMenuForm.Controls.Add(this.btnUpdateMenu);
            this.pnlMenuForm.Controls.Add(this.btnClearAllMenuDetails);
            this.pnlMenuForm.Controls.Add(this.btnAddMenu);
            this.pnlMenuForm.Controls.Add(this.lblMenuPicture);
            this.pnlMenuForm.Controls.Add(this.pctrBoxMenuPicture);
            this.pnlMenuForm.Controls.Add(this.txtBoxPrice);
            this.pnlMenuForm.Controls.Add(this.txtBoxName);
            this.pnlMenuForm.Controls.Add(this.lblMenuPrice);
            this.pnlMenuForm.Controls.Add(this.lblMenuName);
            this.pnlMenuForm.Controls.Add(this.lblMenuDetail);
            this.pnlMenuForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuForm.Location = new System.Drawing.Point(10, 10);
            this.pnlMenuForm.Name = "pnlMenuForm";
            this.pnlMenuForm.Size = new System.Drawing.Size(395, 941);
            this.pnlMenuForm.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(405, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 941);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.panel3.Controls.Add(this.dataGridViewMenuList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(434, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 941);
            this.panel3.TabIndex = 2;
            // 
            // dataGridViewMenuList
            // 
            this.dataGridViewMenuList.AllowUserToAddRows = false;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMenuList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewMenuList.AutoGenerateColumns = false;
            this.dataGridViewMenuList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMenuList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMenuList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.dataGridViewMenuList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMenuList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMenuList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewMenuList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(80)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMenuList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewMenuList.ColumnHeadersHeight = 42;
            this.dataGridViewMenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMenuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuIDDataGridViewTextBoxColumn,
            this.menuNameDataGridViewTextBoxColumn,
            this.menuPriceDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridViewMenuList.DataSource = this.mENUDETAILSBindingSource;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMenuList.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewMenuList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMenuList.EnableHeadersVisualStyles = false;
            this.dataGridViewMenuList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.dataGridViewMenuList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMenuList.MultiSelect = false;
            this.dataGridViewMenuList.Name = "dataGridViewMenuList";
            this.dataGridViewMenuList.ReadOnly = true;
            this.dataGridViewMenuList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewMenuList.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewMenuList.RowHeadersVisible = false;
            this.dataGridViewMenuList.RowHeadersWidth = 50;
            this.dataGridViewMenuList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMenuList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMenuList.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridViewMenuList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMenuList.RowTemplate.Height = 42;
            this.dataGridViewMenuList.RowTemplate.ReadOnly = true;
            this.dataGridViewMenuList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMenuList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewMenuList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenuList.Size = new System.Drawing.Size(1240, 941);
            this.dataGridViewMenuList.StandardTab = true;
            this.dataGridViewMenuList.TabIndex = 1;
            this.dataGridViewMenuList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenuList_CellContentClick);
            this.dataGridViewMenuList.SelectionChanged += new System.EventHandler(this.dataGridViewMenuList_SelectionChanged);
            // 
            // dB_POSZOIDYDataSet
            // 
            this.dB_POSZOIDYDataSet.DataSetName = "DB_POSZOIDYDataSet";
            this.dB_POSZOIDYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mENUDETAILSBindingSource
            // 
            this.mENUDETAILSBindingSource.DataMember = "MENU_DETAILS";
            this.mENUDETAILSBindingSource.DataSource = this.dB_POSZOIDYDataSet;
            // 
            // mENU_DETAILSTableAdapter
            // 
            this.mENU_DETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // menuIDDataGridViewTextBoxColumn
            // 
            this.menuIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuIDDataGridViewTextBoxColumn.DataPropertyName = "menu_ID";
            this.menuIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.menuIDDataGridViewTextBoxColumn.Name = "menuIDDataGridViewTextBoxColumn";
            this.menuIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuNameDataGridViewTextBoxColumn
            // 
            this.menuNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuNameDataGridViewTextBoxColumn.DataPropertyName = "menu_Name";
            this.menuNameDataGridViewTextBoxColumn.HeaderText = "Menu Name";
            this.menuNameDataGridViewTextBoxColumn.Name = "menuNameDataGridViewTextBoxColumn";
            this.menuNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuPriceDataGridViewTextBoxColumn
            // 
            this.menuPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuPriceDataGridViewTextBoxColumn.DataPropertyName = "menu_Price";
            this.menuPriceDataGridViewTextBoxColumn.HeaderText = "Menu Price";
            this.menuPriceDataGridViewTextBoxColumn.Name = "menuPriceDataGridViewTextBoxColumn";
            this.menuPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle21.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle21.NullValue")));
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle21;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::Zoidy.Properties.Resources.pencil_solid_24;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 21;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle22.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle22.NullValue")));
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle22;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::Zoidy.Properties.Resources.trash_solid_24;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 21;
            // 
            // lblMenuDetail
            // 
            this.lblMenuDetail.AutoSize = true;
            this.lblMenuDetail.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.lblMenuDetail.Location = new System.Drawing.Point(33, 21);
            this.lblMenuDetail.Name = "lblMenuDetail";
            this.lblMenuDetail.Size = new System.Drawing.Size(315, 65);
            this.lblMenuDetail.TabIndex = 0;
            this.lblMenuDetail.Text = "Menu Detail";
            // 
            // lblMenuName
            // 
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblMenuName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.lblMenuName.Location = new System.Drawing.Point(40, 165);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(61, 21);
            this.lblMenuName.TabIndex = 1;
            this.lblMenuName.Text = "Name: ";
            // 
            // lblMenuPrice
            // 
            this.lblMenuPrice.AutoSize = true;
            this.lblMenuPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblMenuPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.lblMenuPrice.Location = new System.Drawing.Point(40, 316);
            this.lblMenuPrice.Name = "lblMenuPrice";
            this.lblMenuPrice.Size = new System.Drawing.Size(54, 21);
            this.lblMenuPrice.TabIndex = 2;
            this.lblMenuPrice.Text = "Price: ";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.txtBoxName.Location = new System.Drawing.Point(44, 213);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(220, 25);
            this.txtBoxName.TabIndex = 3;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.txtBoxPrice.Location = new System.Drawing.Point(44, 364);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(220, 25);
            this.txtBoxPrice.TabIndex = 4;
            // 
            // pctrBoxMenuPicture
            // 
            this.pctrBoxMenuPicture.Image = global::Zoidy.Properties.Resources.account;
            this.pctrBoxMenuPicture.Location = new System.Drawing.Point(44, 483);
            this.pctrBoxMenuPicture.Name = "pctrBoxMenuPicture";
            this.pctrBoxMenuPicture.Size = new System.Drawing.Size(144, 156);
            this.pctrBoxMenuPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBoxMenuPicture.TabIndex = 5;
            this.pctrBoxMenuPicture.TabStop = false;
            this.pctrBoxMenuPicture.Click += new System.EventHandler(this.pctrBoxMenuPicture_Click);
            // 
            // lblMenuPicture
            // 
            this.lblMenuPicture.AutoSize = true;
            this.lblMenuPicture.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblMenuPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.lblMenuPicture.Location = new System.Drawing.Point(40, 439);
            this.lblMenuPicture.Name = "lblMenuPicture";
            this.lblMenuPicture.Size = new System.Drawing.Size(69, 21);
            this.lblMenuPicture.TabIndex = 6;
            this.lblMenuPicture.Text = "Picture: ";
            // 
            // btnUpdateMenu
            // 
            this.btnUpdateMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(183)))));
            this.btnUpdateMenu.FlatAppearance.BorderSize = 0;
            this.btnUpdateMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(183)))));
            this.btnUpdateMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.btnUpdateMenu.Location = new System.Drawing.Point(60, 764);
            this.btnUpdateMenu.Name = "btnUpdateMenu";
            this.btnUpdateMenu.Size = new System.Drawing.Size(128, 34);
            this.btnUpdateMenu.TabIndex = 9;
            this.btnUpdateMenu.Text = "Update";
            this.btnUpdateMenu.UseVisualStyleBackColor = false;
            this.btnUpdateMenu.Click += new System.EventHandler(this.btnUpdateMenu_Click);
            // 
            // btnClearAllMenuDetails
            // 
            this.btnClearAllMenuDetails.FlatAppearance.BorderSize = 0;
            this.btnClearAllMenuDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(183)))));
            this.btnClearAllMenuDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllMenuDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllMenuDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.btnClearAllMenuDetails.Location = new System.Drawing.Point(185, 764);
            this.btnClearAllMenuDetails.Name = "btnClearAllMenuDetails";
            this.btnClearAllMenuDetails.Size = new System.Drawing.Size(128, 34);
            this.btnClearAllMenuDetails.TabIndex = 8;
            this.btnClearAllMenuDetails.Text = "Clear All";
            this.btnClearAllMenuDetails.UseVisualStyleBackColor = true;
            this.btnClearAllMenuDetails.Click += new System.EventHandler(this.btnClearAllMenuDetails_Click);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(183)))));
            this.btnAddMenu.FlatAppearance.BorderSize = 0;
            this.btnAddMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.btnAddMenu.Location = new System.Drawing.Point(60, 764);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(128, 34);
            this.btnAddMenu.TabIndex = 7;
            this.btnAddMenu.Text = "Add";
            this.btnAddMenu.UseVisualStyleBackColor = false;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // UpdateMenuNotification
            // 
            this.UpdateMenuNotification.Text = "notifyIcon1";
            this.UpdateMenuNotification.Visible = true;
            // 
            // DeleteMenuNotification
            // 
            this.DeleteMenuNotification.Text = "notifyIcon1";
            this.DeleteMenuNotification.Visible = true;
            // 
            // AddMenuNotification
            // 
            this.AddMenuNotification.Text = "notifyIcon1";
            this.AddMenuNotification.Visible = true;
            // 
            // ItemsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenuForm);
            this.Name = "ItemsUC";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1684, 961);
            this.Load += new System.EventHandler(this.ItemsUC_Load);
            this.pnlMenuForm.ResumeLayout(false);
            this.pnlMenuForm.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_POSZOIDYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxMenuPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewMenuList;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.BindingSource mENUDETAILSBindingSource;
        private DB_POSZOIDYDataSet dB_POSZOIDYDataSet;
        private DB_POSZOIDYDataSetTableAdapters.MENU_DETAILSTableAdapter mENU_DETAILSTableAdapter;
        private System.Windows.Forms.Label lblMenuPrice;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.Label lblMenuDetail;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblMenuPicture;
        private System.Windows.Forms.PictureBox pctrBoxMenuPicture;
        private System.Windows.Forms.Button btnUpdateMenu;
        private System.Windows.Forms.Button btnClearAllMenuDetails;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.NotifyIcon UpdateMenuNotification;
        private System.Windows.Forms.NotifyIcon DeleteMenuNotification;
        private System.Windows.Forms.NotifyIcon AddMenuNotification;
    }
}
