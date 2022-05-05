
namespace WindowsFormsApp1
{
    partial class sort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_fam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_fprice = new System.Windows.Forms.TextBox();
            this.tb_sprice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 316);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(94, 54);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Закрыть";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(112, 316);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 54);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Поиск";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_fam
            // 
            this.tb_fam.Location = new System.Drawing.Point(212, 316);
            this.tb_fam.Name = "tb_fam";
            this.tb_fam.Size = new System.Drawing.Size(124, 20);
            this.tb_fam.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Фильрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_fprice
            // 
            this.tb_fprice.Location = new System.Drawing.Point(442, 316);
            this.tb_fprice.Name = "tb_fprice";
            this.tb_fprice.Size = new System.Drawing.Size(124, 20);
            this.tb_fprice.TabIndex = 5;
            // 
            // tb_sprice
            // 
            this.tb_sprice.Location = new System.Drawing.Point(442, 350);
            this.tb_sprice.Name = "tb_sprice";
            this.tb_sprice.Size = new System.Drawing.Size(124, 20);
            this.tb_sprice.TabIndex = 6;
            // 
            // sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 389);
            this.Controls.Add(this.tb_sprice);
            this.Controls.Add(this.tb_fprice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_fam);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sort";
            this.Text = "sort";
            this.Load += new System.EventHandler(this.sort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_fam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_fprice;
        private System.Windows.Forms.TextBox tb_sprice;
    }
}