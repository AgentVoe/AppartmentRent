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
    public partial class ChangeObjectInfo : Form
    {
        private List<List<Objects>> keepObjects = new List<List<Objects>>();
        public ChangeObjectInfo()
        {
            InitializeComponent();
        }
        public ChangeObjectInfo(string [] info, string [] objectInfo)
        {
            InitializeComponent();
            objectId.Text = info[0];
            AdressBox.Text = info[1];
            SpaceBox.Text = info[2];
            LivingSpaceBox.Text = info[3];
            RoomsBox.Text = info[4];
            FloorBox.Text = info[5];
            CostPerDayBox.Text = info[6];
            foreach (var item in objectInfo)
            {
                var obj = new Objects(item.Split(','));
                if (obj.Id != "#")
                {
                    keepObjects.Add(new List<Objects>() { new Objects(item.Split(',')) });
                }
            }
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
            CostPerDayBox.Text
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

        private void ChangeObjBut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancChangeObjBut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
