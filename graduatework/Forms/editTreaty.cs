using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yt_DesignUI.Components;
using yt_DesignUI.Controls;
using yt_DesignUI;
namespace graduatework.Forms
{
    public partial class editTreaty : Form
    {
        Point last;
        bool _Rc;
        public bool Rc { get { return _Rc; } }
        public string NT
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public DateTime DT
        {
            get { return Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()); }
            set { dateTimePicker1.Value = value; }
        }
        public editTreaty()
        {
            InitializeComponent();
            _Rc = false;
            Animator.Start();

        }



        private void ButtonNext_Click(object sender, EventArgs e)
        {
            _Rc = true;
            Close();
        }

        private void yt_Button1_Click_1(object sender, EventArgs e)
        {
            _Rc = false;
            Close();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
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
    }
}
