namespace Программа_для_взлома_шифра_Цезаря
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.input_label = new System.Windows.Forms.Label();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.Type_of_operation_comboBox = new System.Windows.Forms.ComboBox();
            this.Type_of_operation_label = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.output_textBox = new System.Windows.Forms.TextBox();
            this.output_label = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Open_File_button = new System.Windows.Forms.Button();
            this.key_label = new System.Windows.Forms.Label();
            this.key_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Save_File_button = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Clear_Input_button = new System.Windows.Forms.Button();
            this.Clear_output_button = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.With_radioButton = new System.Windows.Forms.RadioButton();
            this.Without_radioButton = new System.Windows.Forms.RadioButton();
            this.Key_display_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.key_numericUpDown)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Location = new System.Drawing.Point(13, 13);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(92, 13);
            this.input_label.TabIndex = 0;
            this.input_label.Text = "Исходный текст:";
            // 
            // input_textBox
            // 
            this.input_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.input_textBox.Location = new System.Drawing.Point(13, 30);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input_textBox.Size = new System.Drawing.Size(775, 155);
            this.input_textBox.TabIndex = 1;
            this.input_textBox.TextChanged += new System.EventHandler(this.input_textBox_TextChanged);
            // 
            // Type_of_operation_comboBox
            // 
            this.Type_of_operation_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_of_operation_comboBox.FormattingEnabled = true;
            this.Type_of_operation_comboBox.Items.AddRange(new object[] {
            "Дешифровать",
            "Шифровать"});
            this.Type_of_operation_comboBox.Location = new System.Drawing.Point(76, 208);
            this.Type_of_operation_comboBox.Name = "Type_of_operation_comboBox";
            this.Type_of_operation_comboBox.Size = new System.Drawing.Size(95, 21);
            this.Type_of_operation_comboBox.TabIndex = 4;
            this.Type_of_operation_comboBox.SelectedIndexChanged += new System.EventHandler(this.Type_of_operation_comboBox_SelectedIndexChanged);
            // 
            // Type_of_operation_label
            // 
            this.Type_of_operation_label.AutoSize = true;
            this.Type_of_operation_label.Location = new System.Drawing.Point(76, 192);
            this.Type_of_operation_label.Name = "Type_of_operation_label";
            this.Type_of_operation_label.Size = new System.Drawing.Size(80, 13);
            this.Type_of_operation_label.TabIndex = 5;
            this.Type_of_operation_label.Text = "Тип операции:";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(12, 235);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 6;
            this.start_button.Text = "Выполнить";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // output_textBox
            // 
            this.output_textBox.Location = new System.Drawing.Point(12, 283);
            this.output_textBox.Multiline = true;
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.ReadOnly = true;
            this.output_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_textBox.Size = new System.Drawing.Size(775, 155);
            this.output_textBox.TabIndex = 8;
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Location = new System.Drawing.Point(12, 266);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(62, 13);
            this.output_label.TabIndex = 7;
            this.output_label.Text = "Результат:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Open_File_button
            // 
            this.Open_File_button.Location = new System.Drawing.Point(195, 207);
            this.Open_File_button.Name = "Open_File_button";
            this.Open_File_button.Size = new System.Drawing.Size(90, 23);
            this.Open_File_button.TabIndex = 9;
            this.Open_File_button.Text = "Открыть файл";
            this.Open_File_button.UseVisualStyleBackColor = true;
            this.Open_File_button.Click += new System.EventHandler(this.Open_File_button_Click);
            // 
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Location = new System.Drawing.Point(13, 192);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(36, 13);
            this.key_label.TabIndex = 3;
            this.key_label.Text = "Ключ:";
            // 
            // key_numericUpDown
            // 
            this.key_numericUpDown.Location = new System.Drawing.Point(13, 208);
            this.key_numericUpDown.Maximum = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.key_numericUpDown.Name = "key_numericUpDown";
            this.key_numericUpDown.Size = new System.Drawing.Size(40, 20);
            this.key_numericUpDown.TabIndex = 2;
            this.key_numericUpDown.ValueChanged += new System.EventHandler(this.key_numericUpDown_ValueChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(94, 236);
            this.progressBar.Maximum = 33;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(693, 21);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 10;
            // 
            // Save_File_button
            // 
            this.Save_File_button.Location = new System.Drawing.Point(12, 445);
            this.Save_File_button.Name = "Save_File_button";
            this.Save_File_button.Size = new System.Drawing.Size(75, 23);
            this.Save_File_button.TabIndex = 11;
            this.Save_File_button.Text = "Сохранить";
            this.Save_File_button.UseVisualStyleBackColor = true;
            this.Save_File_button.Click += new System.EventHandler(this.Save_File_button_Click);
            // 
            // Clear_Input_button
            // 
            this.Clear_Input_button.Location = new System.Drawing.Point(698, 192);
            this.Clear_Input_button.Name = "Clear_Input_button";
            this.Clear_Input_button.Size = new System.Drawing.Size(90, 23);
            this.Clear_Input_button.TabIndex = 12;
            this.Clear_Input_button.Text = "Очистить";
            this.Clear_Input_button.UseVisualStyleBackColor = true;
            this.Clear_Input_button.Click += new System.EventHandler(this.Clear_Input_button_Click);
            // 
            // Clear_output_button
            // 
            this.Clear_output_button.Location = new System.Drawing.Point(697, 446);
            this.Clear_output_button.Name = "Clear_output_button";
            this.Clear_output_button.Size = new System.Drawing.Size(90, 23);
            this.Clear_output_button.TabIndex = 13;
            this.Clear_output_button.Text = "Очистить";
            this.Clear_output_button.UseVisualStyleBackColor = true;
            this.Clear_output_button.Click += new System.EventHandler(this.Clear_output_button_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.With_radioButton);
            this.panel.Controls.Add(this.Without_radioButton);
            this.panel.Location = new System.Drawing.Point(64, 208);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(160, 23);
            this.panel.TabIndex = 14;
            this.panel.Visible = false;
            // 
            // With_radioButton
            // 
            this.With_radioButton.AutoSize = true;
            this.With_radioButton.Location = new System.Drawing.Point(3, 3);
            this.With_radioButton.Name = "With_radioButton";
            this.With_radioButton.Size = new System.Drawing.Size(74, 17);
            this.With_radioButton.TabIndex = 0;
            this.With_radioButton.Text = "С ключом";
            this.With_radioButton.UseVisualStyleBackColor = true;
            this.With_radioButton.CheckedChanged += new System.EventHandler(this.With_radioButton_CheckedChanged);
            // 
            // Without_radioButton
            // 
            this.Without_radioButton.AutoSize = true;
            this.Without_radioButton.Checked = true;
            this.Without_radioButton.Location = new System.Drawing.Point(80, 3);
            this.Without_radioButton.Name = "Without_radioButton";
            this.Without_radioButton.Size = new System.Drawing.Size(78, 17);
            this.Without_radioButton.TabIndex = 1;
            this.Without_radioButton.TabStop = true;
            this.Without_radioButton.Text = "Без ключа";
            this.Without_radioButton.UseVisualStyleBackColor = true;
            this.Without_radioButton.CheckedChanged += new System.EventHandler(this.Without_radioButton_CheckedChanged);
            // 
            // Key_display_label
            // 
            this.Key_display_label.AutoSize = true;
            this.Key_display_label.Location = new System.Drawing.Point(13, 210);
            this.Key_display_label.Name = "Key_display_label";
            this.Key_display_label.Size = new System.Drawing.Size(13, 13);
            this.Key_display_label.TabIndex = 2;
            this.Key_display_label.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.Clear_output_button);
            this.Controls.Add(this.Clear_Input_button);
            this.Controls.Add(this.Save_File_button);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Open_File_button);
            this.Controls.Add(this.output_textBox);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.Type_of_operation_label);
            this.Controls.Add(this.Type_of_operation_comboBox);
            this.Controls.Add(this.key_label);
            this.Controls.Add(this.key_numericUpDown);
            this.Controls.Add(this.input_textBox);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.Key_display_label);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 520);
            this.MinimumSize = new System.Drawing.Size(816, 520);
            this.Name = "MainForm";
            this.Text = "Программа для взлома шифра Цезаря";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.key_numericUpDown)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.ComboBox Type_of_operation_comboBox;
        private System.Windows.Forms.Label Type_of_operation_label;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TextBox output_textBox;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button Open_File_button;
        private System.Windows.Forms.Label key_label;
        internal System.Windows.Forms.NumericUpDown key_numericUpDown;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button Save_File_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button Clear_Input_button;
        private System.Windows.Forms.Button Clear_output_button;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RadioButton Without_radioButton;
        private System.Windows.Forms.RadioButton With_radioButton;
        private System.Windows.Forms.Label Key_display_label;
    }
}

