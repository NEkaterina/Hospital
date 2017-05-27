namespace Hospital.Action
{
    partial class AddService
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
            this.butCanel = new System.Windows.Forms.Button();
            this.comboSpecialty = new System.Windows.Forms.ComboBox();
            this.maskedPrize = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(31, 192);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 0;
            this.butOk.Text = "Ок";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butCanel
            // 
            this.butCanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCanel.Location = new System.Drawing.Point(165, 192);
            this.butCanel.Name = "butCanel";
            this.butCanel.Size = new System.Drawing.Size(75, 23);
            this.butCanel.TabIndex = 1;
            this.butCanel.Text = "Отмена";
            this.butCanel.UseVisualStyleBackColor = true;
            // 
            // comboSpecialty
            // 
            this.comboSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpecialty.FormattingEnabled = true;
            this.comboSpecialty.Location = new System.Drawing.Point(119, 40);
            this.comboSpecialty.Name = "comboSpecialty";
            this.comboSpecialty.Size = new System.Drawing.Size(121, 21);
            this.comboSpecialty.TabIndex = 2;
            // 
            // maskedPrize
            // 
            this.maskedPrize.Location = new System.Drawing.Point(119, 141);
            this.maskedPrize.Mask = "00000";
            this.maskedPrize.Name = "maskedPrize";
            this.maskedPrize.Size = new System.Drawing.Size(121, 20);
            this.maskedPrize.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Специализация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стоимость";
            // 
            // textBname
            // 
            this.textBname.Location = new System.Drawing.Point(119, 91);
            this.textBname.Name = "textBname";
            this.textBname.Size = new System.Drawing.Size(121, 20);
            this.textBname.TabIndex = 7;
            // 
            // AddService
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCanel;
            this.ClientSize = new System.Drawing.Size(266, 256);
            this.ControlBox = false;
            this.Controls.Add(this.textBname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedPrize);
            this.Controls.Add(this.comboSpecialty);
            this.Controls.Add(this.butCanel);
            this.Controls.Add(this.butOk);
            this.Name = "AddService";
            this.Text = "Добавить услуги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butCanel;
        private System.Windows.Forms.ComboBox comboSpecialty;
        private System.Windows.Forms.MaskedTextBox maskedPrize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBname;
    }
}