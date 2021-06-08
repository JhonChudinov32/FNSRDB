namespace WindowsFormsApp1
{
    partial class Form9
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fnsDataSet6 = new WindowsFormsApp1.fnsDataSet6();
            this.nEDOIMKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEDOIMKTableAdapter = new WindowsFormsApp1.fnsDataSet6TableAdapters.NEDOIMKTableAdapter();
            this.рИЦDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеНалогаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сумНедНалогDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаПениDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаШтрафаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяСуммаНедоимDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEDOIMKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.рИЦDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.наименованиеНалогаDataGridViewTextBoxColumn,
            this.сумНедНалогDataGridViewTextBoxColumn,
            this.суммаПениDataGridViewTextBoxColumn,
            this.суммаШтрафаDataGridViewTextBoxColumn,
            this.общаяСуммаНедоимDataGridViewTextBoxColumn,
            this.годDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nEDOIMKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(929, 583);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(829, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выгрузка в Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // fnsDataSet6
            // 
            this.fnsDataSet6.DataSetName = "fnsDataSet6";
            this.fnsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nEDOIMKBindingSource
            // 
            this.nEDOIMKBindingSource.DataMember = "NEDOIMK";
            this.nEDOIMKBindingSource.DataSource = this.fnsDataSet6;
            // 
            // nEDOIMKTableAdapter
            // 
            this.nEDOIMKTableAdapter.ClearBeforeFill = true;
            // 
            // рИЦDataGridViewTextBoxColumn
            // 
            this.рИЦDataGridViewTextBoxColumn.DataPropertyName = "РИЦ";
            this.рИЦDataGridViewTextBoxColumn.HeaderText = "РИЦ";
            this.рИЦDataGridViewTextBoxColumn.Name = "рИЦDataGridViewTextBoxColumn";
            // 
            // иННDataGridViewTextBoxColumn
            // 
            this.иННDataGridViewTextBoxColumn.DataPropertyName = "ИНН";
            this.иННDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.иННDataGridViewTextBoxColumn.Name = "иННDataGridViewTextBoxColumn";
            // 
            // наименованиеНалогаDataGridViewTextBoxColumn
            // 
            this.наименованиеНалогаDataGridViewTextBoxColumn.DataPropertyName = "Наименование налога";
            this.наименованиеНалогаDataGridViewTextBoxColumn.HeaderText = "Наименование налога";
            this.наименованиеНалогаDataGridViewTextBoxColumn.Name = "наименованиеНалогаDataGridViewTextBoxColumn";
            this.наименованиеНалогаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сумНедНалогDataGridViewTextBoxColumn
            // 
            this.сумНедНалогDataGridViewTextBoxColumn.DataPropertyName = "СумНедНалог";
            this.сумНедНалогDataGridViewTextBoxColumn.HeaderText = "СумНедНалог";
            this.сумНедНалогDataGridViewTextBoxColumn.Name = "сумНедНалогDataGridViewTextBoxColumn";
            // 
            // суммаПениDataGridViewTextBoxColumn
            // 
            this.суммаПениDataGridViewTextBoxColumn.DataPropertyName = "Сумма пени";
            this.суммаПениDataGridViewTextBoxColumn.HeaderText = "Сумма пени";
            this.суммаПениDataGridViewTextBoxColumn.Name = "суммаПениDataGridViewTextBoxColumn";
            // 
            // суммаШтрафаDataGridViewTextBoxColumn
            // 
            this.суммаШтрафаDataGridViewTextBoxColumn.DataPropertyName = "Сумма Штрафа";
            this.суммаШтрафаDataGridViewTextBoxColumn.HeaderText = "Сумма Штрафа";
            this.суммаШтрафаDataGridViewTextBoxColumn.Name = "суммаШтрафаDataGridViewTextBoxColumn";
            // 
            // общаяСуммаНедоимDataGridViewTextBoxColumn
            // 
            this.общаяСуммаНедоимDataGridViewTextBoxColumn.DataPropertyName = "ОбщаяСуммаНедоим";
            this.общаяСуммаНедоимDataGridViewTextBoxColumn.HeaderText = "ОбщаяСуммаНедоим";
            this.общаяСуммаНедоимDataGridViewTextBoxColumn.Name = "общаяСуммаНедоимDataGridViewTextBoxColumn";
            // 
            // годDataGridViewTextBoxColumn
            // 
            this.годDataGridViewTextBoxColumn.DataPropertyName = "Год";
            this.годDataGridViewTextBoxColumn.HeaderText = "Год";
            this.годDataGridViewTextBoxColumn.Name = "годDataGridViewTextBoxColumn";
            this.годDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 640);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Недоимки";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEDOIMKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private fnsDataSet6 fnsDataSet6;
        private System.Windows.Forms.BindingSource nEDOIMKBindingSource;
        private fnsDataSet6TableAdapters.NEDOIMKTableAdapter nEDOIMKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn рИЦDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеНалогаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сумНедНалогDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаПениDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаШтрафаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяСуммаНедоимDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годDataGridViewTextBoxColumn;
    }
}