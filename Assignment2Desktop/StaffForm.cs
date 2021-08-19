using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Desktop
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffPrfPnl_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("StaffDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@QueryStaffId", SqlDbType.VarChar).Value = s;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
          //  SqlDataReader myReader = null;
           // myReader = cmd.ExecuteReader();

           // while (myReader.Read())
            //{
              //  StffNme.Text = (myReader["StaffName"].ToString());
               // Addrs.Text = (myReader["Address"].ToString());
                //CntNmb.Text = (myReader["ContactNumber"].ToString());

            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StffNme.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (Addrs.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (CntNmb.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                String sql = "UPDATE STAFF SET StaffName=@n  , Address=@a ,ContactNumber=@p where StaffId=@i";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@n", StffNme.Text);
                cmd.Parameters.AddWithValue("@a", Addrs.Text);
                cmd.Parameters.AddWithValue("@p", CntNmb.Text);
                cmd.Parameters.AddWithValue("@i", s);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Sucess");
                    SqlConnection cons = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                    cons.Open();
                    SqlCommand cmds = new SqlCommand("StaffDetails", cons);
                    cmds.CommandType = CommandType.StoredProcedure;
                    cmds.Parameters.AddWithValue("@QueryStaffId", SqlDbType.VarChar).Value = s;
                    DataTable dt = new DataTable();
                    dt.Load(cmds.ExecuteReader());
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }
        private string s;
        internal void Sets(string text)
        {
            s = text;
        }

        private void StaffProfile_Click(object sender, EventArgs e)
        {
            StaffPrfPnl.Show();
            StudntMrksPnl.Hide();
            panel1.Hide();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentDataSet.STAFF_COURSE' table. You can move, or remove it, as needed.
          //  this.sTAFF_COURSETableAdapter.Fill(this.assignmentDataSet.STAFF_COURSE);
            StaffPrfPnl.Hide();
            StudntMrksPnl.Hide();
            panel1.Hide();
        }

        private void StudentMarks_Click(object sender, EventArgs e)
        {
            StudntMrksPnl.Show();
            StaffPrfPnl.Hide();
            panel1.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            string sql = "Select STUDENT.StudentName,STUDENT_MARKS.StudentId,STUDENT_MARKS.CourseId,STUDENT_MARKS.Grade,STUDENT_MARKS.Marks from STUDENT inner join STUDENT_MARKS on (STUDENT.StudentId = STUDENT_MARKS.StudentId) where STUDENT.StudentId LIKE'" + StdIdtxt.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dts = new DataTable();
            dts.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dts;
        }

        private void CrseNameTxt_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            string sql = "Select STUDENT.StudentName,STUDENT_MARKS.StudentId,STUDENT_MARKS.CourseId,STUDENT_MARKS.Grade,STUDENT_MARKS.Marks from STUDENT inner join STUDENT_MARKS on (STUDENT.StudentId = STUDENT_MARKS.StudentId) inner join COURSE on (COURSE.CourseId = STUDENT_MARKS.CourseId) where CourseName LIKE'" + CrseNameTxt.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dts = new DataTable();
            dts.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dts;
        }

        private void PgmNmeTxt_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            string sql = "select STUDENT.StudentName,STUDENT_MARKS.StudentId,STUDENT_MARKS.CourseId,STUDENT_MARKS.Grade,STUDENT_MARKS.Marks from STUDENT inner join STUDENT_MARKS on(STUDENT.StudentId = STUDENT_MARKS.StudentId) inner join COURSE on(COURSE.CourseId= STUDENT_MARKS.CourseId) inner join PROGRAMME on(COURSE.ProgrammeId= PROGRAMME.ProgrammeId) where PROGRAMME.ProgrammeName LIKE'" + PgmNmeTxt.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dts = new DataTable();
            dts.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dts;
        }

        private void StdNmeTxt_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            string sql = "Select STUDENT.StudentName,STUDENT_MARKS.StudentId,STUDENT_MARKS.CourseId,STUDENT_MARKS.Grade,STUDENT_MARKS.Marks from STUDENT_MARKS inner join STUDENT on (STUDENT.StudentId = STUDENT_MARKS.StudentId) where STUDENT.StudentName LIKE'" + StdNmeTxt.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dts = new DataTable();
            dts.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dts;

        }

        private void Insert_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            String sql = "Update STUDENT_MARKS set Grade='" + Grd.Text + "',Marks='" + Mrks.Text + "'  where StudentId='" + StdID.Text + "' and CourseId='" + comboBox1.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            if (cmd.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("Insert Success");
                SqlConnection con1 = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                con1.Open();
                SqlCommand cmds = new SqlCommand("SELECT * FROM STUDENT_MARKS ", con1);


                DataTable dts = new DataTable();
                dts.Load(cmds.ExecuteReader());
                dataGridView2.DataSource = dts;
            }
            else
            {
                MessageBox.Show("Insert Failed");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            String sql = "UPDATE STUDENT_MARKS set  Grade='" + Grd.Text + "' , Marks = '" + Mrks.Text + "' where StudentId='" + StdID.Text + "' and CourseId='" + comboBox1.SelectedValue+ "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            if (cmd.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("Update Success");
                SqlConnection con1 = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                con1.Open();
                SqlCommand cmds = new SqlCommand("SELECT * FROM STUDENT_MARKS ", con1);


                DataTable dts = new DataTable();
                dts.Load(cmds.ExecuteReader());
                dataGridView2.DataSource = dts;
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void StudntMrksPnl_Paint(object sender, PaintEventArgs e)
        {
            string a ;
            SqlConnection con1 = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con1.Open();
            SqlCommand cmds = new SqlCommand("SELECT Activity FROM ACTIVITY where StaffId='" + s + "'", con1);
            DataTable dt = new DataTable();
            SqlDataReader Reader = cmds.ExecuteReader();
            while (Reader.Read())
            {
               a  = Reader["Activity"].ToString();
                if (a == "Block")
                {
                    Insert.Hide();
                    Update.Hide();
                }
                else if(a == "Acitve")
                        {
                    Insert.Show();
                    Update.Show();
                }
            }
           

        }

            

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void CrsID_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select CourseId from STAFF_COURSE where StaffId='"+ s +"'", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sda.Fill(ds, "STAFF_COURSE");

            comboBox1.DisplayMember = "CourseId"; // Column Name
            comboBox1.ValueMember = "CourseId"; // Column Name
            comboBox1.DataSource = ds.Tables["STAFF_COURSE"];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con1.Open();
            SqlCommand cmds = new SqlCommand("SELECT ProgrammeId,ProgrammeName FROM PROGRAMME", con1);
              DataTable dts = new DataTable();
            dts.Load(cmds.ExecuteReader());
            dataGridView4.DataSource = dts;
        }

        private void ADD_CrseBtn_Click(object sender, EventArgs e)
        {
            StaffPrfPnl.Hide();
            StudntMrksPnl.Hide();
            panel1.Show();
        }

        private void New_Insrt_Click(object sender, EventArgs e)
        {
            if (PGM.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (CRS.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (CRSN.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (CRD.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }

            if (HRS.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (FEE.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                String sql = "INSERT INTO COURSE (ProgrammeId,CourseId,CourseName,Credit,Hours,Fees) values ('" + PGM.Text + "','" + CRS.Text + "','" + CRSN.Text + "','" + CRD.Text + "','" + HRS.Text + "','" + FEE.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                if (cmd.ExecuteNonQuery().ToString() == "1")
                {
                    MessageBox.Show("INSERT SUCCESS");
                    SqlCommand cmds = new SqlCommand("SELECT * FROM COURSE", con);
                    DataTable dt = new DataTable();
                    dt.Load(cmds.ExecuteReader());
                    dataGridView3.DataSource = dt;
                    PGM.Clear();
                    CRS.Clear();
                    CRSN.Clear();
                    CRD.Clear();
                    HRS.Clear();
                    FEE.Clear();




                }
                else
                {
                    MessageBox.Show("INSERTION FAILED");
                }
            }
        }

    

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
      
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView4_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridView4.Rows.Count > 0)
                {
                    PGM.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();


                }
            }
            catch (Exception q)
            {
                MessageBox.Show("Click the Index of the rows ");
            }
        }

        private void CRSEID_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            string sql = "Select STUDENT.StudentName,STUDENT_MARKS.StudentId,STUDENT_MARKS.CourseId,STUDENT_MARKS.Grade,STUDENT_MARKS.Marks from STUDENT inner join STUDENT_MARKS on(STUDENT.StudentId = STUDENT_MARKS.StudentId) inner join COURSE on(COURSE.CourseId= STUDENT_MARKS.CourseId) where COURSE.CourseId like '" + CRSEID.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql,con);
            DataTable dts = new DataTable();
            dts.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dts;


        }

        private void CRDTS_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            string sql = "Select * from COURSE where Credit like '" + CRDTS.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dts = new DataTable();
            dts.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dts;
        }

        private void Hour_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            string sql = "Select * from COURSE where Hours like '" + Hour.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dts = new DataTable();
            dts.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dts;
        }

        private void UPDT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            String sql = "UPDATE COURSE set  ProgrammeId='" + PGM.Text + "' ,CourseName = '" + CRSN.Text + "',Credit='"+ CRD .Text+ "',Hours='"+ HRS .Text+ "',Fees='"+ FEE .Text+ "' where CourseId = '" + CRS.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            if (cmd.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("Update Success");
                SqlConnection con1 = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                con1.Open();
                SqlCommand cmds = new SqlCommand("SELECT * FROM COURSE ", con1);


                DataTable dts = new DataTable();
                dts.Load(cmds.ExecuteReader());
                dataGridView3.DataSource = dts;
                PGM.Clear();
                CRS.Clear();
                CRSN.Clear();
                CRD.Clear();
                HRS.Clear();
                FEE.Clear();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
