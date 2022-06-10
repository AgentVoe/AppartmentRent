using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Classes
{
    public class Rent
    {
        public string Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Deposit { get; set; }
        public string ClientId { get; set; }
        public string AdressId { get; set; }

        public Rent()
        {

        }
        public Rent(string [] info)
        {
            Id = info[0];
            StartDate = info[1];
            EndDate = info[2];
            Deposit = info[3];
            ClientId = info[4];
            AdressId = info[5];
        }
        public Rent(string clientName, int i)
        {
            ClientId = clientName;

        }
        public Rent(string objectName)
        {
            AdressId = objectName;
        }
        public string GetClientName(string id)
        {
            var client = new Client();
            var idName = client.IdClient();
            string _clientId = "";
            foreach (var pair in idName)
            {
                if (pair.Key == id)
                {
                    _clientId = pair.Value;
                    break;
                }
            }
            return _clientId;
        }

        internal List<string> InfoToList(Rent newRent)
        {
            return new List<string>()
            {
                newRent.Id,
                newRent.StartDate,
                newRent.EndDate,
                newRent.Deposit,
                newRent.ClientId,
                newRent.AdressId,
            };
        }

        public string GetObjectAdress(string id)
        {
            var obj = new Objects();
            var idObject = obj.IdObject();
            string _objectId = "";
            foreach (var pair in idObject)
            {
                if (pair.Key == id)
                {
                    _objectId = pair.Value;
                    break;
                }
            }
            return _objectId;
        }  
        public string GetClientId(string name)
        {
            var client = new Client();
            var idName = client.IdClient();
            string clientId = "";
            foreach (var pair in idName)
            {
                if (pair.Value == name)
                {
                    clientId = pair.Key;
                    break;
                }
            }
            return clientId;
        }
        public string GetAdressId(string adress)
        {
            var obj = new Objects();
            var idObject = obj.IdObject();
            string objectId = "";
            foreach (var pair in idObject)
            {
                if (pair.Value == adress)
                {
                    objectId = pair.Key;
                    break;
                }
            }
            return objectId;
        }
    }
}
