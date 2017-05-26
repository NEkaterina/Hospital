namespace Hospital.Entities
{
    partial class Salary
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
            this.butRasch = new System.Windows.Forms.Button();
            this.butPere = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // butRasch
            // 
            this.butRasch.Location = new System.Drawing.Point(12, 7);
            this.butRasch.Name = "butRasch";
            this.butRasch.Size = new System.Drawing.Size(75, 23);
            this.butRasch.TabIndex = 1;
            this.butRasch.Text = "Расчитать";
            this.butRasch.UseVisualStyleBackColor = true;
            this.butRasch.Click += new System.EventHandler(this.butRasch_Click);
            // 
            // butPere
            // 
            this.butPere.Location = new System.Drawing.Point(93, 7);
            this.butPere.Name = "butPere";
            this.butPere.Size = new System.Drawing.Size(88, 23);
            this.butPere.TabIndex = 2;
            this.butPere.Text = "Пересчитать";
            this.butPere.UseVisualStyleBackColor = true;
            this.butPere.Click += new System.EventHandler(this.butPere_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(187, 7);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(75, 23);
            this.butDel.TabIndex = 3;
            this.butDel.Text = "Удалить";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 315);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butPere);
            this.Controls.Add(this.butRasch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Salary";
            this.Text = "Salary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butDel;
        public System.Windows.Forms.Button butRasch;
        public System.Windows.Forms.Button butPere;
    }
}