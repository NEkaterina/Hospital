namespace Hospital
{
    partial class EditClient
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
            this.butOk = new System.Windows.Forms.Button();
            this.mPolicy = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mPhone = new System.Windows.Forms.MaskedTextBox();
            this.mApartment = new System.Windows.Forms.MaskedTextBox();
            this.mHouse = new System.Windows.Forms.MaskedTextBox();
            this.mNumber = new System.Windows.Forms.MaskedTextBox();
            this.mSeries = new System.Windows.Forms.MaskedTextBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tStreet = new System.Windows.Forms.TextBox();
            this.tCity = new System.Windows.Forms.TextBox();
            this.tOtchestvo = new System.Windows.Forms.TextBox();
            this.tFirstname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(250, 293);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 57;
            this.butOk.Text = "Ок";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // mPolicy
            // 
            this.mPolicy.Location = new System.Drawing.Point(22, 319);
            this.mPolicy.Mask = "00000000000000000000";
            this.mPolicy.Name = "mPolicy";
            this.mPolicy.Size = new System.Drawing.Size(100, 20);
            this.mPolicy.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Полис";
            // 
            // mPhone
            // 
            this.mPhone.Location = new System.Drawing.Point(237, 184);
            this.mPhone.Mask = "000000000000000";
            this.mPhone.Name = "mPhone";
            this.mPhone.Size = new System.Drawing.Size(100, 20);
            this.mPhone.TabIndex = 54;
            // 
            // mApartment
            // 
            this.mApartment.Location = new System.Drawing.Point(238, 139);
            this.mApartment.Mask = "0000";
            this.mApartment.Name = "mApartment";
            this.mApartment.Size = new System.Drawing.Size(100, 20);
            this.mApartment.TabIndex = 53;
            // 
            // mHouse
            // 
            this.mHouse.Location = new System.Drawing.Point(237, 99);
            this.mHouse.Mask = "0000";
            this.mHouse.Name = "mHouse";
            this.mHouse.Size = new System.Drawing.Size(100, 20);
            this.mHouse.TabIndex = 52;
            // 
            // mNumber
            // 
            this.mNumber.Location = new System.Drawing.Point(22, 280);
            this.mNumber.Mask = "00000000";
            this.mNumber.Name = "mNumber";
            this.mNumber.Size = new System.Drawing.Size(100, 20);
            this.mNumber.TabIndex = 51;
            // 
            // mSeries
            // 
            this.mSeries.Location = new System.Drawing.Point(22, 242);
            this.mSeries.Mask = "00000";
            this.mSeries.Name = "mSeries";
            this.mSeries.Size = new System.Drawing.Size(100, 20);
            this.mSeries.TabIndex = 50;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirth.Location = new System.Drawing.Point(22, 203);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dateOfBirth.TabIndex = 49;
            this.dateOfBirth.Value = new System.DateTime(2017, 5, 22, 0, 0, 0, 0);
            // 
            // comboSex
            // 
            this.comboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSex.FormattingEnabled = true;
            this.comboSex.Location = new System.Drawing.Point(22, 160);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(99, 21);
            this.comboSex.TabIndex = 48;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(237, 226);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(99, 20);
            this.tEmail.TabIndex = 47;
            // 
            // tStreet
            // 
            this.tStreet.Location = new System.Drawing.Point(238, 60);
            this.tStreet.Name = "tStreet";
            this.tStreet.Size = new System.Drawing.Size(99, 20);
            this.tStreet.TabIndex = 46;
            // 
            // tCity
            // 
            this.tCity.Location = new System.Drawing.Point(238, 21);
            this.tCity.Name = "tCity";
            this.tCity.Size = new System.Drawing.Size(99, 20);
            this.tCity.TabIndex = 45;
            // 
            // tOtchestvo
            // 
            this.tOtchestvo.Location = new System.Drawing.Point(22, 116);
            this.tOtchestvo.Name = "tOtchestvo";
            this.tOtchestvo.Size = new System.Drawing.Size(99, 20);
            this.tOtchestvo.TabIndex = 44;
            // 
            // tFirstname
            // 
            this.tFirstname.Location = new System.Drawing.Point(22, 70);
            this.tFirstname.Name = "tFirstname";
            this.tFirstname.Size = new System.Drawing.Size(99, 20);
            this.tFirstname.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(235, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "E-mail";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Телефон";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Квартира";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Дом";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Улица";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Город";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Номер паспорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Серия паспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Пол";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Имя";
            // 
            // tSurname
            // 
            this.tSurname.Location = new System.Drawing.Point(22, 21);
            this.tSurname.Name = "tSurname";
            this.tSurname.Size = new System.Drawing.Size(99, 20);
            this.tSurname.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Фамилия";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(158, 37);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(36, 20);
            this.id.TabIndex = 58;
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 363);
            this.Controls.Add(this.id);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.mPolicy);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mPhone);
            this.Controls.Add(this.mApartment);
            this.Controls.Add(this.mHouse);
            this.Controls.Add(this.mNumber);
            this.Controls.Add(this.mSeries);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.comboSex);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tStreet);
            this.Controls.Add(this.tCity);
            this.Controls.Add(this.tOtchestvo);
            this.Controls.Add(this.tFirstname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tSurname);
            this.Controls.Add(this.label1);
            this.Name = "EditClient";
            this.Text = "Редактирование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditClient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button butOk;
        public System.Windows.Forms.MaskedTextBox mPolicy;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.MaskedTextBox mPhone;
        public System.Windows.Forms.MaskedTextBox mApartment;
        public System.Windows.Forms.MaskedTextBox mHouse;
        public System.Windows.Forms.MaskedTextBox mNumber;
        public System.Windows.Forms.MaskedTextBox mSeries;
        public System.Windows.Forms.DateTimePicker dateOfBirth;
        public System.Windows.Forms.ComboBox comboSex;
        public System.Windows.Forms.TextBox tEmail;
        public System.Windows.Forms.TextBox tStreet;
        public System.Windows.Forms.TextBox tCity;
        public System.Windows.Forms.TextBox tOtchestvo;
        public System.Windows.Forms.TextBox tFirstname;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tSurname;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox id;
    }
}