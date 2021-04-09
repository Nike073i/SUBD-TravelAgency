
namespace TravelAgencyView
{
    partial class FormSale
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
            this.comboBoxTours = new System.Windows.Forms.ComboBox();
            this.labelTour = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfSale = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTours
            // 
            this.comboBoxTours.FormattingEnabled = true;
            this.comboBoxTours.Location = new System.Drawing.Point(80, 12);
            this.comboBoxTours.Name = "comboBoxTours";
            this.comboBoxTours.Size = new System.Drawing.Size(244, 21);
            this.comboBoxTours.TabIndex = 28;
            // 
            // labelTour
            // 
            this.labelTour.AutoSize = true;
            this.labelTour.Location = new System.Drawing.Point(14, 15);
            this.labelTour.Name = "labelTour";
            this.labelTour.Size = new System.Drawing.Size(28, 13);
            this.labelTour.TabIndex = 27;
            this.labelTour.Text = "Тур:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(249, 103);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(155, 102);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(80, 39);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(244, 21);
            this.comboBoxClients.TabIndex = 30;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(14, 42);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(46, 13);
            this.labelClient.TabIndex = 29;
            this.labelClient.Text = "Страна:";
            // 
            // dateTimePickerDateOfSale
            // 
            this.dateTimePickerDateOfSale.Location = new System.Drawing.Point(180, 66);
            this.dateTimePickerDateOfSale.Name = "dateTimePickerDateOfSale";
            this.dateTimePickerDateOfSale.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerDateOfSale.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Дата продажи:";
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 132);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDateOfSale);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxTours);
            this.Controls.Add(this.labelTour);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormSale";
            this.Text = "Продажа";
            this.Load += new System.EventHandler(this.FormSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTours;
        private System.Windows.Forms.Label labelTour;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfSale;
        private System.Windows.Forms.Label label1;
    }
}