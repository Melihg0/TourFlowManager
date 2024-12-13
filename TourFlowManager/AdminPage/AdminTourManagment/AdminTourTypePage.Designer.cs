namespace TourAgent.AdminPage.AdminTourManagment
{
    partial class AdminTourTypePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridViewTourTypes = new System.Windows.Forms.DataGridView();
            this.tourTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTourTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourFlowManagerDBDataSet = new TourAgent.TourFlowManagerDBDataSet();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_UsersTableAdapter = new TourAgent.TourFlowManagerDBDataSetTableAdapters.tbl_UsersTableAdapter();
            this.tbl_TourTypesTableAdapter = new TourAgent.TourFlowManagerDBDataSetTableAdapters.tbl_TourTypesTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.txtDescriptionSDSD = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTypeNamASDASD = new System.Windows.Forms.GroupBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.btnAddTourType = new System.Windows.Forms.Button();
            this.btnEditTourType = new System.Windows.Forms.Button();
            this.btnDeleteTourType = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnSystemManagement = new System.Windows.Forms.Button();
            this.btnTourManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnEditTourPage = new System.Windows.Forms.Button();
            this.btnDeletedTourType = new System.Windows.Forms.Button();
            this.btnEditTourTypePage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTourTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourFlowManagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.txtDescriptionSDSD.SuspendLayout();
            this.txtTypeNamASDASD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // dataGridViewTourTypes
            // 
            this.dataGridViewTourTypes.AutoGenerateColumns = false;
            this.dataGridViewTourTypes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTourTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTourTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTourTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tourTypeIDDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewTourTypes.DataSource = this.tblTourTypesBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTourTypes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTourTypes.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewTourTypes.Location = new System.Drawing.Point(267, 148);
            this.dataGridViewTourTypes.Name = "dataGridViewTourTypes";
            this.dataGridViewTourTypes.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTourTypes.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTourTypes.RowTemplate.Height = 24;
            this.dataGridViewTourTypes.Size = new System.Drawing.Size(1036, 317);
            this.dataGridViewTourTypes.TabIndex = 36;
            this.dataGridViewTourTypes.SelectionChanged += new System.EventHandler(this.dataGridViewTourTypes_SelectionChanged);
            // 
            // tourTypeIDDataGridViewTextBoxColumn
            // 
            this.tourTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TourTypeID";
            this.tourTypeIDDataGridViewTextBoxColumn.HeaderText = "TourTypeID";
            this.tourTypeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tourTypeIDDataGridViewTextBoxColumn.Name = "tourTypeIDDataGridViewTextBoxColumn";
            this.tourTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tourTypeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 750;
            // 
            // tblTourTypesBindingSource
            // 
            this.tblTourTypesBindingSource.DataMember = "tbl_TourTypes";
            this.tblTourTypesBindingSource.DataSource = this.tourFlowManagerDBDataSet;
            // 
            // tourFlowManagerDBDataSet
            // 
            this.tourFlowManagerDBDataSet.DataSetName = "TourFlowManagerDBDataSet";
            this.tourFlowManagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tbl_Users";
            this.tblUsersBindingSource.DataSource = this.tourFlowManagerDBDataSet;
            // 
            // tbl_UsersTableAdapter
            // 
            this.tbl_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_TourTypesTableAdapter
            // 
            this.tbl_TourTypesTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.txtDescriptionSDSD);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtTypeNamASDASD);
            this.panel2.Location = new System.Drawing.Point(302, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 160);
            this.panel2.TabIndex = 39;
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
            // txtDescriptionSDSD
            // 
            this.txtDescriptionSDSD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDescriptionSDSD.Controls.Add(this.txtDescription);
            this.txtDescriptionSDSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDescriptionSDSD.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescriptionSDSD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtDescriptionSDSD.Location = new System.Drawing.Point(258, 21);
            this.txtDescriptionSDSD.Name = "txtDescriptionSDSD";
            this.txtDescriptionSDSD.Size = new System.Drawing.Size(685, 99);
            this.txtDescriptionSDSD.TabIndex = 18;
            this.txtDescriptionSDSD.TabStop = false;
            this.txtDescriptionSDSD.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(3, 25);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(679, 71);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.TabStop = false;
            this.txtDescription.WordWrap = false;
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
            // txtTypeNamASDASD
            // 
            this.txtTypeNamASDASD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTypeNamASDASD.Controls.Add(this.txtTypeName);
            this.txtTypeNamASDASD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTypeNamASDASD.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTypeNamASDASD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtTypeNamASDASD.Location = new System.Drawing.Point(19, 46);
            this.txtTypeNamASDASD.Name = "txtTypeNamASDASD";
            this.txtTypeNamASDASD.Size = new System.Drawing.Size(212, 49);
            this.txtTypeNamASDASD.TabIndex = 17;
            this.txtTypeNamASDASD.TabStop = false;
            this.txtTypeNamASDASD.Text = "TypeName";
            // 
            // txtTypeName
            // 
            this.txtTypeName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTypeName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTypeName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTypeName.Location = new System.Drawing.Point(3, 19);
            this.txtTypeName.MaxLength = 100;
            this.txtTypeName.Multiline = true;
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(206, 27);
            this.txtTypeName.TabIndex = 0;
            this.txtTypeName.TabStop = false;
            this.txtTypeName.WordWrap = false;
            // 
            // btnAddTourType
            // 
            this.btnAddTourType.BackColor = System.Drawing.Color.Green;
            this.btnAddTourType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddTourType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTourType.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddTourType.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTourType.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddTourType.Location = new System.Drawing.Point(347, 682);
            this.btnAddTourType.Name = "btnAddTourType";
            this.btnAddTourType.Size = new System.Drawing.Size(236, 63);
            this.btnAddTourType.TabIndex = 42;
            this.btnAddTourType.Text = "Tur Türü Ekle";
            this.btnAddTourType.UseVisualStyleBackColor = false;
            this.btnAddTourType.Click += new System.EventHandler(this.btnAddTourType_Click);
            // 
            // btnEditTourType
            // 
            this.btnEditTourType.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditTourType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditTourType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTourType.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditTourType.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTourType.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditTourType.Location = new System.Drawing.Point(656, 682);
            this.btnEditTourType.Name = "btnEditTourType";
            this.btnEditTourType.Size = new System.Drawing.Size(236, 63);
            this.btnEditTourType.TabIndex = 41;
            this.btnEditTourType.Text = "Tur Türü Düzenle";
            this.btnEditTourType.UseVisualStyleBackColor = false;
            this.btnEditTourType.Click += new System.EventHandler(this.btnEditTourType_Click);
            // 
            // btnDeleteTourType
            // 
            this.btnDeleteTourType.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTourType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteTourType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTourType.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteTourType.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTourType.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteTourType.Location = new System.Drawing.Point(966, 682);
            this.btnDeleteTourType.Name = "btnDeleteTourType";
            this.btnDeleteTourType.Size = new System.Drawing.Size(236, 63);
            this.btnDeleteTourType.TabIndex = 40;
            this.btnDeleteTourType.Text = "Tur Türü Sil";
            this.btnDeleteTourType.UseVisualStyleBackColor = false;
            this.btnDeleteTourType.Click += new System.EventHandler(this.btnDeleteTourType_Click);
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
            this.btnEditTourPage.Location = new System.Drawing.Point(11, 422);
            this.btnEditTourPage.Name = "btnEditTourPage";
            this.btnEditTourPage.Size = new System.Drawing.Size(213, 103);
            this.btnEditTourPage.TabIndex = 31;
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
            this.btnDeletedTourType.Location = new System.Drawing.Point(12, 582);
            this.btnDeletedTourType.Name = "btnDeletedTourType";
            this.btnDeletedTourType.Size = new System.Drawing.Size(213, 103);
            this.btnDeletedTourType.TabIndex = 30;
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
            this.btnEditTourTypePage.Location = new System.Drawing.Point(12, 262);
            this.btnEditTourTypePage.Name = "btnEditTourTypePage";
            this.btnEditTourTypePage.Size = new System.Drawing.Size(213, 103);
            this.btnEditTourTypePage.TabIndex = 29;
            this.btnEditTourTypePage.Text = "Tur Türlerini Düzenle";
            this.btnEditTourTypePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditTourTypePage.UseVisualStyleBackColor = false;
            this.btnEditTourTypePage.Click += new System.EventHandler(this.btnEditTourTypePage_Click);
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
            // AdminTourTypePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1350, 800);
            this.Controls.Add(this.btnAddTourType);
            this.Controls.Add(this.btnEditTourType);
            this.Controls.Add(this.btnDeleteTourType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewTourTypes);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminTourTypePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainPage";
            this.Load += new System.EventHandler(this.AdminTourTypePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTourTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourFlowManagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.txtDescriptionSDSD.ResumeLayout(false);
            this.txtDescriptionSDSD.PerformLayout();
            this.txtTypeNamASDASD.ResumeLayout(false);
            this.txtTypeNamASDASD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnEditTourTypePage;
        private System.Windows.Forms.Button btnDeletedTourType;
        private System.Windows.Forms.DataGridView dataGridViewTourTypes;
        private TourFlowManagerDBDataSet tourFlowManagerDBDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private TourFlowManagerDBDataSetTableAdapters.tbl_UsersTableAdapter tbl_UsersTableAdapter;
        private System.Windows.Forms.BindingSource tblTourTypesBindingSource;
        private TourFlowManagerDBDataSetTableAdapters.tbl_TourTypesTableAdapter tbl_TourTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox txtDescriptionSDSD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox txtTypeNamASDASD;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Button btnAddTourType;
        private System.Windows.Forms.Button btnEditTourType;
        private System.Windows.Forms.Button btnDeleteTourType;
        private System.Windows.Forms.Button btnEditTourPage;
        private System.Windows.Forms.TextBox txtDescription;
    }
}