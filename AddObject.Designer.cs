namespace WindowsFormsApp3
{
    partial class AddObject
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
            this.labelid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.SpaceBox = new System.Windows.Forms.TextBox();
            this.LivingSpaceBox = new System.Windows.Forms.TextBox();
            this.RoomsBox = new System.Windows.Forms.TextBox();
            this.FloorBox = new System.Windows.Forms.TextBox();
            this.CostPerDay = new System.Windows.Forms.TextBox();
            this.objectId = new System.Windows.Forms.Label();
            this.AddObjBut = new System.Windows.Forms.Button();
            this.CanObjBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(275, 20);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(92, 16);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "Код объекта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адресс объекта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Общая площадь:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Жилая площадь:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Кол-во комнат:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Этаж:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Стоимость в сутки:";
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(394, 64);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(100, 22);
            this.AdressBox.TabIndex = 7;
            // 
            // SpaceBox
            // 
            this.SpaceBox.Location = new System.Drawing.Point(394, 107);
            this.SpaceBox.Name = "SpaceBox";
            this.SpaceBox.Size = new System.Drawing.Size(100, 22);
            this.SpaceBox.TabIndex = 8;
            // 
            // LivingSpaceBox
            // 
            this.LivingSpaceBox.Location = new System.Drawing.Point(394, 149);
            this.LivingSpaceBox.Name = "LivingSpaceBox";
            this.LivingSpaceBox.Size = new System.Drawing.Size(100, 22);
            this.LivingSpaceBox.TabIndex = 9;
            // 
            // RoomsBox
            // 
            this.RoomsBox.Location = new System.Drawing.Point(394, 191);
            this.RoomsBox.Name = "RoomsBox";
            this.RoomsBox.Size = new System.Drawing.Size(100, 22);
            this.RoomsBox.TabIndex = 10;
            // 
            // FloorBox
            // 
            this.FloorBox.Location = new System.Drawing.Point(394, 230);
            this.FloorBox.Name = "FloorBox";
            this.FloorBox.Size = new System.Drawing.Size(100, 22);
            this.FloorBox.TabIndex = 11;
            // 
            // CostPerDay
            // 
            this.CostPerDay.Location = new System.Drawing.Point(394, 270);
            this.CostPerDay.Name = "CostPerDay";
            this.CostPerDay.Size = new System.Drawing.Size(100, 22);
            this.CostPerDay.TabIndex = 12;
            // 
            // objectId
            // 
            this.objectId.AutoSize = true;
            this.objectId.Location = new System.Drawing.Point(394, 20);
            this.objectId.Name = "objectId";
            this.objectId.Size = new System.Drawing.Size(0, 16);
            this.objectId.TabIndex = 13;
            // 
            // AddObjBut
            // 
            this.AddObjBut.Location = new System.Drawing.Point(229, 356);
            this.AddObjBut.Name = "AddObjBut";
            this.AddObjBut.Size = new System.Drawing.Size(111, 47);
            this.AddObjBut.TabIndex = 14;
            this.AddObjBut.Text = "Добавить объект";
            this.AddObjBut.UseVisualStyleBackColor = true;
            this.AddObjBut.Click += new System.EventHandler(this.AddObjBut_Click);
            // 
            // CanObjBut
            // 
            this.CanObjBut.Location = new System.Drawing.Point(425, 356);
            this.CanObjBut.Name = "CanObjBut";
            this.CanObjBut.Size = new System.Drawing.Size(111, 47);
            this.CanObjBut.TabIndex = 15;
            this.CanObjBut.Text = "Отмена";
            this.CanObjBut.UseVisualStyleBackColor = true;
            this.CanObjBut.Click += new System.EventHandler(this.CanObjBut_Click);
            // 
            // AddObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CanObjBut);
            this.Controls.Add(this.AddObjBut);
            this.Controls.Add(this.objectId);
            this.Controls.Add(this.CostPerDay);
            this.Controls.Add(this.FloorBox);
            this.Controls.Add(this.RoomsBox);
            this.Controls.Add(this.LivingSpaceBox);
            this.Controls.Add(this.SpaceBox);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelid);
            this.Name = "AddObject";
            this.Text = "Добавить объект";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.TextBox SpaceBox;
        private System.Windows.Forms.TextBox LivingSpaceBox;
        private System.Windows.Forms.TextBox RoomsBox;
        private System.Windows.Forms.TextBox FloorBox;
        private System.Windows.Forms.TextBox CostPerDay;
        private System.Windows.Forms.Label objectId;
        private System.Windows.Forms.Button AddObjBut;
        private System.Windows.Forms.Button CanObjBut;
    }
}