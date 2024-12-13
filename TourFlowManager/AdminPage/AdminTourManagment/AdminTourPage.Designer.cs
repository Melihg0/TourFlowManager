namespace TourAgent.AdminPage.AdminSystemManagement
{
    partial class AdminTourPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourFlowManagerDBDataSet = new TourAgent.TourFlowManagerDBDataSet();
            this.tbl_UsersTableAdapter = new TourAgent.TourFlowManagerDBDataSetTableAdapters.tbl_UsersTableAdapter();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnSystemManagement = new System.Windows.Forms.Button();
            this.btnTourManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditTourPage = new System.Windows.Forms.Button();
            this.btnDeletedTourType = new System.Windows.Forms.Button();
            this.btnEditTourTypePage = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRoleID = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTourTypeID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tblToursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ToursTableAdapter = new TourAgent.TourFlowManagerDBDataSetTableAdapters.tbl_ToursTableAdapter();
            this.tourIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startPointCityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationCityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guideIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxParticipantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStartID = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtDestinationID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourFlowManagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnEditTourPage);
            this.panel1.Controls.Add(this.btnDeletedTourType);
            this.panel1.Controls.Add(this.btnEditTourTypePage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 800);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Yönetim Sayfası";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 800);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(231, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 800);
            this.panel3.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 112);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1109, 10);
            this.panel7.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.btnMainPage);
            this.panel6.Controls.Add(this.btnSystemManagement);
            this.panel6.Controls.Add(this.btnTourManagement);
            this.panel6.Controls.Add(this.btnUserManagement);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(241, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1109, 122);
            this.panel6.TabIndex = 3;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tbl_Users";
            this.tblUsersBindingSource.DataSource = this.tourFlowManagerDBDataSet;
            // 
            // tourFlowManagerDBDataSet
            // 
            this.tourFlowManagerDBDataSet.DataSetName = "TourFlowManagerDBDataSet";
            this.tourFlowManagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UsersTableAdapter
            // 
            this.tbl_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tourIDDataGridViewTextBoxColumn,
            this.tourNameDataGridViewTextBoxColumn,
            this.startPointCityIDDataGridViewTextBoxColumn,
            this.destinationCityIDDataGridViewTextBoxColumn,
            this.tourTypeIDDataGridViewTextBoxColumn,
            this.guideIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.maxParticipantsDataGridViewTextBoxColumn});
            this.dataGridViewUsers.DataSource = this.tblToursBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUsers.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewUsers.Location = new System.Drawing.Point(265, 154);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsers.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1053, 376);
            this.dataGridViewUsers.TabIndex = 37;
            // 
            // btnMainPage
            // 
            this.btnMainPage.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnMainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainPage.FlatAppearance.BorderSize = 0;
            this.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainPage.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMainPage.Image = global::TourAgent.Properties.Resources.home;
            this.btnMainPage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMainPage.Location = new System.Drawing.Point(41, 8);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(126, 101);
            this.btnMainPage.TabIndex = 31;
            this.btnMainPage.Text = "Ana Sayfa";
            this.btnMainPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainPage.UseVisualStyleBackColor = false;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // btnSystemManagement
            // 
            this.btnSystemManagement.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSystemManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSystemManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSystemManagement.FlatAppearance.BorderSize = 0;
            this.btnSystemManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSystemManagement.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSystemManagement.Image = global::TourAgent.Properties.Resources.data_storage;
            this.btnSystemManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSystemManagement.Location = new System.Drawing.Point(836, 6);
            this.btnSystemManagement.Name = "btnSystemManagement";
            this.btnSystemManagement.Size = new System.Drawing.Size(200, 104);
            this.btnSystemManagement.TabIndex = 30;
            this.btnSystemManagement.Text = "Veritabanı Yonetimi";
            this.btnSystemManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSystemManagement.UseVisualStyleBackColor = false;
            this.btnSystemManagement.Click += new System.EventHandler(this.btnSystemManagement_Click);
            // 
            // btnTourManagement
            // 
            this.btnTourManagement.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTourManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTourManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTourManagement.FlatAppearance.BorderSize = 0;
            this.btnTourManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTourManagement.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTourManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTourManagement.Image = global::TourAgent.Properties.Resources.tour;
            this.btnTourManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTourManagement.Location = new System.Drawing.Point(550, 5);
            this.btnTourManagement.Name = "btnTourManagement";
            this.btnTourManagement.Size = new System.Drawing.Size(200, 104);
            this.btnTourManagement.TabIndex = 29;
            this.btnTourManagement.Text = "Tur Islemleri";
            this.btnTourManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTourManagement.UseVisualStyleBackColor = false;
            this.btnTourManagement.Click += new System.EventHandler(this.btnTourManagement_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUserManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserManagement.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUserManagement.Image = global::TourAgent.Properties.Resources.group;
            this.btnUserManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUserManagement.Location = new System.Drawing.Point(253, 6);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(200, 104);
            this.btnUserManagement.TabIndex = 28;
            this.btnUserManagement.Text = "Kullanıcı Islemleri";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::TourAgent.Properties.Resources.software_engineer;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 145);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditTourPage
            // 
            this.btnEditTourPage.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnEditTourPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditTourPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTourPage.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditTourPage.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTourPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditTourPage.Image = global::TourAgent.Properties.Resources.editing;
            this.btnEditTourPage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditTourPage.Location = new System.Drawing.Point(10, 427);
            this.btnEditTourPage.Name = "btnEditTourPage";
            this.btnEditTourPage.Size = new System.Drawing.Size(213, 103);
            this.btnEditTourPage.TabIndex = 34;
            this.btnEditTourPage.Text = "Turları Düzenle";
            this.btnEditTourPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditTourPage.UseVisualStyleBackColor = false;
            // 
            // btnDeletedTourType
            // 
            this.btnDeletedTourType.BackColor = System.Drawing.Color.Lavender;
            this.btnDeletedTourType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeletedTourType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletedTourType.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeletedTourType.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletedTourType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeletedTourType.Image = global::TourAgent.Properties.Resources.deleted;
            this.btnDeletedTourType.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletedTourType.Location = new System.Drawing.Point(11, 587);
            this.btnDeletedTourType.Name = "btnDeletedTourType";
            this.btnDeletedTourType.Size = new System.Drawing.Size(213, 103);
            this.btnDeletedTourType.TabIndex = 33;
            this.btnDeletedTourType.Text = "Silinmis Turlar";
            this.btnDeletedTourType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletedTourType.UseVisualStyleBackColor = false;
            // 
            // btnEditTourTypePage
            // 
            this.btnEditTourTypePage.BackColor = System.Drawing.Color.LightCyan;
            this.btnEditTourTypePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditTourTypePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTourTypePage.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditTourTypePage.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTourTypePage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditTourTypePage.Image = global::TourAgent.Properties.Resources.editing;
            this.btnEditTourTypePage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditTourTypePage.Location = new System.Drawing.Point(11, 267);
            this.btnEditTourTypePage.Name = "btnEditTourTypePage";
            this.btnEditTourTypePage.Size = new System.Drawing.Size(213, 103);
            this.btnEditTourTypePage.TabIndex = 32;
            this.btnEditTourTypePage.Text = "Tur Türlerini Düzenle";
            this.btnEditTourTypePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditTourTypePage.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Green;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddUser.Location = new System.Drawing.Point(368, 726);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(236, 63);
            this.btnAddUser.TabIndex = 41;
            this.btnAddUser.Text = "Kullanıcı Ekle";
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditUser.Location = new System.Drawing.Point(677, 726);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(236, 63);
            this.btnEditUser.TabIndex = 40;
            this.btnEditUser.Text = "Kullanıcıyı Düzenle";
            this.btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteUser.Location = new System.Drawing.Point(987, 726);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(236, 63);
            this.btnDeleteUser.TabIndex = 39;
            this.btnDeleteUser.Text = "Kullanıcıyı Sil";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox8);
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(312, 545);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 160);
            this.panel2.TabIndex = 38;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox7.Controls.Add(this.dtBirthDate);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox7.Location = new System.Drawing.Point(548, 87);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(211, 49);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DOGUM TARİHİ";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtBirthDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtBirthDate.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtBirthDate.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtBirthDate.CalendarTrailingForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtBirthDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBirthDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtBirthDate.Location = new System.Drawing.Point(0, 20);
            this.dtBirthDate.MaxDate = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            this.dtBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(211, 27);
            this.dtBirthDate.TabIndex = 11;
            this.dtBirthDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SteelBlue;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(175, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 68);
            this.button6.TabIndex = 32;
            this.button6.Text = "Kullanıcı Ekle";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.cbRoleID);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(728, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 51);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ROLEID";
            // 
            // cbRoleID
            // 
            this.cbRoleID.FormattingEnabled = true;
            this.cbRoleID.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbRoleID.Location = new System.Drawing.Point(6, 21);
            this.cbRoleID.Name = "cbRoleID";
            this.cbRoleID.Size = new System.Drawing.Size(80, 28);
            this.cbRoleID.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(3, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 68);
            this.button2.TabIndex = 31;
            this.button2.Text = "Kullanıcı Ekle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Controls.Add(this.txtTourTypeID);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Location = new System.Drawing.Point(296, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(99, 49);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TourTypeID";
            // 
            // txtTourTypeID
            // 
            this.txtTourTypeID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTourTypeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTourTypeID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTourTypeID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTourTypeID.Location = new System.Drawing.Point(3, 19);
            this.txtTourTypeID.MaxLength = 50;
            this.txtTourTypeID.Multiline = true;
            this.txtTourTypeID.Name = "txtTourTypeID";
            this.txtTourTypeID.Size = new System.Drawing.Size(93, 27);
            this.txtTourTypeID.TabIndex = 0;
            this.txtTourTypeID.TabStop = false;
            this.txtTourTypeID.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.txtTourName);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(86, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 49);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TourName";
            // 
            // txtTourName
            // 
            this.txtTourName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTourName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTourName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTourName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTourName.Location = new System.Drawing.Point(3, 22);
            this.txtTourName.MaxLength = 50;
            this.txtTourName.Multiline = true;
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.Size = new System.Drawing.Size(175, 24);
            this.txtTourName.TabIndex = 0;
            this.txtTourName.TabStop = false;
            this.txtTourName.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(86, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 49);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SIFRE";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(3, 20);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(123, 26);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TabStop = false;
            this.txtPassword.WordWrap = false;
            // 
            // tblToursBindingSource
            // 
            this.tblToursBindingSource.DataMember = "tbl_Tours";
            this.tblToursBindingSource.DataSource = this.tourFlowManagerDBDataSet;
            // 
            // tbl_ToursTableAdapter
            // 
            this.tbl_ToursTableAdapter.ClearBeforeFill = true;
            // 
            // tourIDDataGridViewTextBoxColumn
            // 
            this.tourIDDataGridViewTextBoxColumn.DataPropertyName = "TourID";
            this.tourIDDataGridViewTextBoxColumn.HeaderText = "TourID";
            this.tourIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tourIDDataGridViewTextBoxColumn.Name = "tourIDDataGridViewTextBoxColumn";
            this.tourIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tourIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tourNameDataGridViewTextBoxColumn
            // 
            this.tourNameDataGridViewTextBoxColumn.DataPropertyName = "TourName";
            this.tourNameDataGridViewTextBoxColumn.HeaderText = "TourName";
            this.tourNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tourNameDataGridViewTextBoxColumn.Name = "tourNameDataGridViewTextBoxColumn";
            this.tourNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // startPointCityIDDataGridViewTextBoxColumn
            // 
            this.startPointCityIDDataGridViewTextBoxColumn.DataPropertyName = "StartPointCityID";
            this.startPointCityIDDataGridViewTextBoxColumn.HeaderText = "StartPointCityID";
            this.startPointCityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startPointCityIDDataGridViewTextBoxColumn.Name = "startPointCityIDDataGridViewTextBoxColumn";
            this.startPointCityIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationCityIDDataGridViewTextBoxColumn
            // 
            this.destinationCityIDDataGridViewTextBoxColumn.DataPropertyName = "DestinationCityID";
            this.destinationCityIDDataGridViewTextBoxColumn.HeaderText = "DestinationCityID";
            this.destinationCityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationCityIDDataGridViewTextBoxColumn.Name = "destinationCityIDDataGridViewTextBoxColumn";
            this.destinationCityIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tourTypeIDDataGridViewTextBoxColumn
            // 
            this.tourTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TourTypeID";
            this.tourTypeIDDataGridViewTextBoxColumn.HeaderText = "TourTypeID";
            this.tourTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tourTypeIDDataGridViewTextBoxColumn.Name = "tourTypeIDDataGridViewTextBoxColumn";
            this.tourTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // guideIDDataGridViewTextBoxColumn
            // 
            this.guideIDDataGridViewTextBoxColumn.DataPropertyName = "GuideID";
            this.guideIDDataGridViewTextBoxColumn.HeaderText = "GuideID";
            this.guideIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.guideIDDataGridViewTextBoxColumn.Name = "guideIDDataGridViewTextBoxColumn";
            this.guideIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxParticipantsDataGridViewTextBoxColumn
            // 
            this.maxParticipantsDataGridViewTextBoxColumn.DataPropertyName = "MaxParticipants";
            this.maxParticipantsDataGridViewTextBoxColumn.HeaderText = "MaxParticipants";
            this.maxParticipantsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxParticipantsDataGridViewTextBoxColumn.Name = "maxParticipantsDataGridViewTextBoxColumn";
            this.maxParticipantsDataGridViewTextBoxColumn.Width = 125;
            // 
            // txtStartID
            // 
            this.txtStartID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtStartID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtStartID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStartID.Location = new System.Drawing.Point(3, 24);
            this.txtStartID.MaxLength = 5;
            this.txtStartID.Multiline = true;
            this.txtStartID.Name = "txtStartID";
            this.txtStartID.Size = new System.Drawing.Size(93, 27);
            this.txtStartID.TabIndex = 0;
            this.txtStartID.TabStop = false;
            this.txtStartID.WordWrap = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Controls.Add(this.txtStartID);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox6.Location = new System.Drawing.Point(431, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(99, 54);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "StartCityID";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox8.Controls.Add(this.txtDestinationID);
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox8.Location = new System.Drawing.Point(570, 17);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(109, 54);
            this.groupBox8.TabIndex = 33;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "DestinationID";
            // 
            // txtDestinationID
            // 
            this.txtDestinationID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDestinationID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestinationID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDestinationID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDestinationID.Location = new System.Drawing.Point(3, 24);
            this.txtDestinationID.MaxLength = 5;
            this.txtDestinationID.Multiline = true;
            this.txtDestinationID.Name = "txtDestinationID";
            this.txtDestinationID.Size = new System.Drawing.Size(103, 27);
            this.txtDestinationID.TabIndex = 0;
            this.txtDestinationID.TabStop = false;
            this.txtDestinationID.WordWrap = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(308, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 49);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DOGUM TARİHİ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 20);
            this.dateTimePicker1.MaxDate = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 27);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // AdminTourPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1350, 800);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminTourPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainPage";
            this.Load += new System.EventHandler(this.AdminTourPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourFlowManagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnSystemManagement;
        private System.Windows.Forms.Button btnTourManagement;
        private System.Windows.Forms.Button btnUserManagement;
        private TourFlowManagerDBDataSet tourFlowManagerDBDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private TourFlowManagerDBDataSetTableAdapters.tbl_UsersTableAdapter tbl_UsersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnEditTourPage;
        private System.Windows.Forms.Button btnDeletedTourType;
        private System.Windows.Forms.Button btnEditTourTypePage;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbRoleID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTourTypeID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.BindingSource tblToursBindingSource;
        private TourFlowManagerDBDataSetTableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPointCityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationCityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guideIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxParticipantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtDestinationID;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtStartID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}