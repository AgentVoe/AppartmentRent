namespace WindowsFormsApp3
{
    partial class ChangeRent
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
            this.RentId = new System.Windows.Forms.Label();
            this.StartBox = new System.Windows.Forms.TextBox();
            this.EndBox = new System.Windows.Forms.TextBox();
            this.DepositBox = new System.Windows.Forms.TextBox();
            this.ClientIdBox = new System.Windows.Forms.TextBox();
            this.AdressIdBox = new System.Windows.Forms.TextBox();
            this.AddChangedRentBut = new System.Windows.Forms.Button();
            this.CancChangeRentBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код аренды:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата начала:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата окончания:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сумма залога:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Клиент (код клиента):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Адрес объекта (код объекта):";
            // 
            // RentId
            // 
            this.RentId.AutoSize = true;
            this.RentId.Location = new System.Drawing.Point(381, 50);
            this.RentId.Name = "RentId";
            this.RentId.Size = new System.Drawing.Size(0, 16);
            this.RentId.TabIndex = 6;
            // 
            // StartBox
            // 
            this.StartBox.Location = new System.Drawing.Point(381, 87);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(100, 22);
            this.StartBox.TabIndex = 7;
            // 
            // EndBox
            // 
            this.EndBox.Location = new System.Drawing.Point(381, 130);
            this.EndBox.Name = "EndBox";
            this.EndBox.Size = new System.Drawing.Size(100, 22);
            this.EndBox.TabIndex = 8;
            // 
            // DepositBox
            // 
            this.DepositBox.Location = new System.Drawing.Point(381, 171);
            this.DepositBox.Name = "DepositBox";
            this.DepositBox.Size = new System.Drawing.Size(100, 22);
            this.DepositBox.TabIndex = 9;
            // 
            // ClientIdBox
            // 
            this.ClientIdBox.Location = new System.Drawing.Point(381, 214);
            this.ClientIdBox.Name = "ClientIdBox";
            this.ClientIdBox.Size = new System.Drawing.Size(100, 22);
            this.ClientIdBox.TabIndex = 10;
            // 
            // AdressIdBox
            // 
            this.AdressIdBox.Location = new System.Drawing.Point(381, 260);
            this.AdressIdBox.Name = "AdressIdBox";
            this.AdressIdBox.Size = new System.Drawing.Size(100, 22);
            this.AdressIdBox.TabIndex = 11;
            // 
            // AddChangedRentBut
            // 
            this.AddChangedRentBut.Location = new System.Drawing.Point(221, 343);
            this.AddChangedRentBut.Name = "AddChangedRentBut";
            this.AddChangedRentBut.Size = new System.Drawing.Size(111, 54);
            this.AddChangedRentBut.TabIndex = 12;
            this.AddChangedRentBut.Text = "Изменить Аренду";
            this.AddChangedRentBut.UseVisualStyleBackColor = true;
            this.AddChangedRentBut.Click += new System.EventHandler(this.AddChangedRentBut_Click);
            // 
            // CancChangeRentBut
            // 
            this.CancChangeRentBut.Location = new System.Drawing.Point(384, 343);
            this.CancChangeRentBut.Name = "CancChangeRentBut";
            this.CancChangeRentBut.Size = new System.Drawing.Size(111, 54);
            this.CancChangeRentBut.TabIndex = 13;
            this.CancChangeRentBut.Text = "Отмена";
            this.CancChangeRentBut.UseVisualStyleBackColor = true;
            this.CancChangeRentBut.Click += new System.EventHandler(this.CancChangeRentBut_Click);
            // 
            // ChangeRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancChangeRentBut);
            this.Controls.Add(this.AddChangedRentBut);
            this.Controls.Add(this.AdressIdBox);
            this.Controls.Add(this.ClientIdBox);
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
            this.Name = "ChangeRent";
            this.Text = "Изменить информацию об аренде";
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
        private System.Windows.Forms.Label RentId;
        private System.Windows.Forms.TextBox StartBox;
        private System.Windows.Forms.TextBox EndBox;
        private System.Windows.Forms.TextBox DepositBox;
        private System.Windows.Forms.TextBox ClientIdBox;
        private System.Windows.Forms.TextBox AdressIdBox;
        private System.Windows.Forms.Button AddChangedRentBut;
        private System.Windows.Forms.Button CancChangeRentBut;
    }
}