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
    public partial class ChangeClientInfo : Form
    {
        private List<List<Client>> keepClients = new List<List<Client>>();
        private Client oldClient = new Client();
        public ChangeClientInfo()
        {
            InitializeComponent();
        }
        public ChangeClientInfo(string [] info, string [] clientInfo)
        {
            InitializeComponent();
            ClientId.Text = info[0];
            SurnameBox.Text = info[1];
            NameBox.Text = info[2];
            MiddleNameBox.Text = info[3];
            BirthDayBox.Text = info[4];
            maskedPhoneBox.Text = info[5];
            oldClient = new Client(new string[6] {
                ClientId.Text,
                SurnameBox.Text,
                NameBox.Text,
                MiddleNameBox.Text,
                BirthDayBox.Text,
                maskedPhoneBox.Text
            });
            foreach (var item in clientInfo)
            {
                var client = new Client(item.Split(','));
                if (client.Id == "")
                    break;
                if (client.Id != "#")
                {
                    keepClients.Add(new List<Client>() { new Client(item.Split(',')) });
                }
            }
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
                        (client.Phone == newClient.Phone && client != newClient))
                    {
                        return false;
                    }
                }
            }
            return true;

        }
        private bool CompareOldAndNew(Client newClient)
        {
            if (newClient.Name == oldClient.Name &&
                newClient.Surname == oldClient.Surname &&
                newClient.MiddleName == oldClient.MiddleName &&
                newClient.Phone == oldClient.Phone)
            {
                return false;
            }
            return true;
        }
        private bool CheckFields(Client newClient)
        {
            var clientInfo = newClient.InfoToList(newClient);
            return clientInfo.Any(x => x == string.Empty);
        }
        private bool IsValidTextBox(Client newClient)
        {
            return newClient.Surname.All(Char.IsLetter) &&
                newClient.Name.All(Char.IsLetter) &&
                newClient.MiddleName.All(Char.IsLetter);
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
        private bool CheckDate(Client newClient)
        {
            Regex correctDate = new Regex(@"\d{2}.\d{2}.\d{4}");
            var date = newClient.BirthDay;
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
                ClientId.Text,
                SurnameBox.Text,
                NameBox.Text,
                MiddleNameBox.Text,
                BirthDayBox.Text,
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
            if (!CheckClient(newClient) && !CompareOldAndNew(newClient))
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

        private void ChangeInfo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void NoChangeBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
