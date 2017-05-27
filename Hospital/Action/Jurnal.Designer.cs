namespace Hospital.Action
{
    partial class Jurnal
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
            this.perfomend = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.timeTable = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.raschet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfomend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // perfomend
            // 
            this.perfomend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perfomend.Location = new System.Drawing.Point(12, 38);
            this.perfomend.Name = "perfomend";
            this.perfomend.Size = new System.Drawing.Size(502, 312);
            this.perfomend.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сформировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeTable
            // 
            this.timeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeTable.Location = new System.Drawing.Point(539, 38);
            this.timeTable.Name = "timeTable";
            this.timeTable.Size = new System.Drawing.Size(280, 312);
            this.timeTable.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(539, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2017, 5, 27, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // raschet
            // 
            this.raschet.Location = new System.Drawing.Point(642, 9);
            this.raschet.Name = "raschet";
            this.raschet.Size = new System.Drawing.Size(75, 25);
            this.raschet.TabIndex = 4;
            this.raschet.Text = "raschet";
            this.raschet.UseVisualStyleBackColor = true;
            this.raschet.Click += new System.EventHandler(this.raschet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выполненые работы";
            // 
            // Jurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raschet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.timeTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.perfomend);
            this.Name = "Jurnal";
            this.Text = "Выполненые работы";
            this.Load += new System.EventHandler(this.Jurnal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfomend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView perfomend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView timeTable;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button raschet;
        private System.Windows.Forms.Label label1;
    }
}