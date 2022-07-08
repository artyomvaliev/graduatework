using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
namespace graduatework.Forms
{
    public partial class Comparative : Form
    {
        public Comparative()
        {
            InitializeComponent();
        }
        public int SaveFlag;
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Comparative_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПТипОтделки". При необходимости она может быть перемещена или удалена.
            this.пТипОтделкиTableAdapter.Fill(this.graduatedbDataSet.ПТипОтделки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПТипСанузлов". При необходимости она может быть перемещена или удалена.
            this.пТипСанузловTableAdapter.Fill(this.graduatedbDataSet.ПТипСанузлов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПБалконЛоджия". При необходимости она может быть перемещена или удалена.
            this.пБалконЛоджияTableAdapter.Fill(this.graduatedbDataSet.ПБалконЛоджия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПВидИзОкон". При необходимости она может быть перемещена или удалена.
            this.пВидИзОконTableAdapter.Fill(this.graduatedbDataSet.ПВидИзОкон);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПСостояниеДома". При необходимости она может быть перемещена или удалена.
            this.пСостояниеДомаTableAdapter.Fill(this.graduatedbDataSet.ПСостояниеДома);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПТипДомаМатериалСтен". При необходимости она может быть перемещена или удалена.
            this.пТипДомаМатериалСтенTableAdapter.Fill(this.graduatedbDataSet.ПТипДомаМатериалСтен);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПТекущиеИмущественныеПраваНаОбъектОценки". При необходимости она может быть перемещена или удалена.
            this.пТекущиеИмущественныеПраваНаОбъектОценкиTableAdapter.Fill(this.graduatedbDataSet.ПТекущиеИмущественныеПраваНаОбъектОценки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПУсловиеФинансирования". При необходимости она может быть перемещена или удалена.
            this.пУсловиеФинансированияTableAdapter.Fill(this.graduatedbDataSet.ПУсловиеФинансирования);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПСпособПодсчетаПлощади". При необходимости она может быть перемещена или удалена.
            this.пСпособПодсчетаПлощадиTableAdapter.Fill(this.graduatedbDataSet.ПСпособПодсчетаПлощади);

            //ANALOG 1
            textBox1.Text = SelectBanking.Analog1[1];
            textBox9.Text = SelectBanking.Analog1[2];
            textBox2.Text = SelectBanking.Analog1[3];
            textBox3.Text = SelectBanking.Analog1[4];
            textBox4.Text = SelectBanking.Analog1[6];
            textBox5.Text = SelectBanking.Analog1[7];
            textBox8.Text = SelectBanking.Analog1[5];
            comboBox1.SelectedValue = Convert.ToInt32(SelectBanking.Analog1[8]);
            textBox6.Text = SelectBanking.Analog1[9];
            comboBox2.SelectedValue = Convert.ToInt32(SelectBanking.Analog1[10]);
            comboBox3.SelectedValue = Convert.ToInt32(SelectBanking.Analog1[11]);
            textBox10.Text = textBox1.Text;
            comboBox5.SelectedValue = Convert.ToInt32(SelectBanking.Analog1[13]);
            comboBox6.SelectedValue = Convert.ToInt32(SelectBanking.Analog1[14]);
            textBox12.Text = SelectBanking.Analog1[15];
            comboBox7.SelectedValue = Convert.ToInt32(SelectBanking.Analog1[16]);
            comboBox8.SelectedValue = Convert.ToInt32(SelectBanking.Analog1[17]);
            comboBox9.SelectedValue = Convert.ToInt32(SelectBanking.Analog1[18]);
            comboBox10.SelectedValue = Convert.ToInt32(SelectBanking.Analog1[19]);
            textBox13.Text = SelectBanking.Analog1[21];
            //12 20
            if (SelectBanking.Analog1[12] == "1")
            {
                rjToggleButton2.Checked = true;
            }
            if (SelectBanking.Analog1[20] == "1")
            {
                rjToggleButton1.Checked = true;
            }

            //ANALOG2
            textBox25.Text = SelectBanking.Analog2[1];
            textBox24.Text = SelectBanking.Analog2[2];
            textBox23.Text = SelectBanking.Analog2[3];
            textBox22.Text = SelectBanking.Analog2[4];
            textBox21.Text = SelectBanking.Analog2[6];
            textBox20.Text = SelectBanking.Analog2[7];
            textBox26.Text = SelectBanking.Analog2[5];
            comboBox18.SelectedValue = Convert.ToInt32(SelectBanking.Analog2[8]);
            textBox19.Text = SelectBanking.Analog2[9];
            comboBox17.SelectedValue = Convert.ToInt32(SelectBanking.Analog2[10]);
            comboBox16.SelectedValue = Convert.ToInt32(SelectBanking.Analog2[11]);
            textBox17.Text = textBox25.Text;
            comboBox15.SelectedValue = Convert.ToInt32(SelectBanking.Analog2[13]);
            comboBox14.SelectedValue = Convert.ToInt32(SelectBanking.Analog2[14]);
            textBox15.Text = SelectBanking.Analog2[15];
            comboBox13.SelectedValue = Convert.ToInt32(SelectBanking.Analog2[16]);
            comboBox12.SelectedValue = Convert.ToInt32(SelectBanking.Analog2[17]);
            comboBox11.SelectedValue = Convert.ToInt32(SelectBanking.Analog2[18]);
            comboBox4.SelectedValue = Convert.ToInt32(SelectBanking.Analog2[19]);
            textBox14.Text = SelectBanking.Analog2[21];
            //12 20
            if (SelectBanking.Analog2[12] == "1")
            {
                rjToggleButton3.Checked = true;
            }
            if (SelectBanking.Analog2[20] == "1")
            {
                rjToggleButton4.Checked = true;
            }

            //ANALOG3
            textBox38.Text = SelectBanking.Analog3[1];
            textBox37.Text = SelectBanking.Analog3[2];
            textBox36.Text = SelectBanking.Analog3[3];
            textBox35.Text = SelectBanking.Analog3[4];
            textBox34.Text = SelectBanking.Analog3[6];
            textBox33.Text = SelectBanking.Analog3[7];
            textBox39.Text = SelectBanking.Analog3[5];
            comboBox27.SelectedValue = Convert.ToInt32(SelectBanking.Analog3[8]);
            textBox32.Text = SelectBanking.Analog3[9];
            comboBox26.SelectedValue = Convert.ToInt32(SelectBanking.Analog3[10]);
            comboBox25.SelectedValue = Convert.ToInt32(SelectBanking.Analog3[11]);
            textBox30.Text = textBox38.Text;
            comboBox24.SelectedValue = Convert.ToInt32(SelectBanking.Analog3[13]);
            comboBox23.SelectedValue = Convert.ToInt32(SelectBanking.Analog3[14]);
            textBox28.Text = SelectBanking.Analog3[15];
            comboBox22.SelectedValue = Convert.ToInt32(SelectBanking.Analog3[16]);
            comboBox21.SelectedValue = Convert.ToInt32(SelectBanking.Analog3[17]);
            comboBox20.SelectedValue = Convert.ToInt32(SelectBanking.Analog3[18]);
            comboBox19.SelectedValue = Convert.ToInt32(SelectBanking.Analog3[19]);
            textBox27.Text = SelectBanking.Analog3[21];
            //12 20
            if (SelectBanking.Analog3[12] == "1")
            {
                rjToggleButton5.Checked = true;
            }
            if (SelectBanking.Analog3[20] == "1")
            {
                rjToggleButton6.Checked = true;
            }


            //ANALOG4
            textBox51.Text = SelectBanking.Analog4[1];
            textBox50.Text = SelectBanking.Analog4[2];
            textBox49.Text = SelectBanking.Analog4[3];
            textBox48.Text = SelectBanking.Analog4[4];
            textBox47.Text = SelectBanking.Analog4[6];
            textBox46.Text = SelectBanking.Analog4[7];
            textBox52.Text = SelectBanking.Analog4[5];
            comboBox36.SelectedValue = Convert.ToInt32(SelectBanking.Analog4[8]);
            textBox45.Text = SelectBanking.Analog4[9];
            comboBox35.SelectedValue = Convert.ToInt32(SelectBanking.Analog4[10]);
            comboBox34.SelectedValue = Convert.ToInt32(SelectBanking.Analog4[11]);
            textBox43.Text = textBox51.Text;
            comboBox33.SelectedValue = Convert.ToInt32(SelectBanking.Analog4[13]);
            comboBox32.SelectedValue = Convert.ToInt32(SelectBanking.Analog4[14]);
            textBox41.Text = SelectBanking.Analog4[15];
            comboBox31.SelectedValue = Convert.ToInt32(SelectBanking.Analog4[16]);
            comboBox30.SelectedValue = Convert.ToInt32(SelectBanking.Analog4[17]);
            comboBox29.SelectedValue = Convert.ToInt32(SelectBanking.Analog4[18]);
            comboBox28.SelectedValue = Convert.ToInt32(SelectBanking.Analog4[19]);
            textBox40.Text = SelectBanking.Analog4[21];
            //12 20
            if (SelectBanking.Analog4[12] == "1")
            {
                rjToggleButton7.Checked = true;
            }
            if (SelectBanking.Analog4[20] == "1")
            {
                rjToggleButton8.Checked = true;
            }

            //ОЬЪЕКТ
            textBox65.Text = SelectBanking.SravnObject[1];
            textBox60.Text = SelectBanking.SravnObject[2];
            comboBox45.SelectedValue = Convert.ToInt32(SelectBanking.SravnObject[3]);
            textBox58.Text = SelectBanking.SravnObject[4];
            comboBox44.SelectedValue = Convert.ToInt32(SelectBanking.SravnObject[5]);
            comboBox43.SelectedValue = Convert.ToInt32(SelectBanking.SravnObject[6]);
            textBox53.Text = SelectBanking.SravnObject[9];
            textBox59.Text = SelectBanking.ObjectOtsenki[7];
            textBox64.Text = SelectBanking.ObjectOtsenki[1];
            textBox63.Text = SelectBanking.ObjectOtsenki[4];
            textBox62.Text = SelectBanking.ObjectOtsenki[1];
            textBox61.Text = SelectBanking.ObjectOtsenki[2];

            textBox57.Text = SelectBanking.ZadanieNaOtcenku[14];

            textBox56.Text = textBox64.Text;

            comboBox42.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[1]);
            comboBox41.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[7]);

            textBox54.Text = SelectBanking.HarkaObjectaOtsenki[4] + "/" + SelectBanking.OXZ[2];
            comboBox40.SelectedValue = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[16]);
            comboBox39.SelectedValue = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[14]);
            comboBox38.SelectedValue = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[12]);
            comboBox37.SelectedValue = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[18]);
            if (SelectBanking.SravnObject[7] == "1")
            {
                rjToggleButton9.Checked = true;
            }
            if (SelectBanking.SravnObject[8] == "1")
            {
                rjToggleButton10.Checked = true;
            }

            SaveFlag = 0;
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            //ANALOG 1
            SelectBanking.Analog1[1] = textBox1.Text; //[АдресГород]
            SelectBanking.Analog1[2] = textBox9.Text;//[АдресУлица]
            SelectBanking.Analog1[3] = textBox2.Text;//[КоличествоКомнат]
            SelectBanking.Analog1[4] = textBox3.Text;//[ГодПостройки]
            SelectBanking.Analog1[6] = textBox4.Text;//[ЦенаПредложения,руб]
            SelectBanking.Analog1[7] = textBox5.Text;//[ПлощадьЗаявленная,квм]
            SelectBanking.Analog1[5] = textBox8.Text;//[ИсточникИнформации]
            SelectBanking.Analog1[8] = comboBox1.SelectedValue.ToString();//[КодСпособПодсчетаПлощади]
            SelectBanking.Analog1[9] = textBox6.Text;//[ФактическаяПлощадь,квм]
            SelectBanking.Analog1[10] = comboBox2.SelectedValue.ToString();//[КодУсловиеФинансирования]
            SelectBanking.Analog1[11] = comboBox3.SelectedValue.ToString();//[ПередаваемыеПрава]
            SelectBanking.Analog1[13] = comboBox5.SelectedValue.ToString();//[КодТипДома/МатериалСтен]
            SelectBanking.Analog1[14] = comboBox6.SelectedValue.ToString();//[СостояниеДома]
            SelectBanking.Analog1[15] = textBox12.Text;//[Этаж/ВсегоЭтажей]
            SelectBanking.Analog1[16] = comboBox7.SelectedValue.ToString();//[ВидИзОкна]
            SelectBanking.Analog1[17] = comboBox8.SelectedValue.ToString();//[НаличиеБалкона/Лоджии]
            SelectBanking.Analog1[18] = comboBox9.SelectedValue.ToString();//[ТипСанузла]
            SelectBanking.Analog1[19] = comboBox10.SelectedValue.ToString();//[СостояниеОтделки/ТипРемонта]
            SelectBanking.Analog1[21] = textBox13.Text;//[УдельнаяЦенаПредложения]
            if (rjToggleButton2.Checked)//[СостояниеДома]
            { SelectBanking.Analog1[12] = "1"; }
            else { SelectBanking.Analog1[12] = "0"; }
            if (rjToggleButton1.Checked)//[НаличиеМебели/Техники]
            { SelectBanking.Analog1[20] = "1"; }
            else { SelectBanking.Analog1[20] = "0"; }

            //ANALOG 2
            SelectBanking.Analog2[1] = textBox25.Text;
            SelectBanking.Analog2[2] = textBox24.Text;
            SelectBanking.Analog2[3] = textBox23.Text;
            SelectBanking.Analog2[4] = textBox22.Text;
            SelectBanking.Analog2[6] = textBox21.Text;
            SelectBanking.Analog2[7] = textBox20.Text;
            SelectBanking.Analog2[5] = textBox26.Text;
            SelectBanking.Analog2[8] = comboBox18.SelectedValue.ToString();
            SelectBanking.Analog2[9] = textBox19.Text;
            SelectBanking.Analog2[10] = comboBox17.SelectedValue.ToString();
            SelectBanking.Analog2[11] = comboBox16.SelectedValue.ToString();
            SelectBanking.Analog2[13] = comboBox15.SelectedValue.ToString();
            SelectBanking.Analog2[14] = comboBox14.SelectedValue.ToString();
            SelectBanking.Analog2[15] = textBox15.Text;
            SelectBanking.Analog2[16] = comboBox13.SelectedValue.ToString();
            SelectBanking.Analog2[17] = comboBox12.SelectedValue.ToString();
            SelectBanking.Analog2[18] = comboBox11.SelectedValue.ToString();
            SelectBanking.Analog2[19] = comboBox4.SelectedValue.ToString();
            SelectBanking.Analog2[21] = textBox14.Text;
            if (rjToggleButton3.Checked)
            { SelectBanking.Analog2[12] = "1"; }
            else { SelectBanking.Analog2[12] = "0"; }
            if (rjToggleButton4.Checked)
            { SelectBanking.Analog2[20] = "1"; }
            else { SelectBanking.Analog2[20] = "0"; }

            //ANALOG 3
            SelectBanking.Analog3[1] = textBox38.Text;
            SelectBanking.Analog3[2] = textBox37.Text;
            SelectBanking.Analog3[3] = textBox36.Text;
            SelectBanking.Analog3[4] = textBox35.Text;
            SelectBanking.Analog3[6] = textBox34.Text;
            SelectBanking.Analog3[7] = textBox33.Text;
            SelectBanking.Analog3[5] = textBox39.Text;
            SelectBanking.Analog3[8] = comboBox27.SelectedValue.ToString();
            SelectBanking.Analog3[9] = textBox32.Text;
            SelectBanking.Analog3[10] = comboBox26.SelectedValue.ToString();
            SelectBanking.Analog3[11] = comboBox25.SelectedValue.ToString();
            SelectBanking.Analog3[13] = comboBox15.SelectedValue.ToString();
            SelectBanking.Analog3[14] = comboBox23.SelectedValue.ToString();
            SelectBanking.Analog3[15] = textBox28.Text;
            SelectBanking.Analog3[16] = comboBox22.SelectedValue.ToString();
            SelectBanking.Analog3[17] = comboBox21.SelectedValue.ToString();
            SelectBanking.Analog3[18] = comboBox20.SelectedValue.ToString();
            SelectBanking.Analog3[19] = comboBox19.SelectedValue.ToString();
            SelectBanking.Analog3[21] = textBox27.Text;
            if (rjToggleButton5.Checked)
            { SelectBanking.Analog3[12] = "1"; }
            else { SelectBanking.Analog3[12] = "0"; }
            if (rjToggleButton6.Checked)
            { SelectBanking.Analog3[20] = "1"; }
            else { SelectBanking.Analog3[20] = "0"; }


            //ANALOG 4
            SelectBanking.Analog4[1] = textBox51.Text;
            SelectBanking.Analog4[2] = textBox50.Text;
            SelectBanking.Analog4[3] = textBox49.Text;
            SelectBanking.Analog4[4] = textBox48.Text;
            SelectBanking.Analog4[6] = textBox47.Text;
            SelectBanking.Analog4[7] = textBox46.Text;
            SelectBanking.Analog4[5] = textBox52.Text;
            SelectBanking.Analog4[8] = comboBox36.SelectedValue.ToString();
            SelectBanking.Analog4[9] = textBox45.Text;
            SelectBanking.Analog4[10] = comboBox35.SelectedValue.ToString();
            SelectBanking.Analog4[11] = comboBox34.SelectedValue.ToString();
            SelectBanking.Analog4[13] = comboBox33.SelectedValue.ToString();
            SelectBanking.Analog4[14] = comboBox32.SelectedValue.ToString();
            SelectBanking.Analog4[15] = textBox41.Text;
            SelectBanking.Analog4[16] = comboBox31.SelectedValue.ToString();
            SelectBanking.Analog4[17] = comboBox30.SelectedValue.ToString();
            SelectBanking.Analog4[18] = comboBox29.SelectedValue.ToString();
            SelectBanking.Analog4[19] = comboBox28.SelectedValue.ToString();
            SelectBanking.Analog4[21] = textBox40.Text;
            if (rjToggleButton7.Checked)
            { SelectBanking.Analog4[12] = "1"; }
            else { SelectBanking.Analog4[12] = "0"; }
            if (rjToggleButton8.Checked)
            { SelectBanking.Analog4[20] = "1"; }
            else { SelectBanking.Analog4[20] = "0"; }

            //СРАВНИТЕЛЬНЫЙ ОБЪЕКТ
            SelectBanking.SravnObject[1] = textBox65.Text; //[ИсточникИнформации]
            SelectBanking.SravnObject[2] = textBox60.Text;//[ЦенаПредложения,руб]
            SelectBanking.SravnObject[3] = comboBox45.SelectedValue.ToString();//[КодСпособПодсчетаПлощади]
            SelectBanking.SravnObject[4] = textBox58.Text;//[ФактическаяПлощадь,квм]
            SelectBanking.SravnObject[5] = comboBox44.SelectedValue.ToString();//[КодУсловиеФинансирования]
            SelectBanking.SravnObject[6] = comboBox43.SelectedValue.ToString();//[ПередаваемыеПрава]
            SelectBanking.SravnObject[9] = textBox53.Text;//[УдельнаяЦенаПредложения]
            if (rjToggleButton9.Checked)//[ВозможностьТорга]
            { SelectBanking.SravnObject[7] = "1"; }
            else { SelectBanking.SravnObject[7] = "0"; }
            if (rjToggleButton10.Checked)//[НаличиеМебели/Техники]
            { SelectBanking.SravnObject[8] = "1"; }
            else { SelectBanking.SravnObject[8] = "0"; }


            queriesTableAdapter1.СравнительныйАналог1_ИЗМЕНИТЬ(SelectBanking.Analog1[1], SelectBanking.Analog1[2], SelectBanking.Analog1[5], Convert.ToInt32(SelectBanking.Analog1[11]), SelectBanking.Analog1[12], Convert.ToInt32(SelectBanking.Analog1[14]), SelectBanking.Analog1[15], Convert.ToInt32(SelectBanking.Analog1[16]), Convert.ToInt32(SelectBanking.Analog1[17]), Convert.ToInt32(SelectBanking.Analog1[19]), SelectBanking.Analog1[20], Convert.ToInt32(SelectBanking.Analog1[21]), Convert.ToInt32(SelectBanking.Analog1[3]), Convert.ToInt32(SelectBanking.Analog1[4]), Convert.ToInt32(SelectBanking.Analog1[6]), Convert.ToInt32(SelectBanking.Analog1[7]), Convert.ToInt32(SelectBanking.Analog1[8]), Convert.ToInt32(SelectBanking.Analog1[9]), Convert.ToInt32(SelectBanking.Analog1[10]), Convert.ToInt32(SelectBanking.Analog1[13]), Convert.ToInt32(SelectBanking.Analog1[18]), Convert.ToInt32(SelectBanking.Analog1[0]));

            queriesTableAdapter1.СравнительныйАналог2_ИЗМЕНИТЬ(SelectBanking.Analog2[1], SelectBanking.Analog2[2], SelectBanking.Analog2[5], Convert.ToInt32(SelectBanking.Analog2[11]), SelectBanking.Analog2[12], Convert.ToInt32(SelectBanking.Analog2[14]), SelectBanking.Analog2[15], Convert.ToInt32(SelectBanking.Analog2[16]), Convert.ToInt32(SelectBanking.Analog2[17]), Convert.ToInt32(SelectBanking.Analog2[19]), SelectBanking.Analog2[20], Convert.ToInt32(SelectBanking.Analog2[21]), Convert.ToInt32(SelectBanking.Analog2[3]), Convert.ToInt32(SelectBanking.Analog2[4]), Convert.ToInt32(SelectBanking.Analog2[6]), Convert.ToInt32(SelectBanking.Analog2[7]), Convert.ToInt32(SelectBanking.Analog2[8]), Convert.ToInt32(SelectBanking.Analog2[9]), Convert.ToInt32(SelectBanking.Analog2[10]), Convert.ToInt32(SelectBanking.Analog2[13]), Convert.ToInt32(SelectBanking.Analog2[18]), Convert.ToInt32(SelectBanking.Analog2[0]));

            queriesTableAdapter1.СравнительныйАналог3_ИЗМЕНИТЬ(SelectBanking.Analog3[1], SelectBanking.Analog3[2], SelectBanking.Analog3[5], Convert.ToInt32(SelectBanking.Analog3[11]), SelectBanking.Analog3[12], Convert.ToInt32(SelectBanking.Analog3[14]), SelectBanking.Analog3[15], Convert.ToInt32(SelectBanking.Analog3[16]), Convert.ToInt32(SelectBanking.Analog3[17]), Convert.ToInt32(SelectBanking.Analog3[19]), SelectBanking.Analog3[20], Convert.ToInt32(SelectBanking.Analog3[21]), Convert.ToInt32(SelectBanking.Analog3[3]), Convert.ToInt32(SelectBanking.Analog3[4]), Convert.ToInt32(SelectBanking.Analog3[6]), Convert.ToInt32(SelectBanking.Analog3[7]), Convert.ToInt32(SelectBanking.Analog3[8]), Convert.ToInt32(SelectBanking.Analog3[9]), Convert.ToInt32(SelectBanking.Analog3[10]), Convert.ToInt32(SelectBanking.Analog3[13]), Convert.ToInt32(SelectBanking.Analog3[18]), Convert.ToInt32(SelectBanking.Analog3[0]));

            queriesTableAdapter1.СравнительныйАналог4_ИЗМЕНИТЬ(SelectBanking.Analog4[1], SelectBanking.Analog4[2], SelectBanking.Analog4[5], Convert.ToInt32(SelectBanking.Analog4[11]), SelectBanking.Analog4[12], Convert.ToInt32(SelectBanking.Analog4[14]), SelectBanking.Analog4[15], Convert.ToInt32(SelectBanking.Analog4[16]), Convert.ToInt32(SelectBanking.Analog4[17]), Convert.ToInt32(SelectBanking.Analog4[19]), SelectBanking.Analog4[20], Convert.ToInt32(SelectBanking.Analog4[21]), Convert.ToInt32(SelectBanking.Analog4[3]), Convert.ToInt32(SelectBanking.Analog4[4]), Convert.ToInt32(SelectBanking.Analog4[6]), Convert.ToInt32(SelectBanking.Analog4[7]), Convert.ToInt32(SelectBanking.Analog4[8]), Convert.ToInt32(SelectBanking.Analog4[9]), Convert.ToInt32(SelectBanking.Analog4[10]), Convert.ToInt32(SelectBanking.Analog4[13]), Convert.ToInt32(SelectBanking.Analog4[18]), Convert.ToInt32(SelectBanking.Analog4[0]));

            queriesTableAdapter1.СравнительныйОбъект_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.SravnObject[2]), Convert.ToInt32(SelectBanking.SravnObject[3]), Convert.ToInt32(SelectBanking.SravnObject[4]), Convert.ToInt32(SelectBanking.SravnObject[5]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[0]), SelectBanking.SravnObject[1], SelectBanking.SravnObject[6], SelectBanking.SravnObject[7], SelectBanking.SravnObject[8], SelectBanking.SravnObject[9], Convert.ToInt32(SelectBanking.SravnObject[0]));


        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            IWebDriver browser;
            //IWebDriver browser;
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Navigate().GoToUrl(textBox8.Text);
            //browser.Manage().Window.Maximize();

            AvitoParseAnalog1.AvitoURL = textBox8.Text;
            try
            {
                AvitoParseAnalog1.AvitoTown = browser.FindElement(By.XPath("//a[@class='breadcrumbs-link-1Z6dK'][1]")).Text;
            }
            catch { }
            try
            {
                AvitoParseAnalog1.AvitoItemID = browser.FindElement(By.XPath("//span[@data-marker='item-view/item-id']")).Text; //Артикуль
            }
            catch { }
            try
            {
                AvitoParseAnalog1.AvitoName = browser.FindElement(By.XPath("//span[contains(@class, 'title-info-title-text')]")).Text; //Описание 
            }
            catch { }
            try
            {
                AvitoParseAnalog1.AvitoPriceMain = browser.FindElement(By.XPath("//*[contains(@class, 'js-item-price style-item-price')]")).Text; //Цена
            }
            catch { }
            try
            {
                AvitoParseAnalog1.AvitoSubPriceMain = browser.FindElement(By.XPath("//*[contains(@class, 'style-item-price-sub-price')]")).Text; //Цена за квадрат
            }
            catch { }
            try
            {
                AvitoParseAnalog1.AvitoAddressUlitsaDomMain = browser.FindElement(By.XPath("//span[contains(@class, 'item-address__string')]")).Text; //Улица, дом
            }
            catch { }
            try
            {
                AvitoParseAnalog1.AvitoAddressRaionMain = browser.FindElement(By.XPath("//span[contains(@class, 'item-address-georeferences')]")).Text; //Район
            }
            catch { }

            IList<IWebElement> all_elem = browser.FindElements(By.XPath("//li[contains(@class, 'params-paramsList__item')]//span[contains(@class, 'css')]"));
            String[] allText_elem = new String[all_elem.Count];
            int k = 0;
            foreach (IWebElement element in all_elem)
            {
                allText_elem[k++] = element.Text;
            }

            IList<IWebElement> all_text = browser.FindElements(By.XPath("//li[contains(@class, 'params-paramsList')]"));
            String[] allText_text = new String[all_text.Count];
            int l = 0;
            foreach (IWebElement element in all_text)
            {
                allText_text[l++] = element.Text;
            }


            for (int i = 0; i <= all_elem.Count; i++) //Счётчик РАБОТАЕТ
            {
                try
                {



                    if (allText_elem[i].Contains("Тип жилья") == true)
                    {
                        AvitoParseAnalog1.AvitoTipJiliyaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Количество комнат") == true)
                    {
                        AvitoParseAnalog1.AvitoKomnatiMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Этаж") == true)
                    {
                        AvitoParseAnalog1.AvitoEtajMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Общая площадь") == true)
                    {
                        AvitoParseAnalog1.AvitoPloshadMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Площадь кухни") == true)
                    {
                        AvitoParseAnalog1.AvitoPloshadKuhniMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Жилая площадь") == true)
                    {
                        AvitoParseAnalog1.AvitoPloshadJilayaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Высота потолков") == true)
                    {
                        AvitoParseAnalog1.AvitoVisotaPotolkovMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Санузел") == true)
                    {
                        AvitoParseAnalog1.AvitoSanuzelMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Окна") == true)
                    {
                        AvitoParseAnalog1.AvitoOknaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Отделка") == true)
                    {
                        AvitoParseAnalog1.AvitoOtdelkaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Тип комнат") == true)
                    {
                        AvitoParseAnalog1.AvitoTipKomnatMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Ремонт") == true)
                    {
                        AvitoParseAnalog1.AvitoRemontMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Способ продажи") == true)
                    {
                        AvitoParseAnalog1.AvitoSposobProdajiMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Балкон или лоджия") == true)
                    {
                        AvitoParseAnalog1.AvitoBalkonMain = allText_text[i];
                    }
                }
                catch { }

            }
            IList<IWebElement> all_elem1 = browser.FindElements(By.XPath("//li[contains(@class, 'style-item-params-list-item')]//span[contains(@class, 'style-item-params-label')]"));
            String[] allText_elem1 = new String[all_elem1.Count];
            int m = 0;
            foreach (IWebElement element in all_elem1)
            {
                allText_elem1[m++] = element.Text;
            }

            IList<IWebElement> all_text1 = browser.FindElements(By.XPath("//li[contains(@class, 'style-item-params-list-item')]"));
            String[] allText_text1 = new String[all_text1.Count];
            int n = 0;
            foreach (IWebElement element in all_text1)
            {
                allText_text1[n++] = element.Text;
            }
                for (int i = 0; i <= all_elem1.Count; i++) //Счётчик РАБОТАЕТ
                {
                    try
                    {
                        string poisk = allText_text1[i];
                        if (poisk.Contains("Тип дома") == true)
                        {
                            AvitoParseAnalog1.AvitoTipDomaMain = allText_text1[i];
                        }
                        else if (poisk.Contains("Год постройки") == true)
                        {
                            AvitoParseAnalog1.AvitoGodPostroykiMain = allText_text1[i];
                        }
                        else if (poisk.Contains("Этажей в доме") == true)
                        {
                            AvitoParseAnalog1.AvitoEtajiAllMain = allText_text1[i];
                        }
                        else if (poisk.Contains("Пассажирский лифт") == true)
                        {
                            AvitoParseAnalog1.AvitoLiftPMain = allText_text1[i];
                        }
                        else if (poisk.Contains("Грузовой лифт") == true)
                        {
                            AvitoParseAnalog1.AvitoLiftGMain = allText_text1[i];
                        }
                        else if (poisk.Contains("Двор") == true)
                        {
                            AvitoParseAnalog1.AvitoDvorMain = allText_text1[i];
                        }
                        else if (poisk.Contains("Парковка") == true)
                        {
                            AvitoParseAnalog1.AvitoParkovkaMain = allText_text1[i];
                        }
                        else if (poisk.Contains("Срок сдачи") == true)
                        {
                            AvitoParseAnalog1.AvitoSrokSdachiMain = allText_text1[i];
                        }
                    }
                    catch { }
                }

                browser.Quit();

            label128.Visible = true;
            label129.Visible = true;
            label130.Visible = true;
            label131.Visible = true;
            label132.Visible = true;
            label133.Visible = true;
            label133.Visible = true;
            label135.Visible = true;

            label39.Visible = true;
            label63.Visible = true;
            label82.Visible = true;
            label87.Visible = true;

            textBox1.Text = AvitoParseAnalog1.AvitoTown;
                textBox9.Text = AvitoParseAnalog1.AvitoAddressUlitsaDomMain;
                string AvitoKomnatiMain = AvitoParseAnalog1.AvitoKomnatiMain.Replace("Количество комнат: ", "");
                textBox2.Text = AvitoKomnatiMain;
                string AvitoPriceMain = AvitoParseAnalog1.AvitoPriceMain.Replace(" ", "");
                textBox4.Text = AvitoPriceMain;//2 641 680
                string AvitoPloshadMain = AvitoParseAnalog1.AvitoPloshadMain.Replace("Общая площадь: ", "");
                string AvitoPloshadMain1 = AvitoPloshadMain.Replace(" м²", "");
                string AvitoPloshadMain2 = AvitoPloshadMain1.Replace(".", ",");
                textBox5.Text = AvitoPloshadMain2;
                textBox6.Text = AvitoPloshadMain2;
                textBox10.Text = AvitoParseAnalog1.AvitoTown;
                string AvitoEtajMain = AvitoParseAnalog1.AvitoEtajMain.Replace("Этаж: ", "");
                string AvitoEtajMain1 = AvitoEtajMain.Replace(" из ", "/");
                textBox12.Text = AvitoEtajMain1;
                string AvitoSubPriceMain = AvitoParseAnalog1.AvitoSubPriceMain.Replace("₽ за м²", "");
                string AvitoSubPriceMain1 = AvitoSubPriceMain.Replace(" ", "");
                textBox13.Text = AvitoSubPriceMain1; //₽ за м²


                if (AvitoParseAnalog1.AvitoGodPostroykiMain != null)
                {
                string AvitoGodPostroykiMain = AvitoParseAnalog1.AvitoGodPostroykiMain.Replace("Год постройки: ", "");
                textBox3.Text = AvitoGodPostroykiMain; 
            }
                else if (AvitoParseAnalog1.AvitoSrokSdachiMain != null)
                {
                string AvitoSrokSdachiMain = AvitoParseAnalog1.AvitoSrokSdachiMain.Replace("Срок сдачи: ", "");
                if (AvitoSrokSdachiMain.Contains("1 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("1 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox3.Text = AvitoSrokSdachiMain2;
                }
                else if (AvitoSrokSdachiMain.Contains("2 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("2 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox3.Text = AvitoSrokSdachiMain2;
                }
                else if (AvitoSrokSdachiMain.Contains("3 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("3 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox3.Text = AvitoSrokSdachiMain2;
                }
                else if (AvitoSrokSdachiMain.Contains("4 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("4 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox3.Text = AvitoSrokSdachiMain2;
                }

                }

                if (AvitoParseAnalog1.AvitoTipDomaMain == null)
                { label39.Text = "н/д"; }
                else
                {
                    label39.Text = AvitoParseAnalog1.AvitoTipDomaMain;
                }

                //ВИД ИЗ ОКОН
                if (AvitoParseAnalog1.AvitoOknaMain == null)
                { label63.Text = "н/д"; }
                else
                {
                    label63.Text = AvitoParseAnalog1.AvitoOknaMain;
                }
                //БАЛКОН ЛОДЖИЯ
                if (AvitoParseAnalog1.AvitoBalkonMain == null)
                { label82.Text = "н/д"; }
                else
                {
                    label82.Text = AvitoParseAnalog1.AvitoBalkonMain;
                }
                //ТИП САНУЗЛА
                if (AvitoParseAnalog1.AvitoSanuzelMain == null)
                { label87.Text = "н/д"; }
                else
                {
                    label87.Text = AvitoParseAnalog1.AvitoSanuzelMain;
                }



            }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            IWebDriver browser;
            //IWebDriver browser;
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Navigate().GoToUrl(textBox26.Text);
            //browser.Manage().Window.Maximize();

            AvitoParseAnalog2.AvitoURL = textBox26.Text;
            try
            {
                AvitoParseAnalog2.AvitoTown = browser.FindElement(By.XPath("//a[@class='breadcrumbs-link-1Z6dK'][1]")).Text;
            }
            catch { }
            try
            {
                AvitoParseAnalog2.AvitoItemID = browser.FindElement(By.XPath("//span[@data-marker='item-view/item-id']")).Text; //Артикуль
            }
            catch { }
            try
            {
                AvitoParseAnalog2.AvitoName = browser.FindElement(By.XPath("//span[contains(@class, 'title-info-title-text')]")).Text; //Описание 
            }
            catch { }
            try
            {
                AvitoParseAnalog2.AvitoPriceMain = browser.FindElement(By.XPath("//*[contains(@class, 'js-item-price style-item-price')]")).Text; //Цена
            }
            catch { }
            try
            {
                AvitoParseAnalog2.AvitoSubPriceMain = browser.FindElement(By.XPath("//*[contains(@class, 'style-item-price-sub-price')]")).Text; //Цена за квадрат
            }
            catch { }
            try
            {
                AvitoParseAnalog2.AvitoAddressUlitsaDomMain = browser.FindElement(By.XPath("//span[contains(@class, 'item-address__string')]")).Text; //Улица, дом
            }
            catch { }
            try
            {
                AvitoParseAnalog2.AvitoAddressRaionMain = browser.FindElement(By.XPath("//span[contains(@class, 'item-address-georeferences')]")).Text; //Район
            }
            catch { }

            IList<IWebElement> all_elem = browser.FindElements(By.XPath("//li[contains(@class, 'params-paramsList__item')]//span[contains(@class, 'css')]"));
            String[] allText_elem = new String[all_elem.Count];
            int k = 0;
            foreach (IWebElement element in all_elem)
            {
                allText_elem[k++] = element.Text;
            }

            IList<IWebElement> all_text = browser.FindElements(By.XPath("//li[contains(@class, 'params-paramsList')]"));
            String[] allText_text = new String[all_text.Count];
            int l = 0;
            foreach (IWebElement element in all_text)
            {
                allText_text[l++] = element.Text;
            }


            for (int i = 0; i <= all_elem.Count; i++) //Счётчик РАБОТАЕТ
            {
                try
                {



                    if (allText_elem[i].Contains("Тип жилья") == true)
                    {
                        AvitoParseAnalog2.AvitoTipJiliyaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Количество комнат") == true)
                    {
                        AvitoParseAnalog2.AvitoKomnatiMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Этаж") == true)
                    {
                        AvitoParseAnalog2.AvitoEtajMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Общая площадь") == true)
                    {
                        AvitoParseAnalog2.AvitoPloshadMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Площадь кухни") == true)
                    {
                        AvitoParseAnalog2.AvitoPloshadKuhniMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Жилая площадь") == true)
                    {
                        AvitoParseAnalog2.AvitoPloshadJilayaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Высота потолков") == true)
                    {
                        AvitoParseAnalog2.AvitoVisotaPotolkovMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Санузел") == true)
                    {
                        AvitoParseAnalog2.AvitoSanuzelMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Окна") == true)
                    {
                        AvitoParseAnalog2.AvitoOknaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Отделка") == true)
                    {
                        AvitoParseAnalog2.AvitoOtdelkaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Тип комнат") == true)
                    {
                        AvitoParseAnalog2.AvitoTipKomnatMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Ремонт") == true)
                    {
                        AvitoParseAnalog2.AvitoRemontMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Способ продажи") == true)
                    {
                        AvitoParseAnalog2.AvitoSposobProdajiMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Балкон или лоджия") == true)
                    {
                        AvitoParseAnalog2.AvitoBalkonMain = allText_text[i];
                    }
                }
                catch { }

            }
            IList<IWebElement> all_elem1 = browser.FindElements(By.XPath("//li[contains(@class, 'style-item-params-list-item')]//span[contains(@class, 'style-item-params-label')]"));
            String[] allText_elem1 = new String[all_elem1.Count];
            int m = 0;
            foreach (IWebElement element in all_elem1)
            {
                allText_elem1[m++] = element.Text;
            }

            IList<IWebElement> all_text1 = browser.FindElements(By.XPath("//li[contains(@class, 'style-item-params-list-item')]"));
            String[] allText_text1 = new String[all_text1.Count];
            int n = 0;
            foreach (IWebElement element in all_text1)
            {
                allText_text1[n++] = element.Text;
            }
            for (int i = 0; i <= all_elem1.Count; i++) //Счётчик РАБОТАЕТ
            {
                try
                {
                    string poisk = allText_text1[i];
                    if (poisk.Contains("Тип дома") == true)
                    {
                        AvitoParseAnalog2.AvitoTipDomaMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Год постройки") == true)
                    {
                        AvitoParseAnalog2.AvitoGodPostroykiMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Этажей в доме") == true)
                    {
                        AvitoParseAnalog2.AvitoEtajiAllMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Пассажирский лифт") == true)
                    {
                        AvitoParseAnalog2.AvitoLiftPMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Грузовой лифт") == true)
                    {
                        AvitoParseAnalog2.AvitoLiftGMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Двор") == true)
                    {
                        AvitoParseAnalog2.AvitoDvorMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Парковка") == true)
                    {
                        AvitoParseAnalog2.AvitoParkovkaMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Срок сдачи") == true)
                    {
                        AvitoParseAnalog2.AvitoSrokSdachiMain = allText_text1[i];
                    }
                }
                catch { }
            }

            browser.Quit();

            label136.Visible = true;
            label137.Visible = true;
            label138.Visible = true;
            label139.Visible = true;
            label140.Visible = true;
            label141.Visible = true;

            label14.Visible = true;
            label18.Visible = true;
            label34.Visible = true;
            label58.Visible = true;

            textBox25.Text = AvitoParseAnalog2.AvitoTown;
            textBox24.Text = AvitoParseAnalog2.AvitoAddressUlitsaDomMain;
            string AvitoKomnatiMain = AvitoParseAnalog2.AvitoKomnatiMain.Replace("Количество комнат: ", "");
            textBox23.Text = AvitoKomnatiMain;
            string AvitoPriceMain = AvitoParseAnalog2.AvitoPriceMain.Replace(" ", "");
            textBox21.Text = AvitoPriceMain;//2 641 680
            string AvitoPloshadMain = AvitoParseAnalog2.AvitoPloshadMain.Replace("Общая площадь: ", "");
            string AvitoPloshadMain1 = AvitoPloshadMain.Replace(" м²", "");
            string AvitoPloshadMain2 = AvitoPloshadMain1.Replace(".", ",");
            textBox20.Text = AvitoPloshadMain2;
            textBox19.Text = AvitoPloshadMain2;
            textBox17.Text = AvitoParseAnalog2.AvitoTown;
            string AvitoEtajMain = AvitoParseAnalog2.AvitoEtajMain.Replace("Этаж: ", "");
            string AvitoEtajMain1 = AvitoEtajMain.Replace(" из ", "/");
            textBox15.Text = AvitoEtajMain1;
            string AvitoSubPriceMain = AvitoParseAnalog2.AvitoSubPriceMain.Replace("₽ за м²", "");
            string AvitoSubPriceMain1 = AvitoSubPriceMain.Replace(" ", "");
            textBox14.Text = AvitoSubPriceMain1; //₽ за м²


            if (AvitoParseAnalog2.AvitoGodPostroykiMain != null)
            {
                string AvitoGodPostroykiMain = AvitoParseAnalog2.AvitoGodPostroykiMain.Replace("Год постройки: ", "");
                textBox22.Text = AvitoGodPostroykiMain;
            }
            else if (AvitoParseAnalog2.AvitoSrokSdachiMain != null)
            {
                string AvitoSrokSdachiMain = AvitoParseAnalog2.AvitoSrokSdachiMain.Replace("Срок сдачи: ", "");
                if (AvitoSrokSdachiMain.Contains("1 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("1 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox22.Text = AvitoSrokSdachiMain2;
                }
                else if (AvitoSrokSdachiMain.Contains("2 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("2 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox22.Text = AvitoSrokSdachiMain2;
                }
                else if (AvitoSrokSdachiMain.Contains("3 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("3 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox22.Text = AvitoSrokSdachiMain2;
                }
                else if (AvitoSrokSdachiMain.Contains("4 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("4 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox22.Text = AvitoSrokSdachiMain2;
                }

            }

            if (AvitoParseAnalog2.AvitoTipDomaMain == null)
            { label58.Text = "н/д"; }
            else
            {
                label58.Text = AvitoParseAnalog2.AvitoTipDomaMain;
            }

            //ВИД ИЗ ОКОН
            if (AvitoParseAnalog2.AvitoOknaMain == null)
            { label34.Text = "н/д"; }
            else
            {
                label34.Text = AvitoParseAnalog2.AvitoOknaMain;
            }
            //БАЛКОН ЛОДЖИЯ
            if (AvitoParseAnalog2.AvitoBalkonMain == null)
            { label18.Text = "н/д"; }
            else
            {
                label18.Text = AvitoParseAnalog2.AvitoBalkonMain;
            }
            //ТИП САНУЗЛА
            if (AvitoParseAnalog2.AvitoSanuzelMain == null)
            { label14.Text = "н/д"; }
            else
            {
                label14.Text = AvitoParseAnalog2.AvitoSanuzelMain;
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            IWebDriver browser;
            //IWebDriver browser;
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Navigate().GoToUrl(textBox39.Text);
            //browser.Manage().Window.Maximize();

            AvitoParseAnalog3.AvitoURL = textBox39.Text;
            try
            {
                AvitoParseAnalog3.AvitoTown = browser.FindElement(By.XPath("//a[@class='breadcrumbs-link-1Z6dK'][1]")).Text;
            }
            catch { }
            try
            {
                AvitoParseAnalog3.AvitoItemID = browser.FindElement(By.XPath("//span[@data-marker='item-view/item-id']")).Text; //Артикуль
            }
            catch { }
            try
            {
                AvitoParseAnalog3.AvitoName = browser.FindElement(By.XPath("//span[contains(@class, 'title-info-title-text')]")).Text; //Описание 
            }
            catch { }
            try
            {
                AvitoParseAnalog3.AvitoPriceMain = browser.FindElement(By.XPath("//*[contains(@class, 'js-item-price style-item-price')]")).Text; //Цена
            }
            catch { }
            try
            {
                AvitoParseAnalog3.AvitoSubPriceMain = browser.FindElement(By.XPath("//*[contains(@class, 'style-item-price-sub-price')]")).Text; //Цена за квадрат
            }
            catch { }
            try
            {
                AvitoParseAnalog3.AvitoAddressUlitsaDomMain = browser.FindElement(By.XPath("//span[contains(@class, 'item-address__string')]")).Text; //Улица, дом
            }
            catch { }
            try
            {
                AvitoParseAnalog3.AvitoAddressRaionMain = browser.FindElement(By.XPath("//span[contains(@class, 'item-address-georeferences')]")).Text; //Район
            }
            catch { }

            IList<IWebElement> all_elem = browser.FindElements(By.XPath("//li[contains(@class, 'params-paramsList__item')]//span[contains(@class, 'css')]"));
            String[] allText_elem = new String[all_elem.Count];
            int k = 0;
            foreach (IWebElement element in all_elem)
            {
                allText_elem[k++] = element.Text;
            }

            IList<IWebElement> all_text = browser.FindElements(By.XPath("//li[contains(@class, 'params-paramsList')]"));
            String[] allText_text = new String[all_text.Count];
            int l = 0;
            foreach (IWebElement element in all_text)
            {
                allText_text[l++] = element.Text;
            }


            for (int i = 0; i <= all_elem.Count; i++) //Счётчик РАБОТАЕТ
            {
                try
                {



                    if (allText_elem[i].Contains("Тип жилья") == true)
                    {
                        AvitoParseAnalog3.AvitoTipJiliyaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Количество комнат") == true)
                    {
                        AvitoParseAnalog3.AvitoKomnatiMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Этаж") == true)
                    {
                        AvitoParseAnalog3.AvitoEtajMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Общая площадь") == true)
                    {
                        AvitoParseAnalog3.AvitoPloshadMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Площадь кухни") == true)
                    {
                        AvitoParseAnalog3.AvitoPloshadKuhniMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Жилая площадь") == true)
                    {
                        AvitoParseAnalog3.AvitoPloshadJilayaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Высота потолков") == true)
                    {
                        AvitoParseAnalog3.AvitoVisotaPotolkovMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Санузел") == true)
                    {
                        AvitoParseAnalog3.AvitoSanuzelMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Окна") == true)
                    {
                        AvitoParseAnalog3.AvitoOknaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Отделка") == true)
                    {
                        AvitoParseAnalog3.AvitoOtdelkaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Тип комнат") == true)
                    {
                        AvitoParseAnalog3.AvitoTipKomnatMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Ремонт") == true)
                    {
                        AvitoParseAnalog3.AvitoRemontMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Способ продажи") == true)
                    {
                        AvitoParseAnalog3.AvitoSposobProdajiMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Балкон или лоджия") == true)
                    {
                        AvitoParseAnalog3.AvitoBalkonMain = allText_text[i];
                    }
                }
                catch { }

            }
            IList<IWebElement> all_elem1 = browser.FindElements(By.XPath("//li[contains(@class, 'style-item-params-list-item')]//span[contains(@class, 'style-item-params-label')]"));
            String[] allText_elem1 = new String[all_elem1.Count];
            int m = 0;
            foreach (IWebElement element in all_elem1)
            {
                allText_elem1[m++] = element.Text;
            }

            IList<IWebElement> all_text1 = browser.FindElements(By.XPath("//li[contains(@class, 'style-item-params-list-item')]"));
            String[] allText_text1 = new String[all_text1.Count];
            int n = 0;
            foreach (IWebElement element in all_text1)
            {
                allText_text1[n++] = element.Text;
            }
            for (int i = 0; i <= all_elem1.Count; i++) //Счётчик РАБОТАЕТ
            {
                try
                {
                    string poisk = allText_text1[i];
                    if (poisk.Contains("Тип дома") == true)
                    {
                        AvitoParseAnalog3.AvitoTipDomaMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Год постройки") == true)
                    {
                        AvitoParseAnalog3.AvitoGodPostroykiMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Этажей в доме") == true)
                    {
                        AvitoParseAnalog3.AvitoEtajiAllMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Пассажирский лифт") == true)
                    {
                        AvitoParseAnalog3.AvitoLiftPMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Грузовой лифт") == true)
                    {
                        AvitoParseAnalog3.AvitoLiftGMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Двор") == true)
                    {
                        AvitoParseAnalog3.AvitoDvorMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Парковка") == true)
                    {
                        AvitoParseAnalog3.AvitoParkovkaMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Срок сдачи") == true)
                    {
                        AvitoParseAnalog3.AvitoSrokSdachiMain = allText_text1[i];
                    }
                }
                catch { }
            }

            browser.Quit();

            label142.Visible = true;
            label143.Visible = true;
            label144.Visible = true;
            label145.Visible = true;
            label146.Visible = true;
            label147.Visible = true;

            label106.Visible = true;
            label121.Visible = true;
            label122.Visible = true;
            label123.Visible = true;

            textBox38.Text = AvitoParseAnalog3.AvitoTown;
            textBox37.Text = AvitoParseAnalog3.AvitoAddressUlitsaDomMain;
            string AvitoKomnatiMain = AvitoParseAnalog3.AvitoKomnatiMain.Replace("Количество комнат: ", "");
            textBox36.Text = AvitoKomnatiMain;
            string AvitoPriceMain = AvitoParseAnalog3.AvitoPriceMain.Replace(" ", "");
            textBox34.Text = AvitoPriceMain;//2 641 680
            string AvitoPloshadMain = AvitoParseAnalog3.AvitoPloshadMain.Replace("Общая площадь: ", "");
            string AvitoPloshadMain1 = AvitoPloshadMain.Replace(" м²", "");
            string AvitoPloshadMain2 = AvitoPloshadMain1.Replace(".", ",");
            textBox33.Text = AvitoPloshadMain2;
            textBox32.Text = AvitoPloshadMain2;
            textBox30.Text = AvitoParseAnalog3.AvitoTown;
            string AvitoEtajMain = AvitoParseAnalog3.AvitoEtajMain.Replace("Этаж: ", "");
            string AvitoEtajMain1 = AvitoEtajMain.Replace(" из ", "/");
            textBox28.Text = AvitoEtajMain1;
            string AvitoSubPriceMain = AvitoParseAnalog3.AvitoSubPriceMain.Replace("₽ за м²", "");
            string AvitoSubPriceMain1 = AvitoSubPriceMain.Replace(" ", "");
            textBox27.Text = AvitoSubPriceMain1; //₽ за м²


            if (AvitoParseAnalog3.AvitoGodPostroykiMain != null)
            {
                string AvitoGodPostroykiMain = AvitoParseAnalog3.AvitoGodPostroykiMain.Replace("Год постройки: ", "");
                textBox35.Text = AvitoGodPostroykiMain;
            }
            else if (AvitoParseAnalog3.AvitoSrokSdachiMain != null)
            {
                string AvitoSrokSdachiMain = AvitoParseAnalog3.AvitoSrokSdachiMain.Replace("Срок сдачи: ", "");
                if (AvitoSrokSdachiMain.Contains("1 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("1 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox35.Text = AvitoSrokSdachiMain2;
                }
                else if (AvitoSrokSdachiMain.Contains("2 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("2 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox35.Text = AvitoSrokSdachiMain2;
                }
                else if (AvitoSrokSdachiMain.Contains("3 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("3 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox35.Text = AvitoSrokSdachiMain2;
                }
                else if (AvitoSrokSdachiMain.Contains("4 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("4 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox35.Text = AvitoSrokSdachiMain2;
                }

            }

            if (AvitoParseAnalog3.AvitoTipDomaMain == null)
            { label123.Text = "н/д"; }
            else
            {
                label123.Text = AvitoParseAnalog3.AvitoTipDomaMain;
            }

            //ВИД ИЗ ОКОН
            if (AvitoParseAnalog3.AvitoOknaMain == null)
            { label122.Text = "н/д"; }
            else
            {
                label122.Text = AvitoParseAnalog3.AvitoOknaMain;
            }
            //БАЛКОН ЛОДЖИЯ
            if (AvitoParseAnalog3.AvitoBalkonMain == null)
            { label121.Text = "н/д"; }
            else
            {
                label121.Text = AvitoParseAnalog3.AvitoBalkonMain;
            }
            //ТИП САНУЗЛА
            if (AvitoParseAnalog3.AvitoSanuzelMain == null)
            { label106.Text = "н/д"; }
            else
            {
                label106.Text = AvitoParseAnalog3.AvitoSanuzelMain;
            }
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            IWebDriver browser;
            //IWebDriver browser;
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Navigate().GoToUrl(textBox52.Text);
            //browser.Manage().Window.Maximize();

            AvitoParseAnalog4.AvitoURL = textBox52.Text;
            try
            {
                AvitoParseAnalog4.AvitoTown = browser.FindElement(By.XPath("//a[@class='breadcrumbs-link-1Z6dK'][1]")).Text;
            }
            catch { }
            try
            {
                AvitoParseAnalog4.AvitoItemID = browser.FindElement(By.XPath("//span[@data-marker='item-view/item-id']")).Text; //Артикуль
            }
            catch { }
            try
            {
                AvitoParseAnalog4.AvitoName = browser.FindElement(By.XPath("//span[contains(@class, 'title-info-title-text')]")).Text; //Описание 
            }
            catch { }
            try
            {
                AvitoParseAnalog4.AvitoPriceMain = browser.FindElement(By.XPath("//*[contains(@class, 'js-item-price style-item-price')]")).Text; //Цена
            }
            catch { }
            try
            {
                AvitoParseAnalog4.AvitoSubPriceMain = browser.FindElement(By.XPath("//*[contains(@class, 'style-item-price-sub-price')]")).Text; //Цена за квадрат
            }
            catch { }
            try
            {
                AvitoParseAnalog4.AvitoAddressUlitsaDomMain = browser.FindElement(By.XPath("//span[contains(@class, 'item-address__string')]")).Text; //Улица, дом
            }
            catch { }
            try
            {
                AvitoParseAnalog4.AvitoAddressRaionMain = browser.FindElement(By.XPath("//span[contains(@class, 'item-address-georeferences')]")).Text; //Район
            }
            catch { }

            IList<IWebElement> all_elem = browser.FindElements(By.XPath("//li[contains(@class, 'params-paramsList__item')]//span[contains(@class, 'css')]"));
            String[] allText_elem = new String[all_elem.Count];
            int k = 0;
            foreach (IWebElement element in all_elem)
            {
                allText_elem[k++] = element.Text;
            }

            IList<IWebElement> all_text = browser.FindElements(By.XPath("//li[contains(@class, 'params-paramsList')]"));
            String[] allText_text = new String[all_text.Count];
            int l = 0;
            foreach (IWebElement element in all_text)
            {
                allText_text[l++] = element.Text;
            }


            for (int i = 0; i <= all_elem.Count; i++) //Счётчик РАБОТАЕТ
            {
                try
                {



                    if (allText_elem[i].Contains("Тип жилья") == true)
                    {
                        AvitoParseAnalog4.AvitoTipJiliyaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Количество комнат") == true)
                    {
                        AvitoParseAnalog4.AvitoKomnatiMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Этаж") == true)
                    {
                        AvitoParseAnalog4.AvitoEtajMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Общая площадь") == true)
                    {
                        AvitoParseAnalog4.AvitoPloshadMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Площадь кухни") == true)
                    {
                        AvitoParseAnalog4.AvitoPloshadKuhniMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Жилая площадь") == true)
                    {
                        AvitoParseAnalog4.AvitoPloshadJilayaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Высота потолков") == true)
                    {
                        AvitoParseAnalog4.AvitoVisotaPotolkovMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Санузел") == true)
                    {
                        AvitoParseAnalog4.AvitoSanuzelMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Окна") == true)
                    {
                        AvitoParseAnalog4.AvitoOknaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Отделка") == true)
                    {
                        AvitoParseAnalog4.AvitoOtdelkaMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Тип комнат") == true)
                    {
                        AvitoParseAnalog4.AvitoTipKomnatMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Ремонт") == true)
                    {
                        AvitoParseAnalog4.AvitoRemontMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Способ продажи") == true)
                    {
                        AvitoParseAnalog4.AvitoSposobProdajiMain = allText_text[i];
                    }
                    else if (allText_elem[i].Contains("Балкон или лоджия") == true)
                    {
                        AvitoParseAnalog4.AvitoBalkonMain = allText_text[i];
                    }
                }
                catch { }

            }
            IList<IWebElement> all_elem1 = browser.FindElements(By.XPath("//li[contains(@class, 'style-item-params-list-item')]//span[contains(@class, 'style-item-params-label')]"));
            String[] allText_elem1 = new String[all_elem1.Count];
            int m = 0;
            foreach (IWebElement element in all_elem1)
            {
                allText_elem1[m++] = element.Text;
            }

            IList<IWebElement> all_text1 = browser.FindElements(By.XPath("//li[contains(@class, 'style-item-params-list-item')]"));
            String[] allText_text1 = new String[all_text1.Count];
            int n = 0;
            foreach (IWebElement element in all_text1)
            {
                allText_text1[n++] = element.Text;
            }
            for (int i = 0; i <= all_elem1.Count; i++) //Счётчик РАБОТАЕТ
            {
                try
                {
                    string poisk = allText_text1[i];
                    if (poisk.Contains("Тип дома") == true)
                    {
                        AvitoParseAnalog4.AvitoTipDomaMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Год постройки") == true)
                    {
                        AvitoParseAnalog4.AvitoGodPostroykiMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Этажей в доме") == true)
                    {
                        AvitoParseAnalog4.AvitoEtajiAllMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Пассажирский лифт") == true)
                    {
                        AvitoParseAnalog4.AvitoLiftPMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Грузовой лифт") == true)
                    {
                        AvitoParseAnalog4.AvitoLiftGMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Двор") == true)
                    {
                        AvitoParseAnalog4.AvitoDvorMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Парковка") == true)
                    {
                        AvitoParseAnalog4.AvitoParkovkaMain = allText_text1[i];
                    }
                    else if (poisk.Contains("Срок сдачи") == true)
                    {
                        AvitoParseAnalog4.AvitoSrokSdachiMain = allText_text1[i];
                    }
                }
                catch { }
            }

            browser.Quit();

            label148.Visible = true;
            label149.Visible = true;
            label150.Visible = true;
            label151.Visible = true;
            label152.Visible = true;
            label153.Visible = true;

            label124.Visible = true;
            label125.Visible = true;
            label126.Visible = true;
            label127.Visible = true;

            textBox51.Text = AvitoParseAnalog4.AvitoTown;
            textBox50.Text = AvitoParseAnalog4.AvitoAddressUlitsaDomMain;
            string AvitoKomnatiMain = AvitoParseAnalog4.AvitoKomnatiMain.Replace("Количество комнат: ", "");
            textBox49.Text = AvitoKomnatiMain;
            string AvitoPriceMain = AvitoParseAnalog4.AvitoPriceMain.Replace(" ", "");
            textBox47.Text = AvitoPriceMain;//2 641 680
            string AvitoPloshadMain = AvitoParseAnalog4.AvitoPloshadMain.Replace("Общая площадь: ", "");
            string AvitoPloshadMain1 = AvitoPloshadMain.Replace(" м²", "");
            string AvitoPloshadMain2 = AvitoPloshadMain1.Replace(".", ",");
            textBox46.Text = AvitoPloshadMain2;
            textBox45.Text = AvitoPloshadMain2;
            textBox43.Text = AvitoParseAnalog4.AvitoTown;
            string AvitoEtajMain = AvitoParseAnalog4.AvitoEtajMain.Replace("Этаж: ", "");
            string AvitoEtajMain1 = AvitoEtajMain.Replace(" из ", "/");
            textBox41.Text = AvitoEtajMain1;
            string AvitoSubPriceMain = AvitoParseAnalog4.AvitoSubPriceMain.Replace("₽ за м²", "");
            string AvitoSubPriceMain1 = AvitoSubPriceMain.Replace(" ", "");
            textBox40.Text = AvitoSubPriceMain1; //₽ за м²


            if (AvitoParseAnalog4.AvitoGodPostroykiMain != null)
            {
                string AvitoGodPostroykiMain = AvitoParseAnalog4.AvitoGodPostroykiMain.Replace("Год постройки: ", "");
                textBox48.Text = AvitoGodPostroykiMain;
            }
            else if (AvitoParseAnalog4.AvitoSrokSdachiMain != null)
            {
                string AvitoSrokSdachiMain = AvitoParseAnalog4.AvitoSrokSdachiMain.Replace("Срок сдачи: ", "");
                if (AvitoSrokSdachiMain.Contains("1 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("1 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox48.Text = AvitoSrokSdachiMain2;
                }
                else if (AvitoSrokSdachiMain.Contains("2 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("2 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox48.Text = AvitoSrokSdachiMain2;
                }
                else if (AvitoSrokSdachiMain.Contains("3 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("3 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox48.Text = AvitoSrokSdachiMain2;
                }
                else if (AvitoSrokSdachiMain.Contains("4 кв. ") == true)
                {
                    string AvitoSrokSdachiMain1 = AvitoSrokSdachiMain.Replace("4 кв. ", "");
                    string AvitoSrokSdachiMain2 = AvitoSrokSdachiMain1.Replace(" года", "");
                    textBox48.Text = AvitoSrokSdachiMain2;
                }

            }

            if (AvitoParseAnalog4.AvitoTipDomaMain == null)
            { label127.Text = "н/д"; }
            else
            {
                label127.Text = AvitoParseAnalog4.AvitoTipDomaMain;
            }

            //ВИД ИЗ ОКОН
            if (AvitoParseAnalog4.AvitoOknaMain == null)
            { label126.Text = "н/д"; }
            else
            {
                label126.Text = AvitoParseAnalog4.AvitoOknaMain;
            }
            //БАЛКОН ЛОДЖИЯ
            if (AvitoParseAnalog4.AvitoBalkonMain == null)
            { label125.Text = "н/д"; }
            else
            {
                label125.Text = AvitoParseAnalog4.AvitoBalkonMain;
            }
            //ТИП САНУЗЛА
            if (AvitoParseAnalog4.AvitoSanuzelMain == null)
            { label124.Text = "н/д"; }
            else
            {
                label124.Text = AvitoParseAnalog4.AvitoSanuzelMain;
            }
        }

        private void rjToggleButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSave(object sender, EventArgs e)
        {
            SaveFlag = 1;
        }
        private void comboBoxSave(object sender, EventArgs e)
        {
            SaveFlag = 1;
        }

        private void rjToggleButtonSave(object sender, EventArgs e)
        {
            SaveFlag = 1;
        }

        private void Comparative_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveFlag == 1)
            {
                DialogResult result = MessageBox.Show(
        "Сохранить изменения?",
        "Сообщение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {

                    //ANALOG 1
                    SelectBanking.Analog1[1] = textBox1.Text; //[АдресГород]
                    SelectBanking.Analog1[2] = textBox9.Text;//[АдресУлица]
                    SelectBanking.Analog1[3] = textBox2.Text;//[КоличествоКомнат]
                    SelectBanking.Analog1[4] = textBox3.Text;//[ГодПостройки]
                    SelectBanking.Analog1[6] = textBox4.Text;//[ЦенаПредложения,руб]
                    SelectBanking.Analog1[7] = textBox5.Text;//[ПлощадьЗаявленная,квм]
                    SelectBanking.Analog1[5] = textBox8.Text;//[ИсточникИнформации]
                    SelectBanking.Analog1[8] = comboBox1.SelectedValue.ToString();//[КодСпособПодсчетаПлощади]
                    SelectBanking.Analog1[9] = textBox6.Text;//[ФактическаяПлощадь,квм]
                    SelectBanking.Analog1[10] = comboBox2.SelectedValue.ToString();//[КодУсловиеФинансирования]
                    SelectBanking.Analog1[11] = comboBox3.SelectedValue.ToString();//[ПередаваемыеПрава]
                    SelectBanking.Analog1[13] = comboBox5.SelectedValue.ToString();//[КодТипДома/МатериалСтен]
                    SelectBanking.Analog1[14] = comboBox6.SelectedValue.ToString();//[СостояниеДома]
                    SelectBanking.Analog1[15] = textBox12.Text;//[Этаж/ВсегоЭтажей]
                    SelectBanking.Analog1[16] = comboBox7.SelectedValue.ToString();//[ВидИзОкна]
                    SelectBanking.Analog1[17] = comboBox8.SelectedValue.ToString();//[НаличиеБалкона/Лоджии]
                    SelectBanking.Analog1[18] = comboBox9.SelectedValue.ToString();//[ТипСанузла]
                    SelectBanking.Analog1[19] = comboBox10.SelectedValue.ToString();//[СостояниеОтделки/ТипРемонта]
                    SelectBanking.Analog1[21] = textBox13.Text;//[УдельнаяЦенаПредложения]
                    if (rjToggleButton2.Checked)//[СостояниеДома]
                    { SelectBanking.Analog1[12] = "1"; }
                    else { SelectBanking.Analog1[12] = "0"; }
                    if (rjToggleButton1.Checked)//[НаличиеМебели/Техники]
                    { SelectBanking.Analog1[20] = "1"; }
                    else { SelectBanking.Analog1[20] = "0"; }

                    //ANALOG 2
                    SelectBanking.Analog2[1] = textBox25.Text;
                    SelectBanking.Analog2[2] = textBox24.Text;
                    SelectBanking.Analog2[3] = textBox23.Text;
                    SelectBanking.Analog2[4] = textBox22.Text;
                    SelectBanking.Analog2[6] = textBox21.Text;
                    SelectBanking.Analog2[7] = textBox20.Text;
                    SelectBanking.Analog2[5] = textBox26.Text;
                    SelectBanking.Analog2[8] = comboBox18.SelectedValue.ToString();
                    SelectBanking.Analog2[9] = textBox19.Text;
                    SelectBanking.Analog2[10] = comboBox17.SelectedValue.ToString();
                    SelectBanking.Analog2[11] = comboBox16.SelectedValue.ToString();
                    SelectBanking.Analog2[13] = comboBox15.SelectedValue.ToString();
                    SelectBanking.Analog2[14] = comboBox14.SelectedValue.ToString();
                    SelectBanking.Analog2[15] = textBox15.Text;
                    SelectBanking.Analog2[16] = comboBox13.SelectedValue.ToString();
                    SelectBanking.Analog2[17] = comboBox12.SelectedValue.ToString();
                    SelectBanking.Analog2[18] = comboBox11.SelectedValue.ToString();
                    SelectBanking.Analog2[19] = comboBox4.SelectedValue.ToString();
                    SelectBanking.Analog2[21] = textBox14.Text;
                    if (rjToggleButton3.Checked)
                    { SelectBanking.Analog2[12] = "1"; }
                    else { SelectBanking.Analog2[12] = "0"; }
                    if (rjToggleButton4.Checked)
                    { SelectBanking.Analog2[20] = "1"; }
                    else { SelectBanking.Analog2[20] = "0"; }

                    //ANALOG 3
                    SelectBanking.Analog3[1] = textBox38.Text;
                    SelectBanking.Analog3[2] = textBox37.Text;
                    SelectBanking.Analog3[3] = textBox36.Text;
                    SelectBanking.Analog3[4] = textBox35.Text;
                    SelectBanking.Analog3[6] = textBox34.Text;
                    SelectBanking.Analog3[7] = textBox33.Text;
                    SelectBanking.Analog3[5] = textBox39.Text;
                    SelectBanking.Analog3[8] = comboBox27.SelectedValue.ToString();
                    SelectBanking.Analog3[9] = textBox32.Text;
                    SelectBanking.Analog3[10] = comboBox26.SelectedValue.ToString();
                    SelectBanking.Analog3[11] = comboBox25.SelectedValue.ToString();
                    SelectBanking.Analog3[13] = comboBox15.SelectedValue.ToString();
                    SelectBanking.Analog3[14] = comboBox23.SelectedValue.ToString();
                    SelectBanking.Analog3[15] = textBox28.Text;
                    SelectBanking.Analog3[16] = comboBox22.SelectedValue.ToString();
                    SelectBanking.Analog3[17] = comboBox21.SelectedValue.ToString();
                    SelectBanking.Analog3[18] = comboBox20.SelectedValue.ToString();
                    SelectBanking.Analog3[19] = comboBox19.SelectedValue.ToString();
                    SelectBanking.Analog3[21] = textBox27.Text;
                    if (rjToggleButton5.Checked)
                    { SelectBanking.Analog3[12] = "1"; }
                    else { SelectBanking.Analog3[12] = "0"; }
                    if (rjToggleButton6.Checked)
                    { SelectBanking.Analog3[20] = "1"; }
                    else { SelectBanking.Analog3[20] = "0"; }


                    //ANALOG 4
                    SelectBanking.Analog4[1] = textBox51.Text;
                    SelectBanking.Analog4[2] = textBox50.Text;
                    SelectBanking.Analog4[3] = textBox49.Text;
                    SelectBanking.Analog4[4] = textBox48.Text;
                    SelectBanking.Analog4[6] = textBox47.Text;
                    SelectBanking.Analog4[7] = textBox46.Text;
                    SelectBanking.Analog4[5] = textBox52.Text;
                    SelectBanking.Analog4[8] = comboBox36.SelectedValue.ToString();
                    SelectBanking.Analog4[9] = textBox45.Text;
                    SelectBanking.Analog4[10] = comboBox35.SelectedValue.ToString();
                    SelectBanking.Analog4[11] = comboBox34.SelectedValue.ToString();
                    SelectBanking.Analog4[13] = comboBox33.SelectedValue.ToString();
                    SelectBanking.Analog4[14] = comboBox32.SelectedValue.ToString();
                    SelectBanking.Analog4[15] = textBox41.Text;
                    SelectBanking.Analog4[16] = comboBox31.SelectedValue.ToString();
                    SelectBanking.Analog4[17] = comboBox30.SelectedValue.ToString();
                    SelectBanking.Analog4[18] = comboBox29.SelectedValue.ToString();
                    SelectBanking.Analog4[19] = comboBox28.SelectedValue.ToString();
                    SelectBanking.Analog4[21] = textBox40.Text;
                    if (rjToggleButton7.Checked)
                    { SelectBanking.Analog4[12] = "1"; }
                    else { SelectBanking.Analog4[12] = "0"; }
                    if (rjToggleButton8.Checked)
                    { SelectBanking.Analog4[20] = "1"; }
                    else { SelectBanking.Analog4[20] = "0"; }

                    //СРАВНИТЕЛЬНЫЙ ОБЪЕКТ
                    SelectBanking.SravnObject[1] = textBox65.Text; //[ИсточникИнформации]
                    SelectBanking.SravnObject[2] = textBox60.Text;//[ЦенаПредложения,руб]
                    SelectBanking.SravnObject[3] = comboBox45.SelectedValue.ToString();//[КодСпособПодсчетаПлощади]
                    SelectBanking.SravnObject[4] = textBox58.Text;//[ФактическаяПлощадь,квм]
                    SelectBanking.SravnObject[5] = comboBox44.SelectedValue.ToString();//[КодУсловиеФинансирования]
                    SelectBanking.SravnObject[6] = comboBox43.SelectedValue.ToString();//[ПередаваемыеПрава]
                    SelectBanking.SravnObject[9] = textBox53.Text;//[УдельнаяЦенаПредложения]
                    if (rjToggleButton9.Checked)//[ВозможностьТорга]
                    { SelectBanking.SravnObject[7] = "1"; }
                    else { SelectBanking.SravnObject[7] = "0"; }
                    if (rjToggleButton10.Checked)//[НаличиеМебели/Техники]
                    { SelectBanking.SravnObject[8] = "1"; }
                    else { SelectBanking.SravnObject[8] = "0"; }

                    try
                    {

                        queriesTableAdapter1.СравнительныйАналог1_ИЗМЕНИТЬ(SelectBanking.Analog1[1], SelectBanking.Analog1[2], SelectBanking.Analog1[5], Convert.ToInt32(SelectBanking.Analog1[11]), SelectBanking.Analog1[12], Convert.ToInt32(SelectBanking.Analog1[14]), SelectBanking.Analog1[15], Convert.ToInt32(SelectBanking.Analog1[16]), Convert.ToInt32(SelectBanking.Analog1[17]), Convert.ToInt32(SelectBanking.Analog1[19]), SelectBanking.Analog1[20], Convert.ToInt32(SelectBanking.Analog1[21]), Convert.ToInt32(SelectBanking.Analog1[3]), Convert.ToInt32(SelectBanking.Analog1[4]), Convert.ToInt32(SelectBanking.Analog1[6]), Convert.ToInt32(SelectBanking.Analog1[7]), Convert.ToInt32(SelectBanking.Analog1[8]), Convert.ToInt32(SelectBanking.Analog1[9]), Convert.ToInt32(SelectBanking.Analog1[10]), Convert.ToInt32(SelectBanking.Analog1[13]), Convert.ToInt32(SelectBanking.Analog1[18]), Convert.ToInt32(SelectBanking.Analog1[0]));
                    }
                    catch { }
                    try { 
                    queriesTableAdapter1.СравнительныйАналог2_ИЗМЕНИТЬ(SelectBanking.Analog2[1], SelectBanking.Analog2[2], SelectBanking.Analog2[5], Convert.ToInt32(SelectBanking.Analog2[11]), SelectBanking.Analog2[12], Convert.ToInt32(SelectBanking.Analog2[14]), SelectBanking.Analog2[15], Convert.ToInt32(SelectBanking.Analog2[16]), Convert.ToInt32(SelectBanking.Analog2[17]), Convert.ToInt32(SelectBanking.Analog2[19]), SelectBanking.Analog2[20], Convert.ToInt32(SelectBanking.Analog2[21]), Convert.ToInt32(SelectBanking.Analog2[3]), Convert.ToInt32(SelectBanking.Analog2[4]), Convert.ToInt32(SelectBanking.Analog2[6]), Convert.ToInt32(SelectBanking.Analog2[7]), Convert.ToInt32(SelectBanking.Analog2[8]), Convert.ToInt32(SelectBanking.Analog2[9]), Convert.ToInt32(SelectBanking.Analog2[10]), Convert.ToInt32(SelectBanking.Analog2[13]), Convert.ToInt32(SelectBanking.Analog2[18]), Convert.ToInt32(SelectBanking.Analog2[0]));
                    }
                    catch { }
                    try
                    {
                        queriesTableAdapter1.СравнительныйАналог3_ИЗМЕНИТЬ(SelectBanking.Analog3[1], SelectBanking.Analog3[2], SelectBanking.Analog3[5], Convert.ToInt32(SelectBanking.Analog3[11]), SelectBanking.Analog3[12], Convert.ToInt32(SelectBanking.Analog3[14]), SelectBanking.Analog3[15], Convert.ToInt32(SelectBanking.Analog3[16]), Convert.ToInt32(SelectBanking.Analog3[17]), Convert.ToInt32(SelectBanking.Analog3[19]), SelectBanking.Analog3[20], Convert.ToInt32(SelectBanking.Analog3[21]), Convert.ToInt32(SelectBanking.Analog3[3]), Convert.ToInt32(SelectBanking.Analog3[4]), Convert.ToInt32(SelectBanking.Analog3[6]), Convert.ToInt32(SelectBanking.Analog3[7]), Convert.ToInt32(SelectBanking.Analog3[8]), Convert.ToInt32(SelectBanking.Analog3[9]), Convert.ToInt32(SelectBanking.Analog3[10]), Convert.ToInt32(SelectBanking.Analog3[13]), Convert.ToInt32(SelectBanking.Analog3[18]), Convert.ToInt32(SelectBanking.Analog3[0]));
                    }
                    catch { }
                    try
                    {
                        queriesTableAdapter1.СравнительныйАналог4_ИЗМЕНИТЬ(SelectBanking.Analog4[1], SelectBanking.Analog4[2], SelectBanking.Analog4[5], Convert.ToInt32(SelectBanking.Analog4[11]), SelectBanking.Analog4[12], Convert.ToInt32(SelectBanking.Analog4[14]), SelectBanking.Analog4[15], Convert.ToInt32(SelectBanking.Analog4[16]), Convert.ToInt32(SelectBanking.Analog4[17]), Convert.ToInt32(SelectBanking.Analog4[19]), SelectBanking.Analog4[20], Convert.ToInt32(SelectBanking.Analog4[21]), Convert.ToInt32(SelectBanking.Analog4[3]), Convert.ToInt32(SelectBanking.Analog4[4]), Convert.ToInt32(SelectBanking.Analog4[6]), Convert.ToInt32(SelectBanking.Analog4[7]), Convert.ToInt32(SelectBanking.Analog4[8]), Convert.ToInt32(SelectBanking.Analog4[9]), Convert.ToInt32(SelectBanking.Analog4[10]), Convert.ToInt32(SelectBanking.Analog4[13]), Convert.ToInt32(SelectBanking.Analog4[18]), Convert.ToInt32(SelectBanking.Analog4[0]));
                    }
                    catch { }
                    try
                    {
                        queriesTableAdapter1.СравнительныйОбъект_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.SravnObject[2]), Convert.ToInt32(SelectBanking.SravnObject[3]), Convert.ToInt32(SelectBanking.SravnObject[4]), Convert.ToInt32(SelectBanking.SravnObject[5]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[0]), SelectBanking.SravnObject[1], SelectBanking.SravnObject[6], SelectBanking.SravnObject[7], SelectBanking.SravnObject[8], SelectBanking.SravnObject[9], Convert.ToInt32(SelectBanking.SravnObject[0]));
                    }
                    catch { }




                    }
            }
                }

        private void textBox_CharOnly(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) & (e.KeyChar != (char)System.Windows.Forms.Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void textBox_CharOnlyAnd(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & (e.KeyChar != ',') & (e.KeyChar != (char)System.Windows.Forms.Keys.Back))
                e.Handled = true;
        }
    }
    } 
