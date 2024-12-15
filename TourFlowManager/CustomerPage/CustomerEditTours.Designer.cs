namespace TourAgent.CustomerPage
{
    partial class CustomerEditTours
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelectTour = new System.Windows.Forms.Button();
            this.btnEditTourPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tourFlowManagerDBDataSet = new TourAgent.TourFlowManagerDBDataSet();
            this.tblToursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ToursTableAdapter = new TourAgent.TourFlowManagerDBDataSetTableAdapters.tbl_ToursTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtDestinationID = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRoleID = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtStartID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTourTypeID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.btnTurdanÇik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourFlowManagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.btnSelectTour);
            this.panel2.Controls.Add(this.btnEditTourPage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 753);
            this.panel2.TabIndex = 21;
            // 
            // btnSelectTour
            // 
            this.btnSelectTour.BackColor = System.Drawing.Color.LightCyan;
            this.btnSelectTour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectTour.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSelectTour.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectTour.Image = global::TourAgent.Properties.Resources.editing;
            this.btnSelectTour.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectTour.Location = new System.Drawing.Point(12, 294);
            this.btnSelectTour.Name = "btnSelectTour";
            this.btnSelectTour.Size = new System.Drawing.Size(213, 103);
            this.btnSelectTour.TabIndex = 36;
            this.btnSelectTour.Text = "Tur Seç";
            this.btnSelectTour.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelectTour.UseVisualStyleBackColor = false;
            this.btnSelectTour.Click += new System.EventHandler(this.btnSelectTour_Click);
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
            this.btnEditTourPage.Location = new System.Drawing.Point(11, 455);
            this.btnEditTourPage.Name = "btnEditTourPage";
            this.btnEditTourPage.Size = new System.Drawing.Size(213, 103);
            this.btnEditTourPage.TabIndex = 35;
            this.btnEditTourPage.Text = "Turlarımı Düzenle";
            this.btnEditTourPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditTourPage.UseVisualStyleBackColor = false;
            this.btnEditTourPage.Click += new System.EventHandler(this.btnEditTourPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(26, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Yönetim Sayfası";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::TourAgent.Properties.Resources.software_engineer;
            this.pictureBox2.Location = new System.Drawing.Point(43, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 145);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 753);
            this.panel5.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(231, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 753);
            this.panel8.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.btnMainPage);
            this.panel6.Controls.Add(this.btnUserManagement);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(241, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1091, 122);
            this.panel6.TabIndex = 22;
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
            this.btnMainPage.Location = new System.Drawing.Point(85, 6);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(126, 101);
            this.btnMainPage.TabIndex = 31;
            this.btnMainPage.Text = "Ana Sayfa";
            this.btnMainPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainPage.UseVisualStyleBackColor = false;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
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
            this.btnUserManagement.Location = new System.Drawing.Point(251, 6);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(200, 104);
            this.btnUserManagement.TabIndex = 28;
            this.btnUserManagement.Text = "Kullanıcı Islemleri";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 112);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1091, 10);
            this.panel7.TabIndex = 15;
            // 
            // tourFlowManagerDBDataSet
            // 
            this.tourFlowManagerDBDataSet.DataSetName = "TourFlowManagerDBDataSet";
            this.tourFlowManagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(312, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 160);
            this.panel1.TabIndex = 41;
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
            this.dateTimePicker1.Enabled = false;
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
            this.txtDestinationID.ReadOnly = true;
            this.txtDestinationID.Size = new System.Drawing.Size(103, 27);
            this.txtDestinationID.TabIndex = 0;
            this.txtDestinationID.TabStop = false;
            this.txtDestinationID.WordWrap = false;
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
            this.dtBirthDate.Enabled = false;
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
            this.cbRoleID.Enabled = false;
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
            this.txtStartID.ReadOnly = true;
            this.txtStartID.Size = new System.Drawing.Size(93, 27);
            this.txtStartID.TabIndex = 0;
            this.txtStartID.TabStop = false;
            this.txtStartID.WordWrap = false;
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
            this.txtTourTypeID.ReadOnly = true;
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
            this.txtTourName.ReadOnly = true;
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
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(123, 26);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TabStop = false;
            this.txtPassword.WordWrap = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.tblToursBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(312, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(965, 260);
            this.dataGridView1.TabIndex = 40;
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
            // btnTurdanÇik
            // 
            this.btnTurdanÇik.BackColor = System.Drawing.Color.LightCyan;
            this.btnTurdanÇik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTurdanÇik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTurdanÇik.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTurdanÇik.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurdanÇik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTurdanÇik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTurdanÇik.Location = new System.Drawing.Point(608, 660);
            this.btnTurdanÇik.Name = "btnTurdanÇik";
            this.btnTurdanÇik.Size = new System.Drawing.Size(305, 43);
            this.btnTurdanÇik.TabIndex = 42;
            this.btnTurdanÇik.Text = "Seçili Turdan Çık";
            this.btnTurdanÇik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTurdanÇik.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(691, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Turlarımı Düzenle";
            // 
            // CustomerEditTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1332, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTurdanÇik);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "CustomerEditTours";
            this.Text = "CustomerEditTours";
            this.Load += new System.EventHandler(this.CustomerEditTours_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tourFlowManagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToursBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelectTour;
        private System.Windows.Forms.Button btnEditTourPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Panel panel7;
        private TourFlowManagerDBDataSet tourFlowManagerDBDataSet;
        private System.Windows.Forms.BindingSource tblToursBindingSource;
        private TourFlowManagerDBDataSetTableAdapters.tbl_ToursTableAdapter tbl_ToursTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtDestinationID;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbRoleID;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtStartID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTourTypeID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button btnTurdanÇik;
        private System.Windows.Forms.Label label1;
    }
}