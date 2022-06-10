namespace WindowsFormsApp3
{
    partial class Nedviga
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.ChangeClientBut = new System.Windows.Forms.Button();
            this.DelClientBut = new System.Windows.Forms.Button();
            this.AddClientBut = new System.Windows.Forms.Button();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabObjects = new System.Windows.Forms.TabPage();
            this.ChangeObjBut = new System.Windows.Forms.Button();
            this.dataGridObjects = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Space = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LivingSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelObjectBut = new System.Windows.Forms.Button();
            this.AddObjectBut = new System.Windows.Forms.Button();
            this.tabRents = new System.Windows.Forms.TabPage();
            this.UploadToExcel = new System.Windows.Forms.Button();
            this.ChangeRentBut = new System.Windows.Forms.Button();
            this.DelRentBut = new System.Windows.Forms.Button();
            this.AddRentBut = new System.Windows.Forms.Button();
            this.dataGridRents = new System.Windows.Forms.DataGridView();
            this.IDRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tab.SuspendLayout();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.tabObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObjects)).BeginInit();
            this.tabRents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRents)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabClients);
            this.Tab.Controls.Add(this.tabObjects);
            this.Tab.Controls.Add(this.tabRents);
            this.Tab.Location = new System.Drawing.Point(-1, 5);
            this.Tab.Margin = new System.Windows.Forms.Padding(4);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1417, 555);
            this.Tab.TabIndex = 6;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.ChangeClientBut);
            this.tabClients.Controls.Add(this.DelClientBut);
            this.tabClients.Controls.Add(this.AddClientBut);
            this.tabClients.Controls.Add(this.dataGridClients);
            this.tabClients.Location = new System.Drawing.Point(4, 25);
            this.tabClients.Margin = new System.Windows.Forms.Padding(4);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(4);
            this.tabClients.Size = new System.Drawing.Size(1409, 526);
            this.tabClients.TabIndex = 1;
            this.tabClients.Text = "Клиенты";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // ChangeClientBut
            // 
            this.ChangeClientBut.Location = new System.Drawing.Point(1016, 225);
            this.ChangeClientBut.Name = "ChangeClientBut";
            this.ChangeClientBut.Size = new System.Drawing.Size(119, 45);
            this.ChangeClientBut.TabIndex = 3;
            this.ChangeClientBut.Text = "Изменить Клиента";
            this.ChangeClientBut.UseVisualStyleBackColor = true;
            this.ChangeClientBut.Click += new System.EventHandler(this.ChangeClientBut_Click);
            // 
            // DelClientBut
            // 
            this.DelClientBut.Location = new System.Drawing.Point(1016, 174);
            this.DelClientBut.Name = "DelClientBut";
            this.DelClientBut.Size = new System.Drawing.Size(119, 45);
            this.DelClientBut.TabIndex = 2;
            this.DelClientBut.Text = "Удалить Клиента";
            this.DelClientBut.UseVisualStyleBackColor = true;
            this.DelClientBut.Click += new System.EventHandler(this.DelClientBut_Click);
            // 
            // AddClientBut
            // 
            this.AddClientBut.Location = new System.Drawing.Point(1016, 121);
            this.AddClientBut.Name = "AddClientBut";
            this.AddClientBut.Size = new System.Drawing.Size(119, 45);
            this.AddClientBut.TabIndex = 1;
            this.AddClientBut.Text = "Добавить Клиента";
            this.AddClientBut.UseVisualStyleBackColor = true;
            this.AddClientBut.Click += new System.EventHandler(this.AddClientBut_Click);
            // 
            // dataGridClients
            // 
            this.dataGridClients.AllowUserToAddRows = false;
            this.dataGridClients.AllowUserToDeleteRows = false;
            this.dataGridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.Surname,
            this.ClientName,
            this.MiddleName,
            this.BirthDay,
            this.PhoneNumber});
            this.dataGridClients.Location = new System.Drawing.Point(0, 0);
            this.dataGridClients.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.ReadOnly = true;
            this.dataGridClients.RowHeadersVisible = false;
            this.dataGridClients.RowHeadersWidth = 51;
            this.dataGridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClients.Size = new System.Drawing.Size(994, 533);
            this.dataGridClients.TabIndex = 0;
            // 
            // ClientId
            // 
            this.ClientId.HeaderText = "Код клиента";
            this.ClientId.MinimumWidth = 6;
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Имя";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Фамилия";
            this.MiddleName.MinimumWidth = 6;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // BirthDay
            // 
            this.BirthDay.HeaderText = "Дата Рождения";
            this.BirthDay.MinimumWidth = 6;
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Номер Телефона";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // tabObjects
            // 
            this.tabObjects.Controls.Add(this.ChangeObjBut);
            this.tabObjects.Controls.Add(this.dataGridObjects);
            this.tabObjects.Controls.Add(this.DelObjectBut);
            this.tabObjects.Controls.Add(this.AddObjectBut);
            this.tabObjects.Location = new System.Drawing.Point(4, 25);
            this.tabObjects.Margin = new System.Windows.Forms.Padding(4);
            this.tabObjects.Name = "tabObjects";
            this.tabObjects.Size = new System.Drawing.Size(1409, 526);
            this.tabObjects.TabIndex = 2;
            this.tabObjects.Text = "Объекты";
            this.tabObjects.UseVisualStyleBackColor = true;
            // 
            // ChangeObjBut
            // 
            this.ChangeObjBut.Location = new System.Drawing.Point(1253, 297);
            this.ChangeObjBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeObjBut.Name = "ChangeObjBut";
            this.ChangeObjBut.Size = new System.Drawing.Size(108, 49);
            this.ChangeObjBut.TabIndex = 13;
            this.ChangeObjBut.Text = "Изменить Объект";
            this.ChangeObjBut.UseVisualStyleBackColor = true;
            this.ChangeObjBut.Click += new System.EventHandler(this.ChangeObjBut_Click);
            // 
            // dataGridObjects
            // 
            this.dataGridObjects.AllowUserToAddRows = false;
            this.dataGridObjects.AllowUserToDeleteRows = false;
            this.dataGridObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Adress,
            this.Space,
            this.LivingSpace,
            this.Rooms,
            this.Floor,
            this.CostPerDay});
            this.dataGridObjects.Location = new System.Drawing.Point(-4, 1);
            this.dataGridObjects.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridObjects.Name = "dataGridObjects";
            this.dataGridObjects.ReadOnly = true;
            this.dataGridObjects.RowHeadersVisible = false;
            this.dataGridObjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridObjects.Size = new System.Drawing.Size(1220, 526);
            this.dataGridObjects.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Код объекта";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Адресс объекта";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            // 
            // Space
            // 
            this.Space.HeaderText = "Общая площадь";
            this.Space.MinimumWidth = 6;
            this.Space.Name = "Space";
            this.Space.ReadOnly = true;
            // 
            // LivingSpace
            // 
            this.LivingSpace.HeaderText = "Жилая площадь";
            this.LivingSpace.MinimumWidth = 6;
            this.LivingSpace.Name = "LivingSpace";
            this.LivingSpace.ReadOnly = true;
            // 
            // Rooms
            // 
            this.Rooms.HeaderText = "Кол-во комнат";
            this.Rooms.MinimumWidth = 6;
            this.Rooms.Name = "Rooms";
            this.Rooms.ReadOnly = true;
            // 
            // Floor
            // 
            this.Floor.HeaderText = "Этаж";
            this.Floor.MinimumWidth = 6;
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            // 
            // CostPerDay
            // 
            this.CostPerDay.HeaderText = "Стоимость в сутки";
            this.CostPerDay.MinimumWidth = 6;
            this.CostPerDay.Name = "CostPerDay";
            this.CostPerDay.ReadOnly = true;
            // 
            // DelObjectBut
            // 
            this.DelObjectBut.Location = new System.Drawing.Point(1253, 227);
            this.DelObjectBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelObjectBut.Name = "DelObjectBut";
            this.DelObjectBut.Size = new System.Drawing.Size(108, 49);
            this.DelObjectBut.TabIndex = 12;
            this.DelObjectBut.Text = "Удалить Объект";
            this.DelObjectBut.UseVisualStyleBackColor = true;
            this.DelObjectBut.Click += new System.EventHandler(this.DelObjectBut_Click);
            // 
            // AddObjectBut
            // 
            this.AddObjectBut.Location = new System.Drawing.Point(1253, 159);
            this.AddObjectBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddObjectBut.Name = "AddObjectBut";
            this.AddObjectBut.Size = new System.Drawing.Size(108, 49);
            this.AddObjectBut.TabIndex = 12;
            this.AddObjectBut.Text = "Добавить Объект";
            this.AddObjectBut.UseVisualStyleBackColor = true;
            this.AddObjectBut.Click += new System.EventHandler(this.AddObjectBut_Click);
            // 
            // tabRents
            // 
            this.tabRents.Controls.Add(this.UploadToExcel);
            this.tabRents.Controls.Add(this.ChangeRentBut);
            this.tabRents.Controls.Add(this.DelRentBut);
            this.tabRents.Controls.Add(this.AddRentBut);
            this.tabRents.Controls.Add(this.dataGridRents);
            this.tabRents.Location = new System.Drawing.Point(4, 25);
            this.tabRents.Margin = new System.Windows.Forms.Padding(4);
            this.tabRents.Name = "tabRents";
            this.tabRents.Padding = new System.Windows.Forms.Padding(4);
            this.tabRents.Size = new System.Drawing.Size(1409, 526);
            this.tabRents.TabIndex = 0;
            this.tabRents.Text = "Аренды";
            this.tabRents.UseVisualStyleBackColor = true;
            // 
            // UploadToExcel
            // 
            this.UploadToExcel.Location = new System.Drawing.Point(1093, 303);
            this.UploadToExcel.Name = "UploadToExcel";
            this.UploadToExcel.Size = new System.Drawing.Size(118, 51);
            this.UploadToExcel.TabIndex = 15;
            this.UploadToExcel.Text = "Открыть в Excel";
            this.UploadToExcel.UseVisualStyleBackColor = true;
            this.UploadToExcel.Click += new System.EventHandler(this.UploadToExcel_Click);
            // 
            // ChangeRentBut
            // 
            this.ChangeRentBut.Location = new System.Drawing.Point(1093, 229);
            this.ChangeRentBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeRentBut.Name = "ChangeRentBut";
            this.ChangeRentBut.Size = new System.Drawing.Size(118, 51);
            this.ChangeRentBut.TabIndex = 14;
            this.ChangeRentBut.Text = "Изменить аренду";
            this.ChangeRentBut.UseVisualStyleBackColor = true;
            this.ChangeRentBut.Click += new System.EventHandler(this.ChangeRentBut_Click);
            // 
            // DelRentBut
            // 
            this.DelRentBut.Location = new System.Drawing.Point(1093, 157);
            this.DelRentBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelRentBut.Name = "DelRentBut";
            this.DelRentBut.Size = new System.Drawing.Size(118, 51);
            this.DelRentBut.TabIndex = 13;
            this.DelRentBut.Text = "Удалить аренду";
            this.DelRentBut.UseVisualStyleBackColor = true;
            this.DelRentBut.Click += new System.EventHandler(this.DelRentBut_Click);
            // 
            // AddRentBut
            // 
            this.AddRentBut.Location = new System.Drawing.Point(1093, 76);
            this.AddRentBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRentBut.Name = "AddRentBut";
            this.AddRentBut.Size = new System.Drawing.Size(118, 51);
            this.AddRentBut.TabIndex = 12;
            this.AddRentBut.Text = "Добавить аренду";
            this.AddRentBut.UseVisualStyleBackColor = true;
            this.AddRentBut.Click += new System.EventHandler(this.AddRentBut_Click);
            // 
            // dataGridRents
            // 
            this.dataGridRents.AllowUserToAddRows = false;
            this.dataGridRents.AllowUserToDeleteRows = false;
            this.dataGridRents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRent,
            this.DateStart,
            this.DataEnd,
            this.SummZ,
            this.IdClient,
            this.IdObject,
            this.RentSum});
            this.dataGridRents.Location = new System.Drawing.Point(0, 2);
            this.dataGridRents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridRents.Name = "dataGridRents";
            this.dataGridRents.ReadOnly = true;
            this.dataGridRents.RowHeadersVisible = false;
            this.dataGridRents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridRents.RowTemplate.Height = 24;
            this.dataGridRents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRents.Size = new System.Drawing.Size(1008, 524);
            this.dataGridRents.TabIndex = 1;
            // 
            // IDRent
            // 
            this.IDRent.HeaderText = "Код аренды";
            this.IDRent.MinimumWidth = 6;
            this.IDRent.Name = "IDRent";
            this.IDRent.ReadOnly = true;
            // 
            // DateStart
            // 
            this.DateStart.HeaderText = "Дата начала";
            this.DateStart.MinimumWidth = 6;
            this.DateStart.Name = "DateStart";
            this.DateStart.ReadOnly = true;
            // 
            // DataEnd
            // 
            this.DataEnd.HeaderText = "Дата окончания";
            this.DataEnd.MinimumWidth = 6;
            this.DataEnd.Name = "DataEnd";
            this.DataEnd.ReadOnly = true;
            // 
            // SummZ
            // 
            this.SummZ.HeaderText = "Сумма залога (Рубли)";
            this.SummZ.MinimumWidth = 6;
            this.SummZ.Name = "SummZ";
            this.SummZ.ReadOnly = true;
            // 
            // IdClient
            // 
            this.IdClient.HeaderText = "Клиент (код клиента)";
            this.IdClient.MinimumWidth = 6;
            this.IdClient.Name = "IdClient";
            this.IdClient.ReadOnly = true;
            // 
            // IdObject
            // 
            this.IdObject.HeaderText = "Адресс объекта (код объекта)";
            this.IdObject.MinimumWidth = 6;
            this.IdObject.Name = "IdObject";
            this.IdObject.ReadOnly = true;
            // 
            // RentSum
            // 
            this.RentSum.HeaderText = "Сумма аренды";
            this.RentSum.MinimumWidth = 6;
            this.RentSum.Name = "RentSum";
            this.RentSum.ReadOnly = true;
            // 
            // Nedviga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 825);
            this.Controls.Add(this.Tab);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Nedviga";
            this.Text = "Аренда объектов";
            this.Tab.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.tabObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridObjects)).EndInit();
            this.tabRents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabRents;
        private System.Windows.Forms.DataGridView dataGridRents;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.TabPage tabObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridView dataGridObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Space;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivingSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPerDay;
        private System.Windows.Forms.Button ChangeClientBut;
        private System.Windows.Forms.Button DelClientBut;
        private System.Windows.Forms.Button AddClientBut;
        private System.Windows.Forms.Button AddObjectBut;
        private System.Windows.Forms.Button DelObjectBut;
        private System.Windows.Forms.Button ChangeObjBut;
        private System.Windows.Forms.Button AddRentBut;
        private System.Windows.Forms.Button ChangeRentBut;
        private System.Windows.Forms.Button DelRentBut;
        private System.Windows.Forms.Button UploadToExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentSum;
    }
}

