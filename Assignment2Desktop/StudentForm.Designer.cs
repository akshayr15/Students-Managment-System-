namespace Assignment2Desktop
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.FAV_BTN = new System.Windows.Forms.ToolStripButton();
            this.Logout = new System.Windows.Forms.ToolStripButton();
            this.StudentPrflPnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UPDATE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StudentMrksPnl = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.CrsePnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FAV_PNL = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.StudentPrflPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.StudentMrksPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.CrsePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.FAV_PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.FAV_BTN,
            this.Logout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1197, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(96, 24);
            this.toolStripButton1.Text = "MyProfile";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(79, 24);
            this.toolStripButton2.Text = "Grades";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(78, 24);
            this.toolStripButton3.Text = "Course";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // FAV_BTN
            // 
            this.FAV_BTN.Image = ((System.Drawing.Image)(resources.GetObject("FAV_BTN.Image")));
            this.FAV_BTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FAV_BTN.Name = "FAV_BTN";
            this.FAV_BTN.Size = new System.Drawing.Size(99, 24);
            this.FAV_BTN.Text = "Favourites";
            this.FAV_BTN.Click += new System.EventHandler(this.FAV_BTN_Click);
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
            // StudentPrflPnl
            // 
            this.StudentPrflPnl.Controls.Add(this.pictureBox1);
            this.StudentPrflPnl.Controls.Add(this.dataGridView1);
            this.StudentPrflPnl.Controls.Add(this.UPDATE);
            this.StudentPrflPnl.Controls.Add(this.label1);
            this.StudentPrflPnl.Controls.Add(this.label3);
            this.StudentPrflPnl.Controls.Add(this.label2);
            this.StudentPrflPnl.Controls.Add(this.StudentID);
            this.StudentPrflPnl.Controls.Add(this.textBox2);
            this.StudentPrflPnl.Controls.Add(this.textBox3);
            this.StudentPrflPnl.Controls.Add(this.textBox1);
            this.StudentPrflPnl.Location = new System.Drawing.Point(12, 42);
            this.StudentPrflPnl.Name = "StudentPrflPnl";
            this.StudentPrflPnl.Size = new System.Drawing.Size(1173, 601);
            this.StudentPrflPnl.TabIndex = 1;
            this.StudentPrflPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentPrflPnl_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(560, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(579, 364);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.Orange;
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.ForeColor = System.Drawing.Color.White;
            this.UPDATE.Location = new System.Drawing.Point(727, 130);
            this.UPDATE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(243, 48);
            this.UPDATE.TabIndex = 34;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(557, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "STUDENT PROFILE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 529);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "PhoneNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Address";
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(42, 345);
            this.StudentID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(94, 17);
            this.StudentID.TabIndex = 30;
            this.StudentID.Text = "StudentName";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(255, 398);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 123);
            this.textBox2.TabIndex = 29;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(255, 529);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 22);
            this.textBox3.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 339);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 22);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StudentMrksPnl
            // 
            this.StudentMrksPnl.Controls.Add(this.dataGridView2);
            this.StudentMrksPnl.Controls.Add(this.label4);
            this.StudentMrksPnl.Location = new System.Drawing.Point(12, 42);
            this.StudentMrksPnl.Name = "StudentMrksPnl";
            this.StudentMrksPnl.Size = new System.Drawing.Size(1170, 587);
            this.StudentMrksPnl.TabIndex = 36;
            this.StudentMrksPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentMrksPnl_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(255, 130);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(626, 246);
            this.dataGridView2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "STUDENT MARKS ";
            // 
            // CrsePnl
            // 
            this.CrsePnl.Controls.Add(this.button1);
            this.CrsePnl.Controls.Add(this.dataGridView3);
            this.CrsePnl.Controls.Add(this.label6);
            this.CrsePnl.Controls.Add(this.textBox4);
            this.CrsePnl.Controls.Add(this.label5);
            this.CrsePnl.Location = new System.Drawing.Point(18, 35);
            this.CrsePnl.Name = "CrsePnl";
            this.CrsePnl.Size = new System.Drawing.Size(1164, 596);
            this.CrsePnl.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(735, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 91);
            this.button1.TabIndex = 35;
            this.button1.Text = "ADD TO FAVOURITES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(25, 201);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1108, 317);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView3_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "CourseID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(456, 142);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(182, 22);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "CourseSearch";
            // 
            // FAV_PNL
            // 
            this.FAV_PNL.Controls.Add(this.dataGridView4);
            this.FAV_PNL.Controls.Add(this.label7);
            this.FAV_PNL.Location = new System.Drawing.Point(0, 30);
            this.FAV_PNL.Name = "FAV_PNL";
            this.FAV_PNL.Size = new System.Drawing.Size(1185, 577);
            this.FAV_PNL.TabIndex = 36;
            this.FAV_PNL.Paint += new System.Windows.Forms.PaintEventHandler(this.FAV_PNL_Paint);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(148, 127);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(946, 335);
            this.dataGridView4.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(380, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "MY FAVOURITES LIST";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 643);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.StudentMrksPnl);
            this.Controls.Add(this.StudentPrflPnl);
            this.Controls.Add(this.FAV_PNL);
            this.Controls.Add(this.CrsePnl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.StudentPrflPnl.ResumeLayout(false);
            this.StudentPrflPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.StudentMrksPnl.ResumeLayout(false);
            this.StudentMrksPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.CrsePnl.ResumeLayout(false);
            this.CrsePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.FAV_PNL.ResumeLayout(false);
            this.FAV_PNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel StudentPrflPnl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel StudentMrksPnl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel CrsePnl;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton Logout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton FAV_BTN;
        private System.Windows.Forms.Panel FAV_PNL;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label7;
    }
}