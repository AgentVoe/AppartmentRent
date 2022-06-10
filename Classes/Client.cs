using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp3.Classes
{
    public class Client
    {
        public string Id { get; set; }
        public string Surname { get; set; }
        public  string Name { get; set; }
        public string MiddleName { get; set; }
        public string BirthDay { get; set; }
        public string Phone { get; set; }
        public string clientPath = @"Клиенты (10 человек).txt";
        public Client(string[] info)
        {
            Id = info[0];
            Surname = info[1];
            Name = info[2];
            MiddleName = info[3];
            BirthDay = info[4];
            Phone = info[5];
        }
        public Client()
        {

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
        public Dictionary<string, string> IdClient()
        {
            var idName = new Dictionary<string, string>();
            var data = RemoveSpace(clientPath); 
            foreach (var item in data)
            {
                if (!idName.ContainsKey(item.Split(',')[0]) && item.Split(',')[0] != "#")
                {
                    idName[item.Split(',')[0]] = item.Split(',')[1];
                }
            }
            return idName;
        }        
        public List<string> InfoToList(Client client)
        {
            return new List<string>()
            {
               client.Id,
               client.Surname,
               client.Name,
               client.MiddleName,
               client.BirthDay,
               client.Phone
            };
        }
    }
}

