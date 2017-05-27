﻿namespace Hospital
{
    partial class ProviderAddEdit
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
            this.provider_save = new System.Windows.Forms.Button();
            this.provider_cancel = new System.Windows.Forms.Button();
            this.tCompanyName = new System.Windows.Forms.TextBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineCentreDataSet = new Hospital.MedicineCentreDataSet();
            this.tCity = new System.Windows.Forms.TextBox();
            this.tStreet = new System.Windows.Forms.TextBox();
            this.tPhone = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.providerTableAdapter = new Hospital.MedicineCentreDataSetTableAdapters.ProviderTableAdapter();
            this.tHouseNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineCentreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // provider_save
            // 
            this.provider_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.provider_save.Location = new System.Drawing.Point(76, 227);
            this.provider_save.Name = "provider_save";
            this.provider_save.Size = new System.Drawing.Size(90, 45);
            this.provider_save.TabIndex = 0;
            this.provider_save.Text = "Сохранить";
            this.provider_save.UseVisualStyleBackColor = true;
            this.provider_save.Click += new System.EventHandler(this.provider_save_Click);
            // 
            // provider_cancel
            // 
            this.provider_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.provider_cancel.Location = new System.Drawing.Point(263, 227);
            this.provider_cancel.Name = "provider_cancel";
            this.provider_cancel.Size = new System.Drawing.Size(90, 45);
            this.provider_cancel.TabIndex = 1;
            this.provider_cancel.Text = "Отмена";
            this.provider_cancel.UseVisualStyleBackColor = true;
            this.provider_cancel.Click += new System.EventHandler(this.provider_cancel_Click);
            // 
            // tCompanyName
            // 
            this.tCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "companyName", true));
            this.tCompanyName.Location = new System.Drawing.Point(105, 39);
            this.tCompanyName.Name = "tCompanyName";
            this.tCompanyName.Size = new System.Drawing.Size(170, 20);
            this.tCompanyName.TabIndex = 2;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.medicineCentreDataSet;
            this.providerBindingSource.CurrentChanged += new System.EventHandler(this.providerBindingSource_CurrentChanged);
            // 
            // medicineCentreDataSet
            // 
            this.medicineCentreDataSet.DataSetName = "MedicineCentreDataSet";
            this.medicineCentreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCity
            // 
            this.tCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "city", true));
            this.tCity.Location = new System.Drawing.Point(105, 65);
            this.tCity.Name = "tCity";
            this.tCity.Size = new System.Drawing.Size(171, 20);
            this.tCity.TabIndex = 3;
            // 
            // tStreet
            // 
            this.tStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "street", true));
            this.tStreet.Location = new System.Drawing.Point(105, 91);
            this.tStreet.Name = "tStreet";
            this.tStreet.Size = new System.Drawing.Size(171, 20);
            this.tStreet.TabIndex = 4;
            // 
            // tPhone
            // 
            this.tPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "phone", true));
            this.tPhone.Location = new System.Drawing.Point(105, 147);
            this.tPhone.Name = "tPhone";
            this.tPhone.Size = new System.Drawing.Size(170, 20);
            this.tPhone.TabIndex = 5;
            // 
            // tEmail
            // 
            this.tEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "email", true));
            this.tEmail.Location = new System.Drawing.Point(105, 182);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(170, 20);
            this.tEmail.TabIndex = 6;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // tHouseNumber
            // 
            this.tHouseNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providerBindingSource, "houseNumber", true));
            this.tHouseNumber.Location = new System.Drawing.Point(105, 121);
            this.tHouseNumber.Name = "tHouseNumber";
            this.tHouseNumber.Size = new System.Drawing.Size(171, 20);
            this.tHouseNumber.TabIndex = 7;
            // 
            // ProviderAddEdit
            // 
            this.AcceptButton = this.provider_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.provider_cancel;
            this.ClientSize = new System.Drawing.Size(457, 302);
            this.ControlBox = false;
            this.Controls.Add(this.tHouseNumber);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tPhone);
            this.Controls.Add(this.tStreet);
            this.Controls.Add(this.tCity);
            this.Controls.Add(this.tCompanyName);
            this.Controls.Add(this.provider_cancel);
            this.Controls.Add(this.provider_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProviderAddEdit";
            this.Text = "ProviderAddEdit";
            this.Load += new System.EventHandler(this.ProviderAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineCentreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button provider_cancel;
        public System.Windows.Forms.TextBox tCompanyName;
        public System.Windows.Forms.TextBox tCity;
        public System.Windows.Forms.TextBox tStreet;
        public System.Windows.Forms.TextBox tPhone;
        public System.Windows.Forms.TextBox tEmail;
        private MedicineCentreDataSet medicineCentreDataSet;
        private MedicineCentreDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        public System.Windows.Forms.Button provider_save;
        public System.Windows.Forms.BindingSource providerBindingSource;
        public System.Windows.Forms.TextBox tHouseNumber;
    }
}