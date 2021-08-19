namespace Assignment2Desktop
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StaffProfile = new System.Windows.Forms.ToolStripButton();
            this.StudentMarks = new System.Windows.Forms.ToolStripButton();
            this.ADD_CrseBtn = new System.Windows.Forms.ToolStripButton();
            this.Logout = new System.Windows.Forms.ToolStripButton();
            this.StaffPrfPnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CntNmb = new System.Windows.Forms.TextBox();
            this.Addrs = new System.Windows.Forms.TextBox();
            this.StffNme = new System.Windows.Forms.TextBox();
            this.StudntMrksPnl = new System.Windows.Forms.Panel();
            this.Hour = new System.Windows.Forms.TextBox();
            this.Hours = new System.Windows.Forms.Label();
            this.CRDTS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CRSEID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Grd = new System.Windows.Forms.TextBox();
            this.Mrks = new System.Windows.Forms.TextBox();
            this.StdID = new System.Windows.Forms.TextBox();
            this.StdNmeTxt = new System.Windows.Forms.TextBox();
            this.PgmNmeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CrseNameTxt = new System.Windows.Forms.TextBox();
            this.StdIdtxt = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UPDT = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.New_Insrt = new System.Windows.Forms.Button();
            this.FEE = new System.Windows.Forms.TextBox();
            this.HRS = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.CRD = new System.Windows.Forms.TextBox();
            this.CRSN = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.PGM = new System.Windows.Forms.TextBox();
            this.CRS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.sTAFFCOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentDataSet = new Assignment2Desktop.AssignmentDataSet();
            this.toolStrip1.SuspendLayout();
            this.StaffPrfPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.StudntMrksPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFCOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaffProfile,
            this.StudentMarks,
            this.ADD_CrseBtn,
            this.Logout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1201, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StaffProfile
            // 
            this.StaffProfile.Image = ((System.Drawing.Image)(resources.GetObject("StaffProfile.Image")));
            this.StaffProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StaffProfile.Name = "StaffProfile";
            this.StaffProfile.Size = new System.Drawing.Size(107, 24);
            this.StaffProfile.Text = "StaffProfile";
            this.StaffProfile.Click += new System.EventHandler(this.StaffProfile_Click);
            // 
            // StudentMarks
            // 
            this.StudentMarks.Image = ((System.Drawing.Image)(resources.GetObject("StudentMarks.Image")));
            this.StudentMarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StudentMarks.Name = "StudentMarks";
            this.StudentMarks.Size = new System.Drawing.Size(123, 24);
            this.StudentMarks.Text = "StudentMarks";
            this.StudentMarks.Click += new System.EventHandler(this.StudentMarks_Click);
            // 
            // ADD_CrseBtn
            // 
            this.ADD_CrseBtn.Image = ((System.Drawing.Image)(resources.GetObject("ADD_CrseBtn.Image")));
            this.ADD_CrseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ADD_CrseBtn.Name = "ADD_CrseBtn";
            this.ADD_CrseBtn.Size = new System.Drawing.Size(136, 24);
            this.ADD_CrseBtn.Text = "AddNewCourse";
            this.ADD_CrseBtn.Click += new System.EventHandler(this.ADD_CrseBtn_Click);
            // 
            // Logout
            // 
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(80, 24);
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // StaffPrfPnl
            // 
            this.StaffPrfPnl.Controls.Add(this.pictureBox1);
            this.StaffPrfPnl.Controls.Add(this.button1);
            this.StaffPrfPnl.Controls.Add(this.dataGridView1);
            this.StaffPrfPnl.Controls.Add(this.label4);
            this.StaffPrfPnl.Controls.Add(this.label2);
            this.StaffPrfPnl.Controls.Add(this.label1);
            this.StaffPrfPnl.Controls.Add(this.CntNmb);
            this.StaffPrfPnl.Controls.Add(this.Addrs);
            this.StaffPrfPnl.Controls.Add(this.StffNme);
            this.StaffPrfPnl.Location = new System.Drawing.Point(9, 46);
            this.StaffPrfPnl.Name = "StaffPrfPnl";
            this.StaffPrfPnl.Size = new System.Drawing.Size(1170, 595);
            this.StaffPrfPnl.TabIndex = 1;
            this.StaffPrfPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.StaffPrfPnl_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button1.Location = new System.Drawing.Point(119, 501);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 39);
            this.button1.TabIndex = 23;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(449, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(718, 248);
            this.dataGridView1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "ContactNumber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "StaffName";
            // 
            // CntNmb
            // 
            this.CntNmb.Location = new System.Drawing.Point(195, 453);
            this.CntNmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CntNmb.Name = "CntNmb";
            this.CntNmb.Size = new System.Drawing.Size(234, 22);
            this.CntNmb.TabIndex = 18;
            // 
            // Addrs
            // 
            this.Addrs.Location = new System.Drawing.Point(195, 319);
            this.Addrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addrs.Multiline = true;
            this.Addrs.Name = "Addrs";
            this.Addrs.Size = new System.Drawing.Size(234, 107);
            this.Addrs.TabIndex = 17;
            // 
            // StffNme
            // 
            this.StffNme.Location = new System.Drawing.Point(195, 263);
            this.StffNme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StffNme.Name = "StffNme";
            this.StffNme.Size = new System.Drawing.Size(234, 22);
            this.StffNme.TabIndex = 16;
            // 
            // StudntMrksPnl
            // 
            this.StudntMrksPnl.Controls.Add(this.Hour);
            this.StudntMrksPnl.Controls.Add(this.Hours);
            this.StudntMrksPnl.Controls.Add(this.CRDTS);
            this.StudntMrksPnl.Controls.Add(this.label13);
            this.StudntMrksPnl.Controls.Add(this.CRSEID);
            this.StudntMrksPnl.Controls.Add(this.label12);
            this.StudntMrksPnl.Controls.Add(this.comboBox1);
            this.StudntMrksPnl.Controls.Add(this.label9);
            this.StudntMrksPnl.Controls.Add(this.Update);
            this.StudntMrksPnl.Controls.Add(this.Insert);
            this.StudntMrksPnl.Controls.Add(this.label8);
            this.StudntMrksPnl.Controls.Add(this.label7);
            this.StudntMrksPnl.Controls.Add(this.label6);
            this.StudntMrksPnl.Controls.Add(this.Grd);
            this.StudntMrksPnl.Controls.Add(this.Mrks);
            this.StudntMrksPnl.Controls.Add(this.StdID);
            this.StudntMrksPnl.Controls.Add(this.StdNmeTxt);
            this.StudntMrksPnl.Controls.Add(this.PgmNmeTxt);
            this.StudntMrksPnl.Controls.Add(this.label5);
            this.StudntMrksPnl.Controls.Add(this.label3);
            this.StudntMrksPnl.Controls.Add(this.label10);
            this.StudntMrksPnl.Controls.Add(this.label11);
            this.StudntMrksPnl.Controls.Add(this.CrseNameTxt);
            this.StudntMrksPnl.Controls.Add(this.StdIdtxt);
            this.StudntMrksPnl.Controls.Add(this.dataGridView2);
            this.StudntMrksPnl.Location = new System.Drawing.Point(9, 46);
            this.StudntMrksPnl.Name = "StudntMrksPnl";
            this.StudntMrksPnl.Size = new System.Drawing.Size(1170, 634);
            this.StudntMrksPnl.TabIndex = 25;
            this.StudntMrksPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.StudntMrksPnl_Paint);
            // 
            // Hour
            // 
            this.Hour.Location = new System.Drawing.Point(796, 165);
            this.Hour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(160, 22);
            this.Hour.TabIndex = 56;
            this.Hour.TextChanged += new System.EventHandler(this.Hour_TextChanged);
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours.Location = new System.Drawing.Point(671, 165);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(51, 17);
            this.Hours.TabIndex = 55;
            this.Hours.Text = "Hours";
            // 
            // CRDTS
            // 
            this.CRDTS.Location = new System.Drawing.Point(449, 165);
            this.CRDTS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CRDTS.Name = "CRDTS";
            this.CRDTS.Size = new System.Drawing.Size(160, 22);
            this.CRDTS.TabIndex = 54;
            this.CRDTS.TextChanged += new System.EventHandler(this.CRDTS_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(324, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Credits";
            // 
            // CRSEID
            // 
            this.CRSEID.Location = new System.Drawing.Point(139, 165);
            this.CRSEID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CRSEID.Name = "CRSEID";
            this.CRSEID.Size = new System.Drawing.Size(160, 22);
            this.CRSEID.TabIndex = 52;
            this.CRSEID.TextChanged += new System.EventHandler(this.CRSEID_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "CourseID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 275);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "CourseID";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Lime;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(208, 440);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(116, 35);
            this.Update.TabIndex = 45;
            this.Update.Text = "UPDATE";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.Color.White;
            this.Insert.Location = new System.Drawing.Point(23, 440);
            this.Insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(116, 35);
            this.Insert.TabIndex = 44;
            this.Insert.Text = "INSERT";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Grade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Marks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "StudentID";
            // 
            // Grd
            // 
            this.Grd.Location = new System.Drawing.Point(156, 385);
            this.Grd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grd.Name = "Grd";
            this.Grd.Size = new System.Drawing.Size(89, 22);
            this.Grd.TabIndex = 40;
            // 
            // Mrks
            // 
            this.Mrks.Location = new System.Drawing.Point(156, 324);
            this.Mrks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mrks.Name = "Mrks";
            this.Mrks.Size = new System.Drawing.Size(89, 22);
            this.Mrks.TabIndex = 39;
            // 
            // StdID
            // 
            this.StdID.Location = new System.Drawing.Point(156, 225);
            this.StdID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StdID.Name = "StdID";
            this.StdID.Size = new System.Drawing.Size(89, 22);
            this.StdID.TabIndex = 38;
            // 
            // StdNmeTxt
            // 
            this.StdNmeTxt.Location = new System.Drawing.Point(855, 108);
            this.StdNmeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StdNmeTxt.Name = "StdNmeTxt";
            this.StdNmeTxt.Size = new System.Drawing.Size(160, 22);
            this.StdNmeTxt.TabIndex = 37;
            this.StdNmeTxt.TextChanged += new System.EventHandler(this.StdNmeTxt_TextChanged);
            // 
            // PgmNmeTxt
            // 
            this.PgmNmeTxt.Location = new System.Drawing.Point(628, 107);
            this.PgmNmeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PgmNmeTxt.Name = "PgmNmeTxt";
            this.PgmNmeTxt.Size = new System.Drawing.Size(89, 22);
            this.PgmNmeTxt.TabIndex = 36;
            this.PgmNmeTxt.TextChanged += new System.EventHandler(this.PgmNmeTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(722, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "StudentName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "ProgrammeName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(238, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "CouseName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "StudentID";
            // 
            // CrseNameTxt
            // 
            this.CrseNameTxt.Location = new System.Drawing.Point(353, 106);
            this.CrseNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CrseNameTxt.Name = "CrseNameTxt";
            this.CrseNameTxt.Size = new System.Drawing.Size(112, 22);
            this.CrseNameTxt.TabIndex = 31;
            this.CrseNameTxt.TextChanged += new System.EventHandler(this.CrseNameTxt_TextChanged);
            // 
            // StdIdtxt
            // 
            this.StdIdtxt.Location = new System.Drawing.Point(119, 104);
            this.StdIdtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StdIdtxt.Name = "StdIdtxt";
            this.StdIdtxt.Size = new System.Drawing.Size(106, 22);
            this.StdIdtxt.TabIndex = 30;
            this.StdIdtxt.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(412, 225);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(733, 224);
            this.dataGridView2.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UPDT);
            this.panel1.Controls.Add(this.dataGridView4);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.New_Insrt);
            this.panel1.Controls.Add(this.FEE);
            this.panel1.Controls.Add(this.HRS);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.CRD);
            this.panel1.Controls.Add(this.CRSN);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.PGM);
            this.panel1.Controls.Add(this.CRS);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(9, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 649);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UPDT
            // 
            this.UPDT.BackColor = System.Drawing.Color.Lime;
            this.UPDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDT.ForeColor = System.Drawing.Color.White;
            this.UPDT.Location = new System.Drawing.Point(208, 426);
            this.UPDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UPDT.Name = "UPDT";
            this.UPDT.Size = new System.Drawing.Size(116, 35);
            this.UPDT.TabIndex = 64;
            this.UPDT.Text = "UPDATE";
            this.UPDT.UseVisualStyleBackColor = false;
            this.UPDT.Click += new System.EventHandler(this.UPDT_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(476, 330);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(350, 276);
            this.dataGridView4.TabIndex = 63;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            this.dataGridView4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView4_MouseClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(476, 18);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(696, 306);
            this.dataGridView3.TabIndex = 62;
            this.dataGridView3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView3_MouseClick);
            // 
            // New_Insrt
            // 
            this.New_Insrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.New_Insrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Insrt.ForeColor = System.Drawing.Color.White;
            this.New_Insrt.Location = new System.Drawing.Point(46, 431);
            this.New_Insrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.New_Insrt.Name = "New_Insrt";
            this.New_Insrt.Size = new System.Drawing.Size(116, 35);
            this.New_Insrt.TabIndex = 61;
            this.New_Insrt.Text = "INSERT";
            this.New_Insrt.UseVisualStyleBackColor = false;
            this.New_Insrt.Click += new System.EventHandler(this.New_Insrt_Click);
            // 
            // FEE
            // 
            this.FEE.Location = new System.Drawing.Point(208, 334);
            this.FEE.Name = "FEE";
            this.FEE.Size = new System.Drawing.Size(100, 22);
            this.FEE.TabIndex = 59;
            // 
            // HRS
            // 
            this.HRS.Location = new System.Drawing.Point(208, 295);
            this.HRS.Name = "HRS";
            this.HRS.Size = new System.Drawing.Size(100, 22);
            this.HRS.TabIndex = 58;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(68, 344);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 17);
            this.label21.TabIndex = 57;
            this.label21.Text = "Fees";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(68, 296);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 17);
            this.label20.TabIndex = 56;
            this.label20.Text = "Hours";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(68, 249);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 17);
            this.label19.TabIndex = 55;
            this.label19.Text = "Credits";
            // 
            // CRD
            // 
            this.CRD.Location = new System.Drawing.Point(208, 238);
            this.CRD.Name = "CRD";
            this.CRD.Size = new System.Drawing.Size(100, 22);
            this.CRD.TabIndex = 54;
            // 
            // CRSN
            // 
            this.CRSN.Location = new System.Drawing.Point(208, 197);
            this.CRSN.Name = "CRSN";
            this.CRSN.Size = new System.Drawing.Size(172, 22);
            this.CRSN.TabIndex = 53;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(68, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 17);
            this.label18.TabIndex = 52;
            this.label18.Text = "ProgrammeID";
            // 
            // PGM
            // 
            this.PGM.Location = new System.Drawing.Point(208, 95);
            this.PGM.Name = "PGM";
            this.PGM.Size = new System.Drawing.Size(100, 22);
            this.PGM.TabIndex = 50;
            // 
            // CRS
            // 
            this.CRS.Location = new System.Drawing.Point(208, 153);
            this.CRS.Name = "CRS";
            this.CRS.Size = new System.Drawing.Size(100, 22);
            this.CRS.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(68, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 48;
            this.label15.Text = "CourseID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(68, 197);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 17);
            this.label16.TabIndex = 47;
            this.label16.Text = "CouseName";
            // 
            // sTAFFCOURSEBindingSource
            // 
            this.sTAFFCOURSEBindingSource.DataMember = "STAFF_COURSE";
            this.sTAFFCOURSEBindingSource.DataSource = this.assignmentDataSet;
            // 
            // assignmentDataSet
            // 
            this.assignmentDataSet.DataSetName = "AssignmentDataSet";
            this.assignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 680);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.StudntMrksPnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StaffPrfPnl);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.StaffPrfPnl.ResumeLayout(false);
            this.StaffPrfPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.StudntMrksPnl.ResumeLayout(false);
            this.StudntMrksPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFCOURSEBindingSource)).EndInit();
       //     ((System.ComponentModel.ISupportInitialize)(this.assignmentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StaffProfile;
        private System.Windows.Forms.ToolStripButton StudentMarks;
        private System.Windows.Forms.Panel StaffPrfPnl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CntNmb;
        private System.Windows.Forms.TextBox Addrs;
        private System.Windows.Forms.TextBox StffNme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel StudntMrksPnl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Grd;
        private System.Windows.Forms.TextBox Mrks;
        private System.Windows.Forms.TextBox StdID;
        private System.Windows.Forms.TextBox StdNmeTxt;
        private System.Windows.Forms.TextBox PgmNmeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CrseNameTxt;
        private System.Windows.Forms.TextBox StdIdtxt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripButton Logout;
        private AssignmentDataSet assignmentDataSet;
        private System.Windows.Forms.BindingSource sTAFFCOURSEBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FEE;
        private System.Windows.Forms.TextBox HRS;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox CRD;
        private System.Windows.Forms.TextBox CRSN;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox PGM;
        private System.Windows.Forms.TextBox CRS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripButton ADD_CrseBtn;
        private System.Windows.Forms.Button New_Insrt;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox CRDTS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CRSEID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Hour;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.Button UPDT;
    }
}