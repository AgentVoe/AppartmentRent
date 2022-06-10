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

namespace WindowsFormsApp3
{
    public partial class AddObject : Form
    {
        private List<List<Objects>> keepObjects = new List<List<Objects>>();
        public AddObject()
        {
            InitializeComponent();
        }
        public AddObject(string[] info)
        {
            InitializeComponent();
            foreach (var item in info)
            {
                var obj = new Objects(item.Split(','));
                if (obj.Id != "#")
                {
                    keepObjects.Add(new List<Objects>() { new Objects(item.Split(',')) });
                }
            }
            objectId.Text = GetObjectId().ToString();
        }
        private int GetObjectId()
        {
            var obj = new Objects();
            var newId = obj.InfoToList(keepObjects[keepObjects.Count - 1][0])[0];
            return int.Parse(newId) + 1;
        }
        private bool CheckObject(Objects newObject)
        {
            foreach (var objects in keepObjects)
            {
                foreach (var obj in objects)
                {
                    if (obj.Adress == newObject.Adress &&
                        obj.Space == newObject.Space &&
                        obj.LivingSpace == newObject.LivingSpace &&
                        obj.Rooms == newObject.Rooms && 
                        obj.Floor == newObject.Floor)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool CheckFields(Objects newObject)
        {
            var objectInfo = newObject.InfoToList(newObject);
            return objectInfo.Any(x => x == string.Empty);
        }
        // Передвать значения с готовыми приписками!
        public Objects ReturnObject()
        {
            var newObject = new Objects(new string[] {
            objectId.Text,
            AdressBox.Text,
            SpaceBox.Text,
            LivingSpaceBox.Text,
            RoomsBox.Text,
            FloorBox.Text,
            CostPerDay.Text
            });
            if (!CheckObject(newObject))
            {
                return null;
            }
            if (CheckFields(newObject))
            {
                return null;
            }
            return newObject;
        }

        private void AddObjBut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CanObjBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
