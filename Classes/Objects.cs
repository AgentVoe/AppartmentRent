using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp3.Classes
{
    public class Objects
    {
        public string Id { get; set; }
        public string Adress { get; set; }
        public string Space { get; set; }
        public string LivingSpace { get; set; }
        public string Rooms { get; set; }
        public string Floor { get; set; }
        public string CostPerDay { get; set; }
        public string objectPath = @"Объекты (20 объектов).txt";
        public Objects(string [] info)
        {
            Id = info[0];
            Adress = info[1];
            Space = info[2];
            LivingSpace = info[3];
            Rooms = info[4];
            Floor = info[5];
            CostPerDay = info[6];
        }
        public Objects()
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
        public Dictionary<string, string> IdObject()
        {
            var idObject = new Dictionary<string, string>();
            var data = RemoveSpace(objectPath);
            foreach (var item in data)
            {
                if (!idObject.ContainsKey(item.Split(',')[0]) && item.Split(',')[0] != "#")
                {
                    idObject[item.Split(',')[0]] = item.Split(',')[1];
                }
            }
            return idObject;
        }
        public List<string> InfoToList(Objects obj)
        {
            return new List<string>()
            {
               obj.Id,
               obj.Adress,
               obj.Space,
               obj.LivingSpace,
               obj.Rooms,
               obj.Floor,
               obj.CostPerDay
            };
        }
    }
}
