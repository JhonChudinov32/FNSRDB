using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form3 : System.Windows.Forms.Form
    {

        //  private Cache memoryCache;
        // Укажите строку подключения. Замените данное значение на a
        // правильную строку подключения к базе данных "Борей" для SQL-сервера 
        // база данных, доступная для вашей системы.
        //private string connectionString = "Data Source=DPO-STAT1/SQLEXPRESS;Initial Catalog=fns;Integrated Security=True;Connect Timeout=10000";
        /*   private string table = "RMSP";
           protected override void OnLoad(EventArgs e)
           {
               // Инициализация формы.
               this.AutoSize = true;
               this.Controls.Add(this.dataGridView1);
               this.Text = "РМСП";
               // Завершения инициализации объекта datagridview.
               this.dataGridView1.Size = new Size(735, 450);
               this.dataGridView1.Dock = DockStyle.None;
               this.dataGridView1.VirtualMode = true;
               this.dataGridView1.ReadOnly = true;
               this.dataGridView1.AllowUserToAddRows = false;
               this.dataGridView1.AllowUserToOrderColumns = false;
               this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
               this.dataGridView1.CellValueNeeded += new DataGridViewCellValueEventHandler(dataGridView1_CellValueNeeded);

               // Создать DataRetriever и используйте его для создания объекта кэша
               // и инициализировать столбцы и строки DataGridView.
               try
               {
                   DataRetriever retriever = new DataRetriever(connectionString, table);
                   memoryCache = new Cache(retriever, 16);
                   foreach (DataColumn column in retriever.Columns)
                   {
                       dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
                   }
                   this.dataGridView1.RowCount = retriever.RowCount;
               }
               catch (SqlException)
               {
                   MessageBox.Show("Соединение не может быть установлено. Убедитесь, что строка подключения является допустимой.");
                   Application.Exit();
               }
               // Регулировка ширины столбцов на основе отображаемых значений.
               this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
               base.OnLoad(e);
           }
           private void dataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
           {
               e.Value = memoryCache.RetrieveElement(e.RowIndex, e.ColumnIndex);
           }*/
        public Form3()
        {

            InitializeComponent();
             Application.DoEvents();
            comboBox1.Items.AddRange(new string[] { "", "1(Микропредприятие)", "2(Малое предприятие)", "3(Среднее предприятие)" });
            comboBox4.Items.AddRange(new string[] { "", "ИП", "ООО", "ЗАО", "АО" });
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        //    comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        //    comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
          
        }
      /*  public interface IDataPageRetriever
        {
            DataTable SupplyPageOfData(int lowerPageBoundary, int rowsPerPage);
        }
        public class DataRetriever : IDataPageRetriever
        {
            private string tableName;
            private SqlCommand command;

            public DataRetriever(string connectionString, string tableName)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                command = connection.CreateCommand();
                this.tableName = tableName;
            }

            private int rowCountValue = -1;
            public int RowCount
            {
                get
                {
                    // Возвращает существующее значение, если оно уже определено
                    if (rowCountValue != -1)
                    {
                        return rowCountValue;
                    }

                    // Извлечение количество строк из базы данных..
                    command.CommandText = "SELECT COUNT(*) FROM " + tableName;
                    rowCountValue = (int)command.ExecuteScalar();
                    return rowCountValue;
                }
            }

            private DataColumnCollection columnsValue;
            public DataColumnCollection Columns
            {
                get
                {
                    // Возвращает существующее значение, если оно уже определено.
                    if (columnsValue != null)
                    {
                        return columnsValue;
                    }
                    // Извлечение информации о столбце из базы данных.
                    command.CommandText = "SELECT * FROM " + tableName;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.FillSchema(table, SchemaType.Source);
                    columnsValue = table.Columns;
                    return columnsValue;
                }
            }
            private string commaSeparatedListOfColumnNamesValue = null;
            private string CommaSeparatedListOfColumnNames
            {
                get
                {
                    // Возвращает существующее значение, если оно уже определено.
                    if (commaSeparatedListOfColumnNamesValue != null)
                    {
                        return commaSeparatedListOfColumnNamesValue;
                    }

                    // Хранит список имен столбцов для использования в
                    // SupplyPageOfData method.
                    System.Text.StringBuilder commaSeparatedColumnNames =
                        new System.Text.StringBuilder();
                    bool firstColumn = true;
                    foreach (DataColumn column in Columns)
                    {
                        if (!firstColumn)
                        {
                            commaSeparatedColumnNames.Append(", ");
                        }
                        commaSeparatedColumnNames.Append(column.ColumnName);
                        firstColumn = false;
                    }

                    commaSeparatedListOfColumnNamesValue = commaSeparatedColumnNames.ToString();
                    return commaSeparatedListOfColumnNamesValue;
                }
            }

            // Объявленные переменные, которые будут повторно использоваться методом SupplyPageOfData.
            private string columnToSortBy;
            private SqlDataAdapter adapter = new SqlDataAdapter();
            public DataTable SupplyPageOfData(int lowerPageBoundary, int rowsPerPage)
            {
                // Сохранит имя столбца ID. Этот столбец должен содержать уникальные данные
                // значения, чтобы приведенный ниже SQL работал правильно.
                columnToSortBy = this.Columns[0].ColumnName;
                  if (!this.Columns[columnToSortBy].Unique)
                  {
                      throw new InvalidOperationException(String.Format("Column {0} must contain unique values.", columnToSortBy));
                  }
                // Извлечение указанного количества строк из базы данных, начиная с
                // со строки, заданной параметром lowerPageBoundary.
                command.CommandText = "Select Top " + rowsPerPage + " " +
                    CommaSeparatedListOfColumnNames + " From " + tableName +
                    " WHERE " + columnToSortBy + " NOT IN (SELECT TOP " +
                    lowerPageBoundary + " " + columnToSortBy + " From " +
                    tableName + " Order By " + columnToSortBy +
                    ") Order By " + columnToSortBy;
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                return table;
              }
        }
        public class Cache
        {
            private static int RowsPerPage;

            // Представляет  одну страницу данных.
            public struct DataPage
            {
                public DataTable table;
                private int lowestIndexValue;
                private int highestIndexValue;

                public DataPage(DataTable table, int rowIndex)
                {
                    this.table = table;
                    lowestIndexValue = MapToLowerBoundary(rowIndex);
                    highestIndexValue = MapToUpperBoundary(rowIndex);
                    System.Diagnostics.Debug.Assert(lowestIndexValue >= 0);
                    System.Diagnostics.Debug.Assert(highestIndexValue >= 0);
                }

                public int LowestIndex
                {
                    get
                    {
                        return lowestIndexValue;
                    }
                }

                public int HighestIndex
                {
                    get
                    {
                        return highestIndexValue;
                    }
                }

                public static int MapToLowerBoundary(int rowIndex)
                {
                    // Возвращает самый низкий индекс страницы, содержащей данный индекс.
                    return (rowIndex / RowsPerPage) * RowsPerPage;
                }

                private static int MapToUpperBoundary(int rowIndex)
                {
                    // Возвращает самый высокий индекс страницы, содержащей данный индекс.
                    return MapToLowerBoundary(rowIndex) + RowsPerPage - 1;
                }
            }

            private DataPage[] cachePages;
            private IDataPageRetriever dataSupply;

            public Cache(IDataPageRetriever dataSupplier, int rowsPerPage)
            {
                dataSupply = dataSupplier;
                Cache.RowsPerPage = rowsPerPage;
                LoadFirstTwoPages();
            }

            // Задает значение параметра элемента, если оно находится в кэше.
            private bool IfPageCached_ThenSetElement(int rowIndex,
                int columnIndex, ref string element)
            {
                if (IsRowCachedInPage(0, rowIndex))
                {
                    element = cachePages[0].table
                        .Rows[rowIndex % RowsPerPage][columnIndex].ToString();
                    return true;
                }
                else if (IsRowCachedInPage(1, rowIndex))
                {
                    element = cachePages[1].table
                        .Rows[rowIndex % RowsPerPage][columnIndex].ToString();
                    return true;
                }

                return false;
            }
            public string RetrieveElement(int rowIndex, int columnIndex)
            {
                string element = null;

                if (IfPageCached_ThenSetElement(rowIndex, columnIndex, ref element))
                {
                    return element;
                }
                else
                {
                    return RetrieveData_CacheIt_ThenReturnElement(
                        rowIndex, columnIndex);
                }
            }

            private void LoadFirstTwoPages()
            {
                cachePages = new DataPage[]{new DataPage(dataSupply.SupplyPageOfData(DataPage.MapToLowerBoundary(0), RowsPerPage), 0),
            new DataPage(dataSupply.SupplyPageOfData(DataPage.MapToLowerBoundary(RowsPerPage),RowsPerPage), RowsPerPage)};
            }
            private string RetrieveData_CacheIt_ThenReturnElement(
                int rowIndex, int columnIndex)
            {
                // Извлечение данных на странице, содержащих требуемое значение.
                DataTable table = dataSupply.SupplyPageOfData(
                    DataPage.MapToLowerBoundary(rowIndex), RowsPerPage);

               // Замените кэшированную страницу, расположенную дальше всего от запрашиваемой ячейки
                // с новой страницей, содержащей вновь полученные данные.
                cachePages[GetIndexToUnusedPage(rowIndex)] = new DataPage(table, rowIndex);

                return RetrieveElement(rowIndex, columnIndex);
            }
            // Возвращает индекс кэшированной страницы, наиболее удаленной от заданного индекса
            // и поэтому с наименьшей вероятностью будет использоваться повторно.
            private int GetIndexToUnusedPage(int rowIndex)
            {
                if (rowIndex > cachePages[0].HighestIndex &&
                    rowIndex > cachePages[1].HighestIndex)
                {
                    int offsetFromPage0 = rowIndex - cachePages[0].HighestIndex;
                    int offsetFromPage1 = rowIndex - cachePages[1].HighestIndex;
                    if (offsetFromPage0 < offsetFromPage1)
                    {
                        return 1;
                    }
                    return 0;
                }
                else
                {
                    int offsetFromPage0 = cachePages[0].LowestIndex - rowIndex;
                    int offsetFromPage1 = cachePages[1].LowestIndex - rowIndex;
                    if (offsetFromPage0 < offsetFromPage1)
                    {
                        return 1;
                    }
                    return 0;
                }
            }
            // Возвращает значение, указывающее, содержится ли данный индекс строки
            // в данном массиве данных.
            private bool IsRowCachedInPage(int pageNumber, int rowIndex)
            {
                return rowIndex <= cachePages[pageNumber].HighestIndex &&
                    rowIndex >= cachePages[pageNumber].LowestIndex;
            }
        }*/
     
        private void button1_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form1 MyForm1 = new Form1();
            MyForm1.login = login;
            MyForm1.password = password;
            MyForm1.ShowDialog();
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Выгрузка РМСП" + DateTime.Today.Date.ToString("d") + ".xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
            }
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
            bw.Write(output, 0, output.Length);
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedState = comboBox1.SelectedItem.ToString();
            //       this.rmspRussiaBindingSource2.Filter = "(Категория LIKE '" + comboBox1.Text + "*')";
        }
     /*   public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox2.SelectedItem.ToString();
            //       this.rmspRussiaBindingSource2.Filter = "(nameRegion LIKE '" + comboBox2.Text + "*')";
        }
        public void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string selectedState = comboBox3.SelectedItem.ToString();
            //       this.rmspRussiaBindingSource2.Filter = "(city LIKE '" + comboBox3.Text + "*')";

        }*/
        public  void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox4.SelectedItem.ToString();
            //         this.rmspRussiaBindingSource2.Filter = "(nameOrgS LIKE '" + comboBox4.Text + "*')";
        }
    
        public void button4_Click(object sender, EventArgs e)
        {
           
            List<string> filterParts = new List<string>();
             if (comboBox1.SelectedIndex >= 0)
                 filterParts.Add("Категория LIKE '%" + comboBox1.Text + "%'");
             if (comboBox2.SelectedIndex >= 0)
                 filterParts.Add("nameRegion LIKE '%" + comboBox2.Text + "%'");
             if (comboBox3.SelectedIndex >= 0)
                 filterParts.Add("city LIKE '%" + comboBox3.Text + "%'");
             if (comboBox4.SelectedIndex >= 0)
                 filterParts.Add("nameOrgS LIKE '%" + comboBox4.Text + "%'");
     
             if (textBox1.Text != null)
                filterParts.Add("kodOKV LIKE '%" + textBox1.Text + "%'");
            if (textBox2.Text != null)
                filterParts.Add("inn LIKE '%" + textBox2.Text + "%'");
          
            
             string filter = string.Join(" AND ", filterParts);
           
             this.rMSPBindingSource.Filter = filter;

        }
        private void button5_Click(object sender, EventArgs e)
        {
           this.rMSPBindingSource.Filter = "";
   
            textBox1.Text = null;
            textBox2.Text = null;
            comboBox1.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
         
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fnsDataSet13.RMSP". При необходимости она может быть перемещена или удалена.
            this.rMSPTableAdapter.Fill(fnsDataSet13.RMSP, textBox2.Text, comboBox2.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fnsDataSet17.RegionMSP". При необходимости она может быть перемещена или удалена.
            this.regionMSPTableAdapter.Fill(this.fnsDataSet17.RegionMSP, textBox2.Text, comboBox2.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fnsDataSet18.FnsMSP". При необходимости она может быть перемещена или удалена.
            this.fnsMSPTableAdapter.Fill(this.fnsDataSet18.FnsMSP);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.rMSPTableAdapter.Fill(fnsDataSet13.RMSP, textBox2.Text, comboBox2.Text);
            this.regionMSPTableAdapter.Fill(this.fnsDataSet17.RegionMSP, textBox2.Text, comboBox2.Text);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            comboBox2.SelectedIndex = 0;
            this.rMSPTableAdapter.Fill(fnsDataSet13.RMSP, textBox2.Text, comboBox2.Text);
            this.regionMSPTableAdapter.Fill(this.fnsDataSet17.RegionMSP, textBox2.Text, comboBox2.Text);
        }
        public string login;
        public string password;
    }
        
}
