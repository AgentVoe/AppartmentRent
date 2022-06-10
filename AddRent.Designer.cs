namespace WindowsFormsApp3
{
    partial class AddRent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StartBox = new System.Windows.Forms.TextBox();
            this.EndBox = new System.Windows.Forms.TextBox();
            this.DepositBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RentId = new System.Windows.Forms.Label();
            this.AddRentBut = new System.Windows.Forms.Button();
            this.CancAddRentBut = new System.Windows.Forms.Button();
            this.ClientIdBox = new System.Windows.Forms.ComboBox();
            this.AdressIdBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата начала:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата окончания:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сумма залога:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Клиент (код клиента):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Адрес объекта (код объекта):";
            // 
            // StartBox
            // 
            this.StartBox.Location = new System.Drawing.Point(332, 103);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(100, 22);
            this.StartBox.TabIndex = 7;
            // 
            // EndBox
            // 
            this.EndBox.Location = new System.Drawing.Point(332, 151);
            this.EndBox.Name = "EndBox";
            this.EndBox.Size = new System.Drawing.Size(100, 22);
            this.EndBox.TabIndex = 8;
            // 
            // DepositBox
            // 
            this.DepositBox.Location = new System.Drawing.Point(332, 193);
            this.DepositBox.Name = "DepositBox";
            this.DepositBox.Size = new System.Drawing.Size(100, 22);
            this.DepositBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код аренды:";
            // 
            // RentId
            // 
            this.RentId.AutoSize = true;
            this.RentId.Location = new System.Drawing.Point(329, 67);
            this.RentId.Name = "RentId";
            this.RentId.Size = new System.Drawing.Size(0, 16);
            this.RentId.TabIndex = 6;
            // 
            // AddRentBut
            // 
            this.AddRentBut.Location = new System.Drawing.Point(153, 347);
            this.AddRentBut.Name = "AddRentBut";
            this.AddRentBut.Size = new System.Drawing.Size(114, 48);
            this.AddRentBut.TabIndex = 18;
            this.AddRentBut.Text = "Добавить Аренду";
            this.AddRentBut.UseVisualStyleBackColor = true;
            this.AddRentBut.Click += new System.EventHandler(this.AddRentBut_Click);
            // 
            // CancAddRentBut
            // 
            this.CancAddRentBut.Location = new System.Drawing.Point(318, 347);
            this.CancAddRentBut.Name = "CancAddRentBut";
            this.CancAddRentBut.Size = new System.Drawing.Size(114, 48);
            this.CancAddRentBut.TabIndex = 19;
            this.CancAddRentBut.Text = "Отмена";
            this.CancAddRentBut.UseVisualStyleBackColor = true;
            this.CancAddRentBut.Click += new System.EventHandler(this.CancAddRentBut_Click);
            // 
            // ClientIdBox
            // 
            this.ClientIdBox.FormattingEnabled = true;
            this.ClientIdBox.Location = new System.Drawing.Point(332, 228);
            this.ClientIdBox.Name = "ClientIdBox";
            this.ClientIdBox.Size = new System.Drawing.Size(121, 24);
            this.ClientIdBox.TabIndex = 20;
            // 
            // AdressIdBox
            // 
            this.AdressIdBox.FormattingEnabled = true;
            this.AdressIdBox.Location = new System.Drawing.Point(332, 269);
            this.AdressIdBox.Name = "AdressIdBox";
            this.AdressIdBox.Size = new System.Drawing.Size(121, 24);
            this.AdressIdBox.TabIndex = 21;
            // 
            // AddRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 507);
            this.Controls.Add(this.AdressIdBox);
            this.Controls.Add(this.ClientIdBox);
            this.Controls.Add(this.CancAddRentBut);
            this.Controls.Add(this.AddRentBut);
            this.Controls.Add(this.DepositBox);
            this.Controls.Add(this.EndBox);
            this.Controls.Add(this.StartBox);
            this.Controls.Add(this.RentId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRent";
            this.Text = "Добавить аренду";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StartBox;
        private System.Windows.Forms.TextBox EndBox;
        private System.Windows.Forms.TextBox DepositBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RentId;
        private System.Windows.Forms.Button AddRentBut;
        private System.Windows.Forms.Button CancAddRentBut;
        private System.Windows.Forms.ComboBox ClientIdBox;
        private System.Windows.Forms.ComboBox AdressIdBox;
    }
}