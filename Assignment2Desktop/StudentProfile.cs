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
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }
        private string s;
        internal void setS(string text)
        {
            s = text;
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=09185379-AKSHAY;Initial Catalog=Assignment;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("STUDENTSDETAILS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@QueryStudentId", SqlDbType.VarChar).Value = s;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox1.Text = (sdr["StudentName"].ToString());
                textBox2.Text = (sdr["Address"].ToString());
                textBox3.Text = (sdr["PhoneNumber"].ToString());
            }

        }
    }
}
