using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
            Application.DoEvents();
            comboBox1.Items.AddRange(new string[] { "", "1 (Микропредприятие)", "2 (Малое предприятие)", "3 (Среднее предприятие)" });
            comboBox2.Items.AddRange(new string[] { "", "011",

"013",
"014",
"015",
"016",
"020",
"021",
"026",
"028",
"033",
"035",
"037",
"038",
"044",
"049",
"053",
"058",
"060",
"062",
"067",
"071",
"072",
"073",
"077",
"078",
"080",
"086",
"087",
"091",
"096",
"112",
"117",
"118",
"123",
"127",
"129",
"132",
"135",
"140",
"148",
"150",
"154",
"158",
"158",
"160",
"166",
"167",
"169",
"172",
"174",
"177",
"180",
"181",
"186",
"187",
"188",
"194",
"195",
"206",
"210",
"220",
"224",
"226",
"230",
"235",
"240",
"245",
"250",
"256",
"264",
"265",
"272",
"275",
"280",
"284",
"296",
"301",
"302",
"304",
"312",
"322",
"328",
"333",
"334",
"337",
"342",
"346",
"350",
"351",
"355",
"358",
"364",
"365",
"368",
"371",
"374",
"376",
"380",
"383",
"385",
"388",
"390",
"392",
"392",
"393",
"398",
"411",
"412",
"415",
"417",
"424",
"426",
"427",
"429",
"430",
"431",
"434",
"436",
"439",
"439",
"442",
"444",
"445",
"448",
"456",
"460",
"464",
"465",
"466",
"468",
"469",
"471",
"472",
"473",
"474",
"476",
"478",
"480",
"482",
"483",
"485",
"486",
"487",
"488",
"490",
"491",
"493",
"494",
"496",
"497",
"498",
"499",
"500",
"501",
"502",
"503",
"504",
"505",
"506",
"507",
"508",
"509",
"510",
"513",
"514",
"515",
"516",
"517",
"518",
"519",
"520",
"521",
"521",
"522",
"948",
"958",
"963"  });
        }
        public string login;
        public string password;
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fnsDataSet.RICRMSP". При необходимости она может быть перемещена или удалена.
            this.rICRMSPTableAdapter.Fill(this.fnsDataSet.RICRMSP);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form1 MyForm1 = new Form1
            {
                login = login,
                password = password
            };
            MyForm1.ShowDialog();
            Close();
        }
        private void Button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Documents (*.xls)|*.xls",
                FileName = "Выгрузка РМСП" + " " + DateTime.Today.Date.ToString("d") + ".xls"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
            }

        }
        private void ToCsV(DataGridView dGV, string filename)
        {
            try
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
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
             List<string> filterParts = new List<string>();
           if (comboBox1.SelectedIndex >= 0)
               filterParts.Add("Категория like '%" + comboBox1.Text + "%'");
           if (comboBox2.SelectedIndex >= 0)
               filterParts.Add("РИЦ  like '%" + comboBox2.Text + "%'");
           string filter = string.Join(" AND ", filterParts);
           this.rICRMSPBindingSource1.Filter = filter;
       
        }
        private void Button5_Click(object sender, EventArgs e)
        {
       
            this.rICRMSPBindingSource1.Filter = "";
         // comboBox1.SelectedIndex = 0;
         //  comboBox2.SelectedIndex = 0;
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           string selectedState = comboBox2.SelectedItem.ToString();
        }

    }
}