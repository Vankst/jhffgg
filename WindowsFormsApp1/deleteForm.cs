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
    public partial class deleteForm : Form
    {
        public deleteForm()
        {
            InitializeComponent();
        }

        private void deleteForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete(object sender, EventArgs e)
        {
            string con = @"Data Source=10.111.105.2,1433\SQLEXPRESS;Initial Catalog=pr-20.102k-chm22;User ID=20.102k-12;Password=SnnmCK12";
            using (SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query = $"delete from Сотрудники where [Табельный номер] = {tb_id.Text};";
                string query2 = $"delete from [Информация о сотрудниках] where [Табельный номер] = {tb_id.Text};";
                SqlCommand command = new SqlCommand(query, Con);
                SqlCommand command2 = new SqlCommand(query2, Con);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                Con.Close();

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
