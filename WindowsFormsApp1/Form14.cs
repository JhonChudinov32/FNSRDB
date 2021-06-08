using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form14 : Form
    {
        SqlConnection mainConnection = new SqlConnection(@"Data Source=DPO-STAT1\SQLEXPRESS;Initial Catalog=fns;Integrated Security=True;Connect Timeout=10000");
        public Form14()
        {
            InitializeComponent();

        }
        public string login;
        public string password;
        private void Form14_Load(object sender, EventArgs e)
        {
         
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            spiskiRICTableAdapter.Update(fnsDataSet7);

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2 != null && dataGridView2.Rows.Count > 0)
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = "DELETE FROM SpiskiRIC";

                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
               spiskiRICTableAdapter.Fill(this.fnsDataSet7.SpiskiRIC); // "Синхронизируем" пустую таблицу в БД и DataTable
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form14.ActiveForm.Hide();
            Form1 MyForm1 = new Form1
            {
                login = login,
                password = password
            };
            MyForm1.ShowDialog();
            Close();
        }
        private void ParserRIC(string file)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            mainConnection.Open();
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(file);
            xlWorkSheet = xlWorkBook.Worksheets["Sheet1"];
            xlRange = xlWorkSheet.UsedRange;
            int i = 0;
            for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
            {
                i++;
                dataGridView1.Rows.Add(xlRange.Cells[xlRow, 1].text, xlRange.Cells[xlRow, 2].text, xlRange.Cells[xlRow, 3].text);
                // внесение данных в БД
                SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.SpiskiRIC(РИЦ, Наименование,ИНН) Values (@attr1,@attr2,@attr3)", mainConnection);

                cmd.Parameters.AddWithValue("@attr1", xlRange.Cells[xlRow, 1].text);
                cmd.Parameters.AddWithValue("@attr2", xlRange.Cells[xlRow, 2].text);
                cmd.Parameters.AddWithValue("@attr3", xlRange.Cells[xlRow, 3].text);
                cmd.ExecuteNonQuery();
            }

            mainConnection.Close();
            xlWorkBook.Close();
            xlApp.Quit();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
              

                //поиск с директории диска С
                openFileDialog1.InitialDirectory = "c:\\";
                //включаем возможность выбора несколько файлов
                openFileDialog1.Multiselect = true;
                //включаем фильтр только XML
                openFileDialog1.Filter = "Excel office |*.xls;*.xlsx";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var Filenames = openFileDialog1.FileNames;
                    //цикл открытия файлов поочередно
                    foreach (string fil in openFileDialog1.FileNames)
                    {
                        ParserRIC(fil);

                    }
                }
            }
        }

    }
}
