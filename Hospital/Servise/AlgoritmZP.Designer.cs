﻿namespace Hospital.Servise
{
    partial class AlgoritmZP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedPrize = new System.Windows.Forms.MaskedTextBox();
            this.maskedTime = new System.Windows.Forms.MaskedTextBox();
            this.maskedOklad = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.comboFio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateS = new System.Windows.Forms.DateTimePicker();
            this.dateF = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Премия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Время работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Оклад";
            // 
            // maskedPrize
            // 
            this.maskedPrize.Location = new System.Drawing.Point(98, 171);
            this.maskedPrize.Name = "maskedPrize";
            this.maskedPrize.Size = new System.Drawing.Size(100, 20);
            this.maskedPrize.TabIndex = 9;
            // 
            // maskedTime
            // 
            this.maskedTime.Location = new System.Drawing.Point(98, 197);
            this.maskedTime.Mask = "000";
            this.maskedTime.Name = "maskedTime";
            this.maskedTime.Size = new System.Drawing.Size(100, 20);
            this.maskedTime.TabIndex = 10;
            // 
            // maskedOklad
            // 
            this.maskedOklad.Enabled = false;
            this.maskedOklad.Location = new System.Drawing.Point(98, 223);
            this.maskedOklad.Name = "maskedOklad";
            this.maskedOklad.Size = new System.Drawing.Size(100, 20);
            this.maskedOklad.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Время";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(98, 261);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 13;
            this.butOk.Text = "Ок";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // comboFio
            // 
            this.comboFio.FormattingEnabled = true;
            this.comboFio.Location = new System.Drawing.Point(98, 144);
            this.comboFio.Name = "comboFio";
            this.comboFio.Size = new System.Drawing.Size(100, 21);
            this.comboFio.TabIndex = 14;
            this.comboFio.SelectedIndexChanged += new System.EventHandler(this.comboFio_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ФИО";
            // 
            // dateS
            // 
            this.dateS.CustomFormat = "yyyy-MM-dd";
            this.dateS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateS.Location = new System.Drawing.Point(19, 118);
            this.dateS.Name = "dateS";
            this.dateS.Size = new System.Drawing.Size(92, 20);
            this.dateS.TabIndex = 16;
            // 
            // dateF
            // 
            this.dateF.CustomFormat = "yyyy-MM-dd";
            this.dateF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateF.Location = new System.Drawing.Point(142, 118);
            this.dateF.Name = "dateF";
            this.dateF.Size = new System.Drawing.Size(91, 20);
            this.dateF.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "----";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(208, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Простая повременная оплата труда";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(229, 17);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Повременно-премиальная оплата труда";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 58);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(144, 17);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Окладная оплата труда";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 81);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(209, 17);
            this.radioButton4.TabIndex = 22;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Окладно-премиальная оплата труда";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // AlgoritmZP
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 309);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateF);
            this.Controls.Add(this.dateS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboFio);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedOklad);
            this.Controls.Add(this.maskedTime);
            this.Controls.Add(this.maskedPrize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlgoritmZP";
            this.Text = "AlgoritmZP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox maskedPrize;
        public System.Windows.Forms.MaskedTextBox maskedTime;
        public System.Windows.Forms.MaskedTextBox maskedOklad;
        public System.Windows.Forms.ComboBox comboFio;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateS;
        public System.Windows.Forms.DateTimePicker dateF;
    }
}