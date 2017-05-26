namespace Hospital.Edit
{
    partial class EditDoctor
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
            this.textBemail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBsex = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.butCanel = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.textBpost = new System.Windows.Forms.TextBox();
            this.maskedOklad = new System.Windows.Forms.MaskedTextBox();
            this.maskedPhone = new System.Windows.Forms.MaskedTextBox();
            this.maskedSer = new System.Windows.Forms.MaskedTextBox();
            this.maskedNum = new System.Windows.Forms.MaskedTextBox();
            this.textBotch = new System.Windows.Forms.TextBox();
            this.textBname = new System.Windows.Forms.TextBox();
            this.textBsur = new System.Windows.Forms.TextBox();
            this.comboSpecialty = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBemail
            // 
            this.textBemail.Location = new System.Drawing.Point(265, 112);
            this.textBemail.Name = "textBemail";
            this.textBemail.Size = new System.Drawing.Size(100, 20);
            this.textBemail.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(270, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Email";
            // 
            // comboBsex
            // 
            this.comboBsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBsex.FormattingEnabled = true;
            this.comboBsex.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBsex.Location = new System.Drawing.Point(265, 57);
            this.comboBsex.Name = "comboBsex";
            this.comboBsex.Size = new System.Drawing.Size(89, 21);
            this.comboBsex.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Пол";
            // 
            // dateBirth
            // 
            this.dateBirth.CustomFormat = "yyyy-MM-dd";
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirth.Location = new System.Drawing.Point(144, 120);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(100, 20);
            this.dateBirth.TabIndex = 49;
            this.dateBirth.Value = new System.DateTime(2017, 5, 25, 0, 0, 0, 0);
            // 
            // butCanel
            // 
            this.butCanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCanel.Location = new System.Drawing.Point(279, 175);
            this.butCanel.Name = "butCanel";
            this.butCanel.Size = new System.Drawing.Size(75, 23);
            this.butCanel.TabIndex = 48;
            this.butCanel.Text = "Отмена";
            this.butCanel.UseVisualStyleBackColor = true;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(279, 146);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 47;
            this.butOk.Text = "Ок";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // textBpost
            // 
            this.textBpost.Location = new System.Drawing.Point(144, 243);
            this.textBpost.Name = "textBpost";
            this.textBpost.Size = new System.Drawing.Size(100, 20);
            this.textBpost.TabIndex = 46;
            // 
            // maskedOklad
            // 
            this.maskedOklad.Location = new System.Drawing.Point(144, 267);
            this.maskedOklad.Mask = "000000";
            this.maskedOklad.Name = "maskedOklad";
            this.maskedOklad.Size = new System.Drawing.Size(100, 20);
            this.maskedOklad.TabIndex = 45;
            // 
            // maskedPhone
            // 
            this.maskedPhone.Location = new System.Drawing.Point(144, 194);
            this.maskedPhone.Mask = "000000000000000";
            this.maskedPhone.Name = "maskedPhone";
            this.maskedPhone.Size = new System.Drawing.Size(100, 20);
            this.maskedPhone.TabIndex = 44;
            // 
            // maskedSer
            // 
            this.maskedSer.Location = new System.Drawing.Point(144, 143);
            this.maskedSer.Mask = "00000";
            this.maskedSer.Name = "maskedSer";
            this.maskedSer.Size = new System.Drawing.Size(100, 20);
            this.maskedSer.TabIndex = 43;
            // 
            // maskedNum
            // 
            this.maskedNum.Location = new System.Drawing.Point(144, 169);
            this.maskedNum.Mask = "00000000";
            this.maskedNum.Name = "maskedNum";
            this.maskedNum.Size = new System.Drawing.Size(100, 20);
            this.maskedNum.TabIndex = 42;
            // 
            // textBotch
            // 
            this.textBotch.Location = new System.Drawing.Point(144, 92);
            this.textBotch.Name = "textBotch";
            this.textBotch.Size = new System.Drawing.Size(100, 20);
            this.textBotch.TabIndex = 41;
            // 
            // textBname
            // 
            this.textBname.Location = new System.Drawing.Point(144, 67);
            this.textBname.Name = "textBname";
            this.textBname.Size = new System.Drawing.Size(100, 20);
            this.textBname.TabIndex = 40;
            // 
            // textBsur
            // 
            this.textBsur.Location = new System.Drawing.Point(144, 41);
            this.textBsur.Name = "textBsur";
            this.textBsur.Size = new System.Drawing.Size(100, 20);
            this.textBsur.TabIndex = 39;
            // 
            // comboSpecialty
            // 
            this.comboSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpecialty.FormattingEnabled = true;
            this.comboSpecialty.Location = new System.Drawing.Point(144, 218);
            this.comboSpecialty.Name = "comboSpecialty";
            this.comboSpecialty.Size = new System.Drawing.Size(121, 21);
            this.comboSpecialty.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Оклад";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Должность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Специализация";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Номер телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Номер паспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Серия пасорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Фамилия";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(25, 16);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(34, 20);
            this.id.TabIndex = 54;
            // 
            // EditDoctor
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCanel;
            this.ClientSize = new System.Drawing.Size(395, 328);
            this.ControlBox = false;
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBemail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBsex);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.butCanel);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.textBpost);
            this.Controls.Add(this.maskedOklad);
            this.Controls.Add(this.maskedPhone);
            this.Controls.Add(this.maskedSer);
            this.Controls.Add(this.maskedNum);
            this.Controls.Add(this.textBotch);
            this.Controls.Add(this.textBname);
            this.Controls.Add(this.textBsur);
            this.Controls.Add(this.comboSpecialty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditDoctor";
            this.Text = "EditDoctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butCanel;
        private System.Windows.Forms.Button butOk;
        public System.Windows.Forms.ComboBox comboSpecialty;
        public System.Windows.Forms.TextBox textBemail;
        public System.Windows.Forms.ComboBox comboBsex;
        public System.Windows.Forms.DateTimePicker dateBirth;
        public System.Windows.Forms.TextBox textBpost;
        public System.Windows.Forms.MaskedTextBox maskedOklad;
        public System.Windows.Forms.MaskedTextBox maskedPhone;
        public System.Windows.Forms.MaskedTextBox maskedSer;
        public System.Windows.Forms.MaskedTextBox maskedNum;
        public System.Windows.Forms.TextBox textBotch;
        public System.Windows.Forms.TextBox textBname;
        public System.Windows.Forms.TextBox textBsur;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox id;
    }
}