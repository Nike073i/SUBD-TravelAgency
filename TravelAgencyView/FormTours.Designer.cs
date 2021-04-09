
namespace TravelAgencyView
{
    partial class FormTours
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
            this.buttonRef = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewTours = new System.Windows.Forms.DataGridView();
            this.buttonVerboseMode = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCostTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxCostFrom = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(838, 155);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(172, 27);
            this.buttonRef.TabIndex = 23;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(838, 109);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(172, 27);
            this.buttonDel.TabIndex = 22;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(838, 61);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(172, 27);
            this.buttonUpd.TabIndex = 21;
            this.buttonUpd.Text = "Изменить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.ButtonUpd_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(838, 16);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(172, 27);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // dataGridViewTours
            // 
            this.dataGridViewTours.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTours.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTours.Size = new System.Drawing.Size(817, 340);
            this.dataGridViewTours.TabIndex = 19;
            // 
            // buttonVerboseMode
            // 
            this.buttonVerboseMode.Location = new System.Drawing.Point(838, 199);
            this.buttonVerboseMode.Name = "buttonVerboseMode";
            this.buttonVerboseMode.Size = new System.Drawing.Size(172, 27);
            this.buttonVerboseMode.TabIndex = 24;
            this.buttonVerboseMode.Text = "Подробный режим";
            this.buttonVerboseMode.UseVisualStyleBackColor = true;
            this.buttonVerboseMode.Click += new System.EventHandler(this.ButtonToursVerboseMode_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.textBoxCostTo);
            this.groupBoxSearch.Controls.Add(this.labelTo);
            this.groupBoxSearch.Controls.Add(this.textBoxCostFrom);
            this.groupBoxSearch.Controls.Add(this.labelFrom);
            this.groupBoxSearch.Location = new System.Drawing.Point(838, 240);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(175, 112);
            this.groupBoxSearch.TabIndex = 25;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Цена";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(24, 75);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(128, 26);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBoxCostTo
            // 
            this.textBoxCostTo.Location = new System.Drawing.Point(54, 44);
            this.textBoxCostTo.Name = "textBoxCostTo";
            this.textBoxCostTo.Size = new System.Drawing.Size(105, 20);
            this.textBoxCostTo.TabIndex = 3;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(14, 47);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(22, 13);
            this.labelTo.TabIndex = 2;
            this.labelTo.Text = "До";
            // 
            // textBoxCostFrom
            // 
            this.textBoxCostFrom.Location = new System.Drawing.Point(54, 18);
            this.textBoxCostFrom.Name = "textBoxCostFrom";
            this.textBoxCostFrom.Size = new System.Drawing.Size(105, 20);
            this.textBoxCostFrom.TabIndex = 1;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(14, 21);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(20, 13);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "От";
            // 
            // FormTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 364);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonVerboseMode);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewTours);
            this.Name = "FormTours";
            this.Text = "Туры";
            this.Load += new System.EventHandler(this.FormTours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewTours;
        private System.Windows.Forms.Button buttonVerboseMode;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCostTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxCostFrom;
        private System.Windows.Forms.Label labelFrom;
    }
}