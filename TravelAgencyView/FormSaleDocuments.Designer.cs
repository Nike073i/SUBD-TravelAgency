
namespace TravelAgencyView
{
    partial class FormSaleDocuments
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
            this.buttonUpdateCache = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.dataGridViewSaleDocuments = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleDocuments)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdateCache
            // 
            this.buttonUpdateCache.Location = new System.Drawing.Point(973, 21);
            this.buttonUpdateCache.Name = "buttonUpdateCache";
            this.buttonUpdateCache.Size = new System.Drawing.Size(139, 26);
            this.buttonUpdateCache.TabIndex = 24;
            this.buttonUpdateCache.Text = "Обновить кэш";
            this.buttonUpdateCache.UseVisualStyleBackColor = true;
            this.buttonUpdateCache.Click += new System.EventHandler(this.buttonUpdateCache_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(973, 63);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(139, 27);
            this.buttonRef.TabIndex = 26;
            this.buttonRef.Text = "Обновить форму";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // dataGridViewSaleDocuments
            // 
            this.dataGridViewSaleDocuments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSaleDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleDocuments.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewSaleDocuments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSaleDocuments.Name = "dataGridViewSaleDocuments";
            this.dataGridViewSaleDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSaleDocuments.Size = new System.Drawing.Size(935, 340);
            this.dataGridViewSaleDocuments.TabIndex = 25;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.textBoxFIO);
            this.groupBoxSearch.Controls.Add(this.labelFIO);
            this.groupBoxSearch.Location = new System.Drawing.Point(953, 240);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(175, 83);
            this.groupBoxSearch.TabIndex = 27;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Клиент";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(20, 45);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(128, 26);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(54, 19);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(105, 20);
            this.textBoxFIO.TabIndex = 1;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(14, 22);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // FormSaleDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 365);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonUpdateCache);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.dataGridViewSaleDocuments);
            this.Name = "FormSaleDocuments";
            this.Text = "Продажи-документы";
            this.Load += new System.EventHandler(this.FormSaleDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleDocuments)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateCache;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.DataGridView dataGridViewSaleDocuments;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelFIO;
    }
}