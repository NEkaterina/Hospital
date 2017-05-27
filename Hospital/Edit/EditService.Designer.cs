namespace Hospital.Edit
{
    partial class EditService
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
            this.textBname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedPrize = new System.Windows.Forms.MaskedTextBox();
            this.butCanel = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.checkedList = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBname
            // 
            this.textBname.Location = new System.Drawing.Point(127, 28);
            this.textBname.Name = "textBname";
            this.textBname.Size = new System.Drawing.Size(121, 20);
            this.textBname.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Стоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Наименование";
            // 
            // maskedPrize
            // 
            this.maskedPrize.Location = new System.Drawing.Point(127, 56);
            this.maskedPrize.Mask = "00000";
            this.maskedPrize.Name = "maskedPrize";
            this.maskedPrize.Size = new System.Drawing.Size(121, 20);
            this.maskedPrize.TabIndex = 10;
            // 
            // butCanel
            // 
            this.butCanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCanel.Location = new System.Drawing.Point(173, 118);
            this.butCanel.Name = "butCanel";
            this.butCanel.Size = new System.Drawing.Size(75, 23);
            this.butCanel.TabIndex = 9;
            this.butCanel.Text = "Отмена";
            this.butCanel.UseVisualStyleBackColor = true;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(34, 118);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 8;
            this.butOk.Text = "Ок";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(3, 3);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(27, 20);
            this.id.TabIndex = 14;
            // 
            // checkedList
            // 
            this.checkedList.FormattingEnabled = true;
            this.checkedList.Location = new System.Drawing.Point(267, 47);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(120, 94);
            this.checkedList.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 16;
            // 
            // EditService
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCanel;
            this.ClientSize = new System.Drawing.Size(411, 167);
            this.ControlBox = false;
            this.Controls.Add(this.checkedList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedPrize);
            this.Controls.Add(this.butCanel);
            this.Controls.Add(this.butOk);
            this.Name = "EditService";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.EditService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butCanel;
        private System.Windows.Forms.Button butOk;
        public System.Windows.Forms.TextBox textBname;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox maskedPrize;
        public System.Windows.Forms.TextBox id;
        private System.Windows.Forms.CheckedListBox checkedList;
        private System.Windows.Forms.TextBox textBox1;
    }
}