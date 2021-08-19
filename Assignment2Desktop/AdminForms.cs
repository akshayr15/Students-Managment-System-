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
    public partial class AdminForms : Form
    {
        public AdminForms()
        {
            InitializeComponent();
        }

        private void AdminForms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentDataSet6.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.assignmentDataSet6.COURSE);
            // TODO: This line of code loads data into the 'assignmentDataSet5.PROGRAMME' table. You can move, or remove it, as needed.
            this.pROGRAMMETableAdapter.Fill(this.assignmentDataSet5.PROGRAMME);
            // TODO: This line of code loads data into the 'assignmentDataSet3.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter2.Fill(this.assignmentDataSet3.STAFF);
            // TODO: This line of code loads data into the 'assignmentDataSet2.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter1.Fill(this.assignmentDataSet2.STAFF);
            // TODO: This line of code loads data into the 'assignmentDataSet1.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.assignmentDataSet1.STAFF);

            StudentServicesTab.Hide();
            StaffServicesTab.Hide();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void StaffServiceTab_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            SqlCommand cmds = new SqlCommand("SELECT * FROM STUDENT", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmds.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

        private void Inst_btn_Click(object sender, EventArgs e)
        {
            if (stdIDlgn.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (PssLgn.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (StdNme.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (StdAdd.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (StdPhn.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (CrseId.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (CrseSts.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                String sql = "INSERT INTO STUDENT (StudentId,StudentName,Address,PhoneNumber) values ('" + stdIDlgn.Text + "','" + StdNme.Text + "','" + StdAdd.Text + "','" + StdPhn.Text + "')";
                String sql1 = "INSERT INTO STUDENT_LOGIN (StudentId,Password) values ('" + stdIDlgn.Text + "','" + PssLgn.Text + "')";
                String sql2 = "INSERT INTO STUDENT_COURSES (StudentId,CourseId,CourseStatus) values ('" + stdIDlgn.Text + "','" + CrseId.Text + "','" + CrseSts.Text + "')";
                String sql3 = "INSERT INTO STUDENT_MARKS (StudentId,CourseId) values ('" + stdIDlgn.Text + "','" + CrseId.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                SqlCommand cmd3 = new SqlCommand(sql3, con);

                con.Open();
                if (cmd1.ExecuteNonQuery().ToString() == "1" && cmd.ExecuteNonQuery().ToString() == "1" && cmd2.ExecuteNonQuery().ToString() == "1" && cmd3.ExecuteNonQuery().ToString() == "1")
                {
                    MessageBox.Show("INSERT SUCCESS");
                    SqlCommand cmds = new SqlCommand("SELECT * FROM STUDENT", con);
                    DataTable dt = new DataTable();
                    dt.Load(cmds.ExecuteReader());
                    dataGridView1.DataSource = dt;
                    stdIDlgn.Clear();
                    PssLgn.Clear();
                    StdNme.Clear();
                    StdAdd.Clear();
                    StdPhn.Clear();
                    CrseId.Clear();
                    CrseSts.Clear();
                }
                else
                {
                    MessageBox.Show("INSERTION FAILED");
                }
            }
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            StudentServicesTab.Show();
            StaffServicesTab.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                StdId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                StdPss.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void StudentServicesTab_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT_LOGIN", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dt;

            SqlCommand cmds = new SqlCommand("SELECT * FROM STUDENT", con);
            DataTable dts = new DataTable();
            dts.Load(cmds.ExecuteReader());
            dataGridView3.DataSource = dts;

            SqlCommand cmdss = new SqlCommand("SELECT * FROM STUDENT_COURSES", con);
            DataTable dtss = new DataTable();
            dtss.Load(cmdss.ExecuteReader());
            dataGridView4.DataSource = dtss;

            SqlCommand cmdu = new SqlCommand("SELECT * FROM STUDENT", con);
            DataTable dtu = new DataTable();
            dtu.Load(cmdu.ExecuteReader());
            dataGridView1.DataSource = dtu;


        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (StdId.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (StdPss.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                String sql = "Update STUDENT_LOGIN  set Password ='" + StdPss.Text + "' where StudentId='" + StdId.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                if (cmd.ExecuteNonQuery().ToString() == "1")
                {
                    MessageBox.Show("UPDATE SUCCESS");
                    SqlCommand cmds = new SqlCommand("SELECT * FROM STUDENT_LOGIN", con);
                    DataTable dt = new DataTable();
                    dt.Load(cmds.ExecuteReader());
                    dataGridView2.DataSource = dt;
                    StdPss.Clear();
                    StdId.Clear();
                }
                else
                {
                    MessageBox.Show("UPDATE FAILED");
                }
            }
        }

        private void Update_btn1_Click(object sender, EventArgs e)
        {
            if (Nme.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (addrs.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (Phne.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (SID.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                String sql = "Update STUDENT set StudentName ='" + Nme.Text + "',Address='" + addrs.Text + "',PhoneNumber='" + Phne.Text + "' where StudentId='" + SID.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                if (cmd.ExecuteNonQuery().ToString() == "1")
                {
                    MessageBox.Show("UPDATE SUCCESS");
                    SqlCommand cmds = new SqlCommand("SELECT * FROM STUDENT", con);
                    DataTable dt = new DataTable();
                    dt.Load(cmds.ExecuteReader());
                    dataGridView3.DataSource = dt;
                    SID.Clear();
                    Nme.Clear();
                    addrs.Clear();
                    Phne.Clear();
                }
                else
                {
                    MessageBox.Show("UPDATE FAILED");
                }
            }
        }

        private void Update_btn2_Click(object sender, EventArgs e)
        {
            if (CourseID.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (StudentID.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (CourseSts.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                String sql = "Update STUDENT_COURSES set CourseId ='" + CourseID.Text + "',CourseStatus='" + CourseSts.Text + "' where StudentId='" + StudentID.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                if (cmd.ExecuteNonQuery().ToString() == "1")
                {
                    MessageBox.Show("UPDATE SUCCESS");
                    SqlCommand cmds = new SqlCommand("SELECT * FROM STUDENT_COURSES", con);
                    DataTable dt = new DataTable();
                    dt.Load(cmds.ExecuteReader());
                    dataGridView4.DataSource = dt;
                    CourseID.Clear();
                    StudentID.Clear();
                    CourseSts.Clear();
                }
                else
                {
                    MessageBox.Show("UPDATE FAILED");
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView3.Rows.Count > 0)
            {
                SID.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                Nme.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                addrs.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                Phne.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void dataGridView4_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView4.Rows.Count > 0)
            {
                StudentID.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
                CourseID.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
                CourseSts.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
               

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DltID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            String sql = "DELETE FROM STUDENT_LOGIN where StudentId='" + DltID.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            if (cmd.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("STUDENT DELETED SUCCESSFULLY");
                SqlCommand cmds = new SqlCommand("SELECT * FROM STUDENT", con);
                DataTable dt = new DataTable();
                dt.Load(cmds.ExecuteReader());
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("DELETION FAILED");
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (Idlgn.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (psw.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (NmeSTF.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (AddSTF.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (PhnSTF.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (RleSTF.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (StfCrseId.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (CRSName.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            String sql = "INSERT INTO STAFF_LOGIN (StaffId,Password) values ('" + Idlgn.Text + "','" + psw.Text + "')";
            String sql1 = "INSERT INTO STAFF (StaffId,StaffName,ContactNumber,Address,RoleorType) values ('" + Idlgn.Text + "','" + NmeSTF.Text + "','" + PhnSTF.Text + "','" + AddSTF.Text + "','" + RleSTF.Text + "')";
            String sql2 = "INSERT INTO STAFF_COURSE (CourseId,StaffId,StaffName,CourseName) values ('" + StfCrseId.Text + "','" + Idlgn.Text + "','" + NmeSTF.Text + "','" + CRSName.Text + "')";
            String sql3 = "INSERT INTO ACTIVITY (StaffId,Activity) values ('"+ Idlgn .Text+ "','Active')";
            String sql4 = "INSERT INTO LOGIN_ACTIVITY (StaffId,Activity) values ('" + Idlgn.Text + "','ACTIVE')";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            SqlCommand cmd4 = new SqlCommand(sql4, con);

            con.Open();
            if (cmd.ExecuteNonQuery().ToString() == "1" && cmd1.ExecuteNonQuery().ToString() == "1"&& cmd2.ExecuteNonQuery().ToString() == "1" && cmd3.ExecuteNonQuery().ToString() == "1" && cmd4.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("INSERT SUCCESS");
                SqlCommand cmds = new SqlCommand("SELECT * FROM STAFF", con);
                DataTable dt = new DataTable();
                dt.Load(cmds.ExecuteReader());
                dataGridView5.DataSource = dt;
                Idlgn.Clear();
                psw.Clear();
                NmeSTF.Clear();
                AddSTF.Clear();
                PhnSTF.Clear();
                RleSTF.Clear();
                StfCrseId.Clear();
                CRSName.Clear();
            }
            else
            {
                MessageBox.Show("INSERTION FAILED");
            }
        }

        private void NewLecture_Click(object sender, EventArgs e)
        {
            
        }

        private void StfPnl_Click(object sender, EventArgs e)
        {
            StaffServicesTab.Show();
            StudentServicesTab.Hide();
        }

        private void StaffServicesTab_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            SqlCommand cmds = new SqlCommand("SELECT * FROM STAFF", con);
            DataTable dt = new DataTable();
            dt.Load(cmds.ExecuteReader());
            dataGridView5.DataSource = dt;
            dataGridView7.DataSource = dt;

        }

        private void dataGridView5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            String sql = "DELETE FROM STAFF_LOGIN where StaffId='" + STAFFID.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            if (cmd.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("STAFF DELETED SUCCESSFULLY");
                SqlCommand cmds = new SqlCommand("SELECT * FROM STAFF", con);
                DataTable dt = new DataTable();
                dt.Load(cmds.ExecuteReader());
                dataGridView5.DataSource = dt;
            }
            else
            {
                MessageBox.Show("DELETION FAILED");
            }
        }

       

        private void StfSrchID_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("StaffSearchID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@QueryStaffName", SqlDbType.VarChar).Value = StfSrchID.Text;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView6.DataSource = dt;
        }

        private void CrseSrchNme_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("StaffCourseName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@QueryCourseName", SqlDbType.VarChar).Value = CrseSrchNme.Text;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView6.DataSource = dt;
        }

        private void StfNmeSrch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("StaffName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@QueryStaffName", SqlDbType.VarChar).Value = StfNmeSrch.Text;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView6.DataSource = dt;
        }

        private void StaffSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView5.Rows.Count > 0)
            {
                STAFFID.Text = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();
               


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView7_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView7.Rows.Count > 0)
            {
                IDSTF.Text = dataGridView7.SelectedRows[0].Cells[0].Value.ToString();
                StaffNme.Text = dataGridView7.SelectedRows[0].Cells[1].Value.ToString();
                PhneNmbr.Text = dataGridView7.SelectedRows[0].Cells[2].Value.ToString();
                Address.Text = dataGridView7.SelectedRows[0].Cells[3].Value.ToString();
                Role.Text = dataGridView7.SelectedRows[0].Cells[4].Value.ToString();

            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (IDSTF.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (StaffNme.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (Address.Text == string.Empty && CRSNME.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (PhneNmbr.Text == string.Empty && CRSNME.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (Role.Text == string.Empty && CRSNME.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                String sql = "Update STAFF set StaffName ='" + StaffNme.Text + "',Address='" + Address.Text + "',ContactNumber='" + PhneNmbr.Text + "',RoleorType='" + Role.Text + "' where StaffId='" + IDSTF.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                if (cmd.ExecuteNonQuery().ToString() == "1")
                {
                    MessageBox.Show("UPDATE SUCCESS");
                    SqlCommand cmds = new SqlCommand("SELECT * FROM STAFF", con);
                    DataTable dt = new DataTable();
                    dt.Load(cmds.ExecuteReader());
                    dataGridView7.DataSource = dt;
                    IDSTF.Clear();
                    StaffNme.Clear();
                    Address.Clear();
                    PhneNmbr.Clear();
                    Role.Clear();
                }
                else
                {
                    MessageBox.Show("UPDATE FAILED");
                }
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Fee_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView8_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridView8.Rows.Count > 0)
                {

                    CRSTXT.Text = dataGridView8.SelectedRows[0].Cells[0].Value.ToString();
                    CRSNME.Text = dataGridView8.SelectedRows[0].Cells[1].Value.ToString();
                    FEES.Text = dataGridView8.SelectedRows[0].Cells[2].Value.ToString();

                }
            }
            catch(Exception d)
            {
                MessageBox.Show(" Click the Index of the rows ");
            }
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentServicesTab_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            SqlCommand cmds = new SqlCommand("SELECT CourseId,CourseName,Fees FROM COURSE", con);
            DataTable dt = new DataTable();
            dt.Load(cmds.ExecuteReader());
            dataGridView8.DataSource = dt;
            label38.Hide();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(FEES.Text);
            int b = a * 5 / 100;
            int c = a - b;
            FEESDIS.Text = c.ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(FEES.Text);
            int b = a * 15 / 100;
            int c = a - b;
            FEESDIS.Text = c.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(FEES.Text);
            int b = a * 20 / 100;
            int c = a - b;
            FEESDIS.Text = c.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            FEESDIS.Text = FEES.Text;
        }

        private void Fee_btn_Click(object sender, EventArgs e)
        {
            if (STDTXT.Text == string.Empty )
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (STNME.Text == string.Empty )
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (CRSTXT.Text == string.Empty && CRSNME.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (CRSNME.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                    String sql = "INSERT INTO Student_Fees (StudentId,StudentName,CourseId,CourseName,Fee) values ('" + STDTXT.Text + "','" + STNME.Text + "','" + CRSTXT.Text + "','" + CRSNME.Text + "','" + FEESDIS.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();





                    if (cmd.ExecuteNonQuery().ToString() == "1")
                    {
                        MessageBox.Show("INSERT SUCCESS");
                        SqlCommand cmds = new SqlCommand("SELECT * FROM Student_Fees", con);
                        DataTable dt = new DataTable();
                        dt.Load(cmds.ExecuteReader());
                        dataGridView8.DataSource = dt;
                        STDTXT.Clear();
                        STNME.Clear();
                        CRSTXT.Clear();
                        CRSNME.Clear();
                        FEESDIS.Clear();
                        label38.Show();
                    }
                    else
                    {
                        MessageBox.Show("INSERTION FAILED");
                    }
                }
                catch(Exception f)
                {
                    MessageBox.Show("StudentID IS Not Enrolled ");
                }



            }
               
            
           
        
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Allow_Click(object sender, EventArgs e)
        {
            string a = "Active";
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            String sql = "Update ACTIVITY set Activity ='"+a+"' where StaffId='" + comboBox1.SelectedValue+ "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            if (cmd.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("Staff Allowed to Modify Student Marks");
            }
            else
            {
                MessageBox.Show("Failed");
            }

           
            }

        private void Block_Click(object sender, EventArgs e)
        {
            string a = "Block";
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            String sql = "Update ACTIVITY set Activity ='"+a+"' where StaffId='" + comboBox1.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            if (cmd.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("Staff Blocked From Modifying Student Marks");
            }
            else
            {
                MessageBox.Show("Failed");
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Prnt_btn_Click(object sender, EventArgs e)
        {
            SqlConnection cons = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            cons.Open();
            SqlCommand cmds = new SqlCommand("ReportProgramme", cons);
            cmds.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmds);
            cmds.Parameters.AddWithValue("@QueryProgrammeName", SqlDbType.VarChar).Value = comboBox3.SelectedValue;
            DataTable dt = new DataTable();
            dt.Load(cmds.ExecuteReader());
            dataGridView9.DataSource = dt;
            DataSet ds = new DataSet();
            da.Fill(ds, "ReportProgramme");
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(ds);

            Form2 frm = new Form2();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();

        }

        private void Enable_btn_Click(object sender, EventArgs e)
        {
            string a = "ACTIVE";
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            String sql = "Update LOGIN_ACTIVITY set Activity ='" + a + "' where StaffId='" + comboBox2.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            if (cmd.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("Staff is Allowed to Access");
            }
            else
            {
                MessageBox.Show("Failed");
            }


        }

        private void Disable_btn_Click(object sender, EventArgs e)
        {
            string a = "BLOCK";
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            String sql = "Update LOGIN_ACTIVITY set Activity ='" + a + "' where StaffId='" + comboBox2.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            if (cmd.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("Staff has been Blocked");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void PrntBtn_Click(object sender, EventArgs e)
        {
            SqlConnection cons = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            cons.Open();
            SqlCommand cmds = new SqlCommand("ReportCourse", cons);
            cmds.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmds);
            cmds.Parameters.AddWithValue("@QueryCourseName", SqlDbType.VarChar).Value = comboBox4.SelectedValue;
            DataTable dt = new DataTable();
            dt.Load(cmds.ExecuteReader());
            dataGridView9.DataSource = dt;
            DataSet ds = new DataSet();
            da.Fill(ds, "ReportCourse");
            CrystalReport2 rpt = new CrystalReport2();
            rpt.SetDataSource(ds);

            Form1 frm = new Form1();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();

        }
    }
    }

