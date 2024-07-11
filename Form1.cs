using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CheckBox_StoredProcedures_db
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("sp_Hobies", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Football", checkBox1.Checked);

            cmd.Parameters.AddWithValue("@Hockey", checkBox3.Checked);
            cmd.Parameters.AddWithValue("@Tennis", checkBox4.Checked);
            con.Open();
            int nq = cmd.ExecuteNonQuery();
            if (nq > 0)
            {
                MessageBox.Show("Data Entered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataBind();
            }
            else
            {
                MessageBox.Show("Data Entry Failure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
        public void dataBind()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Select * from Hobies;";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }
    }
}