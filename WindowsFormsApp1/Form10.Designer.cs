namespace WindowsFormsApp1
{
    partial class Form10
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fnsDataSet4 = new WindowsFormsApp1.fnsDataSet4();
            this.pRAVONARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRAVONARTableAdapter = new WindowsFormsApp1.fnsDataSet4TableAdapters.PRAVONARTableAdapter();
            this.рИЦDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.правонарушениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAVONARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выгрузка в Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.рИЦDataGridViewTextBoxColumn,
            this.иННDataGridViewTextBoxColumn,
            this.правонарушениеDataGridViewTextBoxColumn,
            this.годDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRAVONARBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 322);
            this.dataGridView1.TabIndex = 2;
            // 
            // fnsDataSet4
            // 
            this.fnsDataSet4.DataSetName = "fnsDataSet4";
            this.fnsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRAVONARBindingSource
            // 
            this.pRAVONARBindingSource.DataMember = "PRAVONAR";
            this.pRAVONARBindingSource.DataSource = this.fnsDataSet4;
            // 
            // pRAVONARTableAdapter
            // 
            this.pRAVONARTableAdapter.ClearBeforeFill = true;
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
            // правонарушениеDataGridViewTextBoxColumn
            // 
            this.правонарушениеDataGridViewTextBoxColumn.DataPropertyName = "Правонарушение";
            this.правонарушениеDataGridViewTextBoxColumn.HeaderText = "Правонарушение";
            this.правонарушениеDataGridViewTextBoxColumn.Name = "правонарушениеDataGridViewTextBoxColumn";
            this.правонарушениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // годDataGridViewTextBoxColumn
            // 
            this.годDataGridViewTextBoxColumn.DataPropertyName = "Год";
            this.годDataGridViewTextBoxColumn.HeaderText = "Год";
            this.годDataGridViewTextBoxColumn.Name = "годDataGridViewTextBoxColumn";
            this.годDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form10";
            this.Text = "Штрафы";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAVONARBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private fnsDataSet4 fnsDataSet4;
        private System.Windows.Forms.BindingSource pRAVONARBindingSource;
        private fnsDataSet4TableAdapters.PRAVONARTableAdapter pRAVONARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn рИЦDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn правонарушениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годDataGridViewTextBoxColumn;
    }
}