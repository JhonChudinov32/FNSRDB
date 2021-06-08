using System;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public string login;
        public string password;
        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fnsDataSet3.RICNALOG". При необходимости она может быть перемещена или удалена.
            this.rICNALOGTableAdapter.Fill(this.fnsDataSet3.RICNALOG);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form8.ActiveForm.Hide();
            Form1 MyForm1 = new Form1
            {
                login = login,
                password = password
            };
            MyForm1.ShowDialog();
            Close();
        }
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value.ToString()) + "\t";
                stOutput += stLine + "\n";
            }
            Encoding utf8 = Encoding.GetEncoding(1251);
            byte[] output = utf8.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Documents (*.xls)|*.xls",
                FileName = "Выгрузка налогов РИЦ" + " " + DateTime.Today.Date.ToString("d") + ".xls"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }
      
    }
}
