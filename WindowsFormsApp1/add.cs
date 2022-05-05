using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=10.111.105.2,1433\SQLEXPRESS;Initial Catalog=pr-20.102k-chm22;User ID=20.102k-12;Password=SnnmCK12";
            using(SqlConnection Con = new SqlConnection(con))
            {
                Con.Open();
                string query = $"insert into Сотрудники(Имя, Фамилия, Отчество) values ('{tb_name.Text}', '{tb_surname.Text}', '{tb_otch.Text}');";
                string query2 = $"insert into [Информация о сотрудниках]([Номер телефона],[Банковский счет],[Пол],[Паспортные данные],ИНН,Должность) values({tb_phonenumber.Text}, {tb_bank.Text}, '{tb_s.Text}', {tb_passport.Text}, {tb_inn.Text}, '{tb_dolzh.Text}')";
                SqlCommand command = new SqlCommand(query, Con);
                SqlCommand command2 = new SqlCommand(query2, Con);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                Con.Close();

            }
        }

        private void add_Load(object sender, EventArgs e)
        {

        }
    }
}
