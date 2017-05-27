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
            this.components = new System.ComponentModel.Container();
            this.dataGrid_provider = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineCentreDataSet = new Hospital.MedicineCentreDataSet();
            this.provider_addbutton = new System.Windows.Forms.Button();
            this.provider_editbuttom = new System.Windows.Forms.Button();
            this.show_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.providerTableAdapter = new Hospital.MedicineCentreDataSetTableAdapters.ProviderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_provider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineCentreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_provider
            // 
            this.dataGrid_provider.AllowUserToAddRows = false;
            this.dataGrid_provider.AllowUserToDeleteRows = false;
            this.dataGrid_provider.AutoGenerateColumns = false;
            this.dataGrid_provider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_provider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseNumberDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGrid_provider.DataSource = this.providerBindingSource;
            this.dataGrid_provider.Location = new System.Drawing.Point(12, 12);
            this.dataGrid_provider.Name = "dataGrid_provider";
            this.dataGrid_provider.ReadOnly = true;
            this.dataGrid_provider.Size = new System.Drawing.Size(744, 285);
            this.dataGrid_provider.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "companyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "companyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // houseNumberDataGridViewTextBoxColumn
            // 
            this.houseNumberDataGridViewTextBoxColumn.DataPropertyName = "houseNumber";
            this.houseNumberDataGridViewTextBoxColumn.HeaderText = "houseNumber";
            this.houseNumberDataGridViewTextBoxColumn.Name = "houseNumberDataGridViewTextBoxColumn";
            this.houseNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.medicineCentreDataSet;
            // 
            // medicineCentreDataSet
            // 
            this.medicineCentreDataSet.DataSetName = "MedicineCentreDataSet";
            this.medicineCentreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provider_addbutton
            // 
            this.provider_addbutton.Location = new System.Drawing.Point(777, 76);
            this.provider_addbutton.Name = "provider_addbutton";
            this.provider_addbutton.Size = new System.Drawing.Size(97, 37);
            this.provider_addbutton.TabIndex = 1;
            this.provider_addbutton.Text = "Добавить";
            this.provider_addbutton.UseVisualStyleBackColor = true;
            this.provider_addbutton.Click += new System.EventHandler(this.provider_addbutton_Click);
            // 
            // provider_editbuttom
            // 
            this.provider_editbuttom.Location = new System.Drawing.Point(785, 119);
            this.provider_editbuttom.Name = "provider_editbuttom";
            this.provider_editbuttom.Size = new System.Drawing.Size(97, 37);
            this.provider_editbuttom.TabIndex = 2;
            this.provider_editbuttom.Text = "Изменить";
            this.provider_editbuttom.UseVisualStyleBackColor = true;
            this.provider_editbuttom.Click += new System.EventHandler(this.provider_editbuttom_Click);
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(777, 12);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(105, 37);
            this.show_button.TabIndex = 3;
            this.show_button.Text = "Выгрузить";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(777, 187);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(97, 39);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // Provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 324);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.provider_editbuttom);
            this.Controls.Add(this.provider_addbutton);
            this.Controls.Add(this.dataGrid_provider);
            this.Name = "Provider";
            this.Text = "Provider";
            this.Load += new System.EventHandler(this.Provider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_provider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineCentreDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_provider;
        private System.Windows.Forms.Button provider_addbutton;
        private System.Windows.Forms.Button provider_editbuttom;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Button delete_button;
        private MedicineCentreDataSet medicineCentreDataSet;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private MedicineCentreDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}