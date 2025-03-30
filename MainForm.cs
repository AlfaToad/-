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
            controller.LoadDictionary();
            BindControls();
        }

        private void BindControls()
        {
            this.key_numericUpDown.Value = controller.Key;
            this.Type_of_operation_comboBox.SelectedIndex = controller.Mode == Mode.Decrypt ? 0 : 1;
            this.progressBar.Value = 0;
            this.progressBar.Visible = false;
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
            if (this.Type_of_operation_comboBox.SelectedIndex == 1) { key_numericUpDown.Enabled = true; key_numericUpDown.Value = 0; }  //added key_numericUpDown.Value = 0;
            else { key_numericUpDown.Enabled = false; key_numericUpDown.Value = 0; };
            BindControls();
        }

        private void key_numericUpDown_ValueChanged(object sender, EventArgs e)
        {

            int key = Convert.ToInt32(key_numericUpDown.Value);
            if (controller.Key != key)
                controller.SetKey(key);
            BindControls();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true; //added progressBar.Visible = true;
            progressBar.Value = 0;
            if (Type_of_operation_comboBox.Text == "Дешифровать")
            { progressBar.Maximum = 33; }
            else { progressBar.Maximum = input_textBox.Text.Length; }
            controller.Do((progress) => { progressBar.Value = progress; });
            BindControls();
        }

        private void Open_File_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog.FileName;      // получаем выбранный файл
            string fileText = File.ReadAllText(filename);   // читаем файл в строку
            controller.ReadFromFile(fileText);
            BindControls();
        }

        private void Save_File_button_Click(object sender, EventArgs e) //added Save_File_button_Click
        {
            string save_file_name = string.Join(" ", input_textBox.Text.Split().Take(1)) + "_"
                + Type_of_operation_comboBox.Text + "_key=" + key_numericUpDown.Value + ".txt";
            if (output_textBox.Text == string.Empty) { save_file_name = string.Empty; }
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = save_file_name;


            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;          // получаем выбранный файл
            File.WriteAllText(filename, output_textBox.Text);   // сохраняем текст в файл
        }
    }
}
