using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form16 : Form
    {
        SqlConnection mainCon = new SqlConnection(@"Data Source=DPO-STAT1\SQLEXPRESS;Initial Catalog=fns;Integrated Security=True;Connect Timeout=10000");
        public Form16()
        {
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int k = 0;
                mainCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(middlename)as qw FROM [fns].[dbo].[User] WHERE [login] ='" + textBox1.Text +"' and [password] ='"+ textBox2.Text +"' and [isenabled] = 'true' ", mainCon);
                k = (Int32)cmd.ExecuteScalar();
               // mainConnection.Close();
                if (k != 0)
                {
                    Form1 s = new Form1
                    {
                        login = this.textBox1.Text,
                        password = this.textBox2.Text
                    };
                    s.Show();
                    this.Hide();
                    
            
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("Неправильный логин или пароль");
                }
            
                    Properties.Settings.Default.checkbox = checkBox1.Checked;
                    Properties.Settings.Default.textbox1 = textBox1.Text;
                    Properties.Settings.Default.textbox2 = textBox2.Text;
                    Properties.Settings.Default.Save();
              
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.checkbox;
            textBox1.Text = Properties.Settings.Default.textbox1;
            textBox2.Text = Properties.Settings.Default.textbox2;
        }
    }
}
