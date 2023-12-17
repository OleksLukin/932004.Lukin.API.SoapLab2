namespace SoapLab2
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
            this.BtnGetInfo = new System.Windows.Forms.Button();
            this.CmbCountryCapital = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbPhoneCode = new System.Windows.Forms.ComboBox();
            this.GroupOfBoxes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbCountryName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbCountryContinent = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbCurrencyIso = new System.Windows.Forms.ComboBox();
            this.GroupOfBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGetInfo
            // 
            this.BtnGetInfo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BtnGetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGetInfo.Location = new System.Drawing.Point(267, 64);
            this.BtnGetInfo.Name = "BtnGetInfo";
            this.BtnGetInfo.Size = new System.Drawing.Size(105, 46);
            this.BtnGetInfo.TabIndex = 0;
            this.BtnGetInfo.Text = "Find out!";
            this.BtnGetInfo.UseVisualStyleBackColor = false;
            this.BtnGetInfo.Click += new System.EventHandler(this.BtnGetInfo_Click);
            // 
            // CmbCountryCapital
            // 
            this.CmbCountryCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CmbCountryCapital.FormattingEnabled = true;
            this.CmbCountryCapital.Location = new System.Drawing.Point(87, 48);
            this.CmbCountryCapital.Name = "CmbCountryCapital";
            this.CmbCountryCapital.Size = new System.Drawing.Size(137, 23);
            this.CmbCountryCapital.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(234, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Where should I go?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(333, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone Code";
            // 
            // CmbPhoneCode
            // 
            this.CmbPhoneCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CmbPhoneCode.FormattingEnabled = true;
            this.CmbPhoneCode.Location = new System.Drawing.Point(297, 46);
            this.CmbPhoneCode.Name = "CmbPhoneCode";
            this.CmbPhoneCode.Size = new System.Drawing.Size(137, 23);
            this.CmbPhoneCode.TabIndex = 3;
            // 
            // GroupOfBoxes
            // 
            this.GroupOfBoxes.Controls.Add(this.label6);
            this.GroupOfBoxes.Controls.Add(this.CmbCurrencyIso);
            this.GroupOfBoxes.Controls.Add(this.label4);
            this.GroupOfBoxes.Controls.Add(this.label3);
            this.GroupOfBoxes.Controls.Add(this.CmbCountryContinent);
            this.GroupOfBoxes.Controls.Add(this.CmbCountryCapital);
            this.GroupOfBoxes.Controls.Add(this.label2);
            this.GroupOfBoxes.Controls.Add(this.CmbPhoneCode);
            this.GroupOfBoxes.Location = new System.Drawing.Point(58, 169);
            this.GroupOfBoxes.Name = "GroupOfBoxes";
            this.GroupOfBoxes.Size = new System.Drawing.Size(523, 171);
            this.GroupOfBoxes.TabIndex = 5;
            this.GroupOfBoxes.TabStop = false;
            this.GroupOfBoxes.Text = "Country Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(128, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Capital";
            // 
            // CmbCountryName
            // 
            this.CmbCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CmbCountryName.FormattingEnabled = true;
            this.CmbCountryName.Location = new System.Drawing.Point(248, 133);
            this.CmbCountryName.Name = "CmbCountryName";
            this.CmbCountryName.Size = new System.Drawing.Size(137, 26);
            this.CmbCountryName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(128, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Continent ";
            // 
            // CmbCountryContinent
            // 
            this.CmbCountryContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CmbCountryContinent.FormattingEnabled = true;
            this.CmbCountryContinent.Location = new System.Drawing.Point(87, 106);
            this.CmbCountryContinent.Name = "CmbCountryContinent";
            this.CmbCountryContinent.Size = new System.Drawing.Size(137, 23);
            this.CmbCountryContinent.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(314, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Currency ISO Code";
            // 
            // CmbCurrencyIso
            // 
            this.CmbCurrencyIso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CmbCurrencyIso.FormattingEnabled = true;
            this.CmbCurrencyIso.Location = new System.Drawing.Point(297, 106);
            this.CmbCurrencyIso.Name = "CmbCurrencyIso";
            this.CmbCurrencyIso.Size = new System.Drawing.Size(137, 23);
            this.CmbCurrencyIso.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(650, 415);
            this.Controls.Add(this.GroupOfBoxes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbCountryName);
            this.Controls.Add(this.BtnGetInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupOfBoxes.ResumeLayout(false);
            this.GroupOfBoxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGetInfo;
        private System.Windows.Forms.ComboBox CmbCountryCapital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbPhoneCode;
        private System.Windows.Forms.GroupBox GroupOfBoxes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbCountryName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbCountryContinent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbCurrencyIso;
    }
}

