namespace Hospital.Add
{
    partial class AddEntryJurnal
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
            this.butcanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(32, 268);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 0;
            this.butOk.Text = "Ок";
            this.butOk.UseVisualStyleBackColor = true;
            // 
            // butcanel
            // 
            this.butcanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butcanel.Location = new System.Drawing.Point(175, 268);
            this.butcanel.Name = "butcanel";
            this.butcanel.Size = new System.Drawing.Size(80, 23);
            this.butcanel.TabIndex = 1;
            this.butcanel.Text = "Отмена";
            this.butcanel.UseVisualStyleBackColor = true;
            // 
            // AddEntryJurnal
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butcanel;
            this.ClientSize = new System.Drawing.Size(302, 323);
            this.ControlBox = false;
            this.Controls.Add(this.butcanel);
            this.Controls.Add(this.butOk);
            this.Name = "AddEntryJurnal";
            this.Text = "AddEntryJurnal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butcanel;
    }
}