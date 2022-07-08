using System;
using System.Windows.Forms;
namespace graduatework.Forms
{
    public partial class WearCalculation : Form
    {
        public WearCalculation()
        {
            InitializeComponent();
        }
        public int SaveFlag;
        private void WearCalculation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПМетодОпределенияФизИзноса". При необходимости она может быть перемещена или удалена.
            this.пМетодОпределенияФизИзносаTableAdapter.Fill(this.graduatedbDataSet.ПМетодОпределенияФизИзноса);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПСпособОпределенияФактическогоСрокаСлужбы". При необходимости она может быть перемещена или удалена.
            this.пСпособОпределенияФактическогоСрокаСлужбыTableAdapter.Fill(this.graduatedbDataSet.ПСпособОпределенияФактическогоСрокаСлужбы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПНормативныеСрокиЖизниЖилыхЗданий". При необходимости она может быть перемещена или удалена.
            this.пНормативныеСрокиЖизниЖилыхЗданийTableAdapter.Fill(this.graduatedbDataSet.ПНормативныеСрокиЖизниЖилыхЗданий);

            //1
            comboBox1.SelectedValue = Convert.ToInt32(SelectBanking.PhysIznos[1]);
            comboBox2.SelectedValue = Convert.ToInt32(SelectBanking.PhysIznos[2]);
            textBox1.Text = SelectBanking.OXZ[6];
            try {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(comboBox1.Text);
                textBox2.Text = Math.Round((a / b) * 100).ToString();
            }
            catch { }

            //2
            textBox3.Text = textBox2.Text;
            textBox5.Text = textBox3.Text;
            textBox4.Text = SelectBanking.Method[3];
            comboBox3.SelectedValue = Convert.ToInt32(SelectBanking.Method[2]);
            SaveFlag = 0;
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(comboBox1.Text);
            textBox2.Text = Math.Round((a / b) * 100).ToString();
            textBox3.Text = textBox2.Text;
            textBox5.Text = textBox3.Text;
            }
            catch { }
            SaveFlag = 1;
        }

        private void textBoxSave(object sender, EventArgs e)
        {
            SaveFlag = 1;
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            SelectBanking.PhysIznos[1] = comboBox1.SelectedValue.ToString();
            SelectBanking.PhysIznos[2] = comboBox2.SelectedValue.ToString();

            SelectBanking.Method[1] = textBox3.Text;
            SelectBanking.Method[2] = comboBox3.SelectedValue.ToString();
            SelectBanking.Method[3] = textBox4.Text;
            SelectBanking.Method[4] = textBox5.Text;

            SelectBanking.OXZ[8] = SelectBanking.Method[4];
            SelectBanking.OXZ[9] = SelectBanking.Method[2];

            ////Общая характеристика здания
            queriesTableAdapter1.ОбщаяХаркаЗдания_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.OXZ[1]), Convert.ToInt32(SelectBanking.OXZ[2]), Convert.ToInt32(SelectBanking.OXZ[3]), Convert.ToInt32(SelectBanking.OXZ[4]), Convert.ToInt32(SelectBanking.OXZ[5]), Convert.ToInt32(SelectBanking.OXZ[6]), Convert.ToInt32(SelectBanking.OXZ[7]), Convert.ToInt32(SelectBanking.OXZ[9]), Convert.ToInt32(SelectBanking.OXZ[10]), Convert.ToInt32(SelectBanking.OXZ[11]), Convert.ToInt32(SelectBanking.OXZ[12]), Convert.ToInt32(SelectBanking.OXZ[13]), Convert.ToInt32(SelectBanking.OXZ[14]), Convert.ToInt32(SelectBanking.OXZ[15]), Convert.ToInt32(SelectBanking.OXZ[16]), Convert.ToInt32(SelectBanking.OXZ[17]), SelectBanking.OXZ[8], SelectBanking.OXZ[18], Convert.ToInt32(SelectBanking.OXZ[0]));

            queriesTableAdapter1.РасчетФизИзноса_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.PhysIznos[1]), Convert.ToInt32(SelectBanking.PhysIznos[2]), Convert.ToInt32(SelectBanking.PhysIznos[3]), Convert.ToInt32(SelectBanking.PhysIznos[0]));


                queriesTableAdapter1.МетодыРасчета_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Method[1]), Convert.ToInt32(SelectBanking.Method[2]), Convert.ToInt32(SelectBanking.Method[3]), Convert.ToInt32(SelectBanking.Method[4]), Convert.ToInt32(SelectBanking.Method[0]));


                }

        private void comboBoxSave(object sender, EventArgs e)
        {
            SaveFlag = 1;
        }

        private void WearCalculation_FormClosing(object sender, FormClosingEventArgs e)
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
                    SelectBanking.PhysIznos[1] = comboBox1.SelectedValue.ToString();
                    SelectBanking.PhysIznos[2] = comboBox2.SelectedValue.ToString();

                    SelectBanking.Method[1] = textBox3.Text;
                    SelectBanking.Method[2] = comboBox3.SelectedValue.ToString();
                    SelectBanking.Method[3] = textBox4.Text;
                    SelectBanking.Method[4] = textBox5.Text;

                    SelectBanking.OXZ[8] = SelectBanking.Method[4];
                    SelectBanking.OXZ[9] = SelectBanking.Method[2];

                try
                {
                    ////Общая характеристика здания
                    queriesTableAdapter1.ОбщаяХаркаЗдания_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.OXZ[1]), Convert.ToInt32(SelectBanking.OXZ[2]), Convert.ToInt32(SelectBanking.OXZ[3]), Convert.ToInt32(SelectBanking.OXZ[4]), Convert.ToInt32(SelectBanking.OXZ[5]), Convert.ToInt32(SelectBanking.OXZ[6]), Convert.ToInt32(SelectBanking.OXZ[7]), Convert.ToInt32(SelectBanking.OXZ[9]), Convert.ToInt32(SelectBanking.OXZ[10]), Convert.ToInt32(SelectBanking.OXZ[11]), Convert.ToInt32(SelectBanking.OXZ[12]), Convert.ToInt32(SelectBanking.OXZ[13]), Convert.ToInt32(SelectBanking.OXZ[14]), Convert.ToInt32(SelectBanking.OXZ[15]), Convert.ToInt32(SelectBanking.OXZ[16]), Convert.ToInt32(SelectBanking.OXZ[17]), SelectBanking.OXZ[8], SelectBanking.OXZ[18], Convert.ToInt32(SelectBanking.OXZ[0]));
                }
                    catch { }
                try
                {
                    queriesTableAdapter1.РасчетФизИзноса_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.PhysIznos[1]), Convert.ToInt32(SelectBanking.PhysIznos[2]), Convert.ToInt32(SelectBanking.PhysIznos[3]), Convert.ToInt32(SelectBanking.PhysIznos[0]));
                }
                    catch { }
                try
                {

                    queriesTableAdapter1.МетодыРасчета_ИЗМЕНИТЬ(Convert.ToInt32(SelectBanking.Method[1]), Convert.ToInt32(SelectBanking.Method[2]), Convert.ToInt32(SelectBanking.Method[3]), Convert.ToInt32(SelectBanking.Method[4]), Convert.ToInt32(SelectBanking.Method[0]));
                }
                    catch { }

                }
            }
                }
    }
}
