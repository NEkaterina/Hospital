namespace Hospital.Add
{
    partial class AddTable
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
            this.label4 = new System.Windows.Forms.Label();
            this.docBox = new System.Windows.Forms.ComboBox();
            this.specBox = new System.Windows.Forms.ComboBox();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedStart = new System.Windows.Forms.MaskedTextBox();
            this.maskedFinish = new System.Windows.Forms.MaskedTextBox();
            this.butOk = new System.Windows.Forms.Button();
            this.butCanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Врач";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Специализация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "День ндели";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время начала";
            // 
            // docBox
            // 
            this.docBox.FormattingEnabled = true;
            this.docBox.Location = new System.Drawing.Point(117, 54);
            this.docBox.Name = "docBox";
            this.docBox.Size = new System.Drawing.Size(121, 21);
            this.docBox.TabIndex = 4;
            // 
            // specBox
            // 
            this.specBox.FormattingEnabled = true;
            this.specBox.Location = new System.Drawing.Point(117, 27);
            this.specBox.Name = "specBox";
            this.specBox.Size = new System.Drawing.Size(121, 21);
            this.specBox.TabIndex = 5;
            this.specBox.SelectedIndexChanged += new System.EventHandler(this.specBox_SelectedIndexChanged);
            // 
            // dayBox
            // 
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Location = new System.Drawing.Point(117, 89);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(121, 21);
            this.dayBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "время окончания";
            // 
            // maskedStart
            // 
            this.maskedStart.Location = new System.Drawing.Point(117, 116);
            this.maskedStart.Name = "maskedStart";
            this.maskedStart.Size = new System.Drawing.Size(100, 20);
            this.maskedStart.TabIndex = 8;
            // 
            // maskedFinish
            // 
            this.maskedFinish.Location = new System.Drawing.Point(127, 146);
            this.maskedFinish.Name = "maskedFinish";
            this.maskedFinish.Size = new System.Drawing.Size(100, 20);
            this.maskedFinish.TabIndex = 9;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(46, 207);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 10;
            this.butOk.Text = "button1";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butCanel
            // 
            this.butCanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCanel.Location = new System.Drawing.Point(163, 207);
            this.butCanel.Name = "butCanel";
            this.butCanel.Size = new System.Drawing.Size(75, 23);
            this.butCanel.TabIndex = 11;
            this.butCanel.Text = "button2";
            this.butCanel.UseVisualStyleBackColor = true;
            // 
            // AddTable
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCanel;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.butCanel);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.maskedFinish);
            this.Controls.Add(this.maskedStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.specBox);
            this.Controls.Add(this.docBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTable";
            this.Text = "AddTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox docBox;
        private System.Windows.Forms.ComboBox specBox;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedStart;
        private System.Windows.Forms.MaskedTextBox maskedFinish;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butCanel;
    }
}