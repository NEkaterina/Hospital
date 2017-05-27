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
            this.label7 = new System.Windows.Forms.Label();
            this.comboService = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedKab = new System.Windows.Forms.MaskedTextBox();
            this.butZapis = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataDoctor = new System.Windows.Forms.DataGridView();
            this.dataClient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClient)).BeginInit();
            this.SuspendLayout();
            // 
            // datePriem
            // 
            this.datePriem.CustomFormat = "yyyy-MM-dd";
            this.datePriem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePriem.Location = new System.Drawing.Point(25, 12);
            this.datePriem.Name = "datePriem";
            this.datePriem.Size = new System.Drawing.Size(94, 20);
            this.datePriem.TabIndex = 0;
            this.datePriem.Value = new System.DateTime(2017, 5, 27, 0, 0, 0, 0);
            this.datePriem.ValueChanged += new System.EventHandler(this.datePriem_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Кабинет";
            // 
            // comboService
            // 
            this.comboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboService.FormattingEnabled = true;
            this.comboService.Location = new System.Drawing.Point(153, 54);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(122, 21);
            this.comboService.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Услуга";
            // 
            // maskedKab
            // 
            this.maskedKab.Location = new System.Drawing.Point(290, 54);
            this.maskedKab.Mask = "000";
            this.maskedKab.Name = "maskedKab";
            this.maskedKab.Size = new System.Drawing.Size(43, 20);
            this.maskedKab.TabIndex = 17;
            // 
            // butZapis
            // 
            this.butZapis.Location = new System.Drawing.Point(290, 10);
            this.butZapis.Name = "butZapis";
            this.butZapis.Size = new System.Drawing.Size(75, 23);
            this.butZapis.TabIndex = 18;
            this.butZapis.Text = "Записаться";
            this.butZapis.UseVisualStyleBackColor = true;
            this.butZapis.Click += new System.EventHandler(this.butZapis_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(135, 12);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBox1.TabIndex = 21;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Специализация";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataDoctor
            // 
            this.dataDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoctor.Location = new System.Drawing.Point(13, 106);
            this.dataDoctor.Name = "dataDoctor";
            this.dataDoctor.Size = new System.Drawing.Size(171, 235);
            this.dataDoctor.TabIndex = 24;
            // 
            // dataClient
            // 
            this.dataClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClient.Location = new System.Drawing.Point(212, 106);
            this.dataClient.Name = "dataClient";
            this.dataClient.Size = new System.Drawing.Size(157, 235);
            this.dataClient.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Врач";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Пациент";
            // 
            // Priem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataClient);
            this.Controls.Add(this.dataDoctor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.butZapis);
            this.Controls.Add(this.maskedKab);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboService);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datePriem);
            this.Name = "Priem";
            this.Text = "Запись на прием";
            ((System.ComponentModel.ISupportInitialize)(this.dataDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePriem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedKab;
        private System.Windows.Forms.Button butZapis;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataDoctor;
        private System.Windows.Forms.DataGridView dataClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}