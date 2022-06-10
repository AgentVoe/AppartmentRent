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

namespace WindowsFormsApp3
{
    public partial class ChangeRent : Form
    {
        private List<List<Rent>> keepRents = new List<List<Rent>>();
        private List<List<Client>> keepClients = new List<List<Client>>();
        private List<List<Objects>> keepObjects = new List<List<Objects>>();
        public ChangeRent()
        {
            InitializeComponent();
        }

        public ChangeRent(string [] info, string [] rentInfo, string[] clientPath, string[] objectPath)
        {
            InitializeComponent();
            RentId.Text = info[0];
            StartBox.Text = info[1];
            EndBox.Text = info[2];
            DepositBox.Text = info[3];
            ClientIdBox.Text = info[4];
            AdressIdBox.Text = info[5];
            foreach (var item in rentInfo)
            {
                var rent = new Rent(item.Split(','));
                if (rent.Id != "#")
                {
                    keepRents.Add(new List<Rent> { new Rent(item.Split(',')) });
                }
            }
            foreach (var item in clientPath)
            {
                var client = new Client(item.Split(','));
                if (client.Id != "#")
                {
                    keepClients.Add(new List<Client> { new Client(item.Split(',')) });
                }
            }
            foreach (var item in objectPath)
            {
                var obj = new Objects(item.Split(','));
                if (obj.Id != "#")
                {
                    keepObjects.Add(new List<Objects> { new Objects(item.Split(',')) });
                }
            }
        }
        private bool CheckRent(Rent newRent)
        {
            foreach (var rents in keepRents)
            {
                foreach (var rent in rents)
                {
                    if (rent == newRent)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool CheckRealClient(Rent newRent)
        {
            foreach (var clients in keepClients)
            {
                foreach (var client in clients)
                {
                    if (newRent.ClientId == client.Surname)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool CheckRealObject(Rent newRent)
        {
            foreach (var objcts in keepObjects)
            {
                foreach (var obj in objcts)
                {
                    if (newRent.AdressId == obj.Adress)
                    {
                        return true;
                    }
                }
            }
            return false;
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
        private bool CheckFields(Rent newRent)
        {
            var clientInfo = newRent.InfoToList(newRent);
            return clientInfo.Any(x => x == string.Empty);
        }
        private void UpdateRent(Rent newRent)
        {
            newRent.ClientId = newRent.GetClientName(newRent.ClientId);
            newRent.AdressId = newRent.GetObjectAdress(newRent.AdressId);
        }
        public Rent ReturnChangedRent()
        {          
            var newRent = new Rent(new string[6] {
            RentId.Text,
            StartBox.Text,
            EndBox.Text,
            DepositBox.Text,
            ClientIdBox.Text,
            AdressIdBox.Text
            });
            UpdateRent(newRent);
            if (!CheckRealClient(newRent))
            {
                return null;
            }
            if (CheckFields(newRent))
            {
                return null;
            }
            if (!CheckRent(newRent))
            {
                return null;
            }
            if (!CheckDate(newRent))
            {
                return null;
            }
            return newRent;
        }

        private void AddChangedRentBut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancChangeRentBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
