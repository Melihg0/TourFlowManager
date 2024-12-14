namespace TourAgent.AdminPage.AdminSystemManagement
{
    partial class AdminDeletedTour
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditTourPage = new System.Windows.Forms.Button();
            this.btnDeletedTourType = new System.Windows.Forms.Button();
            this.btnEditTourTypePage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnSystemManagement = new System.Windows.Forms.Button();
            this.btnTourManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.tourFlowManagerDBDataSet = new TourAgent.TourFlowManagerDBDataSet();
            this.tbl_UsersTableAdapter = new TourAgent.TourFlowManagerDBDataSetTableAdapters.tbl_UsersTableAdapter();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViedfdwDeletedUsers = new System.Windows.Forms.DataGridView();
            this.deletedTourIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startPointCityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationCityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guideIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxParticipantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDeletedToursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DeletedToursTableAdapter = new TourAgent.TourFlowManagerDBDataSetTableAdapters.tbl_DeletedToursTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourFlowManagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViedfdwDeletedUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeletedToursBindingSource)).BeginInit();
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
            this.btnEditTourPage.Location = new System.Drawing.Point(11, 414);
            this.btnEditTourPage.Name = "btnEditTourPage";
            this.btnEditTourPage.Size = new System.Drawing.Size(213, 103);
            this.btnEditTourPage.TabIndex = 34;
            this.btnEditTourPage.Text = "Turları Düzenle";
            this.btnEditTourPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditTourPage.UseVisualStyleBackColor = false;
            this.btnEditTourPage.Click += new System.EventHandler(this.btnEditTourPage_Click);
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
            this.btnDeletedTourType.Location = new System.Drawing.Point(12, 574);
            this.btnDeletedTourType.Name = "btnDeletedTourType";
            this.btnDeletedTourType.Size = new System.Drawing.Size(213, 103);
            this.btnDeletedTourType.TabIndex = 33;
            this.btnDeletedTourType.Text = "Silinmis Turlar";
            this.btnDeletedTourType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletedTourType.UseVisualStyleBackColor = false;
            this.btnDeletedTourType.Click += new System.EventHandler(this.btnDeletedTourType_Click);
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
            this.btnEditTourTypePage.Location = new System.Drawing.Point(12, 254);
            this.btnEditTourTypePage.Name = "btnEditTourTypePage";
            this.btnEditTourTypePage.Size = new System.Drawing.Size(213, 103);
            this.btnEditTourTypePage.TabIndex = 32;
            this.btnEditTourTypePage.Text = "Tur Türlerini Düzenle";
            this.btnEditTourTypePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditTourTypePage.UseVisualStyleBackColor = false;
            this.btnEditTourTypePage.Click += new System.EventHandler(this.btnEditTourTypePage_Click);
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
            // tourFlowManagerDBDataSet
            // 
            this.tourFlowManagerDBDataSet.DataSetName = "TourFlowManagerDBDataSet";
            this.tourFlowManagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UsersTableAdapter
            // 
            this.tbl_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tbl_Users";
            // 
            // dataGridViedfdwDeletedUsers
            // 
            this.dataGridViedfdwDeletedUsers.AutoGenerateColumns = false;
            this.dataGridViedfdwDeletedUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViedfdwDeletedUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViedfdwDeletedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViedfdwDeletedUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deletedTourIDDataGridViewTextBoxColumn,
            this.deletedAtDataGridViewTextBoxColumn,
            this.tourNameDataGridViewTextBoxColumn,
            this.startPointCityIDDataGridViewTextBoxColumn,
            this.destinationCityIDDataGridViewTextBoxColumn,
            this.tourTypeIDDataGridViewTextBoxColumn,
            this.guideIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.maxParticipantsDataGridViewTextBoxColumn});
            this.dataGridViedfdwDeletedUsers.DataSource = this.tblDeletedToursBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViedfdwDeletedUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViedfdwDeletedUsers.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViedfdwDeletedUsers.Location = new System.Drawing.Point(272, 160);
            this.dataGridViedfdwDeletedUsers.Name = "dataGridViedfdwDeletedUsers";
            this.dataGridViedfdwDeletedUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViedfdwDeletedUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViedfdwDeletedUsers.RowTemplate.Height = 24;
            this.dataGridViedfdwDeletedUsers.Size = new System.Drawing.Size(1044, 524);
            this.dataGridViedfdwDeletedUsers.TabIndex = 37;
            // 
            // deletedTourIDDataGridViewTextBoxColumn
            // 
            this.deletedTourIDDataGridViewTextBoxColumn.DataPropertyName = "DeletedTourID";
            this.deletedTourIDDataGridViewTextBoxColumn.HeaderText = "DeletedTourID";
            this.deletedTourIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deletedTourIDDataGridViewTextBoxColumn.Name = "deletedTourIDDataGridViewTextBoxColumn";
            this.deletedTourIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // deletedAtDataGridViewTextBoxColumn
            // 
            this.deletedAtDataGridViewTextBoxColumn.DataPropertyName = "DeletedAt";
            this.deletedAtDataGridViewTextBoxColumn.HeaderText = "DeletedAt";
            this.deletedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deletedAtDataGridViewTextBoxColumn.Name = "deletedAtDataGridViewTextBoxColumn";
            this.deletedAtDataGridViewTextBoxColumn.Width = 125;
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
            // tblDeletedToursBindingSource
            // 
            this.tblDeletedToursBindingSource.DataMember = "tbl_DeletedTours";
            this.tblDeletedToursBindingSource.DataSource = this.tourFlowManagerDBDataSet;
            // 
            // tbl_DeletedToursTableAdapter
            // 
            this.tbl_DeletedToursTableAdapter.ClearBeforeFill = true;
            // 
            // AdminDeletedTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1350, 800);
            this.Controls.Add(this.dataGridViedfdwDeletedUsers);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminDeletedTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainPage";
            this.Load += new System.EventHandler(this.AdminDeletedTour_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tourFlowManagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViedfdwDeletedUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeletedToursBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnEditTourPage;
        private System.Windows.Forms.Button btnDeletedTourType;
        private System.Windows.Forms.Button btnEditTourTypePage;
        private TourFlowManagerDBDataSet tourFlowManagerDBDataSet;
        private TourFlowManagerDBDataSetTableAdapters.tbl_UsersTableAdapter tbl_UsersTableAdapter;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private System.Windows.Forms.DataGridView dataGridViedfdwDeletedUsers;
        private System.Windows.Forms.BindingSource tblDeletedToursBindingSource;
        private TourFlowManagerDBDataSetTableAdapters.tbl_DeletedToursTableAdapter tbl_DeletedToursTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedTourIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPointCityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationCityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guideIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxParticipantsDataGridViewTextBoxColumn;
    }
}