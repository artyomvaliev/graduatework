using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace graduatework.Forms
{

    public partial class MainObject : Form
    {
        public int SaveFlag;
        public MainObject()
        {
            InitializeComponent();
        }

        private void MainObject_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПОценкеПодлежит". При необходимости она может быть перемещена или удалена.
            this.пОценкеПодлежитTableAdapter.Fill(this.graduatedbDataSet.ПОценкеПодлежит);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "graduatedbDataSet.ПТипПомещения". При необходимости она может быть перемещена или удалена.
            this.пТипПомещенияTableAdapter.Fill(this.graduatedbDataSet.ПТипПомещения);

            textBox29.Text = SelectBanking.ObjectOtsenki[1];
            textBox28.Text =SelectBanking.ObjectOtsenki[2];
            textBox27.Text = SelectBanking.ObjectOtsenki[3];
            textBox30.Text = SelectBanking.ObjectOtsenki[4];
            comboBox46.SelectedValue = Convert.ToInt32(SelectBanking.ObjectOtsenki[5]);
            textBox31.Text = SelectBanking.ObjectOtsenki[6];
            textBox32.Text = SelectBanking.ObjectOtsenki[7];
            textBox33.Text = SelectBanking.ObjectOtsenki[9];
            comboBox47.SelectedValue = Convert.ToInt32(SelectBanking.ObjectOtsenki[8]); 
            SaveFlag = 0;
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;
           
        }

        private void comboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;
         
        }

        private void rjButton1_Click(object sender, EventArgs e)
        { 

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;
            
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;
            
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;
            
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;
            
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;
   
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;

        }

        private void comboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveFlag = 1;

        }

        private void MainObject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveFlag == 1)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    SelectBanking.ObjectOtsenki[2] = textBox28.Text;
                    SelectBanking.ObjectOtsenki[5] = comboBox46.SelectedValue.ToString();
                    SelectBanking.ObjectOtsenki[1] = textBox29.Text;
                    SelectBanking.ObjectOtsenki[3] = textBox27.Text;
                    SelectBanking.ObjectOtsenki[4] = textBox30.Text;
                    SelectBanking.ObjectOtsenki[6] = textBox31.Text;
                    SelectBanking.ObjectOtsenki[7] = textBox32.Text;
                    SelectBanking.ObjectOtsenki[9] = textBox33.Text;
                    SelectBanking.ObjectOtsenki[8] = comboBox47.SelectedValue.ToString();

                try
                {
                    queriesTableAdapter1.ОбъектОценки_ИЗМЕНИТЬ(SelectBanking.ObjectOtsenki[1], SelectBanking.ObjectOtsenki[2], SelectBanking.ObjectOtsenki[3], SelectBanking.ObjectOtsenki[4], Convert.ToInt32(SelectBanking.ObjectOtsenki[5]), SelectBanking.ObjectOtsenki[6], SelectBanking.ObjectOtsenki[7], Convert.ToInt32(SelectBanking.ObjectOtsenki[8]), SelectBanking.ObjectOtsenki[9], Convert.ToInt32(SelectBanking.ObjectOtsenki[0]));
                }
                    catch { }

                    SaveFlag = 0;
                }
            }
         }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            string oldnumber = textBox33.Text;
            openFileDialog1.Filter = "XML Files(*.XML)|*.XML";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(openFileDialog1.FileName);
                    XmlElement xRoot = xml.DocumentElement;
                    if (xRoot != null)
                    {
                        foreach (XmlElement xnode in xRoot)
                        {
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                    XmlNode attr = childnode.Attributes.GetNamedItem("CadastralNumber");
                                    textBox33.Text = attr?.Value;
                                    if (textBox33.Text != null || textBox33.Text != "")
                                    break; // get out of the loop
                            }
                            if (textBox33.Text != null || textBox33.Text != "")
                            break; // get out of the loop
                        }
                        if (textBox33.Text == null || textBox33.Text == "")
                        {
                            textBox33.Text = oldnumber;
                            MessageBox.Show("Кадастровый (условный) номер не был получен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch { MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
