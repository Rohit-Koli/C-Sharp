//Demonstrate use of Database Connectivity using SQL-Server
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//Imported SQL-Server Package

namespace Database2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        public Form1()
        {
            con.ConnectionString = "Data Source=ITSRK;Initial Catalog=MyDB;Integrated Security=True;Pooling=False";
            InitializeComponent();
            Display();
        }
       private void Display()
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da= new SqlDataAdapter("select * from Stud",con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Stud values (@Rno,@Name,@Class)", con);//Fields Name
            cmd.Parameters.AddWithValue("@Rno", Convert.ToInt32(txtRno.Text));
            cmd.Parameters.AddWithValue("@Name", (txtName.Text));
            cmd.Parameters.AddWithValue("@Class", (txtClass.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Records has been inserted ");
            txtRno.Text = "";
            txtName.Text = "";
            txtClass.Text = "";
            con.Close();            
            Display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Stud set Class=@Class,Name=@Name where RollNo=@Rno",con);
            cmd.Parameters.AddWithValue("@Rno", Convert.ToInt32(txtRno.Text));
            cmd.Parameters.AddWithValue("@Name", (txtName.Text));
            cmd.Parameters.AddWithValue("@Class", (txtClass.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Records has been Updated ");
            txtRno.Text = "";
            txtName.Text = "";
            txtClass.Text = "";
            con.Close();
            Display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Stud where RollNo=@Rno", con);
            cmd.Parameters.AddWithValue("@Rno", Convert.ToInt32(txtRno.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Records has been Deleted");
            txtRno.Text = "";
            txtName.Text = "";
            txtClass.Text = "";
            con.Close();
            Display();
        }
    }
}
