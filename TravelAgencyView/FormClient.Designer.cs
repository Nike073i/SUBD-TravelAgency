
namespace TravelAgencyView
{
    partial class FormClient
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
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelSName = new System.Windows.Forms.Label();
            this.labelMName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.labelCNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(78, 60);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(157, 20);
            this.textBoxMiddleName.TabIndex = 17;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(314, 24);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(212, 20);
            this.textBoxSecondName.TabIndex = 16;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(78, 24);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(157, 20);
            this.textBoxFirstName.TabIndex = 15;
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(12, 27);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(35, 13);
            this.labelFName.TabIndex = 14;
            this.labelFName.Text = "Имя: ";
            // 
            // labelSName
            // 
            this.labelSName.AutoSize = true;
            this.labelSName.Location = new System.Drawing.Point(246, 27);
            this.labelSName.Name = "labelSName";
            this.labelSName.Size = new System.Drawing.Size(62, 13);
            this.labelSName.TabIndex = 13;
            this.labelSName.Text = "Фамилия: ";
            // 
            // labelMName
            // 
            this.labelMName.AutoSize = true;
            this.labelMName.Location = new System.Drawing.Point(12, 63);
            this.labelMName.Name = "labelMName";
            this.labelMName.Size = new System.Drawing.Size(60, 13);
            this.labelMName.TabIndex = 12;
            this.labelMName.Text = "Отчество: ";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(314, 111);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(160, 111);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Location = new System.Drawing.Point(314, 63);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(212, 20);
            this.textBoxContactNumber.TabIndex = 19;
            // 
            // labelCNumber
            // 
            this.labelCNumber.AutoSize = true;
            this.labelCNumber.Location = new System.Drawing.Point(248, 66);
            this.labelCNumber.Name = "labelCNumber";
            this.labelCNumber.Size = new System.Drawing.Size(58, 13);
            this.labelCNumber.TabIndex = 18;
            this.labelCNumber.Text = "Номер т.: ";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 144);
            this.Controls.Add(this.textBoxContactNumber);
            this.Controls.Add(this.labelCNumber);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelSName);
            this.Controls.Add(this.labelMName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormClient";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelSName;
        private System.Windows.Forms.Label labelMName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.Label labelCNumber;
    }
}