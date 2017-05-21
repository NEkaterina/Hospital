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
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.врачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поступившиеТоварыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медРасходникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медОборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьНаПриемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналРаботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьОткрыткуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отркрыткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.сервисToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.врачиToolStripMenuItem,
            this.расписаниеToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.поступившиеТоварыToolStripMenuItem,
            this.поставщикиToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem1.Text = "Справочники";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сформироватьОтчетToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьОткрыткуToolStripMenuItem,
            this.отркрыткиToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
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
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записьНаПриемToolStripMenuItem,
            this.журналРаботToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // врачиToolStripMenuItem
            // 
            this.врачиToolStripMenuItem.Name = "врачиToolStripMenuItem";
            this.врачиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.врачиToolStripMenuItem.Text = "Врачи";
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
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
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
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
            // сформироватьОтчетToolStripMenuItem
            // 
            this.сформироватьОтчетToolStripMenuItem.Name = "сформироватьОтчетToolStripMenuItem";
            this.сформироватьОтчетToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.сформироватьОтчетToolStripMenuItem.Text = "Сформировать отчет";
            // 
            // создатьОткрыткуToolStripMenuItem
            // 
            this.создатьОткрыткуToolStripMenuItem.Name = "создатьОткрыткуToolStripMenuItem";
            this.создатьОткрыткуToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.создатьОткрыткуToolStripMenuItem.Text = "Создать открытку";
            // 
            // отркрыткиToolStripMenuItem
            // 
            this.отркрыткиToolStripMenuItem.Name = "отркрыткиToolStripMenuItem";
            this.отркрыткиToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.отркрыткиToolStripMenuItem.Text = "Отркрытки";
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
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem врачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
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
    }
}

