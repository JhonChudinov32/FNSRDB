using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form3
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.regionMSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fnsDataSet17 = new WindowsFormsApp1.fnsDataSet17();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.fnsMSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fnsDataSet18 = new WindowsFormsApp1.fnsDataSet18();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rMSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fnsDataSet13 = new WindowsFormsApp1.fnsDataSet13();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idfnsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOrgSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateMSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodOKVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOKVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naselpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rayonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rMSPTableAdapter = new WindowsFormsApp1.fnsDataSet13TableAdapters.RMSPTableAdapter();
            this.regionMSPTableAdapter = new WindowsFormsApp1.fnsDataSet17TableAdapters.RegionMSPTableAdapter();
            this.fnsMSPTableAdapter = new WindowsFormsApp1.fnsDataSet18TableAdapters.FnsMSPTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionMSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsMSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(1379, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 424);
            this.panel2.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(109, 122);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Отменить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(205, 122);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Выбрать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ООО/АО/ИП";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Регион";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ИНН";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ОКВЭД";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(109, 286);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Отмена";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(205, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Выгрузка РМСП";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(109, 259);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(181, 21);
            this.comboBox4.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.regionMSPBindingSource;
            this.comboBox3.DisplayMember = "city";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(109, 232);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(181, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "city";
            // 
            // regionMSPBindingSource
            // 
            this.regionMSPBindingSource.DataMember = "RegionMSP";
            this.regionMSPBindingSource.DataSource = this.fnsDataSet17;
            // 
            // fnsDataSet17
            // 
            this.fnsDataSet17.DataSetName = "fnsDataSet17";
            this.fnsDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.fnsMSPBindingSource;
            this.comboBox2.DisplayMember = "nameRegion";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(109, 95);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(181, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "nameRegion";
            // 
            // fnsMSPBindingSource
            // 
            this.fnsMSPBindingSource.DataMember = "FnsMSP";
            this.fnsMSPBindingSource.DataSource = this.fnsDataSet18;
            // 
            // fnsDataSet18
            // 
            this.fnsDataSet18.DataSetName = "fnsDataSet18";
            this.fnsDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // rMSPBindingSource
            // 
            this.rMSPBindingSource.DataMember = "RMSP";
            this.rMSPBindingSource.DataSource = this.fnsDataSet13;
            // 
            // fnsDataSet13
            // 
            this.fnsDataSet13.DataSetName = "fnsDataSet13";
            this.fnsDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfnsDataGridViewTextBoxColumn,
            this.nameOrgSDataGridViewTextBoxColumn,
            this.innDataGridViewTextBoxColumn,
            this.dateMSPDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.kodOKVDataGridViewTextBoxColumn,
            this.nameOKVDataGridViewTextBoxColumn,
            this.nameRegionDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.kodRegionDataGridViewTextBoxColumn,
            this.naselpDataGridViewTextBoxColumn,
            this.rayonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rMSPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1359, 514);
            this.dataGridView1.TabIndex = 1;
            // 
            // idfnsDataGridViewTextBoxColumn
            // 
            this.idfnsDataGridViewTextBoxColumn.DataPropertyName = "id_fns";
            this.idfnsDataGridViewTextBoxColumn.HeaderText = "id_fns";
            this.idfnsDataGridViewTextBoxColumn.Name = "idfnsDataGridViewTextBoxColumn";
            // 
            // nameOrgSDataGridViewTextBoxColumn
            // 
            this.nameOrgSDataGridViewTextBoxColumn.DataPropertyName = "nameOrgS";
            this.nameOrgSDataGridViewTextBoxColumn.HeaderText = "nameOrgS";
            this.nameOrgSDataGridViewTextBoxColumn.Name = "nameOrgSDataGridViewTextBoxColumn";
            // 
            // innDataGridViewTextBoxColumn
            // 
            this.innDataGridViewTextBoxColumn.DataPropertyName = "inn";
            this.innDataGridViewTextBoxColumn.HeaderText = "inn";
            this.innDataGridViewTextBoxColumn.Name = "innDataGridViewTextBoxColumn";
            // 
            // dateMSPDataGridViewTextBoxColumn
            // 
            this.dateMSPDataGridViewTextBoxColumn.DataPropertyName = "dateMSP";
            this.dateMSPDataGridViewTextBoxColumn.HeaderText = "dateMSP";
            this.dateMSPDataGridViewTextBoxColumn.Name = "dateMSPDataGridViewTextBoxColumn";
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodOKVDataGridViewTextBoxColumn
            // 
            this.kodOKVDataGridViewTextBoxColumn.DataPropertyName = "kodOKV";
            this.kodOKVDataGridViewTextBoxColumn.HeaderText = "kodOKV";
            this.kodOKVDataGridViewTextBoxColumn.Name = "kodOKVDataGridViewTextBoxColumn";
            // 
            // nameOKVDataGridViewTextBoxColumn
            // 
            this.nameOKVDataGridViewTextBoxColumn.DataPropertyName = "nameOKV";
            this.nameOKVDataGridViewTextBoxColumn.HeaderText = "nameOKV";
            this.nameOKVDataGridViewTextBoxColumn.Name = "nameOKVDataGridViewTextBoxColumn";
            // 
            // nameRegionDataGridViewTextBoxColumn
            // 
            this.nameRegionDataGridViewTextBoxColumn.DataPropertyName = "nameRegion";
            this.nameRegionDataGridViewTextBoxColumn.HeaderText = "nameRegion";
            this.nameRegionDataGridViewTextBoxColumn.Name = "nameRegionDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // kodRegionDataGridViewTextBoxColumn
            // 
            this.kodRegionDataGridViewTextBoxColumn.DataPropertyName = "kodRegion";
            this.kodRegionDataGridViewTextBoxColumn.HeaderText = "kodRegion";
            this.kodRegionDataGridViewTextBoxColumn.Name = "kodRegionDataGridViewTextBoxColumn";
            // 
            // naselpDataGridViewTextBoxColumn
            // 
            this.naselpDataGridViewTextBoxColumn.DataPropertyName = "naselp";
            this.naselpDataGridViewTextBoxColumn.HeaderText = "naselp";
            this.naselpDataGridViewTextBoxColumn.Name = "naselpDataGridViewTextBoxColumn";
            // 
            // rayonDataGridViewTextBoxColumn
            // 
            this.rayonDataGridViewTextBoxColumn.DataPropertyName = "rayon";
            this.rayonDataGridViewTextBoxColumn.HeaderText = "rayon";
            this.rayonDataGridViewTextBoxColumn.Name = "rayonDataGridViewTextBoxColumn";
            // 
            // rMSPTableAdapter
            // 
            this.rMSPTableAdapter.ClearBeforeFill = true;
            // 
            // regionMSPTableAdapter
            // 
            this.regionMSPTableAdapter.ClearBeforeFill = true;
            // 
            // fnsMSPTableAdapter
            // 
            this.fnsMSPTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(1701, 762);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "Form3";
            this.Text = "Справочник ФНС";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionMSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsMSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnsDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

    //    private System.Windows.Forms.BindingSource RMSPBindingSource;

        #endregion


        private Panel panel2;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private fnsDataSet13 fnsDataSet13;
        private BindingSource rMSPBindingSource;
        private fnsDataSet13TableAdapters.RMSPTableAdapter rMSPTableAdapter;
        private DataGridViewTextBoxColumn idfnsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameOrgSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateMSPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kodOKVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameOKVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameRegionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kodRegionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn naselpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rayonDataGridViewTextBoxColumn;
        private Button button6;
        private Button button7;
        private fnsDataSet17 fnsDataSet17;
        private BindingSource regionMSPBindingSource;
        private fnsDataSet17TableAdapters.RegionMSPTableAdapter regionMSPTableAdapter;
        private fnsDataSet18 fnsDataSet18;
        private BindingSource fnsMSPBindingSource;
        private fnsDataSet18TableAdapters.FnsMSPTableAdapter fnsMSPTableAdapter;
    }
}