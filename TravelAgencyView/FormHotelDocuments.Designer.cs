
namespace TravelAgencyView
{
    partial class FormHotelDocuments
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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonUpdateCache = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.dataGridViewHotelDocuments = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotelDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.textBoxName);
            this.groupBoxSearch.Controls.Add(this.labelName);
            this.groupBoxSearch.Location = new System.Drawing.Point(953, 240);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(191, 83);
            this.groupBoxSearch.TabIndex = 31;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Отель";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(31, 45);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(128, 26);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(77, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(105, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // buttonUpdateCache
            // 
            this.buttonUpdateCache.Location = new System.Drawing.Point(973, 21);
            this.buttonUpdateCache.Name = "buttonUpdateCache";
            this.buttonUpdateCache.Size = new System.Drawing.Size(171, 26);
            this.buttonUpdateCache.TabIndex = 28;
            this.buttonUpdateCache.Text = "Обновить кэш";
            this.buttonUpdateCache.UseVisualStyleBackColor = true;
            this.buttonUpdateCache.Click += new System.EventHandler(this.buttonUpdateCache_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(973, 63);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(171, 27);
            this.buttonRef.TabIndex = 30;
            this.buttonRef.Text = "Обновить форму";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // dataGridViewHotelDocuments
            // 
            this.dataGridViewHotelDocuments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewHotelDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotelDocuments.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewHotelDocuments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewHotelDocuments.Name = "dataGridViewHotelDocuments";
            this.dataGridViewHotelDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHotelDocuments.Size = new System.Drawing.Size(935, 340);
            this.dataGridViewHotelDocuments.TabIndex = 29;
            // 
            // FormHotelDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 367);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonUpdateCache);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.dataGridViewHotelDocuments);
            this.Name = "FormHotelDocuments";
            this.Text = "Отели-документы";
            this.Load += new System.EventHandler(this.FormHotelDocuments_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotelDocuments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonUpdateCache;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.DataGridView dataGridViewHotelDocuments;
    }
}