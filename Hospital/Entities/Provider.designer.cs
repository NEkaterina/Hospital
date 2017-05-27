namespace Hospital
{
    partial class Provider
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
            this.dataGrid_provider = new System.Windows.Forms.DataGridView();
            this.provider_addbutton = new System.Windows.Forms.Button();
            this.provider_editbuttom = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_provider)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_provider
            // 
            this.dataGrid_provider.AllowUserToAddRows = false;
            this.dataGrid_provider.AllowUserToDeleteRows = false;
            this.dataGrid_provider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_provider.Location = new System.Drawing.Point(12, 12);
            this.dataGrid_provider.Name = "dataGrid_provider";
            this.dataGrid_provider.ReadOnly = true;
            this.dataGrid_provider.Size = new System.Drawing.Size(265, 285);
            this.dataGrid_provider.TabIndex = 0;
            // 
            // provider_addbutton
            // 
            this.provider_addbutton.Location = new System.Drawing.Point(283, 12);
            this.provider_addbutton.Name = "provider_addbutton";
            this.provider_addbutton.Size = new System.Drawing.Size(97, 37);
            this.provider_addbutton.TabIndex = 1;
            this.provider_addbutton.Text = "Добавить";
            this.provider_addbutton.UseVisualStyleBackColor = true;
            this.provider_addbutton.Click += new System.EventHandler(this.provider_addbutton_Click);
            // 
            // provider_editbuttom
            // 
            this.provider_editbuttom.Location = new System.Drawing.Point(283, 55);
            this.provider_editbuttom.Name = "provider_editbuttom";
            this.provider_editbuttom.Size = new System.Drawing.Size(97, 37);
            this.provider_editbuttom.TabIndex = 2;
            this.provider_editbuttom.Text = "Изменить";
            this.provider_editbuttom.UseVisualStyleBackColor = true;
            this.provider_editbuttom.Click += new System.EventHandler(this.provider_editbuttom_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(283, 98);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(97, 39);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 324);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.provider_editbuttom);
            this.Controls.Add(this.provider_addbutton);
            this.Controls.Add(this.dataGrid_provider);
            this.Name = "Provider";
            this.Text = "Provider";
            this.Load += new System.EventHandler(this.Provider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_provider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_provider;
        private System.Windows.Forms.Button provider_editbuttom;
        private System.Windows.Forms.Button delete_button;
     //   private MedicineCentreDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button provider_addbutton;
    }
}