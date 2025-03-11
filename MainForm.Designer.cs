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
            this.input_label = new System.Windows.Forms.Label();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.key_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.key_label = new System.Windows.Forms.Label();
            this.Type_of_operation_comboBox = new System.Windows.Forms.ComboBox();
            this.Type_of_operation_label = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.output_textBox = new System.Windows.Forms.TextBox();
            this.output_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.key_numericUpDown)).BeginInit();
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
            this.input_textBox.Location = new System.Drawing.Point(13, 30);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(775, 155);
            this.input_textBox.TabIndex = 1;
            this.input_textBox.TextChanged += new System.EventHandler(this.input_textBox_TextChanged);
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
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Location = new System.Drawing.Point(13, 192);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(36, 13);
            this.key_label.TabIndex = 3;
            this.key_label.Text = "Ключ:";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output_textBox);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.Type_of_operation_label);
            this.Controls.Add(this.Type_of_operation_comboBox);
            this.Controls.Add(this.key_label);
            this.Controls.Add(this.key_numericUpDown);
            this.Controls.Add(this.input_textBox);
            this.Controls.Add(this.input_label);
            this.Name = "MainForm";
            this.Text = "Программа для взлома шифра Цезаря";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.key_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.NumericUpDown key_numericUpDown;
        private System.Windows.Forms.Label key_label;
        private System.Windows.Forms.ComboBox Type_of_operation_comboBox;
        private System.Windows.Forms.Label Type_of_operation_label;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TextBox output_textBox;
        private System.Windows.Forms.Label output_label;
    }
}

