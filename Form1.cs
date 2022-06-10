using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp3.Classes;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp3
{
    public partial class Nedviga : Form
    {
        AddClient addClientForm;
        ChangeClientInfo changeClientForm;
        AddObject addObjectForm;
        ChangeObjectInfo changeObjectForm;
        AddRent addRentForm;
        ChangeRent changeRentForm;
        public string clientPath = @"Клиенты (10 человек).txt";
        public string objectPath = @"Объекты (20 объектов).txt";
        public string rentPath = @"Аренды (30 штук).txt";
        public Nedviga()
        {
            InitializeComponent();
            var clientFile = RemoveSpace(clientPath);
            var objectFile = RemoveSpace(objectPath);
            var rentFile = RemoveSpace(rentPath);
            foreach (var item in clientFile)
            {
                var client = new Client(item.Split(','));
                if (client.Id != "#")
                    dataGridClients.Rows.Add(
                        client.Id,
                        client.Surname,
                        client.Name,
                        client.MiddleName,
                        client.BirthDay,
                        client.Phone);
            }
            foreach (var item in objectFile)
            {
                var obj = new Objects(item.Split(','));
                if (obj.Id != "#")
                    dataGridObjects.Rows.Add(
                        obj.Id,
                        obj.Adress,
                        obj.Space,
                        obj.LivingSpace,
                        obj.Rooms,
                        obj.Floor,
                        obj.CostPerDay);
            }
            foreach (var item in rentFile)
            {
                var rent = new Rent(item.Split(','));
                var client = rent.GetClientName(rent.ClientId);
                var adress = rent.GetObjectAdress(rent.AdressId);
                if (rent.Id != "#")
                    dataGridRents.Rows.Add(
                        rent.Id,
                        rent.StartDate,
                        rent.EndDate,
                        rent.Deposit,
                        client,
                        adress);
            }
            WriteRentsInfo();
            UpdateDataGridRents();
        }
        public string[] ReadFile(string path)
        {
            return File.ReadAllLines(path);
        }
        private bool dataGridViewChanged = false;
        public void WriteRentsInfo()
        {
            File.WriteAllText(rentPath, string.Empty);
            var sw = new StreamWriter(rentPath);
            sw.Write("#,Код аренды,Дата начала,Дата окончания,Сумма залога,Клиент (код клиента),Адрес объекта (код объекта)");
            sw.WriteLine();
            try
            {
                for (int j = 0; j < dataGridRents.Rows.Count; j++)
                {
                    for (int i = 0; i < dataGridRents.Rows[j].Cells.Count; i++)
                    {
                        if (i == dataGridRents.Rows[j].Cells.Count - 1)
                        {
                            break;
                        }                       
                        if (i == dataGridRents.Rows[j].Cells.Count - 3)
                        {
                            var rent = new Rent(dataGridRents.Rows[j].Cells[i].Value.ToString(), i);
                            var client = rent.GetClientId(rent.ClientId);
                            sw.Write(client + ",");
                        }
                        else if (i == dataGridRents.Rows[j].Cells.Count - 2)
                        {
                            var rent = new Rent(dataGridRents.Rows[j].Cells[i].Value.ToString());
                            var adress = rent.GetAdressId(rent.AdressId);
                            sw.Write(adress);
                        }                      
                        else
                            sw.Write(dataGridRents.Rows[j].Cells[i].Value + ",");
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }
        }
        private void RewriteDocument(string path)
        {
            File.WriteAllText(path, string.Empty);
            StreamWriter sw = new StreamWriter(path);
            if (path == clientPath)
            {
                sw.Write("#,Код клиента,Фамилмя,Имя,Отчество,Дата рождения,Телефон");
                sw.WriteLine();
                try
                {
                    for (int j = 0; j < dataGridClients.Rows.Count; j++)
                    {
                        for (int i = 0; i < dataGridClients.Rows[j].Cells.Count; i++)
                        {                           
                            if (i == dataGridClients.Rows[j].Cells.Count - 1)
                            {
                                sw.Write(dataGridClients.Rows[j].Cells[i].Value);
                            }
                            else
                                sw.Write(dataGridClients.Rows[j].Cells[i].Value + ",");
                        }
                        sw.WriteLine();
                    }
                    sw.Close();
                    MessageBox.Show("Файл успешно сохранен");
                }
                catch
                {
                    MessageBox.Show("Ошибка при сохранении файла!");
                }
            }
            else if (path == objectPath)
            {
                sw.Write("#,Код объекта,Адресс объекта,Общая площадь,Жилая площадь,Кол-во комнат,Этаж,Стоимость в сутки");
                sw.WriteLine();
                try
                {
                    for (int j = 0; j < dataGridObjects.Rows.Count; j++)
                    {
                        for (int i = 0; i < dataGridObjects.Rows[j].Cells.Count; i++)
                        {                          
                            if (i == dataGridObjects.Rows[j].Cells.Count - 1)
                            {
                                sw.Write(dataGridObjects.Rows[j].Cells[i].Value);
                            }
                            else
                                sw.Write(dataGridObjects.Rows[j].Cells[i].Value + ",");
                        }
                        sw.WriteLine();
                    }
                    sw.Close();
                    MessageBox.Show("Файл успешно сохранен");
                }
                catch
                {
                    MessageBox.Show("Ошибка при сохранении файла!");
                }
            }
            else if (path == rentPath)
            {
                sw.Write("#,Код аренды,Дата начала,Дата окончания,Сумма залога,Клиент (код клиента),Адрес объекта (код объекта)");
                sw.WriteLine();
                try
                {
                    for (int j = 0; j < dataGridRents.Rows.Count; j++)
                    {
                        for (int i = 0; i < dataGridRents.Rows[j].Cells.Count; i++)
                        {
                            if (i == dataGridRents.Rows[j].Cells.Count - 1)
                            {
                                break;
                            }                           
                            if (i == dataGridRents.Rows[j].Cells.Count - 3)
                            {
                                var rent = new Rent(dataGridRents.Rows[j].Cells[i].Value.ToString(), i);
                                var client = rent.GetClientId(rent.ClientId);
                                sw.Write(client + ",");
                            }
                            else if (i == dataGridRents.Rows[j].Cells.Count - 2)
                            {
                                var rent = new Rent(dataGridRents.Rows[j].Cells[i].Value.ToString());
                                var adress = rent.GetAdressId(rent.AdressId);
                                sw.Write(adress);
                            }                           
                            else
                                sw.Write(dataGridRents.Rows[j].Cells[i].Value + ",");
                        }
                        sw.WriteLine();
                    }
                    sw.Close();
                    MessageBox.Show("Файл успешно сохранён");
                }
                catch
                {
                    MessageBox.Show("Ошибка при сохранении файла!");
                }
            }
        }

        private void UpdateDataGridClients()
        {
            dataGridClients.Rows.Clear();
            var info = RemoveSpace(clientPath);
            foreach (var item in info)
            {
                var client = new Client(item.Split(','));
                if (client.Id != "#")
                    dataGridClients.Rows.Add(
                        client.Id,
                        client.Surname,
                        client.Name,
                        client.MiddleName,
                        client.BirthDay,
                        client.Phone);
            }
        }
        private void UpdateDataGridObjects()
        {
            dataGridClients.Rows.Clear();
            var info = RemoveSpace(objectPath);
            foreach (var item in info)
            {
                var obj = new Objects(item.Split(','));
                if (obj.Id != "#")
                    dataGridClients.Rows.Add(
                        obj.Id,
                        obj.Adress,
                        obj.Space,
                        obj.LivingSpace,
                        obj.Rooms,
                        obj.Floor,
                        obj.CostPerDay);
            }
        }
        private void UpdateDataGridRents()
        {
            dataGridRents.Rows.Clear();
            var info = RemoveSpace(rentPath);
            foreach (var item in info)
            {
                if (!item.Split(',').Any(x => x == string.Empty))
                {
                    
                    var rent = new Rent(item.Split(','));
                    
                    var client = rent.GetClientName(rent.ClientId);
                    var adress = rent.GetObjectAdress(rent.AdressId);
                    if (rent.Id != "#")
                    {
                        var rentSum = GetRentSum(rent);
                        dataGridRents.Rows.Add(
                                rent.Id,
                                rent.StartDate,
                                rent.EndDate,
                                rent.Deposit,
                                client,
                                adress,
                                rentSum);
                    }
                }
            }
        }
        public string[] RemoveSpace(string path)
        {
            var info = new List<string>();
            foreach (var item in ReadFile(path))
            {
                if (!string.IsNullOrEmpty(item))
                {
                    info.Add(item);
                }
            }
            return info.ToArray();

        }
        private bool InfoCheck(object arg)
        {
            return arg == null;
        }
        private void ChangeClientBut_Click(object sender, EventArgs e)
        {
            var data = RemoveSpace(clientPath);
            dataGridClients.Rows[dataGridClients.CurrentRow.Index].Selected = true;
            changeClientForm = new ChangeClientInfo(new string[6] {
                dataGridClients.CurrentRow.Cells[0].Value.ToString(),
                dataGridClients.CurrentRow.Cells[1].Value.ToString(),
                dataGridClients.CurrentRow.Cells[2].Value.ToString(),
                dataGridClients.CurrentRow.Cells[3].Value.ToString(),
                dataGridClients.CurrentRow.Cells[4].Value.ToString(),
                dataGridClients.CurrentRow.Cells[5].Value.ToString()
            }, data);
            changeClientForm.ShowDialog();
            var client = changeClientForm.ReturnClient();
            if (InfoCheck(client))
            {
                MessageBox.Show("Такой клиент существует или не все поля формы были заполнены!");
            }
            else
            {
                dataGridClients.CurrentRow.Cells[0].Value = client.Id;
                dataGridClients.CurrentRow.Cells[1].Value = client.Surname;
                dataGridClients.CurrentRow.Cells[2].Value = client.Name;
                dataGridClients.CurrentRow.Cells[3].Value = client.MiddleName;
                dataGridClients.CurrentRow.Cells[4].Value = client.BirthDay;
                dataGridClients.CurrentRow.Cells[5].Value = client.Phone;
                MessageBox.Show("Клиент успешно изменён!");
            }
            RewriteDocument(clientPath);
            UpdateDataGridClients();
            WriteRentsInfo();
            UpdateDataGridRents();
        }

        private void DelClientBut_Click(object sender, EventArgs e)
        {
            if (dataGridClients.CurrentRow != null)
            {
                dataGridClients.Rows.RemoveAt(dataGridClients.CurrentRow.Index);
                dataGridViewChanged = true;
            }
            RewriteDocument(clientPath);
            UpdateDataGridClients();
            WriteRentsInfo();
            UpdateDataGridRents();
        }

        private void AddClientBut_Click(object sender, EventArgs e)
        {
            var data = RemoveSpace(clientPath);
            addClientForm = new AddClient(data);
            addClientForm.ShowDialog();
            var client = addClientForm.ReturnClient();
            if (InfoCheck(client))
            {
                MessageBox.Show("Такой клиент существует или не все поля формы были заполнены!");
            }
            else
            {
                dataGridClients.Rows.Add(
                                       client.Id,
                                       client.Surname,
                                       client.Name,
                                       client.MiddleName,
                                       client.BirthDay,
                                       client.Phone);
                MessageBox.Show("Клиент успешно добвален");
            }
            RewriteDocument(clientPath);
            UpdateDataGridClients();
            WriteRentsInfo();
            UpdateDataGridRents();
        }

        private void DelObjectBut_Click(object sender, EventArgs e)
        {
            if (dataGridObjects.CurrentRow != null)
            {
                dataGridObjects.Rows.RemoveAt(dataGridObjects.CurrentRow.Index);
                dataGridViewChanged = true;
            }
            RewriteDocument(objectPath);
            UpdateDataGridObjects();
            WriteRentsInfo();
            UpdateDataGridRents();
        }

        private void AddObjectBut_Click(object sender, EventArgs e)
        {
            var data = RemoveSpace(objectPath);
            addObjectForm = new AddObject(data);
            addObjectForm.ShowDialog();
            var obj = addObjectForm.ReturnObject();
            if (InfoCheck(obj))
            {
                MessageBox.Show("Такой объект существует или не все поля формы были заполнены!");
            }
            else
            {
                dataGridObjects.Rows.Add(
                        obj.Id,
                        obj.Adress,
                        obj.Space,
                        obj.LivingSpace,
                        obj.Rooms,
                        obj.Floor,
                        obj.CostPerDay
                    );
                MessageBox.Show("Объект успешно добавлен!");
            }
            RewriteDocument(objectPath);
            UpdateDataGridObjects();
            WriteRentsInfo();
            UpdateDataGridRents();
        }

        private void ChangeObjBut_Click(object sender, EventArgs e)
        {
            var data = RemoveSpace(objectPath);
            dataGridObjects.Rows[dataGridObjects.CurrentRow.Index].Selected = true;
            changeObjectForm = new ChangeObjectInfo(new string[7] {
                dataGridObjects.CurrentRow.Cells[0].Value.ToString(),
                dataGridObjects.CurrentRow.Cells[1].Value.ToString(),
                dataGridObjects.CurrentRow.Cells[2].Value.ToString(),
                dataGridObjects.CurrentRow.Cells[3].Value.ToString(),
                dataGridObjects.CurrentRow.Cells[4].Value.ToString(),
                dataGridObjects.CurrentRow.Cells[5].Value.ToString(),
                dataGridObjects.CurrentRow.Cells[6].Value.ToString()
            }, data);
            changeObjectForm.ShowDialog();
            var obj = changeObjectForm.ReturnObject();
            if (InfoCheck(obj))
            {
                MessageBox.Show("Такой клиент существует или не все поля формы были заполнены!");
            }
            else
            {
                dataGridObjects.CurrentRow.Cells[0].Value = obj.Id;
                dataGridObjects.CurrentRow.Cells[1].Value = obj.Adress;
                dataGridObjects.CurrentRow.Cells[2].Value = obj.Space;
                dataGridObjects.CurrentRow.Cells[3].Value = obj.LivingSpace;
                dataGridObjects.CurrentRow.Cells[4].Value = obj.Rooms;
                dataGridObjects.CurrentRow.Cells[5].Value = obj.Floor;
                dataGridObjects.CurrentRow.Cells[6].Value = obj.CostPerDay;
                MessageBox.Show("Объект успешно изменён!");
            }
            RewriteDocument(objectPath);
            UpdateDataGridObjects();
            WriteRentsInfo();
            UpdateDataGridRents();
        }
        private int GetRentSum(Rent rent)
        {
            var startDate = DateTime.ParseExact(rent.StartDate, "dd.MM.yyyy", null);
            var endDate = DateTime.ParseExact(rent.EndDate, "dd.MM.yyyy", null);
            return (endDate - startDate).Days * int.Parse(rent.Deposit);
        }

        private void AddRentBut_Click(object sender, EventArgs e)
        {
            var data1 = RemoveSpace(rentPath);
            addRentForm = new AddRent(data1, clientPath, objectPath);
            addRentForm.ShowDialog();
            var rent = addRentForm.ReturnRent();
            if (InfoCheck(rent))
            {
                MessageBox.Show("Такая аренда существует или не все поля формы были заполнены!");
            }
            else
            {
                var rentSum = GetRentSum(rent);
                dataGridRents.Rows.Add(
                    rent.Id,
                    rent.StartDate,
                    rent.EndDate,
                    rent.Deposit,
                    rent.ClientId,
                    rent.AdressId,
                    rentSum);
                MessageBox.Show("Аренда успешно добавлена!");
            }
            RewriteDocument(rentPath);
            UpdateDataGridRents();
        }

        private void ChangeRentBut_Click(object sender, EventArgs e)
        {
            var data = RemoveSpace(rentPath);
            var updatedClientPath = RemoveSpace(clientPath);
            var updatedObjectPath = RemoveSpace(objectPath);
            dataGridRents.Rows[dataGridRents.CurrentRow.Index].Selected = true;
            changeRentForm = new ChangeRent(new string[6] {
            dataGridRents.CurrentRow.Cells[0].Value.ToString(),
            dataGridRents.CurrentRow.Cells[1].Value.ToString(),
            dataGridRents.CurrentRow.Cells[2].Value.ToString(),
            dataGridRents.CurrentRow.Cells[3].Value.ToString(),
            dataGridRents.CurrentRow.Cells[4].Value.ToString(),
            dataGridRents.CurrentRow.Cells[5].Value.ToString()},
            data, updatedClientPath, updatedObjectPath);
            changeRentForm.ShowDialog();
            var rent = changeRentForm.ReturnChangedRent();
            if (InfoCheck(rent))
            {
                MessageBox.Show("Такая аренда существует или не все поля формы были заполнены!");
            }
            else
            {
                var rentSum = GetRentSum(rent);
                dataGridRents.CurrentRow.Cells[0].Value = rent.Id;
                dataGridRents.CurrentRow.Cells[1].Value = rent.StartDate;
                dataGridRents.CurrentRow.Cells[2].Value = rent.EndDate;
                dataGridRents.CurrentRow.Cells[3].Value = rent.Deposit;
                dataGridRents.CurrentRow.Cells[4].Value = rent.ClientId;
                dataGridRents.CurrentRow.Cells[5].Value = rent.AdressId;
                dataGridRents.CurrentRow.Cells[6].Value = rentSum;
                MessageBox.Show("Аренда успешно изменена!");
            }
            RewriteDocument(rentPath);
            UpdateDataGridRents();
        }

        private void DelRentBut_Click(object sender, EventArgs e)
        {
            if (dataGridRents.CurrentRow != null)
            {
                dataGridRents.Rows.RemoveAt(dataGridRents.CurrentRow.Index);
                dataGridViewChanged = true;
            }
            RewriteDocument(rentPath);
            UpdateDataGridRents();
        }

        private void UploadToExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application {
                Visible = false,
                DisplayAlerts = false
            };           
            Excel.Workbook xlBook = excel.Workbooks.Add();
            Excel.Worksheet xlSheet = xlBook.ActiveSheet;
            var columnsCount = dataGridRents.ColumnCount;
            int rowsCount = dataGridRents.Rows.Count;

            object[] headers = new object[columnsCount];
            for (int i = 0; i < columnsCount; i++)
                headers[i] = dataGridRents.Columns[i].HeaderText;
            Excel.Range headerRange = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, columnsCount]];
            headerRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            headerRange.Value = headers;
            headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            headerRange.Font.Bold = true;

            object[,] cells = new object[rowsCount, columnsCount];
            for (int j = 0; j < rowsCount; j++)
                for (int i = 0; i < columnsCount; i++)
                    cells[j, i] = dataGridRents.Rows[j].Cells[i].Value;

            Excel.Range dataRange = xlSheet.Range[xlSheet.Cells[2, 1], xlSheet.Cells[rowsCount + 1, columnsCount]];
            dataRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            dataRange.Value = cells;
            dataRange.EntireColumn.AutoFit();
            xlSheet.Cells[rowsCount + 2, columnsCount - 1] = "Итого:";
            xlSheet.Cells[rowsCount + 2, columnsCount] = $"=SUM({xlSheet.Cells[2, columnsCount].Address}:{xlSheet.Cells[rowsCount + 1, columnsCount].Address})";
            excel.Visible = true;
        }
    }
}
