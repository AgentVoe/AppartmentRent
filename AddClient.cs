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
using System.Globalization;

namespace WindowsFormsApp3
{
    public partial class AddClient : Form
    {
        private List<List<Client>> keepClients = new List<List<Client>>();
        public AddClient()
        {
            InitializeComponent();
        }
        public AddClient(string[] info)
        {
            InitializeComponent();
            foreach (var item in info)
            {
                var client = new Client(item.Split(','));
                if (client.Id != "#")
                {
                    keepClients.Add(new List<Client>(){ new Client(item.Split(',')) });
                }
            }
            clientId.Text = GetClientId().ToString();
        }
        private bool CheckClient(Client newClient)
        {
            foreach (var clients in keepClients)
            {
                foreach (var client in clients)
                {
                    if (client.Name == newClient.Name &&
                        client.Surname == newClient.Surname &&
                        client.MiddleName == newClient.MiddleName ||
                        client.Phone == newClient.Phone)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool CheckClientAge(Client newClient)
        {
            try
            {
                return Convert.ToInt32((DateTime.Now - DateTime.ParseExact(newClient.BirthDay, "dd.MM.yyyy", null)).Duration().TotalDays / 365) >= 18;
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidTextBox(Client newClient)
        {
            return newClient.Surname.All(Char.IsLetter) &&
                newClient.Name.All(Char.IsLetter) &&
                newClient.MiddleName.All(Char.IsLetter);
        }
        private bool CheckFields(Client newClient)
        {
            var clientInfo = newClient.InfoToList(newClient);
            return clientInfo.Any(x => x == string.Empty);
        }
        private int GetClientId()
        {
            var client = new Client();
            var newId = client.InfoToList(keepClients[keepClients.Count - 1][0])[0];
            return int.Parse(newId) + 1;
        }       
        private bool CheckDate(Client newClient)
        {
            Regex correctDate = new Regex(@"\d{2}.\d{2}.\d{4}");
            var date =  newClient.BirthDay;
            if (correctDate.IsMatch(date) &&                
                int.Parse(date.Split('.')[2]) > (DateTime.Now.Year - 100) &&
                CheckClientAge(newClient))
                return true;
            return false;
        }
        public Client ReturnClient()
        {
            var newClient = new Client(new string[6]
            {
                clientId.Text = (GetClientId() + 1).ToString(),
                surnameBox.Text,
                nameBox.Text,
                middleNameBox.Text,
                birtDayBox.Text,
                maskedPhoneBox.Text
            }); 
            if (!IsValidTextBox(newClient))
            {
                return null;
            }
            if (!CheckClientAge(newClient))
            {
                return null;
            }
            if (!CheckClient(newClient))
            {
                return null;
            }
            if (!CheckDate(newClient))
            {
                return null;
            }
            if (CheckFields(newClient))
            {
                return null;
            }
            return newClient;
        }

        private void AddClientBut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
