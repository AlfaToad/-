using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Программа_для_взлома_шифра_Цезаря
{
    public partial class MainForm : Form
    {
        private Controller controller;
        public MainForm()
        {
            InitializeComponent();
            openFileDialog.Filter = "txt files(*.txt)|*.txt";
            openFileDialog.FileName = String.Empty;
            saveFileDialog.Filter = "txt files(*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

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
            this.start_button.Enabled = !string.IsNullOrEmpty(controller.InputText);
            this.Clear_Input_button.Enabled = !string.IsNullOrEmpty(controller.InputText);
            this.Clear_output_button.Enabled = !string.IsNullOrEmpty(controller.OutputText);
        }

        private void input_textBox_TextChanged(object sender, EventArgs e)
        {
            controller.InputText = this.input_textBox.Text;
            BindControls();
        }

        private void Type_of_operation_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.SetMode(Type_of_operation_comboBox.SelectedIndex == 1 ? Mode.Encrypt : Mode.Decrypt);
            if (this.Type_of_operation_comboBox.SelectedIndex == 1) { key_numericUpDown.Value = 0; }
            else { key_numericUpDown.Value = 0; };
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
            progressBar.Visible = true;
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

        private void Save_File_button_Click(object sender, EventArgs e) //Сохранение результата действия 
        {
            string save_file_name = string.Join(" ", input_textBox.Text.Split().Take(1)) + "_"
                + Type_of_operation_comboBox.Text + "_key=" + key_numericUpDown.Value + ".txt";
            if (output_textBox.Text == string.Empty) { save_file_name = string.Empty; }
            saveFileDialog.FileName = save_file_name;

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;          // получаем выбранный файл
            File.WriteAllText(filename, output_textBox.Text);   // сохраняем текст в файл
        }

        private void Clear_output_button_Click(object sender, EventArgs e)
        {
            controller.ClearOutput();
            BindControls();
        }

        private void Clear_Input_button_Click(object sender, EventArgs e)
        {
            controller.ClearInput();
            BindControls();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void info_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для взлома шифра Цезаря" +
                "\nАвтор: AlfaToad" +
                "\nРуководство к использованию:" +
                "\n1.Введите текст в поле 'Исходный текст' или загрузите текст из файла" +
                "\n2.Выберите нужное вам действие" +
                "\n3.Нажмите на кнопку 'Выполнить'" +
                "\n4.Сохраните результат нажав на кнопку 'Сохранить'");
        }
    }
}
