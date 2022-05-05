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
    public partial class izm : Form
    {
        public izm()
        {
            InitializeComponent();
        }

        private void btn_izm_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=10.111.105.2,1433\SQLEXPRESS;Initial Catalog=pr-20.102k-chm22;User ID=20.102k-12;Password=SnnmCK12";
            using (SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query = $"update Сотрудники set Фамилия = '{tb_surname.Text}' where [Табельный номер] = {tb_id.Text}";
                SqlCommand command = new SqlCommand(query, Con);
                command.ExecuteNonQuery();
                Con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
