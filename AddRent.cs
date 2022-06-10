using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Classes;
using System.Text.RegularExpressions;
using System.IO;
namespace WindowsFormsApp3
{
    public partial class AddRent : Form
    {
        private List<List<Rent>> keepRents = new List<List<Rent>>();
        public AddRent()
        {
            InitializeComponent();
        }
        public AddRent(string[] info, string clientPath, string objectPath)
        {
            InitializeComponent();
            foreach (var item in info)
            {
                var rent = new Rent(item.Split(','));
                if (rent.Id != "#")
                {
                    keepRents.Add(new List<Rent>() { new Rent(item.Split(',')) });
                }
            }
            RentId.Text = GetRentId().ToString();
            FillClientAndObjectIdBox(clientPath, objectPath);
        }
        public string[] ReadFile(string path)
        {
            return File.ReadAllLines(path);
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
        private void FillClientAndObjectIdBox(string clientPath, string objectPath)
        {
            var updatedClientPath = RemoveSpace(clientPath);
            foreach (var item in updatedClientPath)
            {
                var client = new Client(item.Split(','));
                if (client.Id != "#")
                {
                    ClientIdBox.Items.Add(client.Id);
                }
            }
            var updatedObjectPath = RemoveSpace(objectPath);
            foreach (var item in updatedObjectPath)
            {
                var obj = new Objects(item.Split(','));
                if (obj.Id != "#")
                {
                    AdressIdBox.Items.Add(obj.Id);
                }
            }
        }
        private int GetRentId()
        {

            var rent = new Rent();
            var newId = rent.InfoToList(keepRents[keepRents.Count - 1][0])[0];
            return int.Parse(newId) + 1;
        }
        private bool CheckRent(Rent newRent)
        {
            foreach (var rents in keepRents)
            {
                foreach (var rent in rents)
                {
                    if (rent.StartDate == newRent.StartDate &&
                        rent.EndDate == newRent.EndDate &&
                        rent.Deposit == newRent.Deposit &&
                        rent.ClientId == newRent.ClientId && 
                        rent.AdressId == newRent.AdressId)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool CheckFields(Rent newRent)
        {
            var clientInfo = newRent.InfoToList(newRent);
            return clientInfo.Any(x => x == string.Empty);
        }
        private bool CheckDate(Rent newRent)
        {
            Regex correctDate = new Regex(@"\d{2}.\d{2}.\d{4}");
            var startDate = newRent.StartDate;
            var endDate = newRent.EndDate;           
            if (correctDate.IsMatch(startDate) && correctDate.IsMatch(endDate))
                return true;
            return false;
        }       
        public Rent ReturnRent()
        {
            var newRent = new Rent(new string[6] {
            RentId.Text,
            StartBox.Text,
            EndBox.Text,
            DepositBox.Text,
            ClientIdBox.Text,
            AdressIdBox.Text});
            var client = newRent.GetClientName(newRent.ClientId);
            var adress = newRent.GetObjectAdress(newRent.AdressId);
            newRent.ClientId = client;
            newRent.AdressId = adress;
            if (!CheckRent(newRent))
            {
                return null;
            }
            if (!CheckDate(newRent))
            {
                return null;
            }
            if (CheckFields(newRent))
            {
                return null;
            }
            return newRent;
        }
        private void CancAddRentBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddRentBut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;            
        }       
    }
}
