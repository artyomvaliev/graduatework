using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graduatework.Forms
{
    public partial class EvaluationTask : Form
    {
        public EvaluationTask()
        {
            InitializeComponent();
        }
        public int SaveFlag;
        private void EvaluationTask_Load(object sender, EventArgs e)
        {
            label41.Text = "";
            label42.Text = "";
            label43.Text = "";
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПВидСтоимости". При необходимости она может быть перемещена или удалена.
            this.пВидСтоимостиTableAdapter.Fill(this.graduatedbDataSet.ПВидСтоимости);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПФизЮрЛицо". При необходимости она может быть перемещена или удалена.
            this.пФизЮрЛицоTableAdapter.Fill(this.graduatedbDataSet.ПФизЮрЛицо);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПХарактерОбременений". При необходимости она может быть перемещена или удалена.
            this.пХарактерОбремененийTableAdapter.Fill(this.graduatedbDataSet.ПХарактерОбременений);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПНаличиеОбременений". При необходимости она может быть перемещена или удалена.
            this.пНаличиеОбремененийTableAdapter.Fill(this.graduatedbDataSet.ПНаличиеОбременений);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПТекущиеИмущественныеПраваНаОбъектОценки". При необходимости она может быть перемещена или удалена.
            this.пТекущиеИмущественныеПраваНаОбъектОценкиTableAdapter.Fill(this.graduatedbDataSet.ПТекущиеИмущественныеПраваНаОбъектОценки);
            if (SelectBanking.EGRN[1] == "2")
            {
                rjToggleButton1.Checked = true;
                textBox3.Text = Eramake.eCryptography.Decrypt(SelectBanking.EGRN[2]);
                label41.Text = Path.GetFileName(SelectBanking.EGRN[3]);
                textBox3.Visible = true; rjButton1.Visible = true; label41.Visible = true;
            }
            else
            {
                textBox3.Visible = false; rjButton1.Visible = false; label41.Visible = false;
            }
        
            if (SelectBanking.TehPasport[1] == "2")
            {
                rjToggleButton2.Checked = true;
                textBox44.Text = Eramake.eCryptography.Decrypt(SelectBanking.TehPasport[2]);
                label42.Text = Path.GetFileName(SelectBanking.TehPasport[3]);
                textBox44.Visible = true; rjButton2.Visible = true; label42.Visible = true;
            }
            else
            {
                textBox3.Visible = false; rjButton2.Visible = false; label42.Visible = false;
            }
            if (SelectBanking.Pasport[1] == "2")
            {
                rjToggleButton3.Checked = true;
                textBox45.Text = Eramake.eCryptography.Decrypt(SelectBanking.Pasport[2]);
                label43.Text = Path.GetFileName(SelectBanking.Pasport[3]);
                textBox45.Visible = true; rjButton3.Visible = true; label43.Visible = true;
            }
            else
            {
                textBox3.Visible = false; rjButton3.Visible = false; label41.Visible = false;
            }
            //ЗАДАНИЕ НА ОЦЕНКУ
            //Текущие имущественные права на объект оценки
            comboBox1.SelectedValue = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[14]);
            //Наличие обременений
            comboBox2.SelectedValue = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[3]);
            //Характер обременений
            comboBox3.SelectedValue = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[4]);
            //Цель оценки
            textBox1.Text = SelectBanking.ZadanieNaOtcenku[9];
            //Предполагаемое использование результатов оценки и связанные с этим ограничения
            textBox2.Text = SelectBanking.ZadanieNaOtcenku[10];
            //Вид стоимости
            comboBox12.SelectedValue = SelectBanking.ZadanieNaOtcenku[15];
            //Дата осмотра
            dateTimePicker1.Value = Convert.ToDateTime(SelectBanking.ZadanieNaOtcenku[11]);
            //Дата оценки
            dateTimePicker2.Value = Convert.ToDateTime(SelectBanking.ZadanieNaOtcenku[12]);
            //Дата составления отчета
            dateTimePicker3.Value = Convert.ToDateTime(SelectBanking.ZadanieNaOtcenku[13]);

            //ПРАВООБЛАДАТЕЛЬ
            //Количество собственников
            comboBox4.Text = SelectBanking.ZadanieNaOtcenku[5];
            //Физическое / юридическое лицо
            comboBox5.SelectedValue = Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[6]);

            //ПРАВООБЛАДАТЕЛЬ1
            //Ф
            textBox4.Text = SelectBanking.Provoobledatel1[1];
            //И
            textBox5.Text = SelectBanking.Provoobledatel1[2];
            //О
            textBox6.Text = SelectBanking.Provoobledatel1[3];
            //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            textBox7.Text = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel1[5]);
            //АДРЕС РЕГИСТРАЦИИ
            textBox8.Text = SelectBanking.Provoobledatel1[4];
            //ДОЛЯ В ПРАВЕ
            textBox9.Text = SelectBanking.Provoobledatel1[6];

            //ПРАВООБЛАДАТЕЛЬ2
            //Ф
            textBox10.Text = SelectBanking.Provoobledatel2[1];
            //И
            textBox11.Text = SelectBanking.Provoobledatel2[2];
            //О
            textBox12.Text = SelectBanking.Provoobledatel2[3];
            //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            textBox13.Text = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel2[5]);
            //АДРЕС РЕГИСТРАЦИИ
            textBox14.Text = SelectBanking.Provoobledatel2[4];
            //ДОЛЯ В ПРАВЕ
            textBox15.Text = SelectBanking.Provoobledatel2[6];

            //ПРАВООБЛАДАТЕЛЬ3
            //Ф
            textBox16.Text = SelectBanking.Provoobledatel3[1];
            //И
            textBox17.Text = SelectBanking.Provoobledatel3[2];
            //О
            textBox18.Text = SelectBanking.Provoobledatel3[3];
            //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            textBox19.Text = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel3[5]);
            //АДРЕС РЕГИСТРАЦИИ
            textBox24.Text = SelectBanking.Provoobledatel3[4];
            //ДОЛЯ В ПРАВЕ
            textBox25.Text = SelectBanking.Provoobledatel3[6];

            //ПРАВООБЛАДАТЕЛЬ4
            //Ф
            textBox26.Text = SelectBanking.Provoobledatel4[1];
            //И
            textBox27.Text = SelectBanking.Provoobledatel4[2];
            //О
            textBox28.Text = SelectBanking.Provoobledatel4[3];
            //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            textBox29.Text = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel4[5]);
            //АДРЕС РЕГИСТРАЦИИ
            textBox30.Text = SelectBanking.Provoobledatel4[4];
            //ДОЛЯ В ПРАВЕ
            textBox31.Text = SelectBanking.Provoobledatel4[6];

            //ПРАВООБЛАДАТЕЛЬ5
            //Ф
            textBox32.Text = SelectBanking.Provoobledatel5[1];
            //И
            textBox33.Text = SelectBanking.Provoobledatel5[2];
            //О
            textBox34.Text = SelectBanking.Provoobledatel5[3];
            //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            textBox35.Text = Eramake.eCryptography.Decrypt(SelectBanking.Provoobledatel5[5]);
            //АДРЕС РЕГИСТРАЦИИ
            textBox36.Text = SelectBanking.Provoobledatel5[4];
            //ДОЛЯ В ПРАВЕ
            textBox37.Text = SelectBanking.Provoobledatel5[6];

            //ЗАКАЗЧИК
            //Физическое лицо
            textBox20.Text = SelectBanking.PhysZakaz[1];
            textBox21.Text = SelectBanking.PhysZakaz[2];
            textBox22.Text = SelectBanking.PhysZakaz[3];
            textBox23.Text = Eramake.eCryptography.Decrypt(SelectBanking.PhysZakaz[4]);
            textBox38.Text = Eramake.eCryptography.Decrypt(SelectBanking.PhysZakaz[7]);
            textBox39.Text = SelectBanking.PhysZakaz[5];
            textBox40.Text = SelectBanking.PhysZakaz[6];

            //Юридическое лицо
            textBox41.Text = SelectBanking.UrZakaz[1];
            textBox42.Text = SelectBanking.UrZakaz[2];
            dateTimePicker4.Value = Convert.ToDateTime(SelectBanking.UrZakaz[3]);
            textBox43.Text = SelectBanking.UrZakaz[4];
            if (textBox20.Text == "" && textBox41.Text == "")
            {
                label37.Enabled = false;
                label37.Visible = false;
                label38.Enabled = false;
                label38.Visible = false;
                label39.Enabled = false;
                label39.Visible = false;
                label40.Enabled = false;
                label40.Visible = false;
                label60.Enabled = false;
                label60.Visible = false;
                label18.Enabled = false;
                label18.Visible = false;
                label23.Enabled = false;
                label23.Visible = false;
                textBox20.Enabled = false;
                textBox20.Visible = false;
                textBox21.Enabled = false;
                textBox21.Visible = false;
                textBox22.Enabled = false;
                textBox22.Visible = false;
                textBox23.Enabled = false;
                textBox23.Visible = false;
                textBox38.Enabled = false;
                textBox38.Visible = false;
                textBox39.Enabled = false;
                textBox39.Visible = false;
                textBox40.Enabled = false;
                textBox40.Visible = false;
                label28.Enabled = false;
                label28.Visible = false;
                label33.Enabled = false;
                label33.Visible = false;
                label57.Enabled = false;
                label57.Visible = false;
                label61.Enabled = false;
                label61.Visible = false;
                textBox41.Enabled = false;
                textBox41.Visible = false;
                textBox42.Enabled = false;
                textBox42.Visible = false;
                dateTimePicker4.Enabled = false;
                dateTimePicker4.Visible = false;
                textBox43.Enabled = false;
                textBox43.Visible = false;
            }
            if ((textBox20.Text != "" ||
            textBox21.Text != "" ||
            textBox22.Text != "" ||
            textBox23.Text != "" ||
            textBox38.Text != "" ||
            textBox39.Text != "" ||
            textBox40.Text != "") && (textBox41.Text == "" &&
            textBox42.Text == "" && textBox43.Text == ""))
            {
                comboBox6.Text = "Физическое лицо";
            }
            else if ((textBox20.Text == "" &&
            textBox21.Text == "" &&
            textBox22.Text == "" &&
            textBox23.Text == "" &&
            textBox38.Text == "" &&
            textBox39.Text == "" &&
            textBox40.Text == "") && (textBox41.Text != "" ||
            textBox42.Text != "" || textBox43.Text != ""))
            {
                comboBox6.Text = "Юридическое лицо";
            }
            if (comboBox6.Text == "Физическое лицо")
            {
                label37.Enabled = true;
                label37.Visible = true;
                label38.Enabled = true;
                label38.Visible = true;
                label39.Enabled = true;
                label39.Visible = true;
                label40.Enabled = true;
                label40.Visible = true;
                label60.Enabled = true;
                label60.Visible = true;
                label18.Enabled = true;
                label18.Visible = true;
                label23.Enabled = true;
                label23.Visible = true;
                textBox20.Enabled = true;
                textBox20.Visible = true;
                textBox21.Enabled = true;
                textBox21.Visible = true;
                textBox22.Enabled = true;
                textBox22.Visible = true;
                textBox23.Enabled = true;
                textBox23.Visible = true;
                textBox38.Enabled = true;
                textBox38.Visible = true;
                textBox39.Enabled = true;
                textBox39.Visible = true;
                textBox40.Enabled = true;
                textBox40.Visible = true;

                label28.Enabled = false;
                label28.Visible = false;
                label33.Enabled = false;
                label33.Visible = false;
                label57.Enabled = false;
                label57.Visible = false;
                label61.Enabled = false;
                label61.Visible = false;
                textBox41.Enabled = false;
                textBox41.Visible = false;
                textBox42.Enabled = false;
                textBox42.Visible = false;
                dateTimePicker4.Enabled = false;
                dateTimePicker4.Visible = false;
                textBox43.Enabled = false;
                textBox43.Visible = false;
            }
            else if (comboBox6.Text == "Юридическое лицо")
            {
                label37.Enabled = false;
                label37.Visible = false;
                label38.Enabled = false;
                label38.Visible = false;
                label39.Enabled = false;
                label39.Visible = false;
                label40.Enabled = false;
                label40.Visible = false;
                label60.Enabled = false;
                label60.Visible = false;
                label18.Enabled = false;
                label18.Visible = false;
                label23.Enabled = false;
                label23.Visible = false;
                textBox20.Enabled = false;
                textBox20.Visible = false;
                textBox21.Enabled = false;
                textBox21.Visible = false;
                textBox22.Enabled = false;
                textBox22.Visible = false;
                textBox23.Enabled = false;
                textBox23.Visible = false;
                textBox38.Enabled = false;
                textBox38.Visible = false;
                textBox39.Enabled = false;
                textBox39.Visible = false;
                textBox40.Enabled = false;
                textBox40.Visible = false;

                label28.Enabled = true;
                label28.Visible = true;
                label33.Enabled = true;
                label33.Visible = true;
                label57.Enabled = true;
                label57.Visible = true;
                label61.Enabled = true;
                label61.Visible = true;
                textBox41.Enabled = true;
                textBox41.Visible = true;
                textBox42.Enabled = true;
                textBox42.Visible = true;
                dateTimePicker4.Enabled = true;
                dateTimePicker4.Visible = true;
                textBox43.Enabled = true;
                textBox43.Visible = true;
            }
            SaveFlag = 0;
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked)
            { SelectBanking.EGRN[1] = "1"; }
            else { SelectBanking.EGRN[1] = "0"; }
            if (rjToggleButton2.Checked)
            { SelectBanking.TehPasport[1] = "1"; }
            else { SelectBanking.TehPasport[1] = "0"; }
            if (rjToggleButton3.Checked)
            { SelectBanking.Pasport[1] = "1"; }
            else { SelectBanking.Pasport[1] = "0"; }
            //ЗАДАНИЕ НА ОЦЕНКУ
            //Текущие имущественные права на объект оценки
            SelectBanking.ZadanieNaOtcenku[14] = comboBox1.SelectedValue.ToString();
            //Наличие обременений
            SelectBanking.ZadanieNaOtcenku[3] = comboBox2.SelectedValue.ToString();
            //Характер обременений
            SelectBanking.ZadanieNaOtcenku[4] = comboBox3.SelectedValue.ToString();
            //Цель оценки
            SelectBanking.ZadanieNaOtcenku[9] = textBox1.Text;
            //Предполагаемое использование результатов оценки и связанные с этим ограничения
            //textBox2.Text = SelectBanking.ZadanieNaOtcenku[4];
            //Вид стоимости
            SelectBanking.ZadanieNaOtcenku[15] = comboBox12.SelectedValue.ToString();
            //Дата осмотра
            SelectBanking.ZadanieNaOtcenku[11] = dateTimePicker1.Value.ToString();
            //Дата оценки
            SelectBanking.ZadanieNaOtcenku[12] = dateTimePicker2.Value.ToString();
            //Дата составления отчета
            SelectBanking.ZadanieNaOtcenku[13] = dateTimePicker3.Value.ToString();



            //ПРАВООБЛАДАТЕЛЬ
            //Количество собственников
            SelectBanking.ZadanieNaOtcenku[5] = comboBox4.Text.ToString();
            //Физическое / юридическое лицо
            SelectBanking.ZadanieNaOtcenku[6] = comboBox5.SelectedValue.ToString();

            if (comboBox4.Text == "1")
            {
                //ПРАВООБЛАДАТЕЛЬ1
                //Ф
                SelectBanking.Provoobledatel1[1] = textBox4.Text;
                //И
                SelectBanking.Provoobledatel1[2] = textBox5.Text;
                //О
                SelectBanking.Provoobledatel1[3] = textBox6.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel1[5] = Eramake.eCryptography.Encrypt(textBox7.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel1[4] = textBox8.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel1[6] = textBox9.Text;

                //ПРАВООБЛАДАТЕЛЬ2
                //Ф
                SelectBanking.Provoobledatel2[1] = "";
                //И
                SelectBanking.Provoobledatel2[2] = "";
                //О
                SelectBanking.Provoobledatel2[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel2[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel2[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel2[6] = "";

                //ПРАВООБЛАДАТЕЛЬ3
                //Ф
                SelectBanking.Provoobledatel3[1] = "";
                //И
                SelectBanking.Provoobledatel3[2] = "";
                //О
                SelectBanking.Provoobledatel3[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel3[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel3[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel3[6] = "";

                //ПРАВООБЛАДАТЕЛЬ4
                //Ф
                SelectBanking.Provoobledatel4[1] = "";
                //И
                SelectBanking.Provoobledatel4[2] = "";
                //О
                SelectBanking.Provoobledatel4[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel4[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel4[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel4[6] = "";

                //ПРАВООБЛАДАТЕЛЬ5
                //Ф
                SelectBanking.Provoobledatel5[1] = "";
                //И
                SelectBanking.Provoobledatel5[2] = "";
                //О
                SelectBanking.Provoobledatel5[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel5[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel5[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel5[6] = "";
            }
            else if (comboBox4.Text == "2")
            {  //ПРАВООБЛАДАТЕЛЬ1
               //Ф
                SelectBanking.Provoobledatel1[1] = textBox4.Text;
                //И
                SelectBanking.Provoobledatel1[2] = textBox5.Text;
                //О
                SelectBanking.Provoobledatel1[3] = textBox6.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel1[5] = Eramake.eCryptography.Encrypt(textBox7.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel1[4] = textBox8.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel1[6] = textBox9.Text;

                //ПРАВООБЛАДАТЕЛЬ2
                //Ф
                SelectBanking.Provoobledatel2[1] = textBox10.Text;
                //И
                SelectBanking.Provoobledatel2[2] = textBox11.Text;
                //О
                SelectBanking.Provoobledatel2[3] = textBox12.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel2[5] = Eramake.eCryptography.Encrypt(textBox13.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel2[4] = textBox14.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel2[6] = textBox15.Text;

                //ПРАВООБЛАДАТЕЛЬ3
                //Ф
                SelectBanking.Provoobledatel3[1] = "";
                //И
                SelectBanking.Provoobledatel3[2] = "";
                //О
                SelectBanking.Provoobledatel3[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel3[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel3[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel3[6] = "";

                //ПРАВООБЛАДАТЕЛЬ4
                //Ф
                SelectBanking.Provoobledatel4[1] = "";
                //И
                SelectBanking.Provoobledatel4[2] = "";
                //О
                SelectBanking.Provoobledatel4[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel4[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel4[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel4[6] = "";

                //ПРАВООБЛАДАТЕЛЬ5
                //Ф
                SelectBanking.Provoobledatel5[1] = "";
                //И
                SelectBanking.Provoobledatel5[2] = "";
                //О
                SelectBanking.Provoobledatel5[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel5[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel5[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel5[6] = "";
            }
            else if (comboBox4.Text == "3")
            {  //ПРАВООБЛАДАТЕЛЬ1
               //Ф
                SelectBanking.Provoobledatel1[1] = textBox4.Text;
                //И
                SelectBanking.Provoobledatel1[2] = textBox5.Text;
                //О
                SelectBanking.Provoobledatel1[3] = textBox6.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel1[5] = Eramake.eCryptography.Encrypt(textBox7.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel1[4] = textBox8.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel1[6] = textBox9.Text;

                //ПРАВООБЛАДАТЕЛЬ2
                //Ф
                SelectBanking.Provoobledatel2[1] = textBox10.Text;
                //И
                SelectBanking.Provoobledatel2[2] = textBox11.Text;
                //О
                SelectBanking.Provoobledatel2[3] = textBox12.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel2[5] = Eramake.eCryptography.Encrypt(textBox13.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel2[4] = textBox14.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel2[6] = textBox15.Text;

                //ПРАВООБЛАДАТЕЛЬ3
                //Ф
                SelectBanking.Provoobledatel3[1] = textBox16.Text;
                //И
                SelectBanking.Provoobledatel3[2] = textBox17.Text;
                //О
                SelectBanking.Provoobledatel3[3] = textBox18.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel3[5] = Eramake.eCryptography.Encrypt(textBox19.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel3[4] = textBox24.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel3[6] = textBox25.Text;

                //ПРАВООБЛАДАТЕЛЬ4
                //Ф
                SelectBanking.Provoobledatel4[1] = "";
                //И
                SelectBanking.Provoobledatel4[2] = "";
                //О
                SelectBanking.Provoobledatel4[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel4[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel4[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel4[6] = "";

                //ПРАВООБЛАДАТЕЛЬ5
                //Ф
                SelectBanking.Provoobledatel5[1] = "";
                //И
                SelectBanking.Provoobledatel5[2] = "";
                //О
                SelectBanking.Provoobledatel5[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel5[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel5[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel5[6] = "";
            }
            else if (comboBox4.Text == "4")
            {  //ПРАВООБЛАДАТЕЛЬ1
               //Ф
                SelectBanking.Provoobledatel1[1] = textBox4.Text;
                //И
                SelectBanking.Provoobledatel1[2] = textBox5.Text;
                //О
                SelectBanking.Provoobledatel1[3] = textBox6.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel1[5] = Eramake.eCryptography.Encrypt(textBox7.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel1[4] = textBox8.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel1[6] = textBox9.Text;

                //ПРАВООБЛАДАТЕЛЬ2
                //Ф
                SelectBanking.Provoobledatel2[1] = textBox10.Text;
                //И
                SelectBanking.Provoobledatel2[2] = textBox11.Text;
                //О
                SelectBanking.Provoobledatel2[3] = textBox12.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel2[5] = Eramake.eCryptography.Encrypt(textBox13.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel2[4] = textBox14.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel2[6] = textBox15.Text;

                //ПРАВООБЛАДАТЕЛЬ3
                //Ф
                SelectBanking.Provoobledatel3[1] = textBox16.Text;
                //И
                SelectBanking.Provoobledatel3[2] = textBox17.Text;
                //О
                SelectBanking.Provoobledatel3[3] = textBox18.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel3[5] = Eramake.eCryptography.Encrypt(textBox19.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel3[4] = textBox24.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel3[6] = textBox25.Text;

                //ПРАВООБЛАДАТЕЛЬ4
                //Ф
                SelectBanking.Provoobledatel4[1] = textBox26.Text;
                //И
                SelectBanking.Provoobledatel4[2] = textBox27.Text;
                //О
                SelectBanking.Provoobledatel4[3] = textBox28.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel4[5] = Eramake.eCryptography.Encrypt(textBox29.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel4[4] = textBox30.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel4[6] = textBox31.Text;

                //ПРАВООБЛАДАТЕЛЬ5
                //Ф
                SelectBanking.Provoobledatel5[1] = "";
                //И
                SelectBanking.Provoobledatel5[2] = "";
                //О
                SelectBanking.Provoobledatel5[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel5[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel5[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel5[6] = "";
            }
            else if (comboBox4.Text == "5")
            {  //ПРАВООБЛАДАТЕЛЬ1
               //Ф
                SelectBanking.Provoobledatel1[1] = textBox4.Text;
                //И
                SelectBanking.Provoobledatel1[2] = textBox5.Text;
                //О
                SelectBanking.Provoobledatel1[3] = textBox6.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel1[5] = Eramake.eCryptography.Encrypt(textBox7.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel1[4] = textBox8.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel1[6] = textBox9.Text;

                //ПРАВООБЛАДАТЕЛЬ2
                //Ф
                SelectBanking.Provoobledatel2[1] = textBox10.Text;
                //И
                SelectBanking.Provoobledatel2[2] = textBox11.Text;
                //О
                SelectBanking.Provoobledatel2[3] = textBox12.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel2[5] = Eramake.eCryptography.Encrypt(textBox13.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel2[4] = textBox14.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel2[6] = textBox15.Text;

                //ПРАВООБЛАДАТЕЛЬ3
                //Ф
                SelectBanking.Provoobledatel3[1] = textBox16.Text;
                //И
                SelectBanking.Provoobledatel3[2] = textBox17.Text;
                //О
                SelectBanking.Provoobledatel3[3] = textBox18.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel3[5] = Eramake.eCryptography.Encrypt(textBox19.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel3[4] = textBox24.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel3[6] = textBox25.Text;

                //ПРАВООБЛАДАТЕЛЬ4
                //Ф
                SelectBanking.Provoobledatel4[1] = textBox26.Text;
                //И
                SelectBanking.Provoobledatel4[2] = textBox27.Text;
                //О
                SelectBanking.Provoobledatel4[3] = textBox28.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel4[5] = Eramake.eCryptography.Encrypt(textBox29.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel4[4] = textBox30.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel4[6] = textBox31.Text;

                //ПРАВООБЛАДАТЕЛЬ5
                //Ф
                SelectBanking.Provoobledatel5[1] = textBox32.Text;
                //И
                SelectBanking.Provoobledatel5[2] = textBox33.Text;
                //О
                SelectBanking.Provoobledatel5[3] = textBox34.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel5[5] = Eramake.eCryptography.Encrypt(textBox35.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel5[4] = textBox36.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel5[6] = textBox37.Text;
            }

            ////ПРАВООБЛАДАТЕЛЬ1
            ////Ф
            //SelectBanking.Provoobledatel1[1] = textBox4.Text;
            ////И
            //SelectBanking.Provoobledatel1[2] = textBox5.Text;
            ////О
            //SelectBanking.Provoobledatel1[3] = textBox6.Text;
            ////СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            //SelectBanking.Provoobledatel1[5] = textBox7.Text;
            ////АДРЕС РЕГИСТРАЦИИ
            //SelectBanking.Provoobledatel1[4] = textBox8.Text;
            ////ДОЛЯ В ПРАВЕ
            //SelectBanking.Provoobledatel1[6] = textBox9.Text;

            ////ПРАВООБЛАДАТЕЛЬ2
            ////Ф
            //SelectBanking.Provoobledatel2[1] = textBox10.Text;
            ////И
            //SelectBanking.Provoobledatel2[2] = textBox11.Text;
            ////О
            //SelectBanking.Provoobledatel2[3] = textBox12.Text;
            ////СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            //SelectBanking.Provoobledatel2[5] = textBox13.Text;
            ////АДРЕС РЕГИСТРАЦИИ
            //SelectBanking.Provoobledatel2[4] = textBox14.Text;
            ////ДОЛЯ В ПРАВЕ
            //SelectBanking.Provoobledatel2[6] = textBox15.Text;

            ////ПРАВООБЛАДАТЕЛЬ3
            ////Ф
            //SelectBanking.Provoobledatel3[1] = textBox16.Text;
            ////И
            //SelectBanking.Provoobledatel3[2] = textBox17.Text;
            ////О
            //SelectBanking.Provoobledatel3[3] = textBox18.Text;
            ////СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            //SelectBanking.Provoobledatel3[5] = textBox19.Text;
            ////АДРЕС РЕГИСТРАЦИИ
            //SelectBanking.Provoobledatel3[4] = textBox24.Text;
            ////ДОЛЯ В ПРАВЕ
            //SelectBanking.Provoobledatel3[6] = textBox25.Text;

            ////ПРАВООБЛАДАТЕЛЬ4
            ////Ф
            //SelectBanking.Provoobledatel4[1] = textBox26.Text;
            ////И
            //SelectBanking.Provoobledatel4[2] = textBox27.Text;
            ////О
            //SelectBanking.Provoobledatel4[3] = textBox28.Text;
            ////СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            //SelectBanking.Provoobledatel4[5] = textBox29.Text;
            ////АДРЕС РЕГИСТРАЦИИ
            //SelectBanking.Provoobledatel4[4] = textBox30.Text;
            ////ДОЛЯ В ПРАВЕ
            //SelectBanking.Provoobledatel4[6] = textBox31.Text;

            ////ПРАВООБЛАДАТЕЛЬ5
            ////Ф
            //SelectBanking.Provoobledatel5[1] = textBox32.Text;
            ////И
            //SelectBanking.Provoobledatel5[2] = textBox33.Text;
            ////О
            //SelectBanking.Provoobledatel5[3] = textBox34.Text;
            ////СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            //SelectBanking.Provoobledatel5[5] = textBox35.Text;
            ////АДРЕС РЕГИСТРАЦИИ
            //SelectBanking.Provoobledatel5[4] = textBox36.Text;
            ////ДОЛЯ В ПРАВЕ
            //SelectBanking.Provoobledatel5[6] = textBox37.Text;
            if (comboBox6.Text == "Физическое лицо")
            {
                //Физическое лицо
                SelectBanking.PhysZakaz[1] = textBox20.Text;
                SelectBanking.PhysZakaz[2] = textBox21.Text;
                SelectBanking.PhysZakaz[3] = textBox22.Text;
                SelectBanking.PhysZakaz[4] = Eramake.eCryptography.Encrypt(textBox23.Text);
                SelectBanking.PhysZakaz[7] = Eramake.eCryptography.Encrypt(textBox38.Text);
                SelectBanking.PhysZakaz[5] = textBox39.Text;
                SelectBanking.PhysZakaz[6] = textBox40.Text;

                //Юридическое лицо
                SelectBanking.UrZakaz[1] = "";
                SelectBanking.UrZakaz[2] = "";
                SelectBanking.UrZakaz[3] = DateTime.Today.ToString();
                SelectBanking.UrZakaz[4] = "";

            }
            else if (comboBox6.Text == "Юридическое лицо")
            {
                //Юридическое лицо
                SelectBanking.UrZakaz[1] = textBox41.Text;
                SelectBanking.UrZakaz[2] = textBox42.Text;
                SelectBanking.UrZakaz[3] = dateTimePicker4.Value.ToString(); ;
                SelectBanking.UrZakaz[4] = textBox43.Text;

                SelectBanking.PhysZakaz[1] = "";
                SelectBanking.PhysZakaz[2] = "";
                SelectBanking.PhysZakaz[3] = "";
                SelectBanking.PhysZakaz[5] = "";
                SelectBanking.PhysZakaz[7] = "";
                SelectBanking.PhysZakaz[5] = "";
                SelectBanking.PhysZakaz[6] = "";
            }
            //queriesTableAdapter1.ВыпискаЕГРН_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.EGRN[1]), SelectBanking.EGRN[2], SelectBanking.EGRN[3], Convert.ToInt32(SelectBanking.EGRN[0]));
            //queriesTableAdapter1.ТехПаспорт_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.TehPasport[1]), SelectBanking.TehPasport[2], SelectBanking.TehPasport[3], Convert.ToInt32(SelectBanking.TehPasport[0]));
            //queriesTableAdapter1.УдостоверениеЛичности_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Pasport[1]), SelectBanking.Pasport[2], SelectBanking.Pasport[3], Convert.ToInt32(SelectBanking.Pasport[0]));


            queriesTableAdapter1.Правообладатель_ИЗМЕНИТЬ(SelectBanking.Provoobledatel1[1], SelectBanking.Provoobledatel1[2], SelectBanking.Provoobledatel1[3], SelectBanking.Provoobledatel1[4], SelectBanking.Provoobledatel1[5], SelectBanking.Provoobledatel1[6], Convert.ToInt32(SelectBanking.Provoobledatel1[0]));

            queriesTableAdapter1.Правообладатель2_ИЗМЕНИТЬ(SelectBanking.Provoobledatel2[1], SelectBanking.Provoobledatel2[2], SelectBanking.Provoobledatel2[3], SelectBanking.Provoobledatel2[4], SelectBanking.Provoobledatel2[5], SelectBanking.Provoobledatel2[6], Convert.ToInt32(SelectBanking.Provoobledatel2[0]));

            queriesTableAdapter1.Правообладатель3_ИЗМЕНИТЬ(SelectBanking.Provoobledatel3[1], SelectBanking.Provoobledatel3[2], SelectBanking.Provoobledatel3[3], SelectBanking.Provoobledatel3[4], SelectBanking.Provoobledatel3[5], SelectBanking.Provoobledatel3[6], Convert.ToInt32(SelectBanking.Provoobledatel3[0]));

            queriesTableAdapter1.Правообладатель4_ИЗМЕНИТЬ(SelectBanking.Provoobledatel4[1], SelectBanking.Provoobledatel4[2], SelectBanking.Provoobledatel4[3], SelectBanking.Provoobledatel4[4], SelectBanking.Provoobledatel4[5], SelectBanking.Provoobledatel4[6], Convert.ToInt32(SelectBanking.Provoobledatel4[0]));

            queriesTableAdapter1.Правообладатель5_ИЗМЕНИТЬ(SelectBanking.Provoobledatel5[1], SelectBanking.Provoobledatel5[2], SelectBanking.Provoobledatel5[3], SelectBanking.Provoobledatel5[4], SelectBanking.Provoobledatel5[5], SelectBanking.Provoobledatel5[6], Convert.ToInt32(SelectBanking.Provoobledatel5[0]));

            queriesTableAdapter1.Заказчик_ИЗМЕНИТЬ(SelectBanking.PhysZakaz[1], SelectBanking.PhysZakaz[2], SelectBanking.PhysZakaz[3], SelectBanking.PhysZakaz[4], SelectBanking.PhysZakaz[7], SelectBanking.PhysZakaz[5], SelectBanking.PhysZakaz[6], Convert.ToInt32(SelectBanking.PhysZakaz[0]));

            queriesTableAdapter1.ЗаказчикЮридический_ИЗМЕНИТЬ(SelectBanking.UrZakaz[1], SelectBanking.UrZakaz[2], SelectBanking.UrZakaz[4], Convert.ToDateTime(SelectBanking.UrZakaz[3]), Convert.ToInt32(SelectBanking.UrZakaz[0]));

            queriesTableAdapter1.ЗаданиеНаОценку_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[1]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[2]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[3]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[4]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[5]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[6]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[7]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[8]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[14]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[15]), SelectBanking.ZadanieNaOtcenku[9], SelectBanking.ZadanieNaOtcenku[10], Convert.ToDateTime(SelectBanking.ZadanieNaOtcenku[11]), Convert.ToDateTime(SelectBanking.ZadanieNaOtcenku[12]), Convert.ToDateTime(SelectBanking.ZadanieNaOtcenku[13]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[16]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[17]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[18]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[19]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[20]), SelectBanking.idDogovor, Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[0]));
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "Физическое лицо")
            {
                label37.Enabled = true;
                label37.Visible = true;
                label38.Enabled = true;
                label38.Visible = true;
                label39.Enabled = true;
                label39.Visible = true;
                label40.Enabled = true;
                label40.Visible = true;
                label60.Enabled = true;
                label60.Visible = true;
                label18.Enabled = true;
                label18.Visible = true;
                label23.Enabled = true;
                label23.Visible = true;
                textBox20.Enabled = true;
                textBox20.Visible = true;
                textBox21.Enabled = true;
                textBox21.Visible = true;
                textBox22.Enabled = true;
                textBox22.Visible = true;
                textBox23.Enabled = true;
                textBox23.Visible = true;
                textBox38.Enabled = true;
                textBox38.Visible = true;
                textBox39.Enabled = true;
                textBox39.Visible = true;
                textBox40.Enabled = true;
                textBox40.Visible = true;

                label28.Enabled = false;
                label28.Visible = false;
                label33.Enabled = false;
                label33.Visible = false;
                label57.Enabled = false;
                label57.Visible = false;
                label61.Enabled = false;
                label61.Visible = false;
                textBox41.Enabled = false;
                textBox41.Visible = false;
                textBox42.Enabled = false;
                textBox42.Visible = false;
                dateTimePicker4.Enabled = false;
                dateTimePicker4.Visible = false;
                textBox43.Enabled = false;
                textBox43.Visible = false;
            }
            else if (comboBox6.Text == "Юридическое лицо")
            {
                label37.Enabled = false;
                label37.Visible = false;
                label38.Enabled = false;
                label38.Visible = false;
                label39.Enabled = false;
                label39.Visible = false;
                label40.Enabled = false;
                label40.Visible = false;
                label60.Enabled = false;
                label60.Visible = false;
                label18.Enabled = false;
                label18.Visible = false;
                label23.Enabled = false;
                label23.Visible = false;
                textBox20.Enabled = false;
                textBox20.Visible = false;
                textBox21.Enabled = false;
                textBox21.Visible = false;
                textBox22.Enabled = false;
                textBox22.Visible = false;
                textBox23.Enabled = false;
                textBox23.Visible = false;
                textBox38.Enabled = false;
                textBox38.Visible = false;
                textBox39.Enabled = false;
                textBox39.Visible = false;
                textBox40.Enabled = false;
                textBox40.Visible = false;

                label28.Enabled = true;
                label28.Visible = true;
                label33.Enabled = true;
                label33.Visible = true;
                label57.Enabled = true;
                label57.Visible = true;
                label61.Enabled = true;
                label61.Visible = true;
                textBox41.Enabled = true;
                textBox41.Visible = true;
                textBox42.Enabled = true;
                textBox42.Visible = true;
                dateTimePicker4.Enabled = true;
                dateTimePicker4.Visible = true;
                textBox43.Enabled = true;
                textBox43.Visible = true;
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.SelectedValue = 3;
            if (comboBox4.Text == "1")
            {
                comboBox5.SelectedValue = 2;
                //1
                textBox4.Visible = true;
                textBox4.Enabled = true;
                textBox5.Visible = true;
                textBox5.Enabled = true;
                textBox6.Visible = true;
                textBox6.Enabled = true;
                textBox7.Visible = true;
                textBox7.Enabled = true;
                textBox8.Visible = true;
                textBox8.Enabled = true;
                textBox9.Visible = true;
                textBox9.Enabled = true;
                label16.Visible = true;
                label17.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label45.Visible = true;
                label46.Visible = true;
                label65.Enabled = true;
                label65.Visible = true;

                //2
                textBox10.Visible = false;
                textBox10.Enabled = false;
                textBox11.Visible = false;
                textBox11.Enabled = false;
                textBox12.Visible = false;
                textBox12.Enabled = false;
                textBox13.Visible = false;
                textBox13.Enabled = false;
                textBox14.Visible = false;
                textBox14.Enabled = false;
                textBox15.Visible = false;
                textBox15.Enabled = false;
                label24.Visible = false;
                label25.Visible = false;
                label47.Visible = false;
                label48.Visible = false;
                label22.Visible = false;
                label21.Visible = false;
                label64.Enabled = false;
                label64.Visible = false;

                //3
                textBox16.Visible = false;
                textBox16.Enabled = false;
                textBox17.Visible = false;
                textBox17.Enabled = false;
                textBox18.Visible = false;
                textBox18.Enabled = false;
                textBox19.Visible = false;
                textBox19.Enabled = false;
                textBox24.Visible = false;
                textBox24.Enabled = false;
                textBox25.Visible = false;
                textBox25.Enabled = false;
                label29.Visible = false;
                label30.Visible = false;
                label49.Visible = false;
                label50.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label63.Enabled = false;
                label63.Visible = false;

                //4
                textBox26.Visible = false;
                textBox26.Enabled = false;
                textBox27.Visible = false;
                textBox27.Enabled = false;
                textBox28.Visible = false;
                textBox28.Enabled = false;
                textBox29.Visible = false;
                textBox29.Enabled = false;
                textBox30.Visible = false;
                textBox30.Enabled = false;
                textBox31.Visible = false;
                textBox31.Enabled = false;
                label34.Visible = false;
                label35.Visible = false;
                label51.Visible = false;
                label52.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
                label62.Enabled = false;
                label62.Visible = false;


                //5
                textBox32.Visible = false;
                textBox32.Enabled = false;
                textBox33.Visible = false;
                textBox33.Enabled = false;
                textBox34.Visible = false;
                textBox34.Enabled = false;
                textBox35.Visible = false;
                textBox35.Enabled = false;
                textBox36.Visible = false;
                textBox36.Enabled = false;
                textBox37.Visible = false;
                textBox37.Enabled = false;
                label58.Visible = false;
                label59.Visible = false;
                label55.Visible = false;
                label53.Visible = false;
                label54.Visible = false;
                label56.Visible = false;
                label44.Enabled = false;
                label44.Visible = false;
            }
            else if (comboBox4.Text == "2")
            {                //1
                textBox4.Visible = true;
                textBox4.Enabled = true;
                textBox5.Visible = true;
                textBox5.Enabled = true;
                textBox6.Visible = true;
                textBox6.Enabled = true;
                textBox7.Visible = true;
                textBox7.Enabled = true;
                textBox8.Visible = true;
                textBox8.Enabled = true;
                textBox9.Visible = true;
                textBox9.Enabled = true;
                label16.Visible = true;
                label17.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label45.Visible = true;
                label46.Visible = true;
                label65.Enabled = true;
                label65.Visible = true;

                //2
                textBox10.Visible = true;
                textBox10.Enabled = true;
                textBox11.Visible = true;
                textBox11.Enabled = true;
                textBox12.Visible = true;
                textBox12.Enabled = true;
                textBox13.Visible = true;
                textBox13.Enabled = true;
                textBox14.Visible = true;
                textBox14.Enabled = true;
                textBox15.Visible = true;
                textBox15.Enabled = true;
                label24.Visible = true;
                label25.Visible = true;
                label47.Visible = true;
                label48.Visible = true;
                label22.Visible = true;
                label21.Visible = true;
                label64.Enabled = true;
                label64.Visible = true;

                //3
                textBox16.Visible = false;
                textBox16.Enabled = false;
                textBox17.Visible = false;
                textBox17.Enabled = false;
                textBox18.Visible = false;
                textBox18.Enabled = false;
                textBox19.Visible = false;
                textBox19.Enabled = false;
                textBox24.Visible = false;
                textBox24.Enabled = false;
                textBox25.Visible = false;
                textBox25.Enabled = false;
                label29.Visible = false;
                label30.Visible = false;
                label49.Visible = false;
                label50.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label63.Enabled = false;
                label63.Visible = false;


                //4
                textBox26.Visible = false;
                textBox26.Enabled = false;
                textBox27.Visible = false;
                textBox27.Enabled = false;
                textBox28.Visible = false;
                textBox28.Enabled = false;
                textBox29.Visible = false;
                textBox29.Enabled = false;
                textBox30.Visible = false;
                textBox30.Enabled = false;
                textBox31.Visible = false;
                textBox31.Enabled = false;
                label34.Visible = false;
                label35.Visible = false;
                label51.Visible = false;
                label52.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
                label62.Enabled = false;
                label62.Visible = false;

                //5
                textBox32.Visible = false;
                textBox32.Enabled = false;
                textBox33.Visible = false;
                textBox33.Enabled = false;
                textBox34.Visible = false;
                textBox34.Enabled = false;
                textBox35.Visible = false;
                textBox35.Enabled = false;
                textBox36.Visible = false;
                textBox36.Enabled = false;
                textBox37.Visible = false;
                textBox37.Enabled = false;
                label58.Visible = false;
                label59.Visible = false;
                label55.Visible = false;
                label53.Visible = false;
                label54.Visible = false;
                label56.Visible = false;
                label44.Enabled = false;
                label44.Visible = false;
            }
            else if (comboBox4.Text == "3")
            {  //1
                textBox4.Visible = true;
                textBox4.Enabled = true;
                textBox5.Visible = true;
                textBox5.Enabled = true;
                textBox6.Visible = true;
                textBox6.Enabled = true;
                textBox7.Visible = true;
                textBox7.Enabled = true;
                textBox8.Visible = true;
                textBox8.Enabled = true;
                textBox9.Visible = true;
                textBox9.Enabled = true;
                label16.Visible = true;
                label17.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label45.Visible = true;
                label46.Visible = true;
                label65.Enabled = true;
                label65.Visible = true;

                //2
                textBox10.Visible = true;
                textBox10.Enabled = true;
                textBox11.Visible = true;
                textBox11.Enabled = true;
                textBox12.Visible = true;
                textBox12.Enabled = true;
                textBox13.Visible = true;
                textBox13.Enabled = true;
                textBox14.Visible = true;
                textBox14.Enabled = true;
                textBox15.Visible = true;
                textBox15.Enabled = true;
                label24.Visible = true;
                label25.Visible = true;
                label47.Visible = true;
                label48.Visible = true;
                label22.Visible = true;
                label21.Visible = true;
                label64.Enabled = true;
                label64.Visible = true;

                //3
                textBox16.Visible = true;
                textBox16.Enabled = true;
                textBox17.Visible = true;
                textBox17.Enabled = true;
                textBox18.Visible = true;
                textBox18.Enabled = true;
                textBox19.Visible = true;
                textBox19.Enabled = true;
                textBox24.Visible = true;
                textBox24.Enabled = true;
                textBox25.Visible = true;
                textBox25.Enabled = true;
                label29.Visible = true;
                label30.Visible = true;
                label49.Visible = true;
                label50.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label63.Enabled = true;
                label63.Visible = true;

                //4
                textBox26.Visible = false;
                textBox26.Enabled = false;
                textBox27.Visible = false;
                textBox27.Enabled = false;
                textBox28.Visible = false;
                textBox28.Enabled = false;
                textBox29.Visible = false;
                textBox29.Enabled = false;
                textBox30.Visible = false;
                textBox30.Enabled = false;
                textBox31.Visible = false;
                textBox31.Enabled = false;
                label34.Visible = false;
                label35.Visible = false;
                label51.Visible = false;
                label52.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
                label62.Enabled = false;
                label62.Visible = false;




                //5
                textBox32.Visible = false;
                textBox32.Enabled = false;
                textBox33.Visible = false;
                textBox33.Enabled = false;
                textBox34.Visible = false;
                textBox34.Enabled = false;
                textBox35.Visible = false;
                textBox35.Enabled = false;
                textBox36.Visible = false;
                textBox36.Enabled = false;
                textBox37.Visible = false;
                textBox37.Enabled = false;
                label58.Visible = false;
                label59.Visible = false;
                label55.Visible = false;
                label53.Visible = false;
                label54.Visible = false;
                label56.Visible = false;
                label44.Enabled = false;
                label44.Visible = false;
            }
            else if (comboBox4.Text == "4")
            {  //1
                textBox4.Visible = true;
                textBox4.Enabled = true;
                textBox5.Visible = true;
                textBox5.Enabled = true;
                textBox6.Visible = true;
                textBox6.Enabled = true;
                textBox7.Visible = true;
                textBox7.Enabled = true;
                textBox8.Visible = true;
                textBox8.Enabled = true;
                textBox9.Visible = true;
                textBox9.Enabled = true;
                label16.Visible = true;
                label17.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label45.Visible = true;
                label46.Visible = true;
                label65.Enabled = true;
                label65.Visible = true;

                //2
                textBox10.Visible = true;
                textBox10.Enabled = true;
                textBox11.Visible = true;
                textBox11.Enabled = true;
                textBox12.Visible = true;
                textBox12.Enabled = true;
                textBox13.Visible = true;
                textBox13.Enabled = true;
                textBox14.Visible = true;
                textBox14.Enabled = true;
                textBox15.Visible = true;
                textBox15.Enabled = true;
                label24.Visible = true;
                label25.Visible = true;
                label47.Visible = true;
                label48.Visible = true;
                label22.Visible = true;
                label21.Visible = true;
                label64.Enabled = true;
                label64.Visible = true;

                //3
                textBox16.Visible = true;
                textBox16.Enabled = true;
                textBox17.Visible = true;
                textBox17.Enabled = true;
                textBox18.Visible = true;
                textBox18.Enabled = true;
                textBox19.Visible = true;
                textBox19.Enabled = true;
                textBox24.Visible = true;
                textBox24.Enabled = true;
                textBox25.Visible = true;
                textBox25.Enabled = true;
                label29.Visible = true;
                label30.Visible = true;
                label49.Visible = true;
                label50.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label63.Enabled = true;
                label63.Visible = true;

                //4
                textBox26.Visible = true;
                textBox26.Enabled = true;
                textBox27.Visible = true;
                textBox27.Enabled = true;
                textBox28.Visible = true;
                textBox28.Enabled = true;
                textBox29.Visible = true;
                textBox29.Enabled = true;
                textBox30.Visible = true;
                textBox30.Enabled = true;
                textBox31.Visible = true;
                textBox31.Enabled = true;
                label34.Visible = true;
                label35.Visible = true;
                label51.Visible = true;
                label52.Visible = true;
                label31.Visible = true;
                label32.Visible = true;
                label62.Enabled = true;
                label62.Visible = true;

                //5
                textBox32.Visible = false;
                textBox32.Enabled = false;
                textBox33.Visible = false;
                textBox33.Enabled = false;
                textBox34.Visible = false;
                textBox34.Enabled = false;
                textBox35.Visible = false;
                textBox35.Enabled = false;
                textBox36.Visible = false;
                textBox36.Enabled = false;
                textBox37.Visible = false;
                textBox37.Enabled = false;
                label58.Visible = false;
                label59.Visible = false;
                label55.Visible = false;
                label53.Visible = false;
                label54.Visible = false;
                label56.Visible = false;
                label44.Enabled = false;
                label44.Visible = false;
            }
            else if (comboBox4.Text == "5")
            {  //1
                textBox4.Visible = true;
                textBox4.Enabled = true;
                textBox5.Visible = true;
                textBox5.Enabled = true;
                textBox6.Visible = true;
                textBox6.Enabled = true;
                textBox7.Visible = true;
                textBox7.Enabled = true;
                textBox8.Visible = true;
                textBox8.Enabled = true;
                textBox9.Visible = true;
                textBox9.Enabled = true;
                label16.Visible = true;
                label17.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label45.Visible = true;
                label46.Visible = true;
                label65.Enabled = true;
                label65.Visible = true;

                //2
                textBox10.Visible = true;
                textBox10.Enabled = true;
                textBox11.Visible = true;
                textBox11.Enabled = true;
                textBox12.Visible = true;
                textBox12.Enabled = true;
                textBox13.Visible = true;
                textBox13.Enabled = true;
                textBox14.Visible = true;
                textBox14.Enabled = true;
                textBox15.Visible = true;
                textBox15.Enabled = true;
                label24.Visible = true;
                label25.Visible = true;
                label47.Visible = true;
                label48.Visible = true;
                label22.Visible = true;
                label21.Visible = true;
                label64.Enabled = true;
                label64.Visible = true;

                //3
                textBox16.Visible = true;
                textBox16.Enabled = true;
                textBox17.Visible = true;
                textBox17.Enabled = true;
                textBox18.Visible = true;
                textBox18.Enabled = true;
                textBox19.Visible = true;
                textBox19.Enabled = true;
                textBox24.Visible = true;
                textBox24.Enabled = true;
                textBox25.Visible = true;
                textBox25.Enabled = true;
                label29.Visible = true;
                label30.Visible = true;
                label49.Visible = true;
                label50.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label63.Enabled = true;
                label63.Visible = true;

                //4
                textBox26.Visible = true;
                textBox26.Enabled = true;
                textBox27.Visible = true;
                textBox27.Enabled = true;
                textBox28.Visible = true;
                textBox28.Enabled = true;
                textBox29.Visible = true;
                textBox29.Enabled = true;
                textBox30.Visible = true;
                textBox30.Enabled = true;
                textBox31.Visible = true;
                textBox31.Enabled = true;
                label34.Visible = true;
                label35.Visible = true;
                label51.Visible = true;
                label52.Visible = true;
                label31.Visible = true;
                label32.Visible = true;
                label62.Enabled = true;
                label62.Visible = true;


                //5
                textBox32.Visible = true;
                textBox32.Enabled = true;
                textBox33.Visible = true;
                textBox33.Enabled = true;
                textBox34.Visible = true;
                textBox34.Enabled = true;
                textBox35.Visible = true;
                textBox35.Enabled = true;
                textBox36.Visible = true;
                textBox36.Enabled = true;
                textBox37.Visible = true;
                textBox37.Enabled = true;
                label58.Visible = true;
                label59.Visible = true;
                label55.Visible = true;
                label53.Visible = true;
                label54.Visible = true;
                label56.Visible = true;
                label44.Enabled = true;
                label44.Visible = true;
            }
            SaveFlag = 1;
        }

        private void textBoxSave(object sender, EventArgs e)
        {
            SaveFlag = 1;
        }
        private void comboBoxSave(object sender, EventArgs e)
        {
            SaveFlag = 1;
        }

        private void dateTimePickerSave(object sender, EventArgs e)
        {
            SaveFlag = 1;
        }

        private void EvaluationTask_FormClosing(object sender, FormClosingEventArgs e)
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
                    if (rjToggleButton1.Checked)
            { 
                        SelectBanking.EGRN[1] = "2";
                        SelectBanking.EGRN[2] = Eramake.eCryptography.Encrypt(textBox3.Text);
                    }
            else { 
                        SelectBanking.EGRN[1] = "3";
                        SelectBanking.EGRN[2] = "";
                        SelectBanking.EGRN[3] = "";
                    }
            if (rjToggleButton2.Checked)
            { 
                        SelectBanking.TehPasport[1] = "2";
                        SelectBanking.TehPasport[2] = Eramake.eCryptography.Encrypt(textBox44.Text);
                    }
            else { 
                        SelectBanking.TehPasport[1] = "3";
                        SelectBanking.TehPasport[2] = "";
                        SelectBanking.TehPasport[3] = "";
                    }
            if (rjToggleButton3.Checked)
            { 
                        SelectBanking.Pasport[1] = "2";
                        SelectBanking.Pasport[2] = Eramake.eCryptography.Encrypt(textBox45.Text);
                    }
            else { 
                        SelectBanking.Pasport[1] = "3";
                        SelectBanking.Pasport[2] = "";
                        SelectBanking.Pasport[3] = "";
                    }
            //ЗАДАНИЕ НА ОЦЕНКУ
            //Текущие имущественные права на объект оценки
            SelectBanking.ZadanieNaOtcenku[14] = comboBox1.SelectedValue.ToString();
            //Наличие обременений
            SelectBanking.ZadanieNaOtcenku[3] = comboBox2.SelectedValue.ToString();
            //Характер обременений
            SelectBanking.ZadanieNaOtcenku[4] = comboBox3.SelectedValue.ToString();
            //Цель оценки
            SelectBanking.ZadanieNaOtcenku[9] = textBox1.Text;
            //Предполагаемое использование результатов оценки и связанные с этим ограничения
            SelectBanking.ZadanieNaOtcenku[10]=textBox2.Text ;
            //Вид стоимости
            SelectBanking.ZadanieNaOtcenku[15] = comboBox12.SelectedValue.ToString();
            //Дата осмотра
            SelectBanking.ZadanieNaOtcenku[11] = dateTimePicker1.Value.ToString();
            //Дата оценки
            SelectBanking.ZadanieNaOtcenku[12] = dateTimePicker2.Value.ToString();
            //Дата составления отчета
            SelectBanking.ZadanieNaOtcenku[13] = dateTimePicker3.Value.ToString();



            //ПРАВООБЛАДАТЕЛЬ
            //Количество собственников
            SelectBanking.ZadanieNaOtcenku[5] = comboBox4.Text.ToString();
            //Физическое / юридическое лицо
            SelectBanking.ZadanieNaOtcenku[6] = comboBox5.SelectedValue.ToString();

            if (comboBox4.Text == "1")
            {
                //ПРАВООБЛАДАТЕЛЬ1
                //Ф
                SelectBanking.Provoobledatel1[1] = textBox4.Text;
                //И
                SelectBanking.Provoobledatel1[2] = textBox5.Text;
                //О
                SelectBanking.Provoobledatel1[3] = textBox6.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel1[5] = Eramake.eCryptography.Encrypt(textBox7.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel1[4] = textBox8.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel1[6] = textBox9.Text;

                //ПРАВООБЛАДАТЕЛЬ2
                //Ф
                SelectBanking.Provoobledatel2[1] = "";
                //И
                SelectBanking.Provoobledatel2[2] = "";
                //О
                SelectBanking.Provoobledatel2[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel2[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel2[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel2[6] = "";

                //ПРАВООБЛАДАТЕЛЬ3
                //Ф
                SelectBanking.Provoobledatel3[1] = "";
                //И
                SelectBanking.Provoobledatel3[2] = "";
                //О
                SelectBanking.Provoobledatel3[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel3[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel3[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel3[6] = "";

                //ПРАВООБЛАДАТЕЛЬ4
                //Ф
                SelectBanking.Provoobledatel4[1] = "";
                //И
                SelectBanking.Provoobledatel4[2] = "";
                //О
                SelectBanking.Provoobledatel4[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel4[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel4[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel4[6] = "";

                //ПРАВООБЛАДАТЕЛЬ5
                //Ф
                SelectBanking.Provoobledatel5[1] = "";
                //И
                SelectBanking.Provoobledatel5[2] = "";
                //О
                SelectBanking.Provoobledatel5[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel5[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel5[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel5[6] = "";
            }
            else if (comboBox4.Text == "2")
            {  //ПРАВООБЛАДАТЕЛЬ1
               //Ф
                SelectBanking.Provoobledatel1[1] = textBox4.Text;
                //И
                SelectBanking.Provoobledatel1[2] = textBox5.Text;
                //О
                SelectBanking.Provoobledatel1[3] = textBox6.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel1[5] = Eramake.eCryptography.Encrypt(textBox7.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel1[4] = textBox8.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel1[6] = textBox9.Text;

                //ПРАВООБЛАДАТЕЛЬ2
                //Ф
                SelectBanking.Provoobledatel2[1] = textBox10.Text;
                //И
                SelectBanking.Provoobledatel2[2] = textBox11.Text;
                //О
                SelectBanking.Provoobledatel2[3] = textBox12.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel2[5] = Eramake.eCryptography.Encrypt(textBox13.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel2[4] = textBox14.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel2[6] = textBox15.Text;

                //ПРАВООБЛАДАТЕЛЬ3
                //Ф
                SelectBanking.Provoobledatel3[1] = "";
                //И
                SelectBanking.Provoobledatel3[2] = "";
                //О
                SelectBanking.Provoobledatel3[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel3[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel3[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel3[6] = "";

                //ПРАВООБЛАДАТЕЛЬ4
                //Ф
                SelectBanking.Provoobledatel4[1] = "";
                //И
                SelectBanking.Provoobledatel4[2] = "";
                //О
                SelectBanking.Provoobledatel4[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel4[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel4[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel4[6] = "";

                //ПРАВООБЛАДАТЕЛЬ5
                //Ф
                SelectBanking.Provoobledatel5[1] = "";
                //И
                SelectBanking.Provoobledatel5[2] = "";
                //О
                SelectBanking.Provoobledatel5[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel5[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel5[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel5[6] = "";
            }
            else if (comboBox4.Text == "3")
            {  //ПРАВООБЛАДАТЕЛЬ1
               //Ф
                SelectBanking.Provoobledatel1[1] = textBox4.Text;
                //И
                SelectBanking.Provoobledatel1[2] = textBox5.Text;
                //О
                SelectBanking.Provoobledatel1[3] = textBox6.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel1[5] = Eramake.eCryptography.Encrypt(textBox7.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel1[4] = textBox8.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel1[6] = textBox9.Text;

                //ПРАВООБЛАДАТЕЛЬ2
                //Ф
                SelectBanking.Provoobledatel2[1] = textBox10.Text;
                //И
                SelectBanking.Provoobledatel2[2] = textBox11.Text;
                //О
                SelectBanking.Provoobledatel2[3] = textBox12.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel2[5] = Eramake.eCryptography.Encrypt(textBox13.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel2[4] = textBox14.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel2[6] = textBox15.Text;

                //ПРАВООБЛАДАТЕЛЬ3
                //Ф
                SelectBanking.Provoobledatel3[1] = textBox16.Text;
                //И
                SelectBanking.Provoobledatel3[2] = textBox17.Text;
                //О
                SelectBanking.Provoobledatel3[3] = textBox18.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel3[5] = Eramake.eCryptography.Encrypt(textBox19.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel3[4] = textBox24.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel3[6] = textBox25.Text;

                //ПРАВООБЛАДАТЕЛЬ4
                //Ф
                SelectBanking.Provoobledatel4[1] = "";
                //И
                SelectBanking.Provoobledatel4[2] = "";
                //О
                SelectBanking.Provoobledatel4[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel4[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel4[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel4[6] = "";

                //ПРАВООБЛАДАТЕЛЬ5
                //Ф
                SelectBanking.Provoobledatel5[1] = "";
                //И
                SelectBanking.Provoobledatel5[2] = "";
                //О
                SelectBanking.Provoobledatel5[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel5[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel5[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel5[6] = "";
            }
            else if (comboBox4.Text == "4")
            {  //ПРАВООБЛАДАТЕЛЬ1
               //Ф
                SelectBanking.Provoobledatel1[1] = textBox4.Text;
                //И
                SelectBanking.Provoobledatel1[2] = textBox5.Text;
                //О
                SelectBanking.Provoobledatel1[3] = textBox6.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel1[5] = Eramake.eCryptography.Encrypt(textBox7.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel1[4] = textBox8.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel1[6] = textBox9.Text;

                //ПРАВООБЛАДАТЕЛЬ2
                //Ф
                SelectBanking.Provoobledatel2[1] = textBox10.Text;
                //И
                SelectBanking.Provoobledatel2[2] = textBox11.Text;
                //О
                SelectBanking.Provoobledatel2[3] = textBox12.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel2[5] = Eramake.eCryptography.Encrypt(textBox13.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel2[4] = textBox14.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel2[6] = textBox15.Text;

                //ПРАВООБЛАДАТЕЛЬ3
                //Ф
                SelectBanking.Provoobledatel3[1] = textBox16.Text;
                //И
                SelectBanking.Provoobledatel3[2] = textBox17.Text;
                //О
                SelectBanking.Provoobledatel3[3] = textBox18.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel3[5] = Eramake.eCryptography.Encrypt(textBox19.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel3[4] = textBox24.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel3[6] = textBox25.Text;

                //ПРАВООБЛАДАТЕЛЬ4
                //Ф
                SelectBanking.Provoobledatel4[1] = textBox26.Text;
                //И
                SelectBanking.Provoobledatel4[2] = textBox27.Text;
                //О
                SelectBanking.Provoobledatel4[3] = textBox28.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel4[5] = Eramake.eCryptography.Encrypt(textBox29.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel4[4] = textBox30.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel4[6] = textBox31.Text;

                //ПРАВООБЛАДАТЕЛЬ5
                //Ф
                SelectBanking.Provoobledatel5[1] = "";
                //И
                SelectBanking.Provoobledatel5[2] = "";
                //О
                SelectBanking.Provoobledatel5[3] = "";
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel5[5] = "";
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel5[4] = "";
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel5[6] = "";
            }
            else if (comboBox4.Text == "5")
            {  //ПРАВООБЛАДАТЕЛЬ1
               //Ф
                SelectBanking.Provoobledatel1[1] = textBox4.Text;
                //И
                SelectBanking.Provoobledatel1[2] = textBox5.Text;
                //О
                SelectBanking.Provoobledatel1[3] = textBox6.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel1[5] = Eramake.eCryptography.Encrypt(textBox7.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel1[4] = textBox8.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel1[6] = textBox9.Text;

                //ПРАВООБЛАДАТЕЛЬ2
                //Ф
                SelectBanking.Provoobledatel2[1] = textBox10.Text;
                //И
                SelectBanking.Provoobledatel2[2] = textBox11.Text;
                //О
                SelectBanking.Provoobledatel2[3] = textBox12.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel2[5] = Eramake.eCryptography.Encrypt(textBox13.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel2[4] = textBox14.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel2[6] = textBox15.Text;

                //ПРАВООБЛАДАТЕЛЬ3
                //Ф
                SelectBanking.Provoobledatel3[1] = textBox16.Text;
                //И
                SelectBanking.Provoobledatel3[2] = textBox17.Text;
                //О
                SelectBanking.Provoobledatel3[3] = textBox18.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel3[5] = Eramake.eCryptography.Encrypt(textBox19.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel3[4] = textBox24.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel3[6] = textBox25.Text;

                //ПРАВООБЛАДАТЕЛЬ4
                //Ф
                SelectBanking.Provoobledatel4[1] = textBox26.Text;
                //И
                SelectBanking.Provoobledatel4[2] = textBox27.Text;
                //О
                SelectBanking.Provoobledatel4[3] = textBox28.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel4[5] = Eramake.eCryptography.Encrypt(textBox29.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel4[4] = textBox30.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel4[6] = textBox31.Text;

                //ПРАВООБЛАДАТЕЛЬ5
                //Ф
                SelectBanking.Provoobledatel5[1] = textBox32.Text;
                //И
                SelectBanking.Provoobledatel5[2] = textBox33.Text;
                //О
                SelectBanking.Provoobledatel5[3] = textBox34.Text;
                //СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
                SelectBanking.Provoobledatel5[5] = Eramake.eCryptography.Encrypt(textBox35.Text);
                //АДРЕС РЕГИСТРАЦИИ
                SelectBanking.Provoobledatel5[4] = textBox36.Text;
                //ДОЛЯ В ПРАВЕ
                SelectBanking.Provoobledatel5[6] = textBox37.Text;
            }

            ////ПРАВООБЛАДАТЕЛЬ1
            ////Ф
            //SelectBanking.Provoobledatel1[1] = textBox4.Text;
            ////И
            //SelectBanking.Provoobledatel1[2] = textBox5.Text;
            ////О
            //SelectBanking.Provoobledatel1[3] = textBox6.Text;
            ////СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            //SelectBanking.Provoobledatel1[5] = textBox7.Text;
            ////АДРЕС РЕГИСТРАЦИИ
            //SelectBanking.Provoobledatel1[4] = textBox8.Text;
            ////ДОЛЯ В ПРАВЕ
            //SelectBanking.Provoobledatel1[6] = textBox9.Text;

            ////ПРАВООБЛАДАТЕЛЬ2
            ////Ф
            //SelectBanking.Provoobledatel2[1] = textBox10.Text;
            ////И
            //SelectBanking.Provoobledatel2[2] = textBox11.Text;
            ////О
            //SelectBanking.Provoobledatel2[3] = textBox12.Text;
            ////СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            //SelectBanking.Provoobledatel2[5] = textBox13.Text;
            ////АДРЕС РЕГИСТРАЦИИ
            //SelectBanking.Provoobledatel2[4] = textBox14.Text;
            ////ДОЛЯ В ПРАВЕ
            //SelectBanking.Provoobledatel2[6] = textBox15.Text;

            ////ПРАВООБЛАДАТЕЛЬ3
            ////Ф
            //SelectBanking.Provoobledatel3[1] = textBox16.Text;
            ////И
            //SelectBanking.Provoobledatel3[2] = textBox17.Text;
            ////О
            //SelectBanking.Provoobledatel3[3] = textBox18.Text;
            ////СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            //SelectBanking.Provoobledatel3[5] = textBox19.Text;
            ////АДРЕС РЕГИСТРАЦИИ
            //SelectBanking.Provoobledatel3[4] = textBox24.Text;
            ////ДОЛЯ В ПРАВЕ
            //SelectBanking.Provoobledatel3[6] = textBox25.Text;

            ////ПРАВООБЛАДАТЕЛЬ4
            ////Ф
            //SelectBanking.Provoobledatel4[1] = textBox26.Text;
            ////И
            //SelectBanking.Provoobledatel4[2] = textBox27.Text;
            ////О
            //SelectBanking.Provoobledatel4[3] = textBox28.Text;
            ////СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            //SelectBanking.Provoobledatel4[5] = textBox29.Text;
            ////АДРЕС РЕГИСТРАЦИИ
            //SelectBanking.Provoobledatel4[4] = textBox30.Text;
            ////ДОЛЯ В ПРАВЕ
            //SelectBanking.Provoobledatel4[6] = textBox31.Text;

            ////ПРАВООБЛАДАТЕЛЬ5
            ////Ф
            //SelectBanking.Provoobledatel5[1] = textBox32.Text;
            ////И
            //SelectBanking.Provoobledatel5[2] = textBox33.Text;
            ////О
            //SelectBanking.Provoobledatel5[3] = textBox34.Text;
            ////СВИДЕТЕЛЬСТВО О РОЖДЕНИИ
            //SelectBanking.Provoobledatel5[5] = textBox35.Text;
            ////АДРЕС РЕГИСТРАЦИИ
            //SelectBanking.Provoobledatel5[4] = textBox36.Text;
            ////ДОЛЯ В ПРАВЕ
            //SelectBanking.Provoobledatel5[6] = textBox37.Text;
            if (comboBox6.Text == "Физическое лицо")
            {
                //Физическое лицо
                SelectBanking.PhysZakaz[1] = textBox20.Text;
                SelectBanking.PhysZakaz[2] = textBox21.Text;
                SelectBanking.PhysZakaz[3] = textBox22.Text;
                SelectBanking.PhysZakaz[4] = Eramake.eCryptography.Encrypt(textBox23.Text);
                SelectBanking.PhysZakaz[7] = Eramake.eCryptography.Encrypt(textBox38.Text);
                SelectBanking.PhysZakaz[5] = textBox39.Text;
                SelectBanking.PhysZakaz[6] = textBox40.Text;

                //Юридическое лицо
                SelectBanking.UrZakaz[1] = "";
                SelectBanking.UrZakaz[2] = "";
                SelectBanking.UrZakaz[3] = DateTime.Today.ToString();
                SelectBanking.UrZakaz[4] = "";

            }
            else if (comboBox6.Text == "Юридическое лицо")
            {
                //Юридическое лицо
                SelectBanking.UrZakaz[1] = textBox41.Text;
                SelectBanking.UrZakaz[2] = textBox42.Text;
                SelectBanking.UrZakaz[3] = dateTimePicker4.Value.ToString(); ;
                SelectBanking.UrZakaz[4] = textBox43.Text;

                SelectBanking.PhysZakaz[1] = "";
                SelectBanking.PhysZakaz[2] = "";
                SelectBanking.PhysZakaz[3] = "";
                SelectBanking.PhysZakaz[5] = "";
                SelectBanking.PhysZakaz[7] = "";
                SelectBanking.PhysZakaz[5] = "";
                SelectBanking.PhysZakaz[6] = "";
            }

                try
                {
                    queriesTableAdapter1.ВыпискаЕГРН_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.EGRN[1]), SelectBanking.EGRN[2], SelectBanking.EGRN[3], Convert.ToInt32(SelectBanking.EGRN[0]));
                }
                    catch { }
                try
                {
                    queriesTableAdapter1.ТехПаспорт_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.TehPasport[1]), SelectBanking.TehPasport[2], SelectBanking.TehPasport[3], Convert.ToInt32(SelectBanking.TehPasport[0]));
                }
                    catch { }
                try
                {
                    queriesTableAdapter1.УдостоверениеЛичности_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Pasport[1]), SelectBanking.Pasport[2], SelectBanking.Pasport[3], Convert.ToInt32(SelectBanking.Pasport[0]));

                }
                    catch { }
                try
                {
                    queriesTableAdapter1.Правообладатель_ИЗМЕНИТЬ(SelectBanking.Provoobledatel1[1], SelectBanking.Provoobledatel1[2], SelectBanking.Provoobledatel1[3], SelectBanking.Provoobledatel1[4], SelectBanking.Provoobledatel1[5], SelectBanking.Provoobledatel1[6], Convert.ToInt32(SelectBanking.Provoobledatel1[0]));
                }
                    catch { }
                try
                {
                    queriesTableAdapter1.Правообладатель2_ИЗМЕНИТЬ(SelectBanking.Provoobledatel2[1], SelectBanking.Provoobledatel2[2], SelectBanking.Provoobledatel2[3], SelectBanking.Provoobledatel2[4], SelectBanking.Provoobledatel2[5], SelectBanking.Provoobledatel2[6], Convert.ToInt32(SelectBanking.Provoobledatel2[0]));
                }
                    catch { }
                try
                {
                    queriesTableAdapter1.Правообладатель3_ИЗМЕНИТЬ(SelectBanking.Provoobledatel3[1], SelectBanking.Provoobledatel3[2], SelectBanking.Provoobledatel3[3], SelectBanking.Provoobledatel3[4], SelectBanking.Provoobledatel3[5], SelectBanking.Provoobledatel3[6], Convert.ToInt32(SelectBanking.Provoobledatel3[0]));
                }
                    catch { }
                try
                {
                    queriesTableAdapter1.Правообладатель4_ИЗМЕНИТЬ(SelectBanking.Provoobledatel4[1], SelectBanking.Provoobledatel4[2], SelectBanking.Provoobledatel4[3], SelectBanking.Provoobledatel4[4], SelectBanking.Provoobledatel4[5], SelectBanking.Provoobledatel4[6], Convert.ToInt32(SelectBanking.Provoobledatel4[0]));
                }
                    catch { }
                try
                {
                    queriesTableAdapter1.Правообладатель5_ИЗМЕНИТЬ(SelectBanking.Provoobledatel5[1], SelectBanking.Provoobledatel5[2], SelectBanking.Provoobledatel5[3], SelectBanking.Provoobledatel5[4], SelectBanking.Provoobledatel5[5], SelectBanking.Provoobledatel5[6], Convert.ToInt32(SelectBanking.Provoobledatel5[0]));
                }
                    catch { }
                try
                {
                    queriesTableAdapter1.Заказчик_ИЗМЕНИТЬ(SelectBanking.PhysZakaz[1], SelectBanking.PhysZakaz[2], SelectBanking.PhysZakaz[3], SelectBanking.PhysZakaz[4], SelectBanking.PhysZakaz[7], SelectBanking.PhysZakaz[5], SelectBanking.PhysZakaz[6], Convert.ToInt32(SelectBanking.PhysZakaz[0]));
                }
                    catch { }
                try
                {
                    queriesTableAdapter1.ЗаказчикЮридический_ИЗМЕНИТЬ(SelectBanking.UrZakaz[1], SelectBanking.UrZakaz[2], SelectBanking.UrZakaz[4], Convert.ToDateTime(SelectBanking.UrZakaz[3]), Convert.ToInt32(SelectBanking.UrZakaz[0]));
                }
                    catch { }
                try
                {
                    queriesTableAdapter1.ЗаданиеНаОценку_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[1]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[2]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[3]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[4]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[5]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[6]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[7]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[8]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[14]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[15]), SelectBanking.ZadanieNaOtcenku[9], SelectBanking.ZadanieNaOtcenku[10], Convert.ToDateTime(SelectBanking.ZadanieNaOtcenku[11]), Convert.ToDateTime(SelectBanking.ZadanieNaOtcenku[12]), Convert.ToDateTime(SelectBanking.ZadanieNaOtcenku[13]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[16]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[17]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[18]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[19]), Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[20]), SelectBanking.idDogovor, Convert.ToInt32(SelectBanking.ZadanieNaOtcenku[0]));
                }
                    catch { }

                } }
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;
            if (rjToggleButton1.Checked)
            {
                textBox3.Visible = true; rjButton1.Visible = true; label41.Visible = true;
            }
            else
            {
                textBox3.Visible = false; rjButton1.Visible = false; label41.Visible = false;
            }
        }

        private void rjToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;
            if (rjToggleButton2.Checked)
            {
                textBox44.Visible = true; rjButton2.Visible = true; label42.Visible = true;
            }
            else
            {
                textBox44.Visible = false; rjButton2.Visible = false; label42.Visible = false;
            }
        }

        private void rjToggleButton3_CheckedChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;
            if (rjToggleButton3.Checked)
            {
                textBox45.Visible = true; rjButton3.Visible = true; label43.Visible = true;
            }
            else
            {
                textBox45.Visible = false; rjButton3.Visible = false; label43.Visible = false;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            SaveFlag = 1;
            //filter
            openFileDialog1.Filter = "Все файлы(*.*)|*.*";
            //open
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    label41.Text = Path.GetFileName(openFileDialog1.FileName);
                    SelectBanking.EGRN[3] = openFileDialog1.FileName;
                } 
            }
            catch { }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            SaveFlag = 1;
            //filter
            openFileDialog1.Filter = "Все файлы(*.*)|*.*";
            //open
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    label42.Text = Path.GetFileName(openFileDialog1.FileName);
                    SelectBanking.TehPasport[3] = openFileDialog1.FileName;
                }
            }
            catch { }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            SaveFlag = 1;
            //filter
            openFileDialog1.Filter = "Все файлы(*.*)|*.*";
            //open
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    label43.Text = Path.GetFileName(openFileDialog1.FileName);
                    SelectBanking.Pasport[3] = openFileDialog1.FileName;
                }
            }
            catch { }
        }
    }
}
