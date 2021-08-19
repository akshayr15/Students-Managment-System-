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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

      
      

      
        private string s;
        internal void setS(string text)
        {
            s = text;
        }

 

      

        private void StudentForm_Load(object sender, EventArgs e)
        {
            StudentPrflPnl.Hide();
            StudentMrksPnl.Hide();
            CrsePnl.Hide();
            FAV_PNL.Hide();
        }

      

        private void StudentPrflPnl_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            SqlDataReader myReader = null;
            SqlCommand cmd = new SqlCommand("STUDENTSDETAILS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@QueryStudentId", SqlDbType.VarChar).Value = s;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StudentPrflPnl.Show();
            StudentMrksPnl.Hide();
            CrsePnl.Hide();
            FAV_PNL.Hide();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            if (textBox3.Text == string.Empty )
            {
                MessageBox.Show("Please Fill All the Data");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                String sql = "UPDATE STUDENT SET StudentName='" + textBox1.Text + "'  , Address='" + textBox2.Text + "' ,PhoneNumber='" + textBox3.Text + "' where StudentId='" + s + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Sucess");
                    SqlConnection cons = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                    String sql1 = "Select * from STUDENT";
                    cons.Open();
                    SqlCommand cmds = new SqlCommand(sql1, con);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentMrksPnl_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT_MARKS where StudentId='" + s + "'", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dt;
            
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            StudentMrksPnl.Show();
            StudentPrflPnl.Hide();
            CrsePnl.Hide();
            FAV_PNL.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course where CourseId Like'" + textBox4.Text + "%'", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView3.DataSource = dt;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CrsePnl.Show();
            StudentPrflPnl.Hide();
            StudentMrksPnl.Hide();
            FAV_PNL.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            String sql = "INSERT INTO STUDENT_FAVOURITES (StudentId,CourseId,ProgrammeId,CourseName,Credit,Hours,Fees) values ('"+s+"','" + a + "','" + b + "','" + c + "','" + d + "','" + f + "','" + g + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
           

            con.Open();
            if (cmd.ExecuteNonQuery().ToString() == "1")
            {
                MessageBox.Show("ADDED TO FAVOURITES");
                
              
            }
            else
            {
                MessageBox.Show("INSERTION FAILED");
            }
        }
        string a,b,c,d,f,g;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FAV_BTN_Click(object sender, EventArgs e)
        {
            FAV_PNL.Show();
            CrsePnl.Hide();
            StudentPrflPnl.Hide();
            StudentMrksPnl.Hide();
            
        }

        private void FAV_PNL_Paint(object sender, PaintEventArgs e)
        {
           
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT_FAVOURITES where StudentId='"+s+"'", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView4.DataSource = dt;
        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridView3.Rows.Count > 0)
                {
                    a = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                    b = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                    c = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                    d = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
                    f = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
                    g = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();

                }
            }
            catch(Exception d)
            {
                MessageBox.Show("Please Click the Index");
            }
        }
    }
}
