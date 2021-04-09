
namespace TravelAgencyView
{
    partial class FormHotel
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
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelCNumber = new System.Windows.Forms.Label();
            this.textBoxCNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(13, 53);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(46, 13);
            this.labelCountry.TabIndex = 23;
            this.labelCountry.Text = "Страна:";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(79, 76);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(244, 20);
            this.textBoxRating.TabIndex = 22;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Название:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(79, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(244, 20);
            this.textBoxName.TabIndex = 20;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(248, 167);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(154, 166);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(79, 50);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(244, 21);
            this.comboBoxCountries.TabIndex = 24;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(13, 79);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(51, 13);
            this.labelRating.TabIndex = 25;
            this.labelRating.Text = "Рейтинг:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(13, 105);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(41, 13);
            this.labelAddress.TabIndex = 27;
            this.labelAddress.Text = "Адрес:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(79, 102);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(244, 20);
            this.textBoxAddress.TabIndex = 26;
            // 
            // labelCNumber
            // 
            this.labelCNumber.AutoSize = true;
            this.labelCNumber.Location = new System.Drawing.Point(13, 131);
            this.labelCNumber.Name = "labelCNumber";
            this.labelCNumber.Size = new System.Drawing.Size(55, 13);
            this.labelCNumber.TabIndex = 29;
            this.labelCNumber.Text = "Номер т.:";
            // 
            // textBoxCNumber
            // 
            this.textBoxCNumber.Location = new System.Drawing.Point(79, 128);
            this.textBoxCNumber.Name = "textBoxCNumber";
            this.textBoxCNumber.Size = new System.Drawing.Size(244, 20);
            this.textBoxCNumber.TabIndex = 28;
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 201);
            this.Controls.Add(this.labelCNumber);
            this.Controls.Add(this.textBoxCNumber);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.comboBoxCountries);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormHotel";
            this.Text = "Отель";
            this.Load += new System.EventHandler(this.FormHotel_Load);
            this.Click += new System.EventHandler(this.FormHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelCNumber;
        private System.Windows.Forms.TextBox textBoxCNumber;
    }
}