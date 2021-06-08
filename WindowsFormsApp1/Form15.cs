using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace WindowsFormsApp1
{
    public partial class Form15 : Form
    {
        SqlConnection mainConnection = new SqlConnection(@"Data Source=DPO-STAT1\SQLEXPRESS;Initial Catalog=fns;Integrated Security=True");
        public Form15()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "", "011",

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
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }
        public void Loadfiles(string[] filenames)
        {
            try
              {
                progressBar1.Maximum = filenames.Length;
                double s = 100;
                double gg = progressBar1.Maximum / s;
                progressBar1.Value = progressBar1.Value + 1;
                Application.DoEvents();
                label1.Text = "Обработано/Всего : " + progressBar1.Value.ToString() + "/" + progressBar1.Maximum.ToString();
                label2.Text = "Процент загрузки: " + ((progressBar1.Value) / (Math.Round(gg))).ToString("0.00");
              }
              catch (Exception ex)
              {
                MessageBox.Show(ex.ToString());
              }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
              //  mainConnection.Open();
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

                        ConvertExcelAsMemoryStream(fil);
                        Loadfiles(Filenames);
                      
                    }
               //     mainConnection.Close();

                }
            }
        }
        public static void ConvertExcelAsMemoryStream(string files)
        {
            Microsoft.Office.Interop.Excel.Application app;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            try
              {
          
                 for (int i=2; i<=3; i++)  
                    {

                    app = new Microsoft.Office.Interop.Excel.Application
                    {
                        Visible = false
                    };

                    Microsoft.Office.Interop.Excel.XlFixedFormatQuality paramExportQuality =
                    Microsoft.Office.Interop.Excel.XlFixedFormatQuality.xlQualityStandard;
                    bool paramOpenAfterPublish = false;
                    bool paramIncludeDocProps = true;
                    bool paramIgnorePrintAreas = true;
                    object paramFromPage = Type.Missing;
                    object paramToPage = Type.Missing;

                    workbook = app.Workbooks.Open(files, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value); //к вашей книге
                 
                    app.Worksheets[i].ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, files + i, 
                        paramExportQuality,paramIncludeDocProps,paramIgnorePrintAreas,paramFromPage,paramToPage,paramOpenAfterPublish);//куда сохраняете

                    workbook.Close();
                    app.Quit();
                    }
              }
              catch (Exception ex)
              {
                MessageBox.Show(ex.ToString());
              }
        }
        public DataSet ParserGirbo(string file)
        {

            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel.Workbook oWB;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;

            try
            {

                //  creat a Application object
                oXL = new Microsoft.Office.Interop.Excel.Application();
                //   get   WorkBook  object
                oWB = oXL.Workbooks.Open(file, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value);

                //   get   WorkSheet object 
                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oWB.Sheets[2];
                System.Data.DataTable dt = new System.Data.DataTable("Balance");
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                DataRow dr;

                StringBuilder sb = new StringBuilder();
                int jValue = oSheet.UsedRange.Cells.Columns.Count;
                int iValue = oSheet.UsedRange.Cells.Rows.Count;
                //  get data columns
                for (int j = 1; j <= jValue; j++)
                {
                    dt.Columns.Add("column" + j, System.Type.GetType("System.String"));
                }

                //string colString = sb.ToString().Trim();
                //string[] colArray = colString.Split(':');

                //  get data in cell
                for (int i = 1; i <= iValue; i++)
                {
                    dr = ds.Tables["dtExcel"].NewRow();
                    for (int j = 1; j <= jValue; j++)
                    {
                        oRng = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[i, j];
                        string strValue = oRng.Text.ToString();
                        dr["column" + j] = strValue;
                    }
                    ds.Tables["Balance"].Rows.Add(dr);
                }

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Dispose();

                /*    // load Excel file
                    Workbook workbook = new Workbook();
                    workbook.LoadFromFile(file);

                    // Set PDF template
                    PdfDocument pdfDocument = new PdfDocument();
                    pdfDocument.PageSettings.Orientation = PdfPageOrientation.Landscape;
                    pdfDocument.PageSettings.Width = 970;
                    pdfDocument.PageSettings.Height = 850;

                    //Convert Excel to PDF using the template above
                    PdfConverter pdfConverter = new PdfConverter(workbook);
                    PdfConverterSettings settings = new PdfConverterSettings();
                    settings.TemplateDocument = pdfDocument;
                    pdfDocument = pdfConverter.Convert(settings);

                    // Save and preview PDF
                    pdfDocument.SaveToFile("sample.pdf");*/

                /*  Microsoft.Office.Interop.Excel.Application xlApp;
                  Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                  Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                  Microsoft.Office.Interop.Excel.Range xlRange;

                  xlApp = new Microsoft.Office.Interop.Excel.Application();
                  xlWorkBook = xlApp.Workbooks.Open(file);
                  xlWorkSheet = xlWorkBook.Worksheets["Balance"];
                  xlRange = xlWorkSheet.UsedRange;
                  int rowCount = xlRange.Rows.Count;
                  int colCount = xlRange.Columns.Count;
                  for (int K = 1; K <= rowCount; K++)
                      {
                      for (int L = 1; L <= colCount; L++)
                      {

                          if (xlRange.Cells[K, L] != null && xlRange.Cells[K, L].Value != null)

                          dataGridView1.Rows.Add(xlRange.Cells[K, 1].text, xlRange.Cells[K, 2].text, xlRange.Cells[K, 3].text, xlRange.Cells[K, 4].text, xlRange.Cells[K, 5].text);
                            SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.SpiskiRIC(РИЦ, Наименование,ИНН) Values (@attr1,@attr2,@attr3)", mainConnection);

                             cmd.Parameters.AddWithValue("@attr1", xlRange.Cells[xlRow, 1].text);
                             cmd.Parameters.AddWithValue("@attr2", xlRange.Cells[xlRow, 2].text);
                             cmd.Parameters.AddWithValue("@attr3", xlRange.Cells[xlRow, 3].text);
                             cmd.ExecuteNonQuery();
                      }
                  }

           xlWorkBook.Close();
           xlApp.Quit();*/

           }
        }
        private void ArcGirbo(string file)
        {
            string folder = @"X:\DUS\PravOtnosh\Чудинов\ГИРБО";// папка, в которую надо распаковать архив
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = @"C:\Program Files\WinRAR\WinRAR.exe";
            p.StartInfo.Arguments = string.Format("x -o+ \"{0}\" \"{1}\"", file, folder);
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            p.EnableRaisingEvents = true;
            p.Start();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
          using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
          {
                        openFileDialog1.Filter = "WinRAR | *.rar;*.zip";
                        openFileDialog1.Multiselect = true;
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            var FileNames = openFileDialog1.FileNames;
                            foreach (string fil in openFileDialog1.FileNames)
                            {
                            Loadfiles(FileNames);
                            ArcGirbo(fil);
                            }
                        }
          }
        }
        private void Button3_Click(object sender, EventArgs e)
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
        private void Button4_Click(object sender, EventArgs e)
        {
             using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
             {
                  //mainConnection.Open();
                  //поиск с директории диска С
                  openFileDialog1.InitialDirectory = @"X:\DUS\PravOtnosh\Чудинов\\";
                  //включаем возможность выбора несколько файлов
                  openFileDialog1.Multiselect = true;
                  //включаем фильтр только XML
                  openFileDialog1.Filter = "pdf file |*.pdf";

                  if (openFileDialog1.ShowDialog() == DialogResult.OK)
                  {
                      var Filenames = openFileDialog1.FileNames;
                          Parseline(Filenames);
                  }
             }
        
        }
        private void Parseline(string[] files)
        {
            
            try
            {
             
                    foreach (var fil in files)
                    {
                    Loadfiles(files);
                        if (fil != null)
                        {
                        mainConnection.Open();
                        if (fil.Contains("xlsx2.pdf"))
                        {
                         string   f2 = Path.GetFileName(fil);
                            int k = 0;
                            SqlCommand SqlProv;
                            SqlProv = new SqlCommand("select COUNT(SpiskiRIC.id) as CountTabNum from [Balance] right join [SpiskiRIC] on dbo.SpiskiRIC.ИНН = dbo.[Balance].inn" +
                                " where [Balance] ='" + f2+"' ", mainConnection);
                          //  mainConnection.Open();
                            k = (Int32)SqlProv.ExecuteScalar();
                            //   mainConnection.Close();
                            if (k == 0)
                            {
                                SqlCommand cmd1 = new SqlCommand(@"INSERT INTO [Balance]([inn],[Balance]) Values ('" + f2[8] + f2[9] + f2[10] + f2[11] + f2[12] + f2[13] + f2[14] + f2[15] + f2[16] + f2[17] + "', @f2)", mainConnection);
                                cmd1.Parameters.AddWithValue("@f2", f2);
                                cmd1.ExecuteNonQuery();
                            }
                        }
                        if (fil.Contains("xlsx3.pdf"))
                        {
                        string    f3 = Path.GetFileName(fil);
                            int k = 0;
                            SqlCommand SqlProv;
                            SqlProv = new SqlCommand("select COUNT(SpiskiRIC.id) as CountTabNum from [Financial Result] right join [SpiskiRIC] on dbo.SpiskiRIC.ИНН = dbo.[Financial Result].inn " +
                                "where [Financial Result] ='" + f3 + "' ", mainConnection);
                            //  mainConnection.Open();
                            k = (Int32)SqlProv.ExecuteScalar();
                            //   mainConnection.Close();
                            if (k == 0)
                            {
                                SqlCommand cmd = new SqlCommand(@"INSERT INTO [Financial Result]([inn],[Financial Result]) Values ('" + f3[8] + f3[9] + f3[10] + f3[11] + f3[12] + f3[13] + f3[14] + f3[15] + f3[16] + f3[17] + "',  @f3)", mainConnection);
                                cmd.Parameters.AddWithValue("@f3", f3);
                                cmd.ExecuteNonQuery();
                            }
                        }
                  
                      
                        mainConnection.Close();

                    }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fnsDataSet8.finotchet". При необходимости она может быть перемещена или удалена.
            this.finotchetTableAdapter.Fill(this.fnsDataSet8.finotchet);
            try
            {
                int k = 0;
                mainConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(middlename)as qw FROM [fns].[dbo].[User] WHERE [login] ='" + login + "' and [password] ='" + password + "' and [is_setting_allow] = 'true' ", mainConnection);
                k = (Int32)cmd.ExecuteScalar();
                mainConnection.Close();
                if (k != 0)
                {
                    button7.Visible = true;
                 
                }
                else
                {
                    button7.Visible = false;
                   
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }

        }
        private void Button5_Click(object sender, EventArgs e)
        {
            string s = dt[3, dt.CurrentRow.Index].Value.ToString();
            if (s != "нет информации")
            {
                string fn = @"X:\DUS\PravOtnosh\Чудинов\ГИРБО\" + s;//путь к файлу
                var proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = fn;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }
            else MessageBox.Show("Файл с данными отсутствуют");
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            string s = dt[4, dt.CurrentRow.Index].Value.ToString();
            if (s != "нет информации")
            {
                string fn = @"X:\DUS\PravOtnosh\Чудинов\ГИРБО\" + s;//путь к файлу
                var proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = fn;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }
            else MessageBox.Show("Файл с данными отсутствуют");
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            mainConnection.Open();
            SqlCommand tr = new SqlCommand(@"truncate table [Balance] truncate table [Financial Result] ", mainConnection);
            tr.ExecuteNonQuery();
            MessageBox.Show("Данные удалены");
            mainConnection.Close();
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            List<string> filterParts = new List<string>();
            if (comboBox1.SelectedIndex >= 0)
                filterParts.Add("РИЦ like '%" + comboBox1.Text + "%'");
            if (textBox1.Text != null)
                filterParts.Add("Наименование like '%" + textBox1.Text + "%'");
            if (textBox2.Text != null)
                filterParts.Add("ИНН  like '%" + textBox2.Text + "%'");
            string filter = string.Join(" AND ", filterParts);
            this.finotchetBindingSource1.Filter = filter;
        }
      private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            this.finotchetBindingSource1.Filter = "";
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                dt.Rows[i].Visible = true;
            }
        }
        public string login;
        public string password;
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
        private void Button10_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Documents (*.xls)|*.xls",
                FileName = "ГИРБО" + " " + DateTime.Today.Date.ToString("d") + ".xls"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dt, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }
    }
}
