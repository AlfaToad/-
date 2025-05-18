using System;
using System.Windows.Forms;

namespace Программа_для_взлома_шифра_Цезаря
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            CenterToScreen();
            FormBorderStyle = FormBorderStyle.None;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }
    }
}
