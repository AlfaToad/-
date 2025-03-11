using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Программа_для_взлома_шифра_Цезаря
{
    public partial class MainForm : Form
    {
        private Controller controller;
        public MainForm()
        {
            InitializeComponent();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            controller = new Controller();
            BindControls();
        }

        private void BindControls()
        {
            this.Type_of_operation_comboBox.SelectedIndex = controller.Mode == Mode.Decrypt ? 0 : 1;
            this.input_textBox.Text = controller.InputText;
            this.output_textBox.Text = controller.OutputText;
        }

        private void input_textBox_TextChanged(object sender, EventArgs e)
        {
            controller.InputText = this.input_textBox.Text;
            BindControls();
        }

        private void Type_of_operation_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.SetMode(Type_of_operation_comboBox.SelectedIndex == 1 ? Mode.Encrypt : Mode.Decrypt);
            BindControls();
        }

        private void key_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            controller.SetKey(Convert.ToInt32(key_numericUpDown.Value));
            BindControls();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            controller.Do();
            BindControls();
        }

        private void Open_File_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog.FileName;                          // получаем выбранный файл
            string fileText = System.IO.File.ReadAllText(filename);             // читаем файл в строку
            controller.ReadFromFile(fileText);
            BindControls();
        }
    }
}
