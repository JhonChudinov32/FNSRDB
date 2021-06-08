namespace WindowsFormsApp1
{
    partial class Form8
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
            this.fnsDataSet3 = new WindowsFormsApp1.fnsDataSet3();
            this.rICNALOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rICNALOGTableAdapter = new WindowsFormsApp1.fnsDataSet3TableAdapters.RICNALOGTableAdapter();
            this.рИЦDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеНалогаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summUplnalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rICNALOGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.рИЦDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.наименованиеНалогаDataGridViewTextBoxColumn,
            this.summUplnalogDataGridViewTextBoxColumn,
            this.годDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rICNALOGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выгрузка в Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // fnsDataSet3
            // 
            this.fnsDataSet3.DataSetName = "fnsDataSet3";
            this.fnsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rICNALOGBindingSource
            // 
            this.rICNALOGBindingSource.DataMember = "RICNALOG";
            this.rICNALOGBindingSource.DataSource = this.fnsDataSet3;
            // 
            // rICNALOGTableAdapter
            // 
            this.rICNALOGTableAdapter.ClearBeforeFill = true;
            // 
            // рИЦDataGridViewTextBoxColumn
            // 
            this.рИЦDataGridViewTextBoxColumn.DataPropertyName = "РИЦ";
            this.рИЦDataGridViewTextBoxColumn.HeaderText = "РИЦ";
            this.рИЦDataGridViewTextBoxColumn.Name = "рИЦDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
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
            // summUplnalogDataGridViewTextBoxColumn
            // 
            this.summUplnalogDataGridViewTextBoxColumn.DataPropertyName = "summUplnalog";
            this.summUplnalogDataGridViewTextBoxColumn.HeaderText = "summUplnalog";
            this.summUplnalogDataGridViewTextBoxColumn.Name = "summUplnalogDataGridViewTextBoxColumn";
            // 
            // годDataGridViewTextBoxColumn
            // 
            this.годDataGridViewTextBoxColumn.DataPropertyName = "Год";
            this.годDataGridViewTextBoxColumn.HeaderText = "Год";
            this.годDataGridViewTextBoxColumn.Name = "годDataGridViewTextBoxColumn";
            this.годDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 426);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Налоги";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rICNALOGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private fnsDataSet3 fnsDataSet3;
        private System.Windows.Forms.BindingSource rICNALOGBindingSource;
        private fnsDataSet3TableAdapters.RICNALOGTableAdapter rICNALOGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn рИЦDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеНалогаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summUplnalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годDataGridViewTextBoxColumn;
    }
}