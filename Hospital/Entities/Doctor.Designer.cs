namespace Hospital.Entities
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addDoctor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.edirDoctor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.delDoctor = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctor,
            this.toolStripSeparator1,
            this.edirDoctor,
            this.toolStripSeparator2,
            this.delDoctor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addDoctor
            // 
            this.addDoctor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addDoctor.Image = ((System.Drawing.Image)(resources.GetObject("addDoctor.Image")));
            this.addDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addDoctor.Name = "addDoctor";
            this.addDoctor.Size = new System.Drawing.Size(23, 22);
            this.addDoctor.Text = "Добавить";
            this.addDoctor.Click += new System.EventHandler(this.addDoctor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // edirDoctor
            // 
            this.edirDoctor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.edirDoctor.Image = ((System.Drawing.Image)(resources.GetObject("edirDoctor.Image")));
            this.edirDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edirDoctor.Name = "edirDoctor";
            this.edirDoctor.Size = new System.Drawing.Size(23, 22);
            this.edirDoctor.Text = "Изменить";
            this.edirDoctor.Click += new System.EventHandler(this.edirDoctor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // delDoctor
            // 
            this.delDoctor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delDoctor.Image = ((System.Drawing.Image)(resources.GetObject("delDoctor.Image")));
            this.delDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delDoctor.Name = "delDoctor";
            this.delDoctor.Size = new System.Drawing.Size(23, 22);
            this.delDoctor.Text = "Удалить";
            this.delDoctor.Click += new System.EventHandler(this.delDoctor_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 345);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addDoctor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton edirDoctor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton delDoctor;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}