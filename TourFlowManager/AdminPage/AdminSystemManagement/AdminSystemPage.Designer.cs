namespace TourAgent.AdminPage.AdminSystemManagement
{
    partial class AdminSystemPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourFlowManagerDBDataSet = new TourAgent.TourFlowManagerDBDataSet();
            this.tbl_UsersTableAdapter = new TourAgent.TourFlowManagerDBDataSetTableAdapters.tbl_UsersTableAdapter();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbox_import = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.dataGridViewExport = new System.Windows.Forms.DataGridView();
            this.dataGridViewImport = new System.Windows.Forms.DataGridView();
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourFlowManagerDBDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
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
            this.panel7.Size = new System.Drawing.Size(1209, 10);
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
            this.panel6.Size = new System.Drawing.Size(1209, 122);
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
            this.btnMainPage.Location = new System.Drawing.Point(66, 5);
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
            this.btnSystemManagement.Location = new System.Drawing.Point(893, 2);
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
            this.btnTourManagement.Location = new System.Drawing.Point(598, 2);
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
            this.btnUserManagement.Location = new System.Drawing.Point(290, 2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(200, 104);
            this.btnUserManagement.TabIndex = 28;
            this.btnUserManagement.Text = "Kullanıcı Islemleri";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
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
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Linen;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRestore.Location = new System.Drawing.Point(732, 757);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(167, 38);
            this.btnRestore.TabIndex = 37;
            this.btnRestore.Text = "Yedekten Geri Al";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(396, 764);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Yedekten Geri Dönmek İçin Tıkla:";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Linen;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackup.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBackup.Location = new System.Drawing.Point(732, 699);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(167, 38);
            this.btnBackup.TabIndex = 35;
            this.btnBackup.Text = "Yedekle";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(396, 706);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Veri Tabanını Yedeklemek İçin Tıkla:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(894, 648);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 48);
            this.label5.TabIndex = 33;
            this.label5.Text = "Hangi Tabloya \r\nAktarmak İstersiniz";
            // 
            // cmbox_import
            // 
            this.cmbox_import.FormattingEnabled = true;
            this.cmbox_import.Items.AddRange(new object[] {
            "tbl_Bookings",
            "tbl_Cities",
            "tbl_Tours",
            "tbl_Users"});
            this.cmbox_import.Location = new System.Drawing.Point(1159, 648);
            this.cmbox_import.Name = "cmbox_import";
            this.cmbox_import.Size = new System.Drawing.Size(245, 36);
            this.cmbox_import.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(1084, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 27);
            this.label4.TabIndex = 31;
            this.label4.Text = "İCERİ AKTARMA";
            // 
            // txt_FileName
            // 
            this.txt_FileName.Location = new System.Drawing.Point(1159, 580);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(245, 34);
            this.txt_FileName.TabIndex = 30;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Linen;
            this.btnImport.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImport.Location = new System.Drawing.Point(1201, 712);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(170, 40);
            this.btnImport.TabIndex = 29;
            this.btnImport.Text = "İceri Aktar";
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrowse.Location = new System.Drawing.Point(1410, 580);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(39, 32);
            this.btnBrowse.TabIndex = 28;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(894, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 48);
            this.label3.TabIndex = 27;
            this.label3.Text = "İçeri Aktarmak İstediğiniz \r\nDosyayı Seçin\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(420, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "DISARI AKTARMA";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Linen;
            this.btnExport.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExport.Location = new System.Drawing.Point(671, 627);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 38);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "Dışarı Aktar";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.cbTable);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(271, 545);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 67);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dısarı Aktarmak İstediginiz Tabloyu Seciniz";
            // 
            // cbTable
            // 
            this.cbTable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(0, 35);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(371, 31);
            this.cbTable.TabIndex = 0;
            // 
            // dataGridViewExport
            // 
            this.dataGridViewExport.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExport.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewExport.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewExport.Location = new System.Drawing.Point(272, 189);
            this.dataGridViewExport.Name = "dataGridViewExport";
            this.dataGridViewExport.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewExport.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewExport.RowTemplate.Height = 24;
            this.dataGridViewExport.Size = new System.Drawing.Size(518, 334);
            this.dataGridViewExport.TabIndex = 39;
            // 
            // dataGridViewImport
            // 
            this.dataGridViewImport.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImport.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewImport.GridColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewImport.Location = new System.Drawing.Point(898, 189);
            this.dataGridViewImport.Name = "dataGridViewImport";
            this.dataGridViewImport.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewImport.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewImport.RowTemplate.Height = 24;
            this.dataGridViewImport.Size = new System.Drawing.Size(518, 334);
            this.dataGridViewImport.TabIndex = 40;
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.BackColor = System.Drawing.Color.Linen;
            this.btnLoadTable.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoadTable.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadTable.Location = new System.Drawing.Point(679, 545);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(99, 66);
            this.btnLoadTable.TabIndex = 41;
            this.btnLoadTable.Text = "Tabloda Goster";
            this.btnLoadTable.UseVisualStyleBackColor = false;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // AdminSystemPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.btnLoadTable);
            this.Controls.Add(this.dataGridViewImport);
            this.Controls.Add(this.dataGridViewExport);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbox_import);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminSystemPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourFlowManagerDBDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbox_import;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.DataGridView dataGridViewExport;
        private System.Windows.Forms.DataGridView dataGridViewImport;
        private System.Windows.Forms.Button btnLoadTable;
    }
}