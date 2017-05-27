namespace Hospital.Entities
{
    partial class Service
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
            this.dataGridService = new System.Windows.Forms.DataGridView();
            this.specialty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butAddService = new System.Windows.Forms.Button();
            this.butEditService = new System.Windows.Forms.Button();
            this.butDelService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridService
            // 
            this.dataGridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridService.Location = new System.Drawing.Point(12, 42);
            this.dataGridService.Name = "dataGridService";
            this.dataGridService.Size = new System.Drawing.Size(288, 294);
            this.dataGridService.TabIndex = 0;
            // 
            // specialty
            // 
            this.specialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialty.FormattingEnabled = true;
            this.specialty.Location = new System.Drawing.Point(155, 15);
            this.specialty.Name = "specialty";
            this.specialty.Size = new System.Drawing.Size(145, 21);
            this.specialty.TabIndex = 1;
            this.specialty.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите специализацию";
            // 
            // butAddService
            // 
            this.butAddService.Location = new System.Drawing.Point(306, 42);
            this.butAddService.Name = "butAddService";
            this.butAddService.Size = new System.Drawing.Size(26, 23);
            this.butAddService.TabIndex = 3;
            this.butAddService.Text = "Д";
            this.butAddService.UseVisualStyleBackColor = true;
            this.butAddService.Click += new System.EventHandler(this.butAddService_Click);
            // 
            // butEditService
            // 
            this.butEditService.Location = new System.Drawing.Point(306, 71);
            this.butEditService.Name = "butEditService";
            this.butEditService.Size = new System.Drawing.Size(26, 23);
            this.butEditService.TabIndex = 4;
            this.butEditService.Text = "Р";
            this.butEditService.UseVisualStyleBackColor = true;
            this.butEditService.Click += new System.EventHandler(this.butEditService_Click);
            // 
            // butDelService
            // 
            this.butDelService.Location = new System.Drawing.Point(306, 100);
            this.butDelService.Name = "butDelService";
            this.butDelService.Size = new System.Drawing.Size(26, 23);
            this.butDelService.TabIndex = 5;
            this.butDelService.Text = "У";
            this.butDelService.UseVisualStyleBackColor = true;
            this.butDelService.Click += new System.EventHandler(this.butDelService_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 359);
            this.Controls.Add(this.butDelService);
            this.Controls.Add(this.butEditService);
            this.Controls.Add(this.butAddService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.specialty);
            this.Controls.Add(this.dataGridService);
            this.Name = "Service";
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox specialty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butAddService;
        private System.Windows.Forms.Button butEditService;
        private System.Windows.Forms.Button butDelService;
        public System.Windows.Forms.DataGridView dataGridService;
    }
}