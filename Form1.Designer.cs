namespace ADO.NET_HW_2
{
    partial class Form1
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
            this.lstBoxFruits = new System.Windows.Forms.ListBox();
            this.lstBox_Vegetables = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBox_Tasks = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_ValueInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TaskText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Result = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_SecondValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxFruits
            // 
            this.lstBoxFruits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxFruits.FormattingEnabled = true;
            this.lstBoxFruits.ItemHeight = 16;
            this.lstBoxFruits.Location = new System.Drawing.Point(12, 55);
            this.lstBoxFruits.Name = "lstBoxFruits";
            this.lstBoxFruits.Size = new System.Drawing.Size(380, 164);
            this.lstBoxFruits.TabIndex = 0;
            // 
            // lstBox_Vegetables
            // 
            this.lstBox_Vegetables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBox_Vegetables.FormattingEnabled = true;
            this.lstBox_Vegetables.ItemHeight = 16;
            this.lstBox_Vegetables.Location = new System.Drawing.Point(447, 55);
            this.lstBox_Vegetables.Name = "lstBox_Vegetables";
            this.lstBox_Vegetables.Size = new System.Drawing.Size(385, 164);
            this.lstBox_Vegetables.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фрукты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(443, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Овощи";
            // 
            // cmbBox_Tasks
            // 
            this.cmbBox_Tasks.FormattingEnabled = true;
            this.cmbBox_Tasks.Location = new System.Drawing.Point(12, 270);
            this.cmbBox_Tasks.Name = "cmbBox_Tasks";
            this.cmbBox_Tasks.Size = new System.Drawing.Size(163, 24);
            this.cmbBox_Tasks.TabIndex = 4;
            this.cmbBox_Tasks.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Tasks_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите задание";
            // 
            // txtBox_ValueInput
            // 
            this.txtBox_ValueInput.Location = new System.Drawing.Point(447, 272);
            this.txtBox_ValueInput.Name = "txtBox_ValueInput";
            this.txtBox_ValueInput.Size = new System.Drawing.Size(210, 22);
            this.txtBox_ValueInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(273, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите значение 1";
            // 
            // textBox_TaskText
            // 
            this.textBox_TaskText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_TaskText.Location = new System.Drawing.Point(12, 348);
            this.textBox_TaskText.Multiline = true;
            this.textBox_TaskText.Name = "textBox_TaskText";
            this.textBox_TaskText.Size = new System.Drawing.Size(243, 98);
            this.textBox_TaskText.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Задание";
            // 
            // txtBox_Result
            // 
            this.txtBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_Result.ForeColor = System.Drawing.Color.Blue;
            this.txtBox_Result.Location = new System.Drawing.Point(447, 328);
            this.txtBox_Result.Name = "txtBox_Result";
            this.txtBox_Result.Size = new System.Drawing.Size(131, 45);
            this.txtBox_Result.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(350, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Результат";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(273, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Введите значение 2";
            // 
            // txtBox_SecondValue
            // 
            this.txtBox_SecondValue.Location = new System.Drawing.Point(447, 300);
            this.txtBox_SecondValue.Name = "txtBox_SecondValue";
            this.txtBox_SecondValue.Size = new System.Drawing.Size(210, 22);
            this.txtBox_SecondValue.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(287, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "Показать результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBox_SecondValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox_Result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_TaskText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_ValueInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBox_Tasks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBox_Vegetables);
            this.Controls.Add(this.lstBoxFruits);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxFruits;
        private System.Windows.Forms.ListBox lstBox_Vegetables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBox_Tasks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_ValueInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TaskText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_Result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_SecondValue;
        private System.Windows.Forms.Button button1;
    }
}

