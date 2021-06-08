using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form13 : Form
    {
        SqlConnection mainConnection = new SqlConnection(@"Data Source=DPO-STAT1\SQLEXPRESS;Initial Catalog=fns;Integrated Security=True;Connect Timeout=10000");
        public Form13()
        {
            InitializeComponent();
        }
        public string login;
        public string password;
        private void Button2_Click(object sender, EventArgs e)
        {
            Form13.ActiveForm.Hide();
            Form1 MyForm1 = new Form1
            {
                login = login,
                password = password
            };
            MyForm1.ShowDialog();
            Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            mainConnection.Open();
            SqlCommand tr = new SqlCommand(@"truncate table Nedoimki truncate table Pravonarush", mainConnection);
            tr.ExecuteNonQuery();
            MessageBox.Show("Данные удалены");
            mainConnection.Close();
        }
    }
}
