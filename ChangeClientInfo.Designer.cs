namespace WindowsFormsApp3
{
    partial class ChangeClientInfo
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
            this.ClientId = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.BirthDayBox = new System.Windows.Forms.TextBox();
            this.ChangeInfo = new System.Windows.Forms.Button();
            this.NoChangeBut = new System.Windows.Forms.Button();
            this.maskedPhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код клиента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата Рождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Номер телефона:";
            // 
            // ClientId
            // 
            this.ClientId.AutoSize = true;
            this.ClientId.Location = new System.Drawing.Point(346, 64);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(0, 16);
            this.ClientId.TabIndex = 6;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(349, 102);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(131, 22);
            this.SurnameBox.TabIndex = 7;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(349, 145);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(131, 22);
            this.NameBox.TabIndex = 8;
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Location = new System.Drawing.Point(349, 187);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(131, 22);
            this.MiddleNameBox.TabIndex = 9;
            // 
            // BirthDayBox
            // 
            this.BirthDayBox.Location = new System.Drawing.Point(349, 229);
            this.BirthDayBox.Name = "BirthDayBox";
            this.BirthDayBox.Size = new System.Drawing.Size(131, 22);
            this.BirthDayBox.TabIndex = 10;
            // 
            // ChangeInfo
            // 
            this.ChangeInfo.Location = new System.Drawing.Point(183, 330);
            this.ChangeInfo.Name = "ChangeInfo";
            this.ChangeInfo.Size = new System.Drawing.Size(119, 45);
            this.ChangeInfo.TabIndex = 12;
            this.ChangeInfo.Text = "Добавить изменения";
            this.ChangeInfo.UseVisualStyleBackColor = true;
            this.ChangeInfo.Click += new System.EventHandler(this.ChangeInfo_Click);
            // 
            // NoChangeBut
            // 
            this.NoChangeBut.Location = new System.Drawing.Point(361, 330);
            this.NoChangeBut.Name = "NoChangeBut";
            this.NoChangeBut.Size = new System.Drawing.Size(119, 45);
            this.NoChangeBut.TabIndex = 13;
            this.NoChangeBut.Text = "Отмена";
            this.NoChangeBut.UseVisualStyleBackColor = true;
            this.NoChangeBut.Click += new System.EventHandler(this.NoChangeBut_Click);
            // 
            // maskedPhoneBox
            // 
            this.maskedPhoneBox.Location = new System.Drawing.Point(349, 270);
            this.maskedPhoneBox.Mask = "+7 (000) 000-00-00";
            this.maskedPhoneBox.Name = "maskedPhoneBox";
            this.maskedPhoneBox.Size = new System.Drawing.Size(134, 22);
            this.maskedPhoneBox.TabIndex = 14;
            // 
            // ChangeClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedPhoneBox);
            this.Controls.Add(this.NoChangeBut);
            this.Controls.Add(this.ChangeInfo);
            this.Controls.Add(this.BirthDayBox);
            this.Controls.Add(this.MiddleNameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.ClientId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeClientInfo";
            this.Text = "Изменить информацию о клиенте";
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
        private System.Windows.Forms.Label ClientId;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox MiddleNameBox;
        private System.Windows.Forms.TextBox BirthDayBox;
        private System.Windows.Forms.Button ChangeInfo;
        private System.Windows.Forms.Button NoChangeBut;
        private System.Windows.Forms.MaskedTextBox maskedPhoneBox;
    }
}