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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
            {
            //-----------------StudentLogin------------------//
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*) FROM STUDENT_LOGIN where StudentId='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //--------------------LectureLogin----------------//
            SqlDataAdapter sdas = new SqlDataAdapter("SELECT COUNT (*) FROM STAFF_LOGIN where StaffId='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
            DataTable dts = new DataTable();
            sdas.Fill(dts);
            String s = textBox1.Text;
            //--------------------ADMINLOGIN------------------//
            SqlDataAdapter sdass = new SqlDataAdapter("SELECT COUNT (*) FROM ADMIN_LOGIN where AdminId='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
            DataTable dtss = new DataTable();
            sdass.Fill(dtss);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login success");
                StudentForm form = new StudentForm();
               
                form.setS(this.textBox1.Text);
                this.Hide();
                form.Show();
            }
            
            else if (dts.Rows[0][0].ToString() == "1")
            {
                SqlConnection connect = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
                connect.Open();
                SqlCommand cmds = new SqlCommand("SELECT Activity FROM LOGIN_ACTIVITY where StaffId='" + textBox1.Text + "'", connect);
                SqlDataReader Reader = cmds.ExecuteReader();

                while (Reader.Read())
                {
                    string a;
                    a = Reader["Activity"].ToString();
                    if (a == "ACTIVE")
                    {
                        MessageBox.Show("Login success");
                        StaffForm st = new StaffForm();
                        st.Sets(this.textBox1.Text);
                        this.Hide();
                        st.Show();

                    }
                    else if (a == "BLOCK")
                    {
                        MessageBox.Show("Sorry!! Your Access has been Blocked Please Contact Admin");
                    }
                }
               
            }
            
           

            else if (dtss.Rows[0][0].ToString() == "1")
            {
                AdminForms af = new AdminForms();
                MessageBox.Show("Login success");
                this.Hide();
                af.Show();
            }

            else
            {
                MessageBox.Show("Login Failed");
            }


        }
    }
}
