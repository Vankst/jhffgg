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

namespace WindowsFormsApp1
{
    public partial class sort : Form
    {
        public sort()
        {
            InitializeComponent();
        }

        public static string fam;
        public string con = @"Data Source=10.111.105.2,1433\SQLEXPRESS;Initial Catalog=pr-20.102k-chm22;User ID=20.102k-12;Password=SnnmCK12";
        private void sort_Load(object sender, EventArgs e)
        {
          
            using (SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query = $"select * from Сотрудники order by Фамилия";
                SqlCommand command = new SqlCommand(query, Con);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                Con.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query = $"select * from Сотрудники where Фамилия = '{tb_fam.Text}'";
                SqlCommand command = new SqlCommand(query, Con);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                Con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query = $"Select * from Товар where Стоимость between {tb_fprice.Text} and {tb_sprice.Text}";
                SqlCommand command = new SqlCommand(query, Con);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                Con.Close();
            }
        }
    }
}
