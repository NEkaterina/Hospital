namespace Hospital.Action
{
    partial class Priem
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
            this.datePriem = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboClientF = new System.Windows.Forms.ComboBox();
            this.comboClientI = new System.Windows.Forms.ComboBox();
            this.comboClientO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboDoctorF = new System.Windows.Forms.ComboBox();
            this.comboDoctorI = new System.Windows.Forms.ComboBox();
            this.comboDoctorO = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedKab = new System.Windows.Forms.MaskedTextBox();
            this.butZapis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePriem
            // 
            this.datePriem.CustomFormat = "yyyy-MM-dd";
            this.datePriem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePriem.Location = new System.Drawing.Point(74, 12);
            this.datePriem.Name = "datePriem";
            this.datePriem.Size = new System.Drawing.Size(94, 20);
            this.datePriem.TabIndex = 0;
            this.datePriem.Value = new System.DateTime(2017, 5, 27, 0, 0, 0, 0);
            this.datePriem.ValueChanged += new System.EventHandler(this.datePriem_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // comboClientF
            // 
            this.comboClientF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientF.FormattingEnabled = true;
            this.comboClientF.Location = new System.Drawing.Point(6, 46);
            this.comboClientF.Name = "comboClientF";
            this.comboClientF.Size = new System.Drawing.Size(111, 21);
            this.comboClientF.TabIndex = 5;
            this.comboClientF.SelectedIndexChanged += new System.EventHandler(this.comboClientF_SelectedIndexChanged);
            // 
            // comboClientI
            // 
            this.comboClientI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientI.FormattingEnabled = true;
            this.comboClientI.Location = new System.Drawing.Point(123, 46);
            this.comboClientI.Name = "comboClientI";
            this.comboClientI.Size = new System.Drawing.Size(111, 21);
            this.comboClientI.TabIndex = 6;
            this.comboClientI.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboClientO
            // 
            this.comboClientO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientO.FormattingEnabled = true;
            this.comboClientO.Location = new System.Drawing.Point(242, 46);
            this.comboClientO.Name = "comboClientO";
            this.comboClientO.Size = new System.Drawing.Size(111, 21);
            this.comboClientO.TabIndex = 7;
            this.comboClientO.SelectedIndexChanged += new System.EventHandler(this.comboClientO_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Отчество";
            // 
            // comboDoctorF
            // 
            this.comboDoctorF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDoctorF.FormattingEnabled = true;
            this.comboDoctorF.Location = new System.Drawing.Point(6, 50);
            this.comboDoctorF.Name = "comboDoctorF";
            this.comboDoctorF.Size = new System.Drawing.Size(111, 21);
            this.comboDoctorF.TabIndex = 11;
            this.comboDoctorF.SelectedIndexChanged += new System.EventHandler(this.comboDoctorF_SelectedIndexChanged);
            // 
            // comboDoctorI
            // 
            this.comboDoctorI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDoctorI.FormattingEnabled = true;
            this.comboDoctorI.Location = new System.Drawing.Point(123, 50);
            this.comboDoctorI.Name = "comboDoctorI";
            this.comboDoctorI.Size = new System.Drawing.Size(111, 21);
            this.comboDoctorI.TabIndex = 12;
            this.comboDoctorI.SelectedIndexChanged += new System.EventHandler(this.comboDoctorI_SelectedIndexChanged);
            // 
            // comboDoctorO
            // 
            this.comboDoctorO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDoctorO.FormattingEnabled = true;
            this.comboDoctorO.Location = new System.Drawing.Point(242, 50);
            this.comboDoctorO.Name = "comboDoctorO";
            this.comboDoctorO.Size = new System.Drawing.Size(111, 21);
            this.comboDoctorO.TabIndex = 13;
            this.comboDoctorO.SelectedIndexChanged += new System.EventHandler(this.comboDoctorO_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Кабинет";
            // 
            // comboService
            // 
            this.comboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(86, 291);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(122, 21);
            this.comboService.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Услуга";
            // 
            // maskedKab
            // 
            this.maskedKab.Location = new System.Drawing.Point(86, 233);
            this.maskedKab.Mask = "000";
            this.maskedKab.Name = "maskedKab";
            this.maskedKab.Size = new System.Drawing.Size(43, 20);
            this.maskedKab.TabIndex = 17;
            // 
            // butZapis
            // 
            this.butZapis.Location = new System.Drawing.Point(279, 258);
            this.butZapis.Name = "butZapis";
            this.butZapis.Size = new System.Drawing.Size(75, 23);
            this.butZapis.TabIndex = 18;
            this.butZapis.Text = "Записаться";
            this.butZapis.UseVisualStyleBackColor = true;
            this.butZapis.Click += new System.EventHandler(this.butZapis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboClientF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboClientO);
            this.groupBox1.Controls.Add(this.comboClientI);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 82);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пациент";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboDoctorF);
            this.groupBox2.Controls.Add(this.comboDoctorI);
            this.groupBox2.Controls.Add(this.comboDoctorO);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 88);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Доктор";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(187, 12);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBox1.TabIndex = 21;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Специализация";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 265);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Priem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 345);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.butZapis);
            this.Controls.Add(this.maskedKab);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboService);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datePriem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Priem";
            this.Text = "Запись на прием";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePriem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboClientF;
        private System.Windows.Forms.ComboBox comboClientI;
        private System.Windows.Forms.ComboBox comboClientO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboDoctorF;
        private System.Windows.Forms.ComboBox comboDoctorI;
        private System.Windows.Forms.ComboBox comboDoctorO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedKab;
        private System.Windows.Forms.Button butZapis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}