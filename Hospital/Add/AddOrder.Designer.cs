namespace Hospital.Add
{
    partial class AddOrder
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
            this.radioNew = new System.Windows.Forms.RadioButton();
            this.radioOld = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboProvid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBname = new System.Windows.Forms.TextBox();
            this.maskedNewNum = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedNewPrice = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butNewOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butOldOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedOldNum = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboProv = new System.Windows.Forms.ComboBox();
            this.comboOldName = new System.Windows.Forms.ComboBox();
            this.maskedOldPrice = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioNew
            // 
            this.radioNew.AutoSize = true;
            this.radioNew.Location = new System.Drawing.Point(12, 12);
            this.radioNew.Name = "radioNew";
            this.radioNew.Size = new System.Drawing.Size(92, 17);
            this.radioNew.TabIndex = 0;
            this.radioNew.TabStop = true;
            this.radioNew.Text = "Новый заказ";
            this.radioNew.UseVisualStyleBackColor = true;
            this.radioNew.CheckedChanged += new System.EventHandler(this.radioNew_CheckedChanged);
            // 
            // radioOld
            // 
            this.radioOld.AutoSize = true;
            this.radioOld.Location = new System.Drawing.Point(286, 12);
            this.radioOld.Name = "radioOld";
            this.radioOld.Size = new System.Drawing.Size(74, 17);
            this.radioOld.TabIndex = 1;
            this.radioOld.TabStop = true;
            this.radioOld.Text = "Докупить";
            this.radioOld.UseVisualStyleBackColor = true;
            this.radioOld.CheckedChanged += new System.EventHandler(this.radioOld_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.butNewOk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maskedNewPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maskedNewNum);
            this.groupBox1.Controls.Add(this.textBname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboProvid);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сформировать новый заказ";
            this.groupBox1.Visible = false;
            // 
            // comboProvid
            // 
            this.comboProvid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvid.FormattingEnabled = true;
            this.comboProvid.Location = new System.Drawing.Point(109, 27);
            this.comboProvid.Name = "comboProvid";
            this.comboProvid.Size = new System.Drawing.Size(121, 21);
            this.comboProvid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поставщик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование";
            // 
            // textBname
            // 
            this.textBname.Location = new System.Drawing.Point(109, 62);
            this.textBname.Name = "textBname";
            this.textBname.Size = new System.Drawing.Size(121, 20);
            this.textBname.TabIndex = 3;
            // 
            // maskedNewNum
            // 
            this.maskedNewNum.Location = new System.Drawing.Point(109, 117);
            this.maskedNewNum.Mask = "00000";
            this.maskedNewNum.Name = "maskedNewNum";
            this.maskedNewNum.Size = new System.Drawing.Size(121, 20);
            this.maskedNewNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество";
            // 
            // maskedNewPrice
            // 
            this.maskedNewPrice.Location = new System.Drawing.Point(109, 144);
            this.maskedNewPrice.Mask = "00000";
            this.maskedNewPrice.Name = "maskedNewPrice";
            this.maskedNewPrice.Size = new System.Drawing.Size(121, 20);
            this.maskedNewPrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цена";
            // 
            // butNewOk
            // 
            this.butNewOk.Location = new System.Drawing.Point(76, 181);
            this.butNewOk.Name = "butNewOk";
            this.butNewOk.Size = new System.Drawing.Size(75, 23);
            this.butNewOk.TabIndex = 8;
            this.butNewOk.Text = "ОК";
            this.butNewOk.UseVisualStyleBackColor = true;
            this.butNewOk.Click += new System.EventHandler(this.butNewOk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedOldPrice);
            this.groupBox2.Controls.Add(this.comboOldName);
            this.groupBox2.Controls.Add(this.butOldOk);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.maskedOldNum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboProv);
            this.groupBox2.Location = new System.Drawing.Point(286, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 210);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дозаказать";
            this.groupBox2.Visible = false;
            // 
            // butOldOk
            // 
            this.butOldOk.Location = new System.Drawing.Point(97, 168);
            this.butOldOk.Name = "butOldOk";
            this.butOldOk.Size = new System.Drawing.Size(75, 23);
            this.butOldOk.TabIndex = 8;
            this.butOldOk.Text = "ОК";
            this.butOldOk.UseVisualStyleBackColor = true;
            this.butOldOk.Click += new System.EventHandler(this.butOldOk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Количество";
            // 
            // maskedOldNum
            // 
            this.maskedOldNum.Location = new System.Drawing.Point(109, 91);
            this.maskedOldNum.Mask = "00000";
            this.maskedOldNum.Name = "maskedOldNum";
            this.maskedOldNum.Size = new System.Drawing.Size(121, 20);
            this.maskedOldNum.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Наименование";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Поставщик";
            // 
            // comboProv
            // 
            this.comboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProv.FormattingEnabled = true;
            this.comboProv.Location = new System.Drawing.Point(109, 19);
            this.comboProv.Name = "comboProv";
            this.comboProv.Size = new System.Drawing.Size(121, 21);
            this.comboProv.TabIndex = 0;
            this.comboProv.SelectedIndexChanged += new System.EventHandler(this.comboProv_SelectedIndexChanged);
            // 
            // comboOldName
            // 
            this.comboOldName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOldName.FormattingEnabled = true;
            this.comboOldName.Location = new System.Drawing.Point(108, 54);
            this.comboOldName.Name = "comboOldName";
            this.comboOldName.Size = new System.Drawing.Size(121, 21);
            this.comboOldName.TabIndex = 9;
            // 
            // maskedOldPrice
            // 
            this.maskedOldPrice.Location = new System.Drawing.Point(109, 120);
            this.maskedOldPrice.Mask = "00000";
            this.maskedOldPrice.Name = "maskedOldPrice";
            this.maskedOldPrice.Size = new System.Drawing.Size(121, 20);
            this.maskedOldPrice.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Тип";
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Оборудование",
            "Расходники"});
            this.type.Location = new System.Drawing.Point(109, 90);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 21);
            this.type.TabIndex = 10;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 273);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioOld);
            this.Controls.Add(this.radioNew);
            this.Name = "AddOrder";
            this.Text = "Заказ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioNew;
        private System.Windows.Forms.RadioButton radioOld;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butNewOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedNewPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedNewNum;
        private System.Windows.Forms.TextBox textBname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboProvid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedOldPrice;
        private System.Windows.Forms.ComboBox comboOldName;
        private System.Windows.Forms.Button butOldOk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedOldNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboProv;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label9;
    }
}