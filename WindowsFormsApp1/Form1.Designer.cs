
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._pr_20_102k_chm22DataSet = new WindowsFormsApp1._pr_20_102k_chm22DataSet();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_izm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.табельныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new WindowsFormsApp1._pr_20_102k_chm22DataSetTableAdapters.СотрудникиTableAdapter();
            this.информацияОСотрудникахBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.информация_о_сотрудникахTableAdapter = new WindowsFormsApp1._pr_20_102k_chm22DataSetTableAdapters.Информация_о_сотрудникахTableAdapter();
            this.информацияОСотрудникахBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.табельныйНомерDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.банковскийСчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортныеДанныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияОСотрудникахBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pr_20_102k_chm22DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОСотрудникахBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОСотрудникахBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОСотрудникахBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this._pr_20_102k_chm22DataSet;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // _pr_20_102k_chm22DataSet
            // 
            this._pr_20_102k_chm22DataSet.DataSetName = "_pr_20_102k_chm22DataSet";
            this._pr_20_102k_chm22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 71);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(169, 53);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(12, 130);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(169, 52);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_izm
            // 
            this.btn_izm.Location = new System.Drawing.Point(12, 12);
            this.btn_izm.Name = "btn_izm";
            this.btn_izm.Size = new System.Drawing.Size(169, 53);
            this.btn_izm.TabIndex = 2;
            this.btn_izm.Text = "Изменить";
            this.btn_izm.UseVisualStyleBackColor = true;
            this.btn_izm.Click += new System.EventHandler(this.btn_izm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.табельныйНомерDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сотрудникиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(280, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(547, 283);
            this.dataGridView1.TabIndex = 4;
            // 
            // табельныйНомерDataGridViewTextBoxColumn
            // 
            this.табельныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn.Name = "табельныйНомерDataGridViewTextBoxColumn";
            this.табельныйНомерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.bindingSource1;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // информацияОСотрудникахBindingSource
            // 
            this.информацияОСотрудникахBindingSource.DataMember = "Информация о сотрудниках";
            this.информацияОСотрудникахBindingSource.DataSource = this.bindingSource1;
            // 
            // информация_о_сотрудникахTableAdapter
            // 
            this.информация_о_сотрудникахTableAdapter.ClearBeforeFill = true;
            // 
            // информацияОСотрудникахBindingSource1
            // 
            this.информацияОСотрудникахBindingSource1.DataMember = "Информация о сотрудниках";
            this.информацияОСотрудникахBindingSource1.DataSource = this.bindingSource1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.табельныйНомерDataGridViewTextBoxColumn1,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.банковскийСчетDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.паспортныеДанныеDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.информацияОСотрудникахBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(849, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(554, 283);
            this.dataGridView2.TabIndex = 5;
            // 
            // табельныйНомерDataGridViewTextBoxColumn1
            // 
            this.табельныйНомерDataGridViewTextBoxColumn1.DataPropertyName = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn1.HeaderText = "Табельный номер";
            this.табельныйНомерDataGridViewTextBoxColumn1.Name = "табельныйНомерDataGridViewTextBoxColumn1";
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            // 
            // банковскийСчетDataGridViewTextBoxColumn
            // 
            this.банковскийСчетDataGridViewTextBoxColumn.DataPropertyName = "Банковский счет";
            this.банковскийСчетDataGridViewTextBoxColumn.HeaderText = "Банковский счет";
            this.банковскийСчетDataGridViewTextBoxColumn.Name = "банковскийСчетDataGridViewTextBoxColumn";
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            // 
            // паспортныеДанныеDataGridViewTextBoxColumn
            // 
            this.паспортныеДанныеDataGridViewTextBoxColumn.DataPropertyName = "Паспортные данные";
            this.паспортныеДанныеDataGridViewTextBoxColumn.HeaderText = "Паспортные данные";
            this.паспортныеДанныеDataGridViewTextBoxColumn.Name = "паспортныеДанныеDataGridViewTextBoxColumn";
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // информацияОСотрудникахBindingSource2
            // 
            this.информацияОСотрудникахBindingSource2.DataMember = "Информация о сотрудниках";
            this.информацияОСотрудникахBindingSource2.DataSource = this.bindingSource1;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(12, 188);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(169, 52);
            this.btn_sort.TabIndex = 6;
            this.btn_sort.Text = "Сортировка/Поиск/Фильрация";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 348);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_izm);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pr_20_102k_chm22DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОСотрудникахBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОСотрудникахBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОСотрудникахBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private _pr_20_102k_chm22DataSet _pr_20_102k_chm22DataSet;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_izm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private _pr_20_102k_chm22DataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn табельныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource информацияОСотрудникахBindingSource;
        private _pr_20_102k_chm22DataSetTableAdapters.Информация_о_сотрудникахTableAdapter информация_о_сотрудникахTableAdapter;
        private System.Windows.Forms.BindingSource информацияОСотрудникахBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn табельныйНомерDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn банковскийСчетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортныеДанныеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource информацияОСотрудникахBindingSource2;
        private System.Windows.Forms.Button btn_sort;
    }
}

