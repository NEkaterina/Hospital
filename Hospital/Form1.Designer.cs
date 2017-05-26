namespace Hospital
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поступившиеТоварыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медРасходникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медОборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьНаПриемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналРаботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьОткрыткуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отркрыткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.операцииToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.допИнформацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.timeToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.поступившиеТоварыToolStripMenuItem,
            this.поставщикиToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem1.Text = "Справочники";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.clientToolStripMenuItem.Text = "Клиенты";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.doctorToolStripMenuItem.Text = "Врачи";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.timeToolStripMenuItem.Text = "Расписание";
            this.timeToolStripMenuItem.Click += new System.EventHandler(this.timeToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.услугиToolStripMenuItem.Text = "Услуги";
            // 
            // поступившиеТоварыToolStripMenuItem
            // 
            this.поступившиеТоварыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.медРасходникиToolStripMenuItem,
            this.медОборудованиеToolStripMenuItem});
            this.поступившиеТоварыToolStripMenuItem.Name = "поступившиеТоварыToolStripMenuItem";
            this.поступившиеТоварыToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.поступившиеТоварыToolStripMenuItem.Text = "Поступившие товары";
            // 
            // медРасходникиToolStripMenuItem
            // 
            this.медРасходникиToolStripMenuItem.Name = "медРасходникиToolStripMenuItem";
            this.медРасходникиToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.медРасходникиToolStripMenuItem.Text = "Мед. расходники";
            // 
            // медОборудованиеToolStripMenuItem
            // 
            this.медОборудованиеToolStripMenuItem.Name = "медОборудованиеToolStripMenuItem";
            this.медОборудованиеToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.медОборудованиеToolStripMenuItem.Text = "Мед. оборудование";
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записьНаПриемToolStripMenuItem,
            this.журналРаботToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // записьНаПриемToolStripMenuItem
            // 
            this.записьНаПриемToolStripMenuItem.Name = "записьНаПриемToolStripMenuItem";
            this.записьНаПриемToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.записьНаПриемToolStripMenuItem.Text = "Запись на прием";
            // 
            // журналРаботToolStripMenuItem
            // 
            this.журналРаботToolStripMenuItem.Name = "журналРаботToolStripMenuItem";
            this.журналРаботToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.журналРаботToolStripMenuItem.Text = "Журнал работ";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сформироватьОтчетToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // сформироватьОтчетToolStripMenuItem
            // 
            this.сформироватьОтчетToolStripMenuItem.Name = "сформироватьОтчетToolStripMenuItem";
            this.сформироватьОтчетToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.сформироватьОтчетToolStripMenuItem.Text = "Сформировать отчет";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьОткрыткуToolStripMenuItem,
            this.отркрыткиToolStripMenuItem,
            this.salaryToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // создатьОткрыткуToolStripMenuItem
            // 
            this.создатьОткрыткуToolStripMenuItem.Name = "создатьОткрыткуToolStripMenuItem";
            this.создатьОткрыткуToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.создатьОткрыткуToolStripMenuItem.Text = "Создать открытку";
            // 
            // отркрыткиToolStripMenuItem
            // 
            this.отркрыткиToolStripMenuItem.Name = "отркрыткиToolStripMenuItem";
            this.отркрыткиToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.отркрыткиToolStripMenuItem.Text = "Отркрытки";
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.salaryToolStripMenuItem.Text = "Расчет заработной платы";
            this.salaryToolStripMenuItem.Click += new System.EventHandler(this.salaryToolStripMenuItem_Click);
            // 
            // допИнформацияToolStripMenuItem
            // 
            this.допИнформацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specialToolStripMenuItem});
            this.допИнформацияToolStripMenuItem.Name = "допИнформацияToolStripMenuItem";
            this.допИнформацияToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.допИнформацияToolStripMenuItem.Text = "Доп. информация";
            // 
            // specialToolStripMenuItem
            // 
            this.specialToolStripMenuItem.Name = "specialToolStripMenuItem";
            this.specialToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.specialToolStripMenuItem.Text = "Специализация врачей";
            this.specialToolStripMenuItem.Click += new System.EventHandler(this.specialToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 62);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(365, 261);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 314);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hospital";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поступившиеТоварыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медРасходникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медОборудованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьНаПриемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналРаботToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьОткрыткуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отркрыткиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
    }
}

