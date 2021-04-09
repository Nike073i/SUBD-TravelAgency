
namespace TravelAgencyView
{
    partial class FormTour
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.dateTimePickerDayOfBegining = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfBegining = new System.Windows.Forms.Label();
            this.labelNumberOfDays = new System.Windows.Forms.Label();
            this.textBoxNumberOfDays = new System.Windows.Forms.TextBox();
            this.labelNumberOfPeople = new System.Windows.Forms.Label();
            this.textBoxNumberOfPeople = new System.Windows.Forms.TextBox();
            this.comboBoxHotels = new System.Windows.Forms.ComboBox();
            this.labelHotelName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(94, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(207, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название:";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(12, 51);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(65, 13);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "Стоимость:";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(94, 48);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(207, 20);
            this.textBoxCost.TabIndex = 2;
            // 
            // dateTimePickerDayOfBegining
            // 
            this.dateTimePickerDayOfBegining.Location = new System.Drawing.Point(144, 78);
            this.dateTimePickerDayOfBegining.Name = "dateTimePickerDayOfBegining";
            this.dateTimePickerDayOfBegining.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerDayOfBegining.TabIndex = 4;
            // 
            // labelDateOfBegining
            // 
            this.labelDateOfBegining.AutoSize = true;
            this.labelDateOfBegining.Location = new System.Drawing.Point(12, 81);
            this.labelDateOfBegining.Name = "labelDateOfBegining";
            this.labelDateOfBegining.Size = new System.Drawing.Size(74, 13);
            this.labelDateOfBegining.TabIndex = 5;
            this.labelDateOfBegining.Text = "Дата начала:";
            // 
            // labelNumberOfDays
            // 
            this.labelNumberOfDays.AutoSize = true;
            this.labelNumberOfDays.Location = new System.Drawing.Point(11, 107);
            this.labelNumberOfDays.Name = "labelNumberOfDays";
            this.labelNumberOfDays.Size = new System.Drawing.Size(96, 13);
            this.labelNumberOfDays.TabIndex = 7;
            this.labelNumberOfDays.Text = "Количество дней:";
            // 
            // textBoxNumberOfDays
            // 
            this.textBoxNumberOfDays.Location = new System.Drawing.Point(144, 104);
            this.textBoxNumberOfDays.Name = "textBoxNumberOfDays";
            this.textBoxNumberOfDays.Size = new System.Drawing.Size(156, 20);
            this.textBoxNumberOfDays.TabIndex = 6;
            // 
            // labelNumberOfPeople
            // 
            this.labelNumberOfPeople.AutoSize = true;
            this.labelNumberOfPeople.Location = new System.Drawing.Point(12, 133);
            this.labelNumberOfPeople.Name = "labelNumberOfPeople";
            this.labelNumberOfPeople.Size = new System.Drawing.Size(104, 13);
            this.labelNumberOfPeople.TabIndex = 9;
            this.labelNumberOfPeople.Text = "Количество людей:";
            // 
            // textBoxNumberOfPeople
            // 
            this.textBoxNumberOfPeople.Location = new System.Drawing.Point(144, 130);
            this.textBoxNumberOfPeople.Name = "textBoxNumberOfPeople";
            this.textBoxNumberOfPeople.Size = new System.Drawing.Size(157, 20);
            this.textBoxNumberOfPeople.TabIndex = 8;
            // 
            // comboBoxHotels
            // 
            this.comboBoxHotels.FormattingEnabled = true;
            this.comboBoxHotels.Location = new System.Drawing.Point(95, 161);
            this.comboBoxHotels.Name = "comboBoxHotels";
            this.comboBoxHotels.Size = new System.Drawing.Size(206, 21);
            this.comboBoxHotels.TabIndex = 10;
            // 
            // labelHotelName
            // 
            this.labelHotelName.AutoSize = true;
            this.labelHotelName.Location = new System.Drawing.Point(12, 164);
            this.labelHotelName.Name = "labelHotelName";
            this.labelHotelName.Size = new System.Drawing.Size(41, 13);
            this.labelHotelName.TabIndex = 11;
            this.labelHotelName.Text = "Отель:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(226, 196);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(132, 195);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // FormTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 230);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelHotelName);
            this.Controls.Add(this.comboBoxHotels);
            this.Controls.Add(this.labelNumberOfPeople);
            this.Controls.Add(this.textBoxNumberOfPeople);
            this.Controls.Add(this.labelNumberOfDays);
            this.Controls.Add(this.textBoxNumberOfDays);
            this.Controls.Add(this.labelDateOfBegining);
            this.Controls.Add(this.dateTimePickerDayOfBegining);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormTour";
            this.Text = "Тур";
            this.Load += new System.EventHandler(this.FormTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.DateTimePicker dateTimePickerDayOfBegining;
        private System.Windows.Forms.Label labelDateOfBegining;
        private System.Windows.Forms.Label labelNumberOfDays;
        private System.Windows.Forms.TextBox textBoxNumberOfDays;
        private System.Windows.Forms.Label labelNumberOfPeople;
        private System.Windows.Forms.TextBox textBoxNumberOfPeople;
        private System.Windows.Forms.ComboBox comboBoxHotels;
        private System.Windows.Forms.Label labelHotelName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}