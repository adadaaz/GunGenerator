using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunGenerator
{

    public partial class frmGunGenerator : Form
    {
        public frmGunGenerator()
        {
            InitializeComponent();
        }

        private void cmboxManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }

    class Weapon
    {
        private string _Name;
        private string _Manufacturer;
        private string _GunType;
        private int _Damage;
        private float _Accuracy;
        private float _FireRate;
        private float _Reload;
        private int _Magazine;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Manufacturer
        {
            get { return _Manufacturer; }
            set { _Manufacturer = value; }
        }
        public string GunType
        {
            get { return _GunType; }
            set { _GunType = value; }
        }
        public int Damage
        {
            get { return _Damage; }
            set { _Damage = value; }
        }
        public float Accuracy
        {
            get { return _Accuracy; }
            set { _Accuracy = value; }
        }
        public float FireRate
        {
            get { return _FireRate; }
            set { _FireRate = value; }
        }
        public float Reload
        {
            get { return _Reload; }
            set { _Reload = value; }
        }
        public int Magazine
        {
            get { return _Magazine; }
            set { _Magazine = value; }
        }
    }
}
