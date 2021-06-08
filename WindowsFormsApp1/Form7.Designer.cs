namespace WindowsFormsApp1
{
    partial class Form7
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
            this.fnsDataSet10 = new WindowsFormsApp1.fnsDataSet10();
            this.dOCHODRASHODBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCHODRASHODTableAdapter = new WindowsFormsApp1.fnsDataSet10TableAdapters.DOCHODRASHODTableAdapter();
            this.рИЦDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаДоходовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаРасходовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCHODRASHODBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.рИЦDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.суммаДоходовDataGridViewTextBoxColumn,
            this.суммаРасходовDataGridViewTextBoxColumn,
            this.годDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dOCHODRASHODBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выгрузка в Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // fnsDataSet10
            // 
            this.fnsDataSet10.DataSetName = "fnsDataSet10";
            this.fnsDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCHODRASHODBindingSource
            // 
            this.dOCHODRASHODBindingSource.DataMember = "DOCHODRASHOD";
            this.dOCHODRASHODBindingSource.DataSource = this.fnsDataSet10;
            // 
            // dOCHODRASHODTableAdapter
            // 
            this.dOCHODRASHODTableAdapter.ClearBeforeFill = true;
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
            // суммаДоходовDataGridViewTextBoxColumn
            // 
            this.суммаДоходовDataGridViewTextBoxColumn.DataPropertyName = "Сумма доходов";
            this.суммаДоходовDataGridViewTextBoxColumn.HeaderText = "Сумма доходов";
            this.суммаДоходовDataGridViewTextBoxColumn.Name = "суммаДоходовDataGridViewTextBoxColumn";
            this.суммаДоходовDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаРасходовDataGridViewTextBoxColumn
            // 
            this.суммаРасходовDataGridViewTextBoxColumn.DataPropertyName = "Сумма Расходов";
            this.суммаРасходовDataGridViewTextBoxColumn.HeaderText = "Сумма Расходов";
            this.суммаРасходовDataGridViewTextBoxColumn.Name = "суммаРасходовDataGridViewTextBoxColumn";
            this.суммаРасходовDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // годDataGridViewTextBoxColumn
            // 
            this.годDataGridViewTextBoxColumn.DataPropertyName = "Год";
            this.годDataGridViewTextBoxColumn.HeaderText = "Год";
            this.годDataGridViewTextBoxColumn.Name = "годDataGridViewTextBoxColumn";
            this.годDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Доходы и Расходы";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCHODRASHODBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private fnsDataSet10 fnsDataSet10;
        private System.Windows.Forms.BindingSource dOCHODRASHODBindingSource;
        private fnsDataSet10TableAdapters.DOCHODRASHODTableAdapter dOCHODRASHODTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn рИЦDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаДоходовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаРасходовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годDataGridViewTextBoxColumn;
    }
}