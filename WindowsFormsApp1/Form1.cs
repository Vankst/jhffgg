using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            add add = new add();
            add.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_pr_20_102k_chm22DataSet.Информация_о_сотрудниках". При необходимости она может быть перемещена или удалена.
            this.информация_о_сотрудникахTableAdapter.Fill(this._pr_20_102k_chm22DataSet.Информация_о_сотрудниках);

            this.сотрудникиTableAdapter.Fill(this._pr_20_102k_chm22DataSet.Сотрудники);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deleteForm deleteForm = new deleteForm();
            deleteForm.Show();
            this.Hide();
        }

        private void btn_izm_Click(object sender, EventArgs e)
        {
            izm izm = new izm();
            izm.Show();
            this.Hide();
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            sort sort = new sort();
            sort.Show();
            this.Hide();
        }
    }
}
