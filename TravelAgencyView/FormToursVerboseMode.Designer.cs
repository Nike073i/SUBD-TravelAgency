
namespace TravelAgencyView
{
    partial class FormToursVerboseMode
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
            this.dataGridViewTours = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumberOfPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfBeginning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumberOfDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTours
            // 
            this.dataGridViewTours.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnTour,
            this.ColumnCountry,
            this.ColumnAddress,
            this.ColumnNumberOfPeople,
            this.ColumnDateOfBeginning,
            this.ColumnNumberOfDays});
            this.dataGridViewTours.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTours.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTours.Size = new System.Drawing.Size(774, 263);
            this.dataGridViewTours.TabIndex = 20;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            // 
            // ColumnTour
            // 
            this.ColumnTour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTour.FillWeight = 15F;
            this.ColumnTour.HeaderText = "Тур";
            this.ColumnTour.Name = "ColumnTour";
            // 
            // ColumnCountry
            // 
            this.ColumnCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCountry.FillWeight = 15F;
            this.ColumnCountry.HeaderText = "Страна";
            this.ColumnCountry.Name = "ColumnCountry";
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAddress.FillWeight = 15F;
            this.ColumnAddress.HeaderText = "Адрес";
            this.ColumnAddress.Name = "ColumnAddress";
            // 
            // ColumnNumberOfPeople
            // 
            this.ColumnNumberOfPeople.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNumberOfPeople.FillWeight = 10F;
            this.ColumnNumberOfPeople.HeaderText = "Количество людей";
            this.ColumnNumberOfPeople.Name = "ColumnNumberOfPeople";
            // 
            // ColumnDateOfBeginning
            // 
            this.ColumnDateOfBeginning.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDateOfBeginning.FillWeight = 10F;
            this.ColumnDateOfBeginning.HeaderText = "Дата начала";
            this.ColumnDateOfBeginning.Name = "ColumnDateOfBeginning";
            // 
            // ColumnNumberOfDays
            // 
            this.ColumnNumberOfDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNumberOfDays.FillWeight = 10F;
            this.ColumnNumberOfDays.HeaderText = "Количество дней";
            this.ColumnNumberOfDays.Name = "ColumnNumberOfDays";
            // 
            // FormToursVerboseMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 285);
            this.Controls.Add(this.dataGridViewTours);
            this.Name = "FormToursVerboseMode";
            this.Text = "Туры в подробном режиме";
            this.Load += new System.EventHandler(this.FormToursVerboseMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTours;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumberOfPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfBeginning;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumberOfDays;
    }
}