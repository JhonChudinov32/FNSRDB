using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;


namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        //Создание Подключение к БД
        SqlConnection mainConnection = new SqlConnection(@"Data Source=DPO-STAT1\SQLEXPRESS;Initial Catalog=fns;Integrated Security=True");
        public object OpenFileDialog1 { get; private set; }
        public Form1()
        {
            InitializeComponent();
            Application.DoEvents();

        }
     
        /*private DataTable CreateTable()
        {
            //создаём таблицу

            DataTable dt = new DataTable();
            //создаём три колонки

            DataColumn dateMSP = new DataColumn("datemsp", typeof(DateTime));
            DataColumn CategoryMSP = new DataColumn("category", typeof(String));
            DataColumn NameOrg = new DataColumn("name", typeof(String));
            DataColumn NameOrgS = new DataColumn("nameS", typeof(String));
            DataColumn inn = new DataColumn("inn", typeof(String));

            DataColumn idr = new DataColumn("idr", typeof(String));
            DataColumn nameR = new DataColumn("nameR", typeof(String));
            DataColumn nameG = new DataColumn("nameG", typeof(String));
            DataColumn rayon = new DataColumn("rayon", typeof(String));
            DataColumn naselp = new DataColumn("naselp", typeof(String));

            DataColumn idOKV = new DataColumn("idOKV", typeof(String));
            DataColumn nameOKV = new DataColumn("nameOKV", typeof(String));
            DataColumn versOKV = new DataColumn("versOKV", typeof(String));

       
            //добавляем колонки в таблицу

            dt.Columns.Add(dateMSP);
            dt.Columns.Add(CategoryMSP);
            dt.Columns.Add(NameOrg);
            dt.Columns.Add(NameOrgS);
            dt.Columns.Add(inn);
            dt.Columns.Add(idr);
            dt.Columns.Add(nameR);
            dt.Columns.Add(nameG);
            dt.Columns.Add(rayon);
            dt.Columns.Add(naselp);
            dt.Columns.Add(idOKV);
            dt.Columns.Add(nameOKV);
            dt.Columns.Add(versOKV);
          
            return dt;
        }*/
        /* private DataTable CreateTable1()
        {
            //создаём таблицу

            DataTable dt = new DataTable();
            //создаём три колонки


            DataColumn inn = new DataColumn("inn", typeof(String));
            DataColumn datesost = new DataColumn("datesost", typeof(DateTime));
            DataColumn NameORG = new DataColumn("NameORG", typeof(String));
            DataColumn ColRab = new DataColumn("ColRab", typeof(String));


            //добавляем колонки в таблицу


            dt.Columns.Add(inn);
            dt.Columns.Add(datesost);
            dt.Columns.Add(NameORG);
            dt.Columns.Add(ColRab);

            return dt;
        }*/
        /* private DataTable CreateTable2()
        {
            //создаём таблицу

            DataTable dt = new DataTable();
            //создаём три колонки


            DataColumn inn = new DataColumn("inn", typeof(String));
            DataColumn datesost = new DataColumn("datesost", typeof(DateTime));
            DataColumn NameORG = new DataColumn("NameORG", typeof(String));
            DataColumn ESXN = new DataColumn("ESXN", typeof(String));
            DataColumn USN = new DataColumn("USN", typeof(String));
            DataColumn EIVD = new DataColumn("EIVD", typeof(String));
            DataColumn SRP = new DataColumn("SRP", typeof(String));

            //добавляем колонки в таблицу


            dt.Columns.Add(inn);
            dt.Columns.Add(datesost);
            dt.Columns.Add(NameORG);
            dt.Columns.Add(ESXN);
            dt.Columns.Add(USN);
            dt.Columns.Add(EIVD);
            dt.Columns.Add(SRP);

            return dt;
        }*/
        /* private DataTable CreateTable3()
        {
            //создаём таблицу

            DataTable dt = new DataTable();
            //создаём три колонки

            DataColumn inn = new DataColumn("inn", typeof(String));
            DataColumn datesost = new DataColumn("datesost", typeof(DateTime));
            DataColumn NameORG = new DataColumn("NameORG", typeof(String));
            DataColumn summDochod = new DataColumn("summDochod", typeof(String));
            DataColumn summRaschod = new DataColumn("summRaschod", typeof(String));

            //добавляем колонки в таблицу

            dt.Columns.Add(inn);
            dt.Columns.Add(datesost);
            dt.Columns.Add(NameORG);
            dt.Columns.Add(summDochod);
            dt.Columns.Add(summRaschod);


            return dt;
        }*/
        /* private DataTable CreateTable4()
        {
            //создаём таблицу

            DataTable dt = new DataTable();
            //создаём три колонки

            DataColumn inn = new DataColumn("inn", typeof(String));
            DataColumn datesost = new DataColumn("datesost", typeof(DateTime));
            DataColumn NameORG = new DataColumn("NameORG", typeof(String));
            DataColumn nameNalog = new DataColumn("nameNalog", typeof(String));
            DataColumn summUplnalog = new DataColumn("summUplnalog", typeof(String));

            //добавляем колонки в таблицу

            dt.Columns.Add(inn);
            dt.Columns.Add(datesost);
            dt.Columns.Add(NameORG);
            dt.Columns.Add(nameNalog);
            dt.Columns.Add(summUplnalog);


            return dt;
        }*/
        /* private DataTable CreateTable5()
        {
            //создаём таблицу

            DataTable dt = new DataTable();
            //создаём три колонки

            DataColumn inn = new DataColumn("inn", typeof(String));
            DataColumn datesost = new DataColumn("datesost", typeof(DateTime));
            DataColumn NameORG = new DataColumn("NameORG", typeof(String));
            DataColumn nameNalog = new DataColumn("nameNalog", typeof(String));
            DataColumn summNedoimN = new DataColumn("summNedoimN", typeof(String));
            DataColumn summPeni = new DataColumn("summPeni", typeof(String));
            DataColumn summShtraf = new DataColumn("summShtraf", typeof(String));
            DataColumn ObchayaSummNedoim = new DataColumn("ObchayaSummNedoim", typeof(String));
            //добавляем колонки в таблицу

            dt.Columns.Add(inn);
            dt.Columns.Add(datesost);
            dt.Columns.Add(NameORG);
            dt.Columns.Add(nameNalog);
            dt.Columns.Add(summNedoimN);
            dt.Columns.Add(summPeni);
            dt.Columns.Add(summShtraf);
            dt.Columns.Add(ObchayaSummNedoim);


            return dt;
        }*/
        public void Loadfiles(string[] filenames)
        {
            progressBar1.Maximum = filenames.Length; 
            progressBar1.Value = progressBar1.Value + 1;
            double gg = progressBar1.Maximum / 100D;
            double percent = progressBar1.Value / gg;
            Application.DoEvents();
            label1.Text = "Обработано/Всего : " + progressBar1.Value.ToString() + "/" + progressBar1.Maximum.ToString();
            label2.Text = $"Загружено : { string.Format("{0:0.##}", percent)}%";
        }
        private void Arc(string file)
        {
            string folder = @"X:\DUS\PravOtnosh\Чудинов\ARC";// папка, в которую надо распаковать архив
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = @"C:\Program Files\WinRAR\WinRAR.exe";
            p.StartInfo.Arguments = string.Format("x -o+ \"{0}\" \"{1}\"", file, folder);
            p.EnableRaisingEvents = true;
            p.Start();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //Открываем диалоговое окно
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //поиск с директории диска С
                openFileDialog.InitialDirectory = @"X:\DUS\PravOtnosh\Чудинов\";
                //включаем возможность выбора несколько файлов
                openFileDialog.Multiselect = true;
                //включаем фильтр только XML
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var Filenames = openFileDialog.FileNames;
                    //цикл открытия файлов поочередно
                    foreach (string fil in openFileDialog.FileNames)
                    {
                        //ProgressBar
                        Loadfiles(Filenames);
                        //Parser
                        Parser(fil);
                    }

                }
            }
        }
        /*private void Parser(string file)
        {
            DataTable ReadXml()
            {

                DataTable dt = null;

                //Код парсера
                try
                {

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(file);
                    // получим корневой элемент
                    XmlElement xRoot = xDoc.DocumentElement;
                    DataRow newRow = null;
                    //создаём таблицу
                    dt = CreateTable();
                    foreach (XmlNode xnode in xRoot)
                    {

                        newRow = dt.NewRow();

                        // получаем атрибуты с первого корневого узла
                        if (xnode.Attributes.Count > 0)
                        {
                            XmlNode attr = xnode.Attributes.GetNamedItem("ДатаВклМСП");
                            if (attr != null)
                                newRow["datemsp"] = attr.Value.ToUpper();

                            XmlNode attr1 = xnode.Attributes.GetNamedItem("КатСубМСП");
                            if (attr1 != null)
                                newRow["category"] = attr1.Value.ToUpper();

                            foreach (XmlNode childnodes in xnode.ChildNodes)
                            {
                                if (childnodes.Name == "ИПВклМСП")
                                {
                                    XmlNode attr5 = childnodes.Attributes.GetNamedItem("ИННФЛ");
                                    if (attr5 != null)
                                        newRow["inn"] = attr5.Value.ToUpper();
                                    else
                                        newRow["inn"] = "НЕТ ИНФОРМАЦИИ";
                                }
                                foreach (XmlNode childnodess in childnodes.SelectNodes("ФИОИП"))

                                {
                                    XmlNode at1 = childnodess.Attributes.GetNamedItem("Фамилия");
                                    XmlNode at2 = childnodess.Attributes.GetNamedItem("Имя");
                                    XmlNode at3 = childnodess.Attributes.GetNamedItem("Отчество");
                                    if (at1 != null && at2 != null && at3 != null)
                                    {

                                        newRow["name"] = ("ИНДИВИДУАЛЬНЫЙ ПРЕДПРИНИМАТЕЛЬ" + " " + "'" + "'" + at1.Value.ToUpper() + " " + at2.Value.ToUpper() + " " + at3.Value.ToUpper() + "'" + "'");
                                        newRow["nameS"] = ("ИП" + " " + "'" + "'" + at1.Value.ToUpper() + " " + at2.Value[0] + "." + at3.Value[0] + "." + "'" + "'");
                                    }
                                    else
                                    {

                                        newRow["name"] = ("НЕТ ИНФОРМАЦИИ");
                                        newRow["nameS"] = ("НЕТ ИНФОРМАЦИИ");
                                    }
                                }
                            }

                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                // получаем атрибуты с тега ОргВклМСП корневого узла
                                if (childnode.Name == "ОргВклМСП")
                                {

                                    XmlNode attr2 = childnode.Attributes.GetNamedItem("НаимОрг");
                                    {
                                        if (attr2 != null)
                                            newRow["name"] = attr2.Value.ToUpper();
                                        else
                                            newRow["name"] = "НЕТ ИНФОРМАЦИИ";
                                    }
                                    XmlNode attr3 = childnode.Attributes.GetNamedItem("НаимОргСокр");
                                    {
                                        if (attr3 != null)
                                            newRow["nameS"] = attr3.Value.ToUpper();
                                        else
                                            newRow["nameS"] = "НЕТ ИНФОРМАЦИИ";
                                    }
                                    XmlNode attr4 = childnode.Attributes.GetNamedItem("ИННЮЛ");
                                    if (attr4 != null)
                                        newRow["inn"] = attr4.Value.ToUpper();
                                    else
                                        newRow["inn"] = "НЕТ ИНФОРМАЦИИ";
                                }
                            }
                            foreach (XmlNode childnod in xnode.ChildNodes)
                            {
                                if (childnod.Name == "СведМН")
                                {
                                    XmlNode attr7 = childnod.Attributes.GetNamedItem("КодРегион");
                                    if (attr7 != null)
                                        newRow["idr"] = attr7.Value.ToUpper();
                                }

                                foreach (XmlNode child in childnod.SelectNodes("Регион"))
                                {

                                    XmlNode at8 = child.Attributes.GetNamedItem("Тип");
                                    XmlNode at9 = child.Attributes.GetNamedItem("Наим");
                                    if (at8 != null && at9 != null)
                                    {
                                        newRow["nameR"] = at9.Value.ToUpper() + " " + at8.Value.ToUpper();
                                    }
                                    if (at9.Value == "МОСКВА")
                                    {

                                        newRow["nameG"] = at9.Value.ToUpper();
                                    }
                                    if (at9.Value == "САНКТ-ПЕТЕРБУРГ")
                                    {

                                        newRow["nameG"] = at9.Value.ToUpper();
                                    }
                                    if (at9.Value == "СЕВАСТОПОЛЬ")
                                    {

                                        newRow["nameG"] = at9.Value.ToUpper();
                                    }

                                }
                                foreach (XmlNode childd in childnod.SelectNodes("Город"))
                                {

                                    // XmlNode at10 = childd.Attributes.GetNamedItem("Тип");
                                    XmlNode at11 = childd.Attributes.GetNamedItem("Наим");
                                    //  if (at10 != null && at11 != null)
                                    if (at11 != null)
                                    {
                                        //  newRow["nameG"] = at10.Value.ToUpper() + " " + at11.Value.ToUpper();
                                        newRow["nameG"] = at11.Value.ToUpper();
                                    }
                                }
                                foreach (XmlNode childd1 in childnod.SelectNodes("Район"))
                                {
                                    // XmlNode at121 = childd1.Attributes.GetNamedItem("Тип");
                                    XmlNode at12 = childd1.Attributes.GetNamedItem("Наим");
                                    // if (at12 != null && at121 !=null)
                                    if (at12 != null)
                                    {
                                        //newRow["rayon"] = at121.Value[0]+ " " + at12.Value.ToUpper();
                                        newRow["rayon"] = at12.Value.ToUpper();
                                    }
                                }
                                foreach (XmlNode childd2 in childnod.SelectNodes("НаселПункт"))
                                {
                                    XmlNode at131 = childd2.Attributes.GetNamedItem("Тип");
                                    XmlNode at13 = childd2.Attributes.GetNamedItem("Наим");
                                    if (at13 != null && at131 != null)
                                    {
                                        newRow["naselp"] = at131.Value.ToUpper() + " " + at13.Value.ToUpper();
                                    }
                                }
                            }
                            foreach (XmlNode childnod2 in xnode.ChildNodes)
                            {
                                if (childnod2.Name == "СвОКВЭД")
                                {
                                    foreach (XmlNode child1 in childnod2.SelectNodes("СвОКВЭДОсн"))
                                    {
                                        XmlNode at15 = child1.Attributes.GetNamedItem("КодОКВЭД");
                                        XmlNode at16 = child1.Attributes.GetNamedItem("НаимОКВЭД");
                                        XmlNode at17 = child1.Attributes.GetNamedItem("ВерсОКВЭД");
                                        if (at15 != null && at16 != null && at17 != null)
                                        {
                                            newRow["idOKV"] = at15.Value.ToUpper();
                                            newRow["nameOKV"] = at16.Value.ToUpper();
                                            newRow["versOKV"] = at17.Value.ToUpper();
                                        }
                                    }
                                    foreach (XmlNode child2 in childnod2.SelectNodes("СвОКВЭДДоп"))
                                    {
                                        XmlNode at18 = child2.Attributes.GetNamedItem("КодОКВЭД");
                                        XmlNode at19 = child2.Attributes.GetNamedItem("НаимОКВЭД");
                                        XmlNode at20 = child2.Attributes.GetNamedItem("ВерсОКВЭД");
                                        if (at18 != null && at19 != null && at20 != null)
                                        {
                                            newRow["idOKV"] = at18.Value.ToUpper();
                                            newRow["nameOKV"] = at19.Value.ToUpper();
                                            newRow["versOKV"] = at20.Value.ToUpper();
                                        }
                                    }
                                }
                            }

                            // подключение к БД
                            mainConnection.Open();
                            // внесение данных в БД
                            SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.FnsMSP(nameOrg, nameOrgS,dateMSP,inn,categoryMSP) Values (@attr2,@attr3,@attr,@attr4,@attr1) 
                                                                            INSERT INTO dbo.RegionMSP(KodRegion,nameRegion,city,rayon,naselp) Values (@attr7,@attr8,@attr9,@attr13,@attr14) 
                                                                            INSERT INTO dbo.OkvedMSP(KodOKV,nameOKV,versOKV) Values (@attr10,@attr11,@attr12)", mainConnection);

                            cmd.Parameters.AddWithValue("@attr", newRow["datemsp"]);
                            cmd.Parameters.AddWithValue("@attr1", newRow["category"]);
                            cmd.Parameters.AddWithValue("@attr2", newRow["name"]);
                            cmd.Parameters.AddWithValue("@attr3", newRow["nameS"]);
                            cmd.Parameters.AddWithValue("@attr4", newRow["inn"]);
                            cmd.Parameters.AddWithValue("@attr7", newRow["idr"]);
                            cmd.Parameters.AddWithValue("@attr8", newRow["nameR"]);
                            cmd.Parameters.AddWithValue("@attr9", newRow["nameG"]);
                            cmd.Parameters.AddWithValue("@attr13", newRow["rayon"]);
                            cmd.Parameters.AddWithValue("@attr14", newRow["naselp"]);
                            cmd.Parameters.AddWithValue("@attr10", newRow["idOKV"]);
                            cmd.Parameters.AddWithValue("@attr11", newRow["nameOKV"]);
                            cmd.Parameters.AddWithValue("@attr12", newRow["versOKV"]);

                            cmd.ExecuteNonQuery();

                            //добавляем новую запись в таблицу
                            dt.Rows.Add(newRow);
                            mainConnection.Close();

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return dt;
            }
            {
                dt.DataSource = ReadXml();
                mainConnection.Close();
            }
        }*/
        private void Parser(string file)
        {
          
                //Код парсера
                try
                {

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(file);
                    // получим корневой элемент
                    XmlElement xRoot = xDoc.DocumentElement;
                   
                    foreach (XmlNode xnode in xRoot)
                    {
                    DateTime datemsp = DateTime.Now;
                    String category = "";
                    String inn = "";
                    String name = "";
                    String nameS = "";


                    // получаем атрибуты с первого корневого узла
                    if (xnode.Attributes.Count > 0)
                        {
                            XmlNode attr = xnode.Attributes.GetNamedItem("ДатаВклМСП");
                            if (attr != null)
                                datemsp = DateTime.ParseExact(attr.Value, "mm.dd.yyyy", null);

                        XmlNode attr1 = xnode.Attributes.GetNamedItem("КатСубМСП");
                            if (attr1 != null)
                                category = attr1.Value;

                            foreach (XmlNode childnodes in xnode.ChildNodes)
                            {
                                if (childnodes.Name == "ИПВклМСП")
                                {
                                    XmlNode attr5 = childnodes.Attributes.GetNamedItem("ИННФЛ");
                                    if (attr5 != null)
                                        inn = attr5.Value;
                                }
                                foreach (XmlNode childnodess in childnodes.SelectNodes("ФИОИП"))

                                {
                                    XmlNode at1 = childnodess.Attributes.GetNamedItem("Фамилия");
                                    XmlNode at2 = childnodess.Attributes.GetNamedItem("Имя");
                                    XmlNode at3 = childnodess.Attributes.GetNamedItem("Отчество");
                                    if (at1 != null && at2 != null && at3 != null)
                                    {

                                        name = ("ИНДИВИДУАЛЬНЫЙ ПРЕДПРИНИМАТЕЛЬ" + " " + "'" + "'" + at1.Value + " " + at2.Value + " " + at3.Value + "'" + "'");
                                        nameS = ("ИП" + " " + "'" + "'" + at1.Value + " " + at2.Value[0] + "." + at3.Value[0] + "." + "'" + "'");
                                    } 
                                }
                            }

                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                // получаем атрибуты с тега ОргВклМСП корневого узла
                                if (childnode.Name == "ОргВклМСП")
                                {

                                    XmlNode attr2 = childnode.Attributes.GetNamedItem("НаимОрг");
                                    {
                                        if (attr2 != null)
                                            name = attr2.Value;
                                    }
                                    XmlNode attr3 = childnode.Attributes.GetNamedItem("НаимОргСокр");
                                    {
                                        if (attr3 != null)
                                            nameS = attr3.Value;
                                    }
                                    XmlNode attr4 = childnode.Attributes.GetNamedItem("ИННЮЛ");
                                    if (attr4 != null)
                                        inn = attr4.Value;
                                
                                }
                            }
                            

                            // подключение к БД
                            mainConnection.Open();
                            // внесение данных в БД
                            SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.FnsMSP(nameOrg, nameOrgS,dateMSP,inn,categoryMSP) Values (@attr2,@attr3,@attr,@attr4,@attr1)", mainConnection);

                            cmd.Parameters.AddWithValue("@attr", datemsp);
                            cmd.Parameters.AddWithValue("@attr1", category);
                            cmd.Parameters.AddWithValue("@attr2", name);
                            cmd.Parameters.AddWithValue("@attr3", nameS);
                            cmd.Parameters.AddWithValue("@attr4", inn);
                           
                            cmd.ExecuteNonQuery();

                            //добавляем новую запись в таблицу
                          
                            mainConnection.Close();

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
         
               // mainConnection.Close();
            
        }
        /*private void ParserSSCH(string file)
        {
            DataTable ReadXml()
            {

                DataTable dt = null;

                //Код парсера
                try
                {

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(file);
                    // получим корневой элемент
                    XmlElement xRoot = xDoc.DocumentElement;
                    DataRow newRow = null;
                    //создаём таблицу
                    dt = CreateTable1();
                    foreach (XmlNode xnode in xRoot)
                    {

                        newRow = dt.NewRow();

                        // получаем атрибуты с первого корневого узла
                        if (xnode.Attributes.Count > 0)
                        {
                            XmlNode attr = xnode.Attributes.GetNamedItem("ДатаСост");
                            if (attr != null)
                                newRow["datesost"] = attr.Value.ToUpper();

                            foreach (XmlNode childnodes in xnode.ChildNodes)
                            {
                                if (childnodes.Name == "СведНП")
                                {
                                    XmlNode attr1 = childnodes.Attributes.GetNamedItem("НаимОрг");
                                    if (attr1 != null)
                                        newRow["NameORG"] = attr1.Value.ToUpper();
                                    else
                                        newRow["NameORG"] = "НЕТ ИНФОРМАЦИИ";
                                    XmlNode attr2 = childnodes.Attributes.GetNamedItem("ИННЮЛ");
                                    if (attr2 != null)
                                        newRow["inn"] = attr2.Value.ToUpper();

                                }

                                foreach (XmlNode childnodess in xnode.ChildNodes)

                                {
                                    XmlNode attr3 = childnodess.Attributes.GetNamedItem("КолРаб");

                                    if (attr3 != null)
                                    {

                                        newRow["ColRab"] = attr3.Value.ToUpper();
                                    }

                                }
                            }

                            // подключение к БД
                            mainConnection.Open();
                            // внесение данных в БД
                            SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.SSCHR(nameORG, signDate,inn,colRab) Values (@attr1,@attr,@attr2,@attr3)", mainConnection);

                            cmd.Parameters.AddWithValue("@attr", newRow["datesost"]);
                            cmd.Parameters.AddWithValue("@attr1", newRow["NameORG"]);
                            cmd.Parameters.AddWithValue("@attr2", newRow["inn"]);
                            cmd.Parameters.AddWithValue("@attr3", newRow["ColRab"]);


                            cmd.ExecuteNonQuery();

                            //добавляем новую запись в таблицу
                            dt.Rows.Add(newRow);
                            mainConnection.Close();

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return dt;
            }
            {
                dt.DataSource = ReadXml();
                mainConnection.Close();
            }
        }*/
        private void ParserSSCH(string file)
        {
                //Код парсера
                try
                {

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(file);
                    // получим корневой элемент
                    XmlElement xRoot = xDoc.DocumentElement;
                    
                    foreach (XmlNode xnode in xRoot)
                    {
                    DateTime datesost = DateTime.Now;
                    String NameORG = "";
                    String inn = "";
                    String ColRab = "";
                   


                    // получаем атрибуты с первого корневого узла
                    if (xnode.Attributes.Count > 0)
                        {
                            XmlNode attr = xnode.Attributes.GetNamedItem("ДатаСост");
                            if (attr != null)
                                datesost = DateTime.ParseExact(attr.Value, "mm.dd.yyyy", null);

                        foreach (XmlNode childnodes in xnode.ChildNodes)
                            {
                                if (childnodes.Name == "СведНП")
                                {
                                    XmlNode attr1 = childnodes.Attributes.GetNamedItem("НаимОрг");
                                    if (attr1 != null)
                                        NameORG = attr1.Value;
                                   
                                    XmlNode attr2 = childnodes.Attributes.GetNamedItem("ИННЮЛ");
                                    if (attr2 != null)
                                        inn = attr2.Value;

                                }

                                foreach (XmlNode childnodess in xnode.ChildNodes)

                                {
                                    XmlNode attr3 = childnodess.Attributes.GetNamedItem("КолРаб");

                                    if (attr3 != null)
                                    {
                                        ColRab = attr3.Value;
                                    }

                                }
                            }

                            // подключение к БД
                            mainConnection.Open();
                            // внесение данных в БД
                            SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.SSCHR(nameORG, signDate,inn,colRab) Values (@attr1,@attr,@attr2,@attr3)", mainConnection);

                            cmd.Parameters.AddWithValue("@attr", datesost);
                            cmd.Parameters.AddWithValue("@attr1", NameORG);
                            cmd.Parameters.AddWithValue("@attr2", inn);
                            cmd.Parameters.AddWithValue("@attr3", ColRab);


                            cmd.ExecuteNonQuery();

                            //добавляем новую запись в таблицу
                           
                            mainConnection.Close();

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
        /* private void ParserUSN(string file)
         {
             DataTable ReadXml()
             {

                 DataTable dt = null;

                 //Код парсера
                 try
                 {

                     XmlDocument xDoc = new XmlDocument();
                     xDoc.Load(file);
                     // получим корневой элемент
                     XmlElement xRoot = xDoc.DocumentElement;
                     DataRow newRow = null;
                     //создаём таблицу
                     dt = CreateTable2();
                     foreach (XmlNode xnode in xRoot)
                     {

                         newRow = dt.NewRow();

                         // получаем атрибуты с первого корневого узла
                         if (xnode.Attributes.Count > 0)
                         {
                             XmlNode attr = xnode.Attributes.GetNamedItem("ДатаСост");
                             if (attr != null)
                                 newRow["datesost"] = attr.Value.ToUpper();

                             foreach (XmlNode childnodes in xnode.ChildNodes)
                             {
                                 if (childnodes.Name == "СведНП")
                                 {
                                     XmlNode attr1 = childnodes.Attributes.GetNamedItem("НаимОрг");
                                     if (attr1 != null)
                                         newRow["NameORG"] = attr1.Value.ToUpper();
                                     else
                                         newRow["NameORG"] = "НЕТ ИНФОРМАЦИИ";
                                     XmlNode attr2 = childnodes.Attributes.GetNamedItem("ИННЮЛ");
                                     if (attr2 != null)
                                         newRow["inn"] = attr2.Value.ToUpper();

                                 }

                                 foreach (XmlNode childnodess in xnode.ChildNodes)

                                 {
                                     XmlNode attr3 = childnodess.Attributes.GetNamedItem("ПризнЕСХН");
                                     if (attr3 != null)
                                         newRow["ESXN"] = attr3.Value.ToUpper();
                                     XmlNode attr4 = childnodess.Attributes.GetNamedItem("ПризнУСН");
                                     if (attr4 != null)
                                         newRow["USN"] = attr4.Value.ToUpper();
                                     XmlNode attr5 = childnodess.Attributes.GetNamedItem("ПризнЕНВД");
                                     if (attr5 != null)
                                         newRow["EIVD"] = attr5.Value.ToUpper();
                                     XmlNode attr6 = childnodess.Attributes.GetNamedItem("ПризнСРП");
                                     if (attr6 != null)
                                         newRow["SRP"] = attr6.Value.ToUpper();
                                 }
                             }

                             // подключение к БД
                             mainConnection.Open();
                             // внесение данных в БД
                             SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.USN(nameORG, signDate,inn,esxn,usn,eivd,srp) Values (@attr1,@attr,@attr2,@attr3,@attr4,@attr5,@attr6)", mainConnection);

                             cmd.Parameters.AddWithValue("@attr", newRow["datesost"]);
                             cmd.Parameters.AddWithValue("@attr1", newRow["NameORG"]);
                             cmd.Parameters.AddWithValue("@attr2", newRow["inn"]);
                             cmd.Parameters.AddWithValue("@attr3", newRow["ESXN"]);
                             cmd.Parameters.AddWithValue("@attr4", newRow["USN"]);
                             cmd.Parameters.AddWithValue("@attr5", newRow["EIVD"]);
                             cmd.Parameters.AddWithValue("@attr6", newRow["SRP"]);


                             cmd.ExecuteNonQuery();

                             //добавляем новую запись в таблицу
                             dt.Rows.Add(newRow);
                             mainConnection.Close();

                         }
                     }
                 }

                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 return dt;
             }
             {
                 dt.DataSource = ReadXml();
                 mainConnection.Close();
             }
         }*/
        private void ParserUSN(string file)
        {
      
                //Код парсера
                try
                {

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(file);
                    // получим корневой элемент
                    XmlElement xRoot = xDoc.DocumentElement;
                 
                    foreach (XmlNode xnode in xRoot)
                    {
                    DateTime datesost = DateTime.Now;
                    String NameORG = "";
                    String inn = "";
                    String ESXN = "";
                    String USN = "";
                    String EIVD = "";
                    String SRP = "";


                    // получаем атрибуты с первого корневого узла
                    if (xnode.Attributes.Count > 0)
                        {
                            XmlNode attr = xnode.Attributes.GetNamedItem("ДатаСост");
                            if (attr != null)
                                datesost = DateTime.ParseExact(attr.Value, "mm.dd.yyyy", null);

                        foreach (XmlNode childnodes in xnode.ChildNodes)
                            {
                                if (childnodes.Name == "СведНП")
                                {
                                    XmlNode attr1 = childnodes.Attributes.GetNamedItem("НаимОрг");
                                if (attr1 != null)
                                    NameORG = attr1.Value;
                               
                                    XmlNode attr2 = childnodes.Attributes.GetNamedItem("ИННЮЛ");
                                if (attr2 != null)
                                    inn = attr2.Value;

                                }

                                foreach (XmlNode childnodess in xnode.ChildNodes)

                                {
                                    XmlNode attr3 = childnodess.Attributes.GetNamedItem("ПризнЕСХН");
                                    if (attr3 != null)
                                        ESXN = attr3.Value;
                                    XmlNode attr4 = childnodess.Attributes.GetNamedItem("ПризнУСН");
                                    if (attr4 != null)
                                        USN = attr4.Value;
                                    XmlNode attr5 = childnodess.Attributes.GetNamedItem("ПризнЕНВД");
                                    if (attr5 != null)
                                        EIVD = attr5.Value;
                                    XmlNode attr6 = childnodess.Attributes.GetNamedItem("ПризнСРП");
                                    if (attr6 != null)
                                        SRP = attr6.Value;
                                }
                            }

                            // подключение к БД
                            mainConnection.Open();
                            // внесение данных в БД
                            SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.USN(nameORG, signDate,inn,esxn,usn,eivd,srp) Values (@attr1,@attr,@attr2,@attr3,@attr4,@attr5,@attr6)", mainConnection);

                            cmd.Parameters.AddWithValue("@attr", datesost);
                            cmd.Parameters.AddWithValue("@attr1", NameORG);
                            cmd.Parameters.AddWithValue("@attr2", inn);
                            cmd.Parameters.AddWithValue("@attr3", ESXN);
                            cmd.Parameters.AddWithValue("@attr4", USN);
                            cmd.Parameters.AddWithValue("@attr5", EIVD);
                            cmd.Parameters.AddWithValue("@attr6", SRP);

                            cmd.ExecuteNonQuery();
                        
                            mainConnection.Close();

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
          
        }
        /*  private void ParserDochod(string file)
        {
            DataTable ReadXml()
            {

                DataTable dt = null;

                //Код парсера
                try
                {

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(file);
                    // получим корневой элемент
                    XmlElement xRoot = xDoc.DocumentElement;
                    DataRow newRow = null;
                    //создаём таблицу
                    dt = CreateTable3();
                    foreach (XmlNode xnode in xRoot)
                    {

                        newRow = dt.NewRow();

                        // получаем атрибуты с первого корневого узла
                        if (xnode.Attributes.Count > 0)
                        {
                            XmlNode attr = xnode.Attributes.GetNamedItem("ДатаСост");
                            if (attr != null)
                                newRow["datesost"] = attr.Value.ToUpper();

                            foreach (XmlNode childnodes in xnode.ChildNodes)
                            {
                                if (childnodes.Name == "СведНП")
                                {
                                    XmlNode attr1 = childnodes.Attributes.GetNamedItem("НаимОрг");
                                    if (attr1 != null)
                                        newRow["NameORG"] = attr1.Value.ToUpper();
                                    else
                                        newRow["NameORG"] = "НЕТ ИНФОРМАЦИИ";
                                    XmlNode attr2 = childnodes.Attributes.GetNamedItem("ИННЮЛ");
                                    if (attr2 != null)
                                        newRow["inn"] = attr2.Value.ToUpper();

                                }

                                foreach (XmlNode childnodess in xnode.ChildNodes)

                                {
                                    XmlNode attr3 = childnodess.Attributes.GetNamedItem("СумДоход");
                                    if (attr3 != null)
                                        newRow["summDochod"] = attr3.Value.ToUpper();
                                    XmlNode attr4 = childnodess.Attributes.GetNamedItem("СумРасход");
                                    if (attr4 != null)
                                        newRow["summRaschod"] = attr4.Value.ToUpper();

                                }
                            }

                            // подключение к БД
                            mainConnection.Open();
                            // внесение данных в БД
                            SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.Dochod(nameORG, signDate,inn,summDochod,summRaschod) Values (@attr1,@attr,@attr2,@attr3,@attr4)", mainConnection);

                            cmd.Parameters.AddWithValue("@attr", newRow["datesost"]);
                            cmd.Parameters.AddWithValue("@attr1", newRow["NameORG"]);
                            cmd.Parameters.AddWithValue("@attr2", newRow["inn"]);
                            cmd.Parameters.AddWithValue("@attr3", newRow["summDochod"]);
                            cmd.Parameters.AddWithValue("@attr4", newRow["summRaschod"]);



                            cmd.ExecuteNonQuery();

                            //добавляем новую запись в таблицу
                            dt.Rows.Add(newRow);
                            mainConnection.Close();

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return dt;
            }
            {
                dt.DataSource = ReadXml();
                mainConnection.Close();
            }
        }*/
        private void ParserDochod(string file)
        {
                //Код парсера
                try
                {

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(file);
                    // получим корневой элемент
                    XmlElement xRoot = xDoc.DocumentElement;
              
                    foreach (XmlNode xnode in xRoot)
                    {
                       DateTime datesost = DateTime.Now;
                       String NameORG = "";
                       String inn = "";
                       String summDochod = "";
                       String summRaschod = "";
                  
                    // получаем атрибуты с первого корневого узла
                    if (xnode.Attributes.Count > 0)
                        {
                            XmlNode attr = xnode.Attributes.GetNamedItem("ДатаСост");
                            if (attr != null)
                                datesost = DateTime.ParseExact(attr.Value, "mm.dd.yyyy", null);

                        foreach (XmlNode childnodes in xnode.ChildNodes)
                            {
                                if (childnodes.Name == "СведНП")
                                {
                                    XmlNode attr1 = childnodes.Attributes.GetNamedItem("НаимОрг");
                                    if (attr1 != null)
                                        NameORG = attr1.Value;
                                   
                                    XmlNode attr2 = childnodes.Attributes.GetNamedItem("ИННЮЛ");
                                    if (attr2 != null)
                                        inn = attr2.Value;

                                }

                                foreach (XmlNode childnodess in xnode.ChildNodes)

                                {
                                    XmlNode attr3 = childnodess.Attributes.GetNamedItem("СумДоход");
                                    if (attr3 != null)
                                        summDochod = attr3.Value;
                                    XmlNode attr4 = childnodess.Attributes.GetNamedItem("СумРасход");
                                    if (attr4 != null)
                                        summRaschod = attr4.Value;

                                }
                            }

                            // подключение к БД
                            mainConnection.Open();
                            // внесение данных в БД
                            SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.Dochod(nameORG, signDate,inn,summDochod,summRaschod) Values (@attr1,@attr,@attr2,@attr3,@attr4)", mainConnection);

                            cmd.Parameters.AddWithValue("@attr", datesost);
                            cmd.Parameters.AddWithValue("@attr1", NameORG);
                            cmd.Parameters.AddWithValue("@attr2", inn);
                            cmd.Parameters.AddWithValue("@attr3", summDochod);
                            cmd.Parameters.AddWithValue("@attr4", summRaschod);

                            cmd.ExecuteNonQuery();

                            mainConnection.Close();

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
        private void ParserNalog(string file)
        {
          
                //Код парсера
                try
                {
            
                XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(file);
                    // получим корневой элемент
                    XmlElement xRoot = xDoc.DocumentElement;
                
                    foreach (XmlNode xnode in xRoot)
                    {
                    DateTime datesost = DateTime.Now;
                    String NameORG ="";
                    String inn ="";
                    String nameNalog ="";
                    String summUplnalog = "";

                    if (xnode.Attributes.Count > 0)
                        {
                            XmlNode attr = xnode.Attributes.GetNamedItem("ДатаСост");
                        if (attr != null)
                            datesost = DateTime.ParseExact(attr.Value, "mm.dd.yyyy", null);
                        
                            // получаем атрибуты с первого корневого узла
                            foreach (XmlNode childnodes in xnode.ChildNodes)
                            {
                                if (childnodes.Name == "СведНП")
                                {
                                    XmlNode attr1 = childnodes.Attributes.GetNamedItem("НаимОрг");
                                    if (attr1 != null)
                                       NameORG = attr1.Value.ToUpper();
                                    else
                                        NameORG = "НЕТ ИНФОРМАЦИИ";
                                    XmlNode attr2 = childnodes.Attributes.GetNamedItem("ИННЮЛ");
                                    if (attr2 != null)
                                        inn = attr2.Value.ToUpper();


                                    foreach (XmlNode child in xnode.SelectNodes("СвУплСумНал"))
                                    {
                                      
                                        if (child.Attributes.Count > 0)
                                        {
                                           
                                            XmlNode attr3 = child.Attributes.GetNamedItem("НаимНалог");
                                            if (attr3 != null)
                                               nameNalog = attr3.Value;
                                           
                                            XmlNode attr4 = child.Attributes.GetNamedItem("СумУплНал");
                                            if (attr4 != null)
                                                summUplnalog = attr4.Value.ToUpper();
                                         
                                        }

                                        // подключение к БД
                                        mainConnection.Open();
                                        // внесение данных в БД
                                        SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.Nalog(nameORG,signDate, inn,nameNalog,summUplnalog) Values (@attr1,@attr,@attr2,@attr3,@attr4)", mainConnection);

                                        cmd.Parameters.AddWithValue("@attr", datesost);
                                        cmd.Parameters.AddWithValue("@attr1", NameORG);
                                        cmd.Parameters.AddWithValue("@attr2", inn);
                                        cmd.Parameters.AddWithValue("@attr3", nameNalog);
                                        cmd.Parameters.AddWithValue("@attr4", summUplnalog);



                                        cmd.ExecuteNonQuery();

                                        //добавляем новую запись в таблицу
                                       
                                        mainConnection.Close();

                                    }
                                }
                            }
                        }
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
        private void ParserNedoim(string file)
        {

            //Код парсера
            try
            {

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(file);
                // получим корневой элемент
                XmlElement xRoot = xDoc.DocumentElement;

                foreach (XmlNode xnode in xRoot)
                {
                    DateTime datesost = DateTime.Now;
                    String NameORG = "";
                    String inn = "";
                    String nameNalog = "";
                    String summNedoimN = "";
                    String summPeni = "";
                    String summShtraf = "";
                    String ObchayaSummNedoim = "";

                    // получаем атрибуты с первого корневого узла
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("ДатаСост");
                        if (attr != null)
                            datesost = DateTime.ParseExact(attr.Value,"mm.dd.yyyy",null);

                        foreach (XmlNode childnodes in xnode.ChildNodes)
                        {
                            if (childnodes.Name == "СведНП")
                            {
                                XmlNode attr1 = childnodes.Attributes.GetNamedItem("НаимОрг");
                                if (attr1 != null)
                                    NameORG = attr1.Value.ToUpper();
                                else
                                    NameORG = "НЕТ ИНФОРМАЦИИ";
                                XmlNode attr2 = childnodes.Attributes.GetNamedItem("ИННЮЛ");
                                if (attr2 != null)
                                    inn = attr2.Value.ToUpper();

                                foreach (XmlNode childnodess in xnode.ChildNodes)

                                {
                                    XmlNode attr3 = childnodess.Attributes.GetNamedItem("НаимНалог");
                                    if (attr3 != null)
                                        nameNalog = attr3.Value.ToUpper();

                                    XmlNode attr4 = childnodess.Attributes.GetNamedItem("СумНедНалог");
                                    if (attr4 != null)
                                        summNedoimN = attr4.Value.ToUpper();

                                    XmlNode attr5 = childnodess.Attributes.GetNamedItem("СумПени");
                                    if (attr5 != null)
                                        summPeni = attr5.Value.ToUpper();

                                    XmlNode attr6 = childnodess.Attributes.GetNamedItem("СумШтраф");
                                    if (attr6 != null)
                                        summShtraf = attr6.Value.ToUpper();

                                    XmlNode attr7 = childnodess.Attributes.GetNamedItem("ОбщСумНедоим");
                                    if (attr7 != null)
                                        ObchayaSummNedoim = attr7.Value.ToUpper();
                                }
                                    // подключение к БД
                                    mainConnection.Open();
                                    // внесение данных в БД
                                    SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.Nedoimki(nameORG, signDate,inn,nameNalog,summNedoimN,summPeni,summShtraf,ObchayaSummNedoim) Values (@attr1,@attr,@attr2,@attr3,@attr4,@attr5,@attr6,@attr7)", mainConnection);

                                    cmd.Parameters.AddWithValue("@attr", datesost);
                                    cmd.Parameters.AddWithValue("@attr1", NameORG);
                                    cmd.Parameters.AddWithValue("@attr2", inn);
                                    cmd.Parameters.AddWithValue("@attr3", nameNalog);
                                    cmd.Parameters.AddWithValue("@attr4", summNedoimN);
                                    cmd.Parameters.AddWithValue("@attr5", summPeni);
                                    cmd.Parameters.AddWithValue("@attr6", summShtraf);
                                    cmd.Parameters.AddWithValue("@attr7", ObchayaSummNedoim);

                                    cmd.ExecuteNonQuery();
                                



                                //добавляем новую запись в таблицу

                                mainConnection.Close();
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           // mainConnection.Close();

        }
        private void ParserNarush(string file)
        {

            //Код парсера
            try
            {

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(file);
                // получим корневой элемент
                XmlElement xRoot = xDoc.DocumentElement;

                foreach (XmlNode xnode in xRoot)
                {
                    DateTime datesost = DateTime.Now;
                    String NameORG = "";
                    String inn = "";
                    String summ = "";
                   

                    // получаем атрибуты с первого корневого узла
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("ДатаСост");
                        if (attr != null)
                            datesost = DateTime.ParseExact(attr.Value, "mm.dd.yyyy", null);

                        foreach (XmlNode childnodes in xnode.ChildNodes)
                        {
                            if (childnodes.Name == "СведНП")
                            {
                                XmlNode attr1 = childnodes.Attributes.GetNamedItem("НаимОрг");
                                if (attr1 != null)
                                    NameORG = attr1.Value.ToUpper();
                                else
                                    NameORG = "НЕТ ИНФОРМАЦИИ";
                                XmlNode attr2 = childnodes.Attributes.GetNamedItem("ИННЮЛ");
                                if (attr2 != null)
                                    inn = attr2.Value.ToUpper();

                                foreach (XmlNode childnodess in xnode.ChildNodes)

                                {
                                    XmlNode attr3 = childnodess.Attributes.GetNamedItem("СумШтраф");
                                    if (attr3 != null)
                                        summ = attr3.Value.ToUpper();

                                }
                                // подключение к БД
                                mainConnection.Open();
                                // внесение данных в БД
                                SqlCommand cmd = new SqlCommand(@"INSERT INTO dbo.Pravonarush(nameORG, signDate,inn,summ) Values (@attr1,@attr,@attr2,@attr3)", mainConnection);

                                cmd.Parameters.AddWithValue("@attr", datesost);
                                cmd.Parameters.AddWithValue("@attr1", NameORG);
                                cmd.Parameters.AddWithValue("@attr2", inn);
                                cmd.Parameters.AddWithValue("@attr3", summ);
                       

                                cmd.ExecuteNonQuery();




                                //добавляем новую запись в таблицу

                                mainConnection.Close();
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // mainConnection.Close();

        }
        private void Button6_Click(object sender, EventArgs e)
        {
            //Открываем диалоговое окно
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //поиск с директории диска С
                openFileDialog.InitialDirectory = @"X:\DUS\PravOtnosh\Чудинов\";
                //включаем возможность выбора несколько файлов
                openFileDialog.Multiselect = true;
                //включаем фильтр только XML
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var Filenames = openFileDialog.FileNames;
                    //цикл открытия файлов поочередно
                    foreach (string fil in openFileDialog.FileNames)
                    {
                        //ProgressBar
                        Loadfiles(Filenames);
                        //Parser
                        ParserSSCH(fil);
                    }

                }
            }
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            //Открываем диалоговое окно
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //поиск с директории диска С
                openFileDialog.InitialDirectory = @"X:\DUS\PravOtnosh\Чудинов\";
                //включаем возможность выбора несколько файлов
                openFileDialog.Multiselect = true;
                //включаем фильтр только XML
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var Filenames = openFileDialog.FileNames;
                    //цикл открытия файлов поочередно
                    foreach (string fil in openFileDialog.FileNames)
                    {
                        //ProgressBar
                        Loadfiles(Filenames);
                        //Parser
                        ParserUSN(fil);
                    }

                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form2 MyForm2 = new Form2
            {
                login = login,
                password = password
            };
            MyForm2.ShowDialog();
            Close();

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form14 MyForm14 = new Form14
            {
                login = login,
                password = password
            };
            MyForm14.ShowDialog();
            Close();

        }
        private void Button4_Click(object sender, EventArgs e)
        {
            mainConnection.Close();
            Close();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            Form4 MyForm4 = new Form4
            {
                login = login,
                password = password
            };
            MyForm4.ShowDialog();
            Close();
        }

        public string login;
        public string password;
        private void Form1_Load(object sender, EventArgs e)
        {
            Application.DoEvents();
            
            try
            {
                int k = 0;
                mainConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(middlename)as qw FROM [fns].[dbo].[User] WHERE [login] ='" + login + "' and [password] ='" + password + "' and [is_setting_allow] = 'true' ", mainConnection);
                k = (Int32)cmd.ExecuteScalar();
                 mainConnection.Close();
                if (k != 0)
                {
                    button22.Visible = true;
                    button19.Visible = true;
                    button18.Visible = true;
                    button5.Visible = true;
                    button13.Visible = true;
                    label7.Visible = true;
                    button24.Visible = true;
                }
                else
                {
                    button22.Visible = false;
                    button19.Visible = false;
                    button18.Visible = false;
                    button5.Visible = false;
                    button13.Visible = false;
                    label7.Visible = false;
                   
                }
            
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form5 MyForm5 = new Form5
            {
                login = login,
                password = password
            };
            MyForm5.ShowDialog();
            Close();
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form6 MyForm6 = new Form6
            {
                login = login,
                password = password
            };
            MyForm6.ShowDialog();
            Close();
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            //Открываем диалоговое окно
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //поиск с директории диска С
                openFileDialog.InitialDirectory = @"X:\DUS\PravOtnosh\Чудинов\";
                //включаем возможность выбора несколько файлов
                openFileDialog.Multiselect = true;
                //включаем фильтр только XML
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var Filenames = openFileDialog.FileNames;
                    //цикл открытия файлов поочередно
                    foreach (string fil in openFileDialog.FileNames)
                    {
                        //ProgressBar
                        Loadfiles(Filenames);
                        //Parser
                        ParserDochod(fil);
                    }

                }
            }
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            //Открываем диалоговое окно
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //поиск с директории диска С
                openFileDialog.InitialDirectory = @"X:\DUS\PravOtnosh\Чудинов\";
                //включаем возможность выбора несколько файлов
                openFileDialog.Multiselect = true;
                //включаем фильтр только XML
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var Filenames = openFileDialog.FileNames;
                    //цикл открытия файлов поочередно
                    foreach (string fil in openFileDialog.FileNames)
                    {
                        //ProgressBar
                        Loadfiles(Filenames);
                        //Parser
                        ParserNalog(fil);
                    }

                }
            }
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form7 MyForm7 = new Form7
            {
                login = login,
                password = password
            };
            MyForm7.ShowDialog();
            Close();
        }
        private void Button15_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form8 MyForm8 = new Form8
            {
                login = login,
                password = password
            };
            MyForm8.ShowDialog();
            Close();
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form9 MyForm9 = new Form9
            {
                login = login,
                password = password
            };
            MyForm9.ShowDialog();
            Close();
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            //Открываем диалоговое окно
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //поиск с директории диска С
                openFileDialog.InitialDirectory = @"X:\DUS\PravOtnosh\Чудинов\";
                //включаем возможность выбора несколько файлов
                openFileDialog.Multiselect = true;
                //включаем фильтр только XML
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var Filenames = openFileDialog.FileNames;
                    //цикл открытия файлов поочередно
                    foreach (string fil in openFileDialog.FileNames)
                    {
                        //ProgressBar
                        Loadfiles(Filenames);
                        //Parser
                        ParserNedoim(fil);
                    }

                }
            }
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form10 MyForm10 = new Form10
            {
                login = login,
                password = password
            };
            MyForm10.ShowDialog();
            Close();
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            Form11 MyForm11 = new Form11
            {
                login = login,
                password = password
            };
            MyForm11.ShowDialog();
            Close();
        }
        private void Button19_Click(object sender, EventArgs e)
        {
            Form12 MyForm12 = new Form12
            {
                login = login,
                password = password
            };
            MyForm12.ShowDialog();
            Close();
        }
        private void Button18_Click(object sender, EventArgs e)
        {
            Form13 MyForm13 = new Form13
            {
                login = login,
                password = password
            };
            MyForm13.ShowDialog();
            Close();
        }
        private void Button20_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form15 MyForm15 = new Form15
            {
                login = login,
                password = password
            };
            MyForm15.ShowDialog();
            Close();

        }
        private void Button21_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {

                openFileDialog1.Filter = "WinRAR | *.rar;*.zip";
                openFileDialog1.Multiselect = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var FileNames = openFileDialog1.FileName;
                    foreach (string fil in openFileDialog1.FileNames)
                    {
                        Arc(fil);
                    }
                }
            }
        }
        private void Button22_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form17 MyForm17 = new Form17
            {
                login = login,
                password = password
            };
            MyForm17.ShowDialog();
            Close();
        }
        private void Button24_Click(object sender, EventArgs e)
        {
            //Открываем диалоговое окно
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //поиск с директории диска С
                openFileDialog.InitialDirectory = @"X:\DUS\PravOtnosh\Чудинов\";
                //включаем возможность выбора несколько файлов
                openFileDialog.Multiselect = true;
                //включаем фильтр только XML
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var Filenames = openFileDialog.FileNames;
                    //цикл открытия файлов поочередно
                    foreach (string fil in openFileDialog.FileNames)
                    {
                        //ProgressBar
                        Loadfiles(Filenames);
                        //Parser
                        ParserNarush(fil);
                    }

                }
            }
        }
    }
}
    

