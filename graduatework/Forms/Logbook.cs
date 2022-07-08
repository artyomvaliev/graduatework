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
    public partial class Logbook : Form
    {
        public int SaveFlag;
        public Logbook()
        {
            InitializeComponent();
        }

        private void Logbook_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПЭкспертноеСостояние". При необходимости она может быть перемещена или удалена.
            this.пЭкспертноеСостояниеTableAdapter.Fill(this.graduatedbDataSet.ПЭкспертноеСостояние);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПОкна". При необходимости она может быть перемещена или удалена.
            this.пОкнаTableAdapter1.Fill(this.graduatedbDataSet.ПОкна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ППотолок". При необходимости она может быть перемещена или удалена.
            this.пПотолокTableAdapter1.Fill(this.graduatedbDataSet.ППотолок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ППолы". При необходимости она может быть перемещена или удалена.
            this.пПолыTableAdapter1.Fill(this.graduatedbDataSet.ППолы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПСтены". При необходимости она может быть перемещена или удалена.
            this.пСтеныTableAdapter1.Fill(this.graduatedbDataSet.ПСтены);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПМежкомнатныеДвери". При необходимости она может быть перемещена или удалена.
            this.пМежкомнатныеДвериTableAdapter1.Fill(this.graduatedbDataSet.ПМежкомнатныеДвери);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПВходнаяДверь". При необходимости она может быть перемещена или удалена.
            this.пВходнаяДверьTableAdapter1.Fill(this.graduatedbDataSet.ПВходнаяДверь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПТипОтделки". При необходимости она может быть перемещена или удалена.
            this.пТипОтделкиTableAdapter1.Fill(this.graduatedbDataSet.ПТипОтделки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПДанныеОПерепланировке". При необходимости она может быть перемещена или удалена.
            this.пДанныеОПерепланировкеTableAdapter1.Fill(this.graduatedbDataSet.ПДанныеОПерепланировке);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПВидИзОкон". При необходимости она может быть перемещена или удалена.
            this.пВидИзОконTableAdapter1.Fill(this.graduatedbDataSet.ПВидИзОкон);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПЗастеклен". При необходимости она может быть перемещена или удалена.
            this.пЗастекленTableAdapter1.Fill(this.graduatedbDataSet.ПЗастеклен);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПБалконЛоджия". При необходимости она может быть перемещена или удалена.
            this.пБалконЛоджияTableAdapter1.Fill(this.graduatedbDataSet.ПБалконЛоджия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПТипСанузлов". При необходимости она может быть перемещена или удалена.
            this.пТипСанузловTableAdapter1.Fill(this.graduatedbDataSet.ПТипСанузлов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПТекущееИспользование". При необходимости она может быть перемещена или удалена.
            this.пТекущееИспользованиеTableAdapter1.Fill(this.graduatedbDataSet.ПТекущееИспользование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПНазначение". При необходимости она может быть перемещена или удалена.
            this.пНазначениеTableAdapter1.Fill(this.graduatedbDataSet.ПНазначение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПЗеленыеНасаждения". При необходимости она может быть перемещена или удалена.
            this.пЗеленыеНасажденияTableAdapter1.Fill(this.graduatedbDataSet.ПЗеленыеНасаждения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПДетскаяПлощадка". При необходимости она может быть перемещена или удалена.
            this.пДетскаяПлощадкаTableAdapter1.Fill(this.graduatedbDataSet.ПДетскаяПлощадка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПСостояниеПодъезда". При необходимости она может быть перемещена или удалена.
            this.пСостояниеПодъездаTableAdapter1.Fill(this.graduatedbDataSet.ПСостояниеПодъезда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПНаличиеОбъектовПривлекательности". При необходимости она может быть перемещена или удалена.
            this.пНаличиеОбъектовПривлекательностиTableAdapter1.Fill(this.graduatedbDataSet.ПНаличиеОбъектовПривлекательности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПНаличиеОгороженнойПридомовойТерритории". При необходимости она может быть перемещена или удалена.
            this.пНаличиеОгороженнойПридомовойТерриторииTableAdapter1.Fill(this.graduatedbDataSet.ПНаличиеОгороженнойПридомовойТерритории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ППарковка". При необходимости она может быть перемещена или удалена.
            this.пПарковкаTableAdapter1.Fill(this.graduatedbDataSet.ППарковка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПДомофон". При необходимости она может быть перемещена или удалена.
            this.пДомофонTableAdapter1.Fill(this.graduatedbDataSet.ПДомофон);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПСостояниеВнешнейОтделки". При необходимости она может быть перемещена или удалена.
            this.пСостояниеВнешнейОтделкиTableAdapter1.Fill(this.graduatedbDataSet.ПСостояниеВнешнейОтделки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПМетодОпределенияФизИзноса". При необходимости она может быть перемещена или удалена.
            this.пМетодОпределенияФизИзносаTableAdapter1.Fill(this.graduatedbDataSet.ПМетодОпределенияФизИзноса);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПСостояниеДома". При необходимости она может быть перемещена или удалена.
            this.пСостояниеДомаTableAdapter1.Fill(this.graduatedbDataSet.ПСостояниеДома);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПМатериалПерекрытий". При необходимости она может быть перемещена или удалена.
            this.пМатериалПерекрытийTableAdapter1.Fill(this.graduatedbDataSet.ПМатериалПерекрытий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПТипДомаМатериалСтен". При необходимости она может быть перемещена или удалена.
            this.пТипДомаМатериалСтенTableAdapter1.Fill(this.graduatedbDataSet.ПТипДомаМатериалСтен);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПЭкологическаяОбстановкаРайона". При необходимости она может быть перемещена или удалена.
            this.пЭкологическаяОбстановкаРайонаTableAdapter1.Fill(this.graduatedbDataSet.ПЭкологическаяОбстановкаРайона);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПОбеспеченностьОбъектамиСоцИнфраструктуры". При необходимости она может быть перемещена или удалена.
            this.пОбеспеченностьОбъектамиСоцИнфраструктурыTableAdapter1.Fill(this.graduatedbDataSet.ПОбеспеченностьОбъектамиСоцИнфраструктуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПОбеспеченностьОбщТранспортом". При необходимости она может быть перемещена или удалена.
            this.пОбеспеченностьОбщТранспортомTableAdapter1.Fill(this.graduatedbDataSet.ПОбеспеченностьОбщТранспортом);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПТранспортнаяДоступность". При необходимости она может быть перемещена или удалена.
            this.пТранспортнаяДоступностьTableAdapter1.Fill(this.graduatedbDataSet.ПТранспортнаяДоступность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ППреобладающаяЗастройка". При необходимости она может быть перемещена или удалена.
            this.пПреобладающаяЗастройкаTableAdapter1.Fill(this.graduatedbDataSet.ППреобладающаяЗастройка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПЛокальноеРасположениеВнутриМикрорайона". При необходимости она может быть перемещена или удалена.
            this.пЛокальноеРасположениеВнутриМикрорайонаTableAdapter1.Fill(this.graduatedbDataSet.ПЛокальноеРасположениеВнутриМикрорайона);
            
            //Идентификация и характеристика местоположения объекта оценки
            comboBox1.SelectedValue = Convert.ToInt32(SelectBanking.IIXMO[2]); //[КодЛокальноеРасположениеВнутриМикрорайона]
            comboBox2.SelectedValue = Convert.ToInt32(SelectBanking.IIXMO[3]); //[КодПреобладающаяЗастройка]
            comboBox3.SelectedValue = Convert.ToInt32(SelectBanking.IIXMO[4]);//[КодТранспортнаяДоступность]
            comboBox4.SelectedValue = Convert.ToInt32(SelectBanking.IIXMO[5]);//[КодОбеспеченнностьОбщТранспортом]
            textBox6.Text = SelectBanking.IIXMO[6];//[ОбъектыСоцИнфраструктурыПешая]
            comboBox5.SelectedValue = Convert.ToInt32(SelectBanking.IIXMO[7]);//[КодОбеспеченностьОбъектамиСоцИнфраструктуры]
            comboBox6.SelectedValue = Convert.ToInt32(SelectBanking.IIXMO[8]);//[КодЭкологичестваяОбстановкаРайона]
            textBox7.Text = SelectBanking.IIXMO[9];//[ОбъектыПромИнфраструктуры]

            //Общая характеристика здания
            comboBox7.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[1]);//[КодТипДома/МатериалСтен]
            textBox9.Text = SelectBanking.OXZ[2];//[Этажность]
            comboBox8.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[3]);//[КодМатериалПерекрытий]
            textBox10.Text = SelectBanking.OXZ[4];//[ГодПостройки]
            textBox11.Text = SelectBanking.OXZ[5];//[ГодПоследнегоКапРемонта]
            textBox12.Text = SelectBanking.OXZ[6];//[ФактическийСрокСлужбы]
            comboBox9.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[7]);//[КодСостояниеДома]
            textBox13.Text = SelectBanking.OXZ[8];//[ОбщийФизическийИзнос]
            comboBox10.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[9]);//[КодМетодОпределенияФизИзноса]
            comboBox11.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[10]);//[КодСостояниеВнешнейОтделки]
            comboBox12.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[11]);//[КодДомофон]
            comboBox13.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[12]);//[КодПарковка]
            comboBox14.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[13]);//[КодНаличиеОгражденнойПридомовойТерритории]
            comboBox15.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[14]);//[КодНаличиеОбъектовПривлекательности]
            comboBox16.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[15]);//[КодСостояниеПодъезда]
            comboBox17.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[16]);//[КодДетскаяПлощадка]
            comboBox18.SelectedValue = Convert.ToInt32(SelectBanking.OXZ[17]);//[КодЗеленыеНасаждения]
            textBox14.Text = SelectBanking.OXZ[18];//[ДопИнформация]

            //Характеристика объекта оценки
            comboBox20.SelectedValue = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[2]);
            comboBox21.SelectedValue = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[3]);
            textBox15.Text = SelectBanking.HarkaObjectaOtsenki[4];

            textBox16.Text = SelectBanking.ObjectOtsenki[7];

            textBox17.Text = SelectBanking.HarkaObjectaOtsenki[5];

            textBox18.Text = SelectBanking.ObjectOtsenki[6];

            textBox20.Text = SelectBanking.HarkaObjectaOtsenki[6];
            textBox24.Text = SelectBanking.HarkaObjectaOtsenki[7];
            textBox25.Text = SelectBanking.HarkaObjectaOtsenki[8];
            textBox26.Text = SelectBanking.HarkaObjectaOtsenki[9];
            textBox21.Text = SelectBanking.HarkaObjectaOtsenki[10];
            textBox22.Text = SelectBanking.HarkaObjectaOtsenki[11];
            comboBox22.SelectedValue = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[12]);
            textBox19.Text = SelectBanking.HarkaObjectaOtsenki[13];
            textBox23.Text = SelectBanking.HarkaObjectaOtsenki[19];
            comboBox23.SelectedValue = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[14]);
            comboBox24.SelectedValue = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[15]);
            comboBox25.SelectedValue = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[16]);
            comboBox26.SelectedValue = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[17]);
            comboBox27.SelectedValue = Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[18]);

            //Инженерное обеспечение
            if(SelectBanking.InjenernoeObesp[1] == "1")
            {
                rjToggleButton2.Checked = true;
            }
            if (SelectBanking.InjenernoeObesp[2] == "1")
            {
                rjToggleButton3.Checked = true;
            }
            if (SelectBanking.InjenernoeObesp[3] == "1")
            {
                rjToggleButton4.Checked = true;
            }
            if (SelectBanking.InjenernoeObesp[4] == "1")
            {
                rjToggleButton5.Checked = true;
            }
            if (SelectBanking.InjenernoeObesp[5] == "1")
            {
                rjToggleButton6.Checked = true;
            }
            if (SelectBanking.InjenernoeObesp[6] == "1")
            {
                rjToggleButton7.Checked = true;
            }
            if (SelectBanking.InjenernoeObesp[7] == "1")
            {
                rjToggleButton8.Checked = true;
            }
            if (SelectBanking.InjenernoeObesp[8] == "1")
            {
                rjToggleButton9.Checked = true;
            }
            if (SelectBanking.InjenernoeObesp[9] == "1")
            {
                rjToggleButton10.Checked = true;
            }
            if (SelectBanking.InjenernoeObesp[10] == "1")
            {
                rjToggleButton11.Checked = true;
            }

            //Отделка
            comboBox28.SelectedValue = Convert.ToInt32(SelectBanking.Otdelka[1]);
            comboBox29.SelectedValue = Convert.ToInt32(SelectBanking.Otdelka[2]);
            //Комнаты
            comboBox30.SelectedValue = Convert.ToInt32(SelectBanking.Komnati[1]);
            comboBox37.SelectedValue = Convert.ToInt32(SelectBanking.Komnati[2]);
            comboBox41.SelectedValue = Convert.ToInt32(SelectBanking.Komnati[3]);
            comboBox45.SelectedValue = Convert.ToInt32(SelectBanking.Komnati[4]);
            //Кухня
            comboBox31.SelectedValue = Convert.ToInt32(SelectBanking.Kuhnya[1]);
            comboBox34.SelectedValue = Convert.ToInt32(SelectBanking.Kuhnya[2]);
            comboBox38.SelectedValue = Convert.ToInt32(SelectBanking.Kuhnya[3]);
            comboBox42.SelectedValue = Convert.ToInt32(SelectBanking.Kuhnya[4]);
            //Санузлы
            comboBox32.SelectedValue = Convert.ToInt32(SelectBanking.Sanuzli[1]);
            comboBox35.SelectedValue = Convert.ToInt32(SelectBanking.Sanuzli[2]);
            comboBox39.SelectedValue = Convert.ToInt32(SelectBanking.Sanuzli[3]);
            comboBox43.SelectedValue = Convert.ToInt32(SelectBanking.Sanuzli[4]);
            //Иные
            comboBox33.SelectedValue = Convert.ToInt32(SelectBanking.Inie[1]);
            comboBox36.SelectedValue = Convert.ToInt32(SelectBanking.Inie[2]);
            comboBox40.SelectedValue = Convert.ToInt32(SelectBanking.Inie[3]);
            comboBox44.SelectedValue = Convert.ToInt32(SelectBanking.Inie[4]);
            SaveFlag = 0;

            //Экспертное состояние
            comboBox19.SelectedValue = SelectBanking.EOTS[1];
            comboBox46.SelectedValue = SelectBanking.EOTS[2];
            comboBox47.SelectedValue = SelectBanking.EOTS[3];
            comboBox48.SelectedValue = SelectBanking.EOTS[4];
            comboBox49.SelectedValue = SelectBanking.EOTS[5];
            comboBox50.SelectedValue = SelectBanking.EOTS[6];
            comboBox51.SelectedValue = SelectBanking.EOTS[7];
            comboBox52.SelectedValue = SelectBanking.EOTS[8];
            comboBox53.SelectedValue = SelectBanking.EOTS[10];
            comboBox54.SelectedValue = SelectBanking.EOTS[11];
            comboBox55.SelectedValue = SelectBanking.EOTS[12];
            comboBox56.SelectedValue = SelectBanking.EOTS[13];
            comboBox57.SelectedValue = SelectBanking.EOTS[14];
            comboBox58.SelectedValue = SelectBanking.EOTS[15];
            comboBox59.SelectedValue = SelectBanking.EOTS[16];
            comboBox60.SelectedValue = SelectBanking.EOTS[9];
            textBox1.Text = SelectBanking.EOTS[17];

        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked)
            {
                textBox8.Enabled = true;
                rjButton2.Enabled = true;
            }
            else
            {
                textBox8.Enabled = false;
                rjButton2.Enabled = false;
            }

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            //Идентификация и характеристика местоположения объекта оценки
            SelectBanking.IIXMO[2] = comboBox1.SelectedValue.ToString();
            SelectBanking.IIXMO[3] = comboBox2.SelectedValue.ToString();
            SelectBanking.IIXMO[4] = comboBox3.SelectedValue.ToString();
            SelectBanking.IIXMO[5] = comboBox4.SelectedValue.ToString();
            SelectBanking.IIXMO[6] = textBox6.Text;
            SelectBanking.IIXMO[7] = comboBox5.SelectedValue.ToString();
            SelectBanking.IIXMO[8] = comboBox6.SelectedValue.ToString();
            SelectBanking.IIXMO[9] = textBox7.Text;

            //Общая характеристика здания
            SelectBanking.OXZ[1] =comboBox7.SelectedValue.ToString() ;
            SelectBanking.OXZ[2] =textBox9.Text ;
            SelectBanking.OXZ[3] =comboBox8.SelectedValue.ToString();
            SelectBanking.OXZ[4] =textBox10.Text  ;
            SelectBanking.OXZ[5] =textBox11.Text ;
            SelectBanking.OXZ[6] =textBox12.Text  ;
            SelectBanking.OXZ[7] =comboBox9.SelectedValue.ToString();
            SelectBanking.OXZ[8] =textBox13.Text  ;
            SelectBanking.OXZ[9] =comboBox10.SelectedValue.ToString();
            SelectBanking.OXZ[10] =comboBox11.SelectedValue.ToString();
            SelectBanking.OXZ[11] =comboBox12.SelectedValue.ToString();
            SelectBanking.OXZ[12] =comboBox13.SelectedValue.ToString();
            SelectBanking.OXZ[13] =comboBox14.SelectedValue.ToString();
            SelectBanking.OXZ[14] =comboBox15.SelectedValue.ToString();
            SelectBanking.OXZ[15] =comboBox16.SelectedValue.ToString();
            SelectBanking.OXZ[16] =comboBox17.SelectedValue.ToString();
            SelectBanking.OXZ[17] =comboBox18.SelectedValue.ToString();
            SelectBanking.OXZ[18] =textBox14.Text  ;

            //Характеристика объекта оценки
            SelectBanking.HarkaObjectaOtsenki[2] =comboBox20.SelectedValue.ToString()  ;
            SelectBanking.HarkaObjectaOtsenki[3] =comboBox21.SelectedValue.ToString()  ;
            SelectBanking.HarkaObjectaOtsenki[4] =textBox15.Text  ;
            SelectBanking.HarkaObjectaOtsenki[5] =textBox17.Text  ;
            SelectBanking.HarkaObjectaOtsenki[6] =textBox20.Text  ;
            SelectBanking.HarkaObjectaOtsenki[7] =textBox24.Text  ;
            SelectBanking.HarkaObjectaOtsenki[8] =textBox25.Text  ;
            SelectBanking.HarkaObjectaOtsenki[9] =textBox26.Text  ;
            SelectBanking.HarkaObjectaOtsenki[10] =textBox21.Text  ;
            SelectBanking.HarkaObjectaOtsenki[11] =textBox22.Text ;
            SelectBanking.HarkaObjectaOtsenki[12] =comboBox22.SelectedValue.ToString()  ;
            SelectBanking.HarkaObjectaOtsenki[13] =textBox19.Text  ;
            SelectBanking.HarkaObjectaOtsenki[19] =textBox23.Text ;
            SelectBanking.HarkaObjectaOtsenki[14] =comboBox23.SelectedValue.ToString()  ;
            SelectBanking.HarkaObjectaOtsenki[15] =comboBox24.SelectedValue.ToString()  ;
            SelectBanking.HarkaObjectaOtsenki[16] =comboBox25.SelectedValue.ToString()  ;
            SelectBanking.HarkaObjectaOtsenki[17] =comboBox26.SelectedValue.ToString()  ;
            SelectBanking.HarkaObjectaOtsenki[18] =comboBox27.SelectedValue.ToString()  ;

            //Инженерное обеспечение
            if(rjToggleButton2.Checked)
            { SelectBanking.InjenernoeObesp[1] = "1"; }
            else { SelectBanking.InjenernoeObesp[1] = "0"; }
            if (rjToggleButton3.Checked)
            { SelectBanking.InjenernoeObesp[2] = "1"; }
            else { SelectBanking.InjenernoeObesp[2] = "0"; }
            if (rjToggleButton4.Checked)
            { SelectBanking.InjenernoeObesp[3] = "1"; }
            else { SelectBanking.InjenernoeObesp[3] = "0"; }
            if (rjToggleButton5.Checked)
            { SelectBanking.InjenernoeObesp[4] = "1"; }
            else { SelectBanking.InjenernoeObesp[4] = "0"; }
            if (rjToggleButton6.Checked)
            { SelectBanking.InjenernoeObesp[5] = "1"; }
            else { SelectBanking.InjenernoeObesp[5] = "0"; }
            if (rjToggleButton7.Checked)
            { SelectBanking.InjenernoeObesp[6] = "1"; }
            else { SelectBanking.InjenernoeObesp[6] = "0"; }
            if (rjToggleButton8.Checked)
            { SelectBanking.InjenernoeObesp[7] = "1"; }
            else { SelectBanking.InjenernoeObesp[7] = "0"; }
            if (rjToggleButton9.Checked)
            { SelectBanking.InjenernoeObesp[8] = "1"; }
            else { SelectBanking.InjenernoeObesp[8] = "0"; }
            if (rjToggleButton10.Checked)
            { SelectBanking.InjenernoeObesp[9] = "1"; }
            else { SelectBanking.InjenernoeObesp[9] = "0"; }
            if (rjToggleButton11.Checked)
            { SelectBanking.InjenernoeObesp[10] = "1"; }
            else { SelectBanking.InjenernoeObesp[10] = "0"; }

            //Отделка
            SelectBanking.Otdelka[1]=comboBox28.SelectedValue.ToString()  ;
            SelectBanking.Otdelka[2]=comboBox29.SelectedValue.ToString()  ;
            //Комнаты
            SelectBanking.Komnati[1]=comboBox30.SelectedValue.ToString()  ;
            SelectBanking.Komnati[2]=comboBox37.SelectedValue.ToString()  ;
            SelectBanking.Komnati[3]=comboBox41.SelectedValue.ToString()  ;
            SelectBanking.Komnati[4]=comboBox45.SelectedValue.ToString()  ;
            //Кухня
            SelectBanking.Kuhnya[1]=comboBox31.SelectedValue.ToString()  ;
            SelectBanking.Kuhnya[2]=comboBox34.SelectedValue.ToString()  ;
            SelectBanking.Kuhnya[3]=comboBox38.SelectedValue.ToString()  ;
            SelectBanking.Kuhnya[4]=comboBox42.SelectedValue.ToString()  ;
            //Санузлы
            SelectBanking.Sanuzli[1]=comboBox32.SelectedValue.ToString()  ;
            SelectBanking.Sanuzli[2]=comboBox35.SelectedValue.ToString()  ;
            SelectBanking.Sanuzli[3]=comboBox39.SelectedValue.ToString()  ;
            SelectBanking.Sanuzli[4]=comboBox43.SelectedValue.ToString()  ;
            //Иные
           SelectBanking.Inie[1] =comboBox33.SelectedValue.ToString()  ;
            SelectBanking.Inie[2]=comboBox36.SelectedValue.ToString()  ;
             SelectBanking.Inie[3]=comboBox40.SelectedValue.ToString() ;
            SelectBanking.Inie[4]=comboBox44.SelectedValue.ToString()  ;

            //АПДЕЙТ
            ////Идентификация и характеристика местоположения объекта оценки
            queriesTableAdapter1.ИндентификацияИХаркаМестополженияОбъекта_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.IIXMO[1]), Convert.ToInt32(SelectBanking.IIXMO[2]), Convert.ToInt32(SelectBanking.IIXMO[3]), Convert.ToInt32(SelectBanking.IIXMO[4]), Convert.ToInt32(SelectBanking.IIXMO[5]), Convert.ToInt32(SelectBanking.IIXMO[8]), Convert.ToInt32(SelectBanking.IIXMO[7]), SelectBanking.IIXMO[6], SelectBanking.IIXMO[9], Convert.ToInt32(SelectBanking.IIXMO[0]));

            ////Общая характеристика здания
            queriesTableAdapter1.ОбщаяХаркаЗдания_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.OXZ[1]), Convert.ToInt32(SelectBanking.OXZ[2]), Convert.ToInt32(SelectBanking.OXZ[3]), Convert.ToInt32(SelectBanking.OXZ[4]), Convert.ToInt32(SelectBanking.OXZ[5]), Convert.ToInt32(SelectBanking.OXZ[6]), Convert.ToInt32(SelectBanking.OXZ[7]), Convert.ToInt32(SelectBanking.OXZ[9]), Convert.ToInt32(SelectBanking.OXZ[10]), Convert.ToInt32(SelectBanking.OXZ[11]), Convert.ToInt32(SelectBanking.OXZ[12]), Convert.ToInt32(SelectBanking.OXZ[13]), Convert.ToInt32(SelectBanking.OXZ[14]), Convert.ToInt32(SelectBanking.OXZ[15]), Convert.ToInt32(SelectBanking.OXZ[16]), Convert.ToInt32(SelectBanking.OXZ[17]), SelectBanking.OXZ[8], SelectBanking.OXZ[18], Convert.ToInt32(SelectBanking.OXZ[0]));

            ////Характеристика объекта оценки
            queriesTableAdapter1.ХаркаОбъектаОценки_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[1]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[2]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[3]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[4]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[5]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[6]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[7]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[8]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[9]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[10]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[11]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[12]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[13]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[14]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[15]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[16]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[17]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[18]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[19]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[0]));

            ////Инженерное обеспечение
            queriesTableAdapter1.ИнженерноеОбеспечение_ИЗМЕНИТЬ(SelectBanking.InjenernoeObesp[1], SelectBanking.InjenernoeObesp[2], SelectBanking.InjenernoeObesp[3], SelectBanking.InjenernoeObesp[4], SelectBanking.InjenernoeObesp[5], SelectBanking.InjenernoeObesp[6], SelectBanking.InjenernoeObesp[7], SelectBanking.InjenernoeObesp[8], SelectBanking.InjenernoeObesp[9], SelectBanking.InjenernoeObesp[10], Convert.ToInt32(SelectBanking.InjenernoeObesp[0]));

            ////Отделка
            queriesTableAdapter1.Отделка_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Otdelka[1]), Convert.ToInt32(SelectBanking.Otdelka[2]), Convert.ToInt32(SelectBanking.Otdelka[3]), Convert.ToInt32(SelectBanking.Otdelka[4]), Convert.ToInt32(SelectBanking.Otdelka[5]), Convert.ToInt32(SelectBanking.Otdelka[6]), Convert.ToInt32(SelectBanking.Otdelka[0]));

            ////Комнаты
            queriesTableAdapter1.Комнаты_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Komnati[1]), Convert.ToInt32(SelectBanking.Komnati[2]), Convert.ToInt32(SelectBanking.Komnati[3]), Convert.ToInt32(SelectBanking.Komnati[4]), Convert.ToInt32(SelectBanking.Komnati[0]));

            ////Кухня
            queriesTableAdapter1.Кухня_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Kuhnya[1]), Convert.ToInt32(SelectBanking.Kuhnya[2]), Convert.ToInt32(SelectBanking.Kuhnya[3]), Convert.ToInt32(SelectBanking.Kuhnya[4]), Convert.ToInt32(SelectBanking.Kuhnya[0]));

            ////Санузлы
            queriesTableAdapter1.Санузлы_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Sanuzli[1]), Convert.ToInt32(SelectBanking.Sanuzli[2]), Convert.ToInt32(SelectBanking.Sanuzli[3]), Convert.ToInt32(SelectBanking.Sanuzli[4]), Convert.ToInt32(SelectBanking.Sanuzli[0]));

            ////Иные
            queriesTableAdapter1.Иные_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Inie[1]), Convert.ToInt32(SelectBanking.Inie[2]), Convert.ToInt32(SelectBanking.Inie[3]), Convert.ToInt32(SelectBanking.Inie[4]), Convert.ToInt32(SelectBanking.Inie[0]));


        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

            IWebDriver browser;
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Navigate().GoToUrl(textBox8.Text);
                            int ssize = browser.FindElements(By.XPath("//dd")).Count();
                for (int i = 1; i <= ssize; i++)
                {try
                    {
                        string poisk = browser.FindElement(By.XPath("//dt[" + i.ToString() + "]")).Text;
                    if (poisk.Contains("Адрес") == true)
                    {GKHParse.GKHAddress = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Год постройки") == true)
                    {GKHParse.GKHGodPostroiki = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Количество этажей") == true)
                    {GKHParse.GKHKolVoEtajey = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Тип дома") == true)
                    {GKHParse.GKHTipDoma = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Жилых помещений") == true)
                    {GKHParse.GHJiliePomesheniya = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Серия, тип постройки") == true)
                    {GKHParse.GKHSeriaTipZdaniya = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Тип перекрытий") == true)
                    {GKHParse.GKHTipPerekritiy = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Материал несущих стен") == true)
                    {GKHParse.GKHMaterialNesushSten = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Тип мусоропровода") == true)
                    {GKHParse.GKHTipMusora = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Дом признан аварийным") == true)
                    {GKHParse.GKHAvariya = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Детская площадка") == true)
                    {GKHParse.GKHDetskayaPloshadka = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Спортивная площадка") == true)
                    {GKHParse.GKHSportPloshadka = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Кадастровый номер") == true)
                    {GKHParse.GKHKadastr = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                    else if (poisk.Contains("Управляющая компания") == true)
                    {GKHParse.GKHUprKompaniya = browser.FindElement(By.XPath("//dd[" + i.ToString() + "]")).Text;}
                }catch{}}
            IList<IWebElement> all_elem = browser.FindElements(By.XPath("//td[@class='col-md-6 col-xs-8 word-wrap-force']"));
            String[] allText_elem = new String[all_elem.Count];
            int k = 0;
            foreach (IWebElement element in all_elem)
            {allText_elem[k++] = element.Text;}
            IList<IWebElement> all_text = browser.FindElements(By.XPath("//td[@class='col-md-6 col-xs-4 word-wrap-force']"));
            String[] allText_text = new String[all_text.Count];
            int l = 0;
            foreach (IWebElement element in all_text)
            {allText_text[l++] = element.Text;}
            for (int i = 0; i <= all_elem.Count; i++) //Счётчик
            {try
                {if (allText_elem[i].Contains("Год ввода в эксплуатацию") == true)
                    {GKHParse.GKHGodVvoda = allText_text[i];}
                    else if (allText_elem[i].Contains("Дополнительная информация") == true) //+
                    {GKHParse.GKHDopInfa = allText_text[i];}
                    else if (allText_elem[i].Contains("Класс энергетической эффективности") == true)
                    {GKHParse.GKHEnergoEff = allText_text[i];}
                    else if (allText_elem[i].Contains("Количество подъездов") == true)
                    {GKHParse.GKHPodezdi = allText_text[i];}
                    else if (allText_elem[i].Contains("Наибольшее количество этажей") == true)
                    {GKHParse.GKHEtajiMax = allText_text[i];}
                    else if (allText_elem[i].Contains("Наименьшее количество этажей") == true)
                    {GKHParse.GKHEtajiMin = allText_text[i];}
                    else if (allText_elem[i].Contains("Площадь жилых помещений") == true)
                    {GKHParse.GKHJilayaPloshad = allText_text[i];}
                    //////////////////////////////////////////////////
                    else if (allText_elem[i].Contains("Площадь нежилых помещений") == true)
                    {GKHParse.GKHNeJilayaPloshad = allText_text[i];}
                    else if (allText_elem[i].Contains("Площадь помещений общего имущества") == true)
                    {GKHParse.GKHPloshadPomesh = allText_text[i];}
                    else if (allText_elem[i].Contains("Площадь зем. участка общего имущества") == true)
                    {GKHParse.GKHZemlyaPloshad = allText_text[i];}
                    else if (allText_elem[i].Contains("Площадь парковки") == true)
                    {GKHParse.GKHParkovkaPloshad = allText_text[i];}
                    else if (allText_elem[i].Contains("Формирование фонда кап. ремонта") == true)
                    {GKHParse.GKHFondKapRemonta = allText_text[i];}
                }catch{}}

            browser.Quit();
            label90.Visible = true;
            label91.Visible = true;
            label92.Visible = true;
            label93.Visible = true;
            label94.Visible = true;
            label95.Visible = true;
            label96.Visible = true;
            label97.Visible = true;

            label97.Visible = true;
            label97.Visible = true;
            label97.Visible = true;
            label97.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label27.Visible = true;
            label78.Visible = true;

            label1.Text = GKHParse.GKHMaterialNesushSten;
            textBox9.Text = GKHParse.GKHKolVoEtajey;
            label2.Text = GKHParse.GKHTipPerekritiy;
            textBox10.Text = GKHParse.GKHGodPostroiki;

                label27.Text = "Площадь парковки, м2: ";
                label27.Text += GKHParse.GKHParkovkaPloshad;
            
            label78.Text = GKHParse.GKHDetskayaPloshadka;
            textBox14.Text = GKHParse.GKHDopInfa;
            textBox12.Text = (Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(GKHParse.GKHGodPostroiki)).ToString();


        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;
            if (textBox10.Text != "")
            {
                int a = Convert.ToInt32(DateTime.Now.Year);
                int b = Convert.ToInt32(textBox10.Text);
                int c = a - b;
                textBox12.Text = c.ToString();
            }
        else if (textBox10.Text == "")
            {
                textBox12.Text = "";
            }


        }

        private void textBoxFlag(object sender, EventArgs e)
        {
            SaveFlag = 1;
        }

        private void comboBoxFlag(object sender, EventArgs e)
        {
            SaveFlag = 1;
        }

        private void rjToggleButtonFlag(object sender, EventArgs e)
        {
            SaveFlag = 1;
        }

        private void Logbook_FormClosing(object sender, FormClosingEventArgs e)
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
                    //Идентификация и характеристика местоположения объекта оценки
                    SelectBanking.IIXMO[2] = comboBox1.SelectedValue.ToString();
                    SelectBanking.IIXMO[3] = comboBox2.SelectedValue.ToString();
                    SelectBanking.IIXMO[4] = comboBox3.SelectedValue.ToString();
                    SelectBanking.IIXMO[5] = comboBox4.SelectedValue.ToString();
                    SelectBanking.IIXMO[6] = textBox6.Text;
                    SelectBanking.IIXMO[7] = comboBox5.SelectedValue.ToString();
                    SelectBanking.IIXMO[8] = comboBox6.SelectedValue.ToString();
                    SelectBanking.IIXMO[9] = textBox7.Text;

                    //Общая характеристика здания
                    SelectBanking.OXZ[1] = comboBox7.SelectedValue.ToString();
                    SelectBanking.OXZ[2] = textBox9.Text;
                    SelectBanking.OXZ[3] = comboBox8.SelectedValue.ToString();
                    SelectBanking.OXZ[4] = textBox10.Text;
                    SelectBanking.OXZ[5] = textBox11.Text;
                    SelectBanking.OXZ[6] = textBox12.Text;
                    SelectBanking.OXZ[7] = comboBox9.SelectedValue.ToString();
                    SelectBanking.OXZ[8] = textBox13.Text;
                    SelectBanking.OXZ[9] = comboBox10.SelectedValue.ToString();
                    SelectBanking.OXZ[10] = comboBox11.SelectedValue.ToString();
                    SelectBanking.OXZ[11] = comboBox12.SelectedValue.ToString();
                    SelectBanking.OXZ[12] = comboBox13.SelectedValue.ToString();
                    SelectBanking.OXZ[13] = comboBox14.SelectedValue.ToString();
                    SelectBanking.OXZ[14] = comboBox15.SelectedValue.ToString();
                    SelectBanking.OXZ[15] = comboBox16.SelectedValue.ToString();
                    SelectBanking.OXZ[16] = comboBox17.SelectedValue.ToString();
                    SelectBanking.OXZ[17] = comboBox18.SelectedValue.ToString();
                    SelectBanking.OXZ[18] = textBox14.Text;

                    //Характеристика объекта оценки
                    SelectBanking.HarkaObjectaOtsenki[2] = comboBox20.SelectedValue.ToString();
                    SelectBanking.HarkaObjectaOtsenki[3] = comboBox21.SelectedValue.ToString();
                    SelectBanking.HarkaObjectaOtsenki[4] = textBox15.Text;
                    SelectBanking.HarkaObjectaOtsenki[5] = textBox17.Text;
                    SelectBanking.HarkaObjectaOtsenki[6] = textBox20.Text;
                    SelectBanking.HarkaObjectaOtsenki[7] = textBox24.Text;
                    SelectBanking.HarkaObjectaOtsenki[8] = textBox25.Text;
                    SelectBanking.HarkaObjectaOtsenki[9] = textBox26.Text;
                    SelectBanking.HarkaObjectaOtsenki[10] = textBox21.Text;
                    SelectBanking.HarkaObjectaOtsenki[11] = textBox22.Text;
                    SelectBanking.HarkaObjectaOtsenki[12] = comboBox22.SelectedValue.ToString();
                    SelectBanking.HarkaObjectaOtsenki[13] = textBox19.Text;
                    SelectBanking.HarkaObjectaOtsenki[19] = textBox23.Text;
                    SelectBanking.HarkaObjectaOtsenki[14] = comboBox23.SelectedValue.ToString();
                    SelectBanking.HarkaObjectaOtsenki[15] = comboBox24.SelectedValue.ToString();
                    SelectBanking.HarkaObjectaOtsenki[16] = comboBox25.SelectedValue.ToString();
                    SelectBanking.HarkaObjectaOtsenki[17] = comboBox26.SelectedValue.ToString();
                    SelectBanking.HarkaObjectaOtsenki[18] = comboBox27.SelectedValue.ToString();

                    //Инженерное обеспечение
                    if (rjToggleButton2.Checked)
                    { SelectBanking.InjenernoeObesp[1] = "1"; }
                    else { SelectBanking.InjenernoeObesp[1] = "0"; }
                    if (rjToggleButton3.Checked)
                    { SelectBanking.InjenernoeObesp[2] = "1"; }
                    else { SelectBanking.InjenernoeObesp[2] = "0"; }
                    if (rjToggleButton4.Checked)
                    { SelectBanking.InjenernoeObesp[3] = "1"; }
                    else { SelectBanking.InjenernoeObesp[3] = "0"; }
                    if (rjToggleButton5.Checked)
                    { SelectBanking.InjenernoeObesp[4] = "1"; }
                    else { SelectBanking.InjenernoeObesp[4] = "0"; }
                    if (rjToggleButton6.Checked)
                    { SelectBanking.InjenernoeObesp[5] = "1"; }
                    else { SelectBanking.InjenernoeObesp[5] = "0"; }
                    if (rjToggleButton7.Checked)
                    { SelectBanking.InjenernoeObesp[6] = "1"; }
                    else { SelectBanking.InjenernoeObesp[6] = "0"; }
                    if (rjToggleButton8.Checked)
                    { SelectBanking.InjenernoeObesp[7] = "1"; }
                    else { SelectBanking.InjenernoeObesp[7] = "0"; }
                    if (rjToggleButton9.Checked)
                    { SelectBanking.InjenernoeObesp[8] = "1"; }
                    else { SelectBanking.InjenernoeObesp[8] = "0"; }
                    if (rjToggleButton10.Checked)
                    { SelectBanking.InjenernoeObesp[9] = "1"; }
                    else { SelectBanking.InjenernoeObesp[9] = "0"; }
                    if (rjToggleButton11.Checked)
                    { SelectBanking.InjenernoeObesp[10] = "1"; }
                    else { SelectBanking.InjenernoeObesp[10] = "0"; }

                    //Отделка
                    SelectBanking.Otdelka[1] = comboBox28.SelectedValue.ToString();
                    SelectBanking.Otdelka[2] = comboBox29.SelectedValue.ToString();
                    //Комнаты
                    SelectBanking.Komnati[1] = comboBox30.SelectedValue.ToString();
                    SelectBanking.Komnati[2] = comboBox37.SelectedValue.ToString();
                    SelectBanking.Komnati[3] = comboBox41.SelectedValue.ToString();
                    SelectBanking.Komnati[4] = comboBox45.SelectedValue.ToString();
                    //Кухня
                    SelectBanking.Kuhnya[1] = comboBox31.SelectedValue.ToString();
                    SelectBanking.Kuhnya[2] = comboBox34.SelectedValue.ToString();
                    SelectBanking.Kuhnya[3] = comboBox38.SelectedValue.ToString();
                    SelectBanking.Kuhnya[4] = comboBox42.SelectedValue.ToString();
                    //Санузлы
                    SelectBanking.Sanuzli[1] = comboBox32.SelectedValue.ToString();
                    SelectBanking.Sanuzli[2] = comboBox35.SelectedValue.ToString();
                    SelectBanking.Sanuzli[3] = comboBox39.SelectedValue.ToString();
                    SelectBanking.Sanuzli[4] = comboBox43.SelectedValue.ToString();
                    //Иные
                    SelectBanking.Inie[1] = comboBox33.SelectedValue.ToString();
                    SelectBanking.Inie[2] = comboBox36.SelectedValue.ToString();
                    SelectBanking.Inie[3] = comboBox40.SelectedValue.ToString();
                    SelectBanking.Inie[4] = comboBox44.SelectedValue.ToString();

                    //ЭКСПЕТНАЯ ОЦЕНКА
                    SelectBanking.EOTS[1] = comboBox19.SelectedValue.ToString();
                    SelectBanking.EOTS[2] = comboBox46.SelectedValue.ToString();
                    SelectBanking.EOTS[3] = comboBox47.SelectedValue.ToString();
                    SelectBanking.EOTS[4] = comboBox48.SelectedValue.ToString();
                    SelectBanking.EOTS[5] = comboBox49.SelectedValue.ToString();
                    SelectBanking.EOTS[6] = comboBox50.SelectedValue.ToString();
                    SelectBanking.EOTS[7] = comboBox51.SelectedValue.ToString();
                    SelectBanking.EOTS[8] = comboBox52.SelectedValue.ToString();
                    SelectBanking.EOTS[9] = comboBox60.SelectedValue.ToString();
                    SelectBanking.EOTS[10] = comboBox53.SelectedValue.ToString();
                    SelectBanking.EOTS[11] = comboBox54.SelectedValue.ToString();
                    SelectBanking.EOTS[12] = comboBox55.SelectedValue.ToString();
                    SelectBanking.EOTS[13] = comboBox56.SelectedValue.ToString();
                    SelectBanking.EOTS[14] = comboBox57.SelectedValue.ToString();
                    SelectBanking.EOTS[15] = comboBox58.SelectedValue.ToString();
                    SelectBanking.EOTS[16] = comboBox59.SelectedValue.ToString();
                    SelectBanking.EOTS[17] = textBox1.Text;
                    //АПДЕЙТ
                    ////Идентификация и характеристика местоположения объекта оценки
                    ///                    
                    try
                    {
                        queriesTableAdapter1.ИндентификацияИХаркаМестополженияОбъекта_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.IIXMO[1]), Convert.ToInt32(SelectBanking.IIXMO[2]), Convert.ToInt32(SelectBanking.IIXMO[3]), Convert.ToInt32(SelectBanking.IIXMO[4]), Convert.ToInt32(SelectBanking.IIXMO[5]), Convert.ToInt32(SelectBanking.IIXMO[8]), Convert.ToInt32(SelectBanking.IIXMO[7]), SelectBanking.IIXMO[6], SelectBanking.IIXMO[9], Convert.ToInt32(SelectBanking.IIXMO[0]));
                }
                    catch { }
                try
                {
                    ////Общая характеристика здания
                    queriesTableAdapter1.ОбщаяХаркаЗдания_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.OXZ[1]), Convert.ToInt32(SelectBanking.OXZ[2]), Convert.ToInt32(SelectBanking.OXZ[3]), Convert.ToInt32(SelectBanking.OXZ[4]), Convert.ToInt32(SelectBanking.OXZ[5]), Convert.ToInt32(SelectBanking.OXZ[6]), Convert.ToInt32(SelectBanking.OXZ[7]), Convert.ToInt32(SelectBanking.OXZ[9]), Convert.ToInt32(SelectBanking.OXZ[10]), Convert.ToInt32(SelectBanking.OXZ[11]), Convert.ToInt32(SelectBanking.OXZ[12]), Convert.ToInt32(SelectBanking.OXZ[13]), Convert.ToInt32(SelectBanking.OXZ[14]), Convert.ToInt32(SelectBanking.OXZ[15]), Convert.ToInt32(SelectBanking.OXZ[16]), Convert.ToInt32(SelectBanking.OXZ[17]), SelectBanking.OXZ[8], SelectBanking.OXZ[18], Convert.ToInt32(SelectBanking.OXZ[0]));
                }
                    catch { }
                try
                {
                    ////Характеристика объекта оценки
                    queriesTableAdapter1.ХаркаОбъектаОценки_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[1]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[2]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[3]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[4]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[5]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[6]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[7]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[8]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[9]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[10]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[11]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[12]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[13]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[14]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[15]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[16]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[17]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[18]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[19]), Convert.ToInt32(SelectBanking.HarkaObjectaOtsenki[0]));
                }
                    catch { }
                try
                {
                    ////Инженерное обеспечение
                    queriesTableAdapter1.ИнженерноеОбеспечение_ИЗМЕНИТЬ(SelectBanking.InjenernoeObesp[1], SelectBanking.InjenernoeObesp[2], SelectBanking.InjenernoeObesp[3], SelectBanking.InjenernoeObesp[4], SelectBanking.InjenernoeObesp[5], SelectBanking.InjenernoeObesp[6], SelectBanking.InjenernoeObesp[7], SelectBanking.InjenernoeObesp[8], SelectBanking.InjenernoeObesp[9], SelectBanking.InjenernoeObesp[10], Convert.ToInt32(SelectBanking.InjenernoeObesp[0]));
                }
                    catch { }
                try
                {
                    ////Отделка
                    queriesTableAdapter1.Отделка_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Otdelka[1]), Convert.ToInt32(SelectBanking.Otdelka[2]), Convert.ToInt32(SelectBanking.Otdelka[3]), Convert.ToInt32(SelectBanking.Otdelka[4]), Convert.ToInt32(SelectBanking.Otdelka[5]), Convert.ToInt32(SelectBanking.Otdelka[6]), Convert.ToInt32(SelectBanking.Otdelka[0]));
                }
                    catch { }
                try
                {
                    ////Комнаты
                    queriesTableAdapter1.Комнаты_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Komnati[1]), Convert.ToInt32(SelectBanking.Komnati[2]), Convert.ToInt32(SelectBanking.Komnati[3]), Convert.ToInt32(SelectBanking.Komnati[4]), Convert.ToInt32(SelectBanking.Komnati[0]));
                }
                    catch { }
                try
                {
                    ////Кухня
                    queriesTableAdapter1.Кухня_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Kuhnya[1]), Convert.ToInt32(SelectBanking.Kuhnya[2]), Convert.ToInt32(SelectBanking.Kuhnya[3]), Convert.ToInt32(SelectBanking.Kuhnya[4]), Convert.ToInt32(SelectBanking.Kuhnya[0]));
                }
                    catch { }
                try
                {
                    ////Санузлы
                    queriesTableAdapter1.Санузлы_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Sanuzli[1]), Convert.ToInt32(SelectBanking.Sanuzli[2]), Convert.ToInt32(SelectBanking.Sanuzli[3]), Convert.ToInt32(SelectBanking.Sanuzli[4]), Convert.ToInt32(SelectBanking.Sanuzli[0]));
                }
                    catch { }
                try
                {
                    ////Иные
                    queriesTableAdapter1.Иные_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Inie[1]), Convert.ToInt32(SelectBanking.Inie[2]), Convert.ToInt32(SelectBanking.Inie[3]), Convert.ToInt32(SelectBanking.Inie[4]), Convert.ToInt32(SelectBanking.Inie[0]));
                }
                    catch { }
                try
                {
                    ////ЭКСПЕРТАНЯ ОЦЕНКА
                    queriesTableAdapter1.ЭкспертнаяОценкаТехСостояния_ИЗМЕНИТЬ(SelectBanking.EOTS[1], SelectBanking.EOTS[2], SelectBanking.EOTS[3], SelectBanking.EOTS[4], SelectBanking.EOTS[5], SelectBanking.EOTS[6], SelectBanking.EOTS[7], SelectBanking.EOTS[8], SelectBanking.EOTS[9], SelectBanking.EOTS[10], SelectBanking.EOTS[11], SelectBanking.EOTS[12], SelectBanking.EOTS[13], SelectBanking.EOTS[14], SelectBanking.EOTS[15], SelectBanking.EOTS[16], SelectBanking.EOTS[17], Convert.ToInt32(SelectBanking.EOTS[0]));
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

