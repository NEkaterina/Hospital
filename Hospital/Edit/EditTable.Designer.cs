namespace Hospital.Edit
{
    partial class EditTable
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
            this.id = new System.Windows.Forms.TextBox();
            this.butCanel = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.maskedFinish = new System.Windows.Forms.MaskedTextBox();
            this.maskedStart = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(14, 17);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(33, 20);
            this.id.TabIndex = 0;
            // 
            // butCanel
            // 
            this.butCanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCanel.Location = new System.Drawing.Point(174, 178);
            this.butCanel.Name = "butCanel";
            this.butCanel.Size = new System.Drawing.Size(75, 23);
            this.butCanel.TabIndex = 19;
            this.butCanel.Text = "button2";
            this.butCanel.UseVisualStyleBackColor = true;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(57, 178);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 18;
            this.butOk.Text = "button1";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // maskedFinish
            // 
            this.maskedFinish.Location = new System.Drawing.Point(138, 117);
            this.maskedFinish.Name = "maskedFinish";
            this.maskedFinish.Size = new System.Drawing.Size(100, 20);
            this.maskedFinish.TabIndex = 17;
            // 
            // maskedStart
            // 
            this.maskedStart.Location = new System.Drawing.Point(128, 87);
            this.maskedStart.Name = "maskedStart";
            this.maskedStart.Size = new System.Drawing.Size(100, 20);
            this.maskedStart.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "время окончания";
            // 
            // dayBox
            // 
            this.dayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Location = new System.Drawing.Point(128, 60);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(121, 21);
            this.dayBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Время начала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "День ндели";
            // 
            // EditTable
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCanel;
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.ControlBox = false;
            this.Controls.Add(this.butCanel);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.maskedFinish);
            this.Controls.Add(this.maskedStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id);
            this.Name = "EditTable";
            this.Text = "EditTablecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button butCanel;
        public System.Windows.Forms.Button butOk;
        public System.Windows.Forms.MaskedTextBox maskedFinish;
        public System.Windows.Forms.MaskedTextBox maskedStart;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox dayBox;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox id;
    }
}