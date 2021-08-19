namespace Assignment2Desktop
{
    partial class Form1
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
            this.pROGRAMMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentDataSet4 = new Assignment2Desktop.AssignmentDataSet4();
            this.pROGRAMMETableAdapter = new Assignment2Desktop.AssignmentDataSet4TableAdapters.PROGRAMMETableAdapter();
            this.report = new Assignment2Desktop.AssignmentDataSet();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report)).BeginInit();
            this.SuspendLayout();
            // 
            // pROGRAMMEBindingSource
            // 
            this.pROGRAMMEBindingSource.DataMember = "PROGRAMME";
            this.pROGRAMMEBindingSource.DataSource = this.assignmentDataSet4;
            // 
            // assignmentDataSet4
            // 
            this.assignmentDataSet4.DataSetName = "AssignmentDataSet4";
            this.assignmentDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROGRAMMETableAdapter
            // 
            this.pROGRAMMETableAdapter.ClearBeforeFill = true;
            // 
            // report
            // 
            this.report.DataSetName = "report";
            this.report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1054, 690);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 690);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AssignmentDataSet4 assignmentDataSet4;
        private System.Windows.Forms.BindingSource pROGRAMMEBindingSource;
        private AssignmentDataSet4TableAdapters.PROGRAMMETableAdapter pROGRAMMETableAdapter;
        private AssignmentDataSet report;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}