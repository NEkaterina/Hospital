namespace Hospital.Entities
{
    partial class Specialty
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textSpec = new System.Windows.Forms.TextBox();
            this.butAddSpec = new System.Windows.Forms.Button();
            this.butDelSpec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(249, 317);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите новую специализацию";
            // 
            // textSpec
            // 
            this.textSpec.Location = new System.Drawing.Point(268, 28);
            this.textSpec.Multiline = true;
            this.textSpec.Name = "textSpec";
            this.textSpec.Size = new System.Drawing.Size(163, 20);
            this.textSpec.TabIndex = 3;
            this.textSpec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSpec_KeyPress);
            // 
            // butAddSpec
            // 
            this.butAddSpec.Location = new System.Drawing.Point(268, 54);
            this.butAddSpec.Name = "butAddSpec";
            this.butAddSpec.Size = new System.Drawing.Size(163, 25);
            this.butAddSpec.TabIndex = 4;
            this.butAddSpec.Text = "Добавить";
            this.butAddSpec.UseVisualStyleBackColor = true;
            this.butAddSpec.Click += new System.EventHandler(this.butAddSpec_Click);
            // 
            // butDelSpec
            // 
            this.butDelSpec.Location = new System.Drawing.Point(268, 85);
            this.butDelSpec.Name = "butDelSpec";
            this.butDelSpec.Size = new System.Drawing.Size(163, 25);
            this.butDelSpec.TabIndex = 5;
            this.butDelSpec.Text = "Удалить";
            this.butDelSpec.UseVisualStyleBackColor = true;
            this.butDelSpec.Click += new System.EventHandler(this.butDelSpec_Click);
            // 
            // Specialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 341);
            this.Controls.Add(this.butDelSpec);
            this.Controls.Add(this.butAddSpec);
            this.Controls.Add(this.textSpec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Specialty";
            this.Text = "Specialty";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSpec;
        private System.Windows.Forms.Button butAddSpec;
        private System.Windows.Forms.Button butDelSpec;
    }
}