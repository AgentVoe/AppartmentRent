namespace WindowsFormsApp3
{
    partial class AddClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clientId = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.middleNameBox = new System.Windows.Forms.TextBox();
            this.birtDayBox = new System.Windows.Forms.TextBox();
            this.addClientBut = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.maskedPhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код клиента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата Рождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Номер телефона:";
            // 
            // clientId
            // 
            this.clientId.AutoSize = true;
            this.clientId.Location = new System.Drawing.Point(285, 56);
            this.clientId.Name = "clientId";
            this.clientId.Size = new System.Drawing.Size(0, 16);
            this.clientId.TabIndex = 6;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(288, 103);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 22);
            this.surnameBox.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(288, 153);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 8;
            // 
            // middleNameBox
            // 
            this.middleNameBox.Location = new System.Drawing.Point(288, 187);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new System.Drawing.Size(100, 22);
            this.middleNameBox.TabIndex = 9;
            // 
            // birtDayBox
            // 
            this.birtDayBox.Location = new System.Drawing.Point(288, 225);
            this.birtDayBox.Name = "birtDayBox";
            this.birtDayBox.Size = new System.Drawing.Size(100, 22);
            this.birtDayBox.TabIndex = 10;
            // 
            // addClientBut
            // 
            this.addClientBut.Location = new System.Drawing.Point(176, 370);
            this.addClientBut.Name = "addClientBut";
            this.addClientBut.Size = new System.Drawing.Size(109, 44);
            this.addClientBut.TabIndex = 12;
            this.addClientBut.Text = "Добавить Клиента";
            this.addClientBut.UseVisualStyleBackColor = true;
            this.addClientBut.Click += new System.EventHandler(this.AddClientBut_Click);
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(380, 370);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(109, 44);
            this.CancelBut.TabIndex = 13;
            this.CancelBut.Text = "Отмена";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // maskedPhoneBox
            // 
            this.maskedPhoneBox.Location = new System.Drawing.Point(288, 275);
            this.maskedPhoneBox.Mask = "+7 (000) 000-00-00";
            this.maskedPhoneBox.Name = "maskedPhoneBox";
            this.maskedPhoneBox.Size = new System.Drawing.Size(123, 22);
            this.maskedPhoneBox.TabIndex = 14;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 491);
            this.Controls.Add(this.maskedPhoneBox);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.addClientBut);
            this.Controls.Add(this.birtDayBox);
            this.Controls.Add(this.middleNameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddClient";
            this.Text = "Добавить клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label clientId;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox middleNameBox;
        private System.Windows.Forms.TextBox birtDayBox;
        private System.Windows.Forms.Button addClientBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.MaskedTextBox maskedPhoneBox;
    }
}