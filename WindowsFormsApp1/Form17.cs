using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        public string login;
        public string password;
        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fnsDataSet9.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.fnsDataSet9.User);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form17.ActiveForm.Hide();
            Form1 MyForm1 = new Form1
            {
                login = login,
                password = password
            };
            MyForm1.ShowDialog();
            Close();
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.userTableAdapter.Update(this.fnsDataSet9.User);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int c = 0; c < dataGridView1.Columns.Count; c++)
                {
                    if (dataGridView1[c, i].Value.ToString() == textBox1.Text)
                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;
                    }
                  
                }
            }

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = null;
         
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {

                this.userBindingSource.RemoveCurrent();
                this.userTableAdapter.Update(this.fnsDataSet9.User);
                this.userTableAdapter.Fill(this.fnsDataSet9.User);
                this.userBindingSource.MoveLast();
                dataGridView1.Update();
                MessageBox.Show("удаление успешно");
            }
            catch (System.Exception)
            {
                MessageBox.Show("неудача");
            }
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.userBindingSource.EndEdit();
                this.userTableAdapter.Update(this.fnsDataSet9.User);
                MessageBox.Show("Обновление успешно");
            }
            catch (System.Exception)
            {
                MessageBox.Show("неудача");
            }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {

            this.userTableAdapter.Update(this.fnsDataSet9.User);
            MessageBox.Show("Сохранение успешно");
            }
            catch (System.Exception)
            {
                MessageBox.Show("неудача");
            }
        }
    }
    
}

