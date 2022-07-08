using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graduatework
{
    public partial class MainForm : Form
    {
        Point last;
        public MainForm()
        {
            InitializeComponent();

           
        }
        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point cur = MousePosition;
                int dx = cur.X - last.X;
                int dy = cur.Y - last.Y;
                Point loc = new Point(Location.X + dx, Location.Y + dy);
                Location = loc;
                last = cur;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            button7_Click(sender, e);
            
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel7.Controls.Add(childForm);
            panel7.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new graduatework.Forms.MainObject());

            label1.Text = "ОБЪЕКТ ОЦЕНКИ";
        }

        private void pnlExit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new graduatework.Forms.Logbook());

            label1.Text = "ОПИСАНИЕ ФОРМУЛЯР";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new graduatework.Forms.Treaty());

            label1.Text = "ДОГОВОР";
        }
        public void btnVisible(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new graduatework.Forms.WearCalculation());
            label1.Text = "РАСЧЕТ ИЗНОСА";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new graduatework.Forms.Comparative());
            label1.Text = "СРАВНЕНИЕ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new graduatework.Forms.EvaluationTask());
            label1.Text = "ЗАДАНИЕ НА ОЦЕНКУ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new graduatework.Forms.ExportForm());
            label1.Text = "ЭКСПОРТ";
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
