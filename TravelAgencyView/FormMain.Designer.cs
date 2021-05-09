
namespace TravelAgencyView
{
    partial class FormMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.турыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отелиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.страныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перенестиДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRef = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.buttonSalesForPeriod = new System.Windows.Forms.Button();
            this.отелидокументыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажидокументыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.турыToolStripMenuItem,
            this.отелиToolStripMenuItem,
            this.страныToolStripMenuItem,
            this.перенестиДанныеToolStripMenuItem,
            this.отелидокументыToolStripMenuItem,
            this.продажидокументыToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(824, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // турыToolStripMenuItem
            // 
            this.турыToolStripMenuItem.Name = "турыToolStripMenuItem";
            this.турыToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.турыToolStripMenuItem.Text = "Туры";
            this.турыToolStripMenuItem.Click += new System.EventHandler(this.турыToolStripMenuItem_Click);
            // 
            // отелиToolStripMenuItem
            // 
            this.отелиToolStripMenuItem.Name = "отелиToolStripMenuItem";
            this.отелиToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.отелиToolStripMenuItem.Text = "Отели";
            this.отелиToolStripMenuItem.Click += new System.EventHandler(this.отелиToolStripMenuItem_Click);
            // 
            // страныToolStripMenuItem
            // 
            this.страныToolStripMenuItem.Name = "страныToolStripMenuItem";
            this.страныToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.страныToolStripMenuItem.Text = "Страны";
            this.страныToolStripMenuItem.Click += new System.EventHandler(this.страныToolStripMenuItem_Click);
            // 
            // перенестиДанныеToolStripMenuItem
            // 
            this.перенестиДанныеToolStripMenuItem.Name = "перенестиДанныеToolStripMenuItem";
            this.перенестиДанныеToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.перенестиДанныеToolStripMenuItem.Text = "Перенести данные";
            this.перенестиДанныеToolStripMenuItem.Click += new System.EventHandler(this.перенестиДанныеToolStripMenuItem_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(681, 169);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(116, 27);
            this.buttonRef.TabIndex = 13;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(681, 121);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(116, 27);
            this.buttonDel.TabIndex = 12;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(681, 75);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(116, 27);
            this.buttonUpd.TabIndex = 11;
            this.buttonUpd.Text = "Изменить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.ButtonUpd_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(681, 30);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 27);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewSales.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSales.Size = new System.Drawing.Size(640, 263);
            this.dataGridViewSales.TabIndex = 9;
            // 
            // buttonSalesForPeriod
            // 
            this.buttonSalesForPeriod.Location = new System.Drawing.Point(681, 213);
            this.buttonSalesForPeriod.Name = "buttonSalesForPeriod";
            this.buttonSalesForPeriod.Size = new System.Drawing.Size(116, 27);
            this.buttonSalesForPeriod.TabIndex = 14;
            this.buttonSalesForPeriod.Text = "Продажи за период";
            this.buttonSalesForPeriod.UseVisualStyleBackColor = true;
            this.buttonSalesForPeriod.Click += new System.EventHandler(this.ButtonSalesForPeriod_Click);
            // 
            // отелидокументыToolStripMenuItem
            // 
            this.отелидокументыToolStripMenuItem.Name = "отелидокументыToolStripMenuItem";
            this.отелидокументыToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.отелидокументыToolStripMenuItem.Text = "Отели-документы";
            this.отелидокументыToolStripMenuItem.Click += new System.EventHandler(this.отелидокументыToolStripMenuItem_Click);
            // 
            // продажидокументыToolStripMenuItem
            // 
            this.продажидокументыToolStripMenuItem.Name = "продажидокументыToolStripMenuItem";
            this.продажидокументыToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.продажидокументыToolStripMenuItem.Text = "Продажи-документы";
            this.продажидокументыToolStripMenuItem.Click += new System.EventHandler(this.продажидокументыToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 302);
            this.Controls.Add(this.buttonSalesForPeriod);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem турыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отелиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem страныToolStripMenuItem;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Button buttonSalesForPeriod;
        private System.Windows.Forms.ToolStripMenuItem перенестиДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отелидокументыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажидокументыToolStripMenuItem;
    }
}

