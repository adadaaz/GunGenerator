using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace GunGenerator
{
    public partial class frmGunGenerator : Form
    {
        public frmGunGenerator()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Weapon MyWeapon;
        private void comboxManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MyWeapon != null)
            {
                string selectedManufacturer = comboxManufacturer.SelectedItem.ToString();
                MyWeapon.Manufacturer = selectedManufacturer;
            }
           // MyWeapon.SetManufactureRandomRange(comboxManufacturer.SelectedIndex);
          //  MyWeapon.RerollStats();
            //TextBoxDisplay();
        }
        private void cmboxGunType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MyWeapon != null)
            {
                int selectedGunType = cmboxGunType.SelectedIndex;
                MyWeapon.GunType = selectedGunType;
            }
          //  MyWeapon.SetGun();
           // MyWeapon.RerollStats();
           // TextBoxDisplay();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtGunName.Text != null && comboxManufacturer.SelectedIndex != -1 && cmboxGunType.SelectedIndex != -1)
            {
                string name = txtGunName.Text;
                txtGunName.ReadOnly = true;
                //assign value to gun
                if (MyWeapon == null)
                {
                    MyWeapon = new Weapon();
                    MyWeapon.Name = name;
                    MyWeapon.Manufacturer = comboxManufacturer.SelectedItem.ToString();
                    MyWeapon.GunType = cmboxGunType.SelectedIndex;
                    MyWeapon.SetGun();
                    MyWeapon.SetManufactureRandomRange(comboxManufacturer.SelectedIndex);
                    MyWeapon.RerollStats();
                }
                TextBoxDisplay();
            }
            else
            {
                txtGunName.ReadOnly = false;
                MessageBox.Show("Invalid Input");
            }
        }
        public void TextBoxDisplay()
        {
            if (MyWeapon == null) return;
            txtAccuracy.Text = MyWeapon.Accuracy.ToString();
            txtDamage.Text = MyWeapon.Damage.ToString();
            txtFireRate.Text = MyWeapon.FireRate.ToString();
            txtMagazine.Text = MyWeapon.Magazine.ToString();
            txtReload.Text = MyWeapon.ReloadSpeed.ToString();
        }

        private void btnReroll_Click(object sender, EventArgs e)
        {
            if (MyWeapon != null)
            {
                MyWeapon.RerollStats();
                TextBoxDisplay();
            }
        }
    }
    // Weapon Class
    class Weapon
    {
        //base attributes
        private int _baseDamage;
        private int _baseMagazine;
        private float _baseAccuracy;
        private float _baseFireRate;
        private float _baseReloadSpeed;
        private float _ManufacturerMin;
        private float _ManufacturerMax;
        //display attributes
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int GunType { get; set; }
        public int Damage;
        public int Magazine;
        public float Accuracy;
        public float FireRate;
        public float ReloadSpeed;
        public Weapon()
        {
            Damage = 0;
            Accuracy = 0;
            FireRate = 0;
            ReloadSpeed = 0;
            Magazine = 0;
        }
        public void SetGun()
        {
            switch (GunType)
            {
                case 0:
                    //pistols
                    SetBaseAttributes(1000, 56.2f, 12.1f, 30.2f, 7);
                    break;
                case 1:
                    //submachine
                    SetBaseAttributes(1000, 56.2f, 12.1f, 30.2f, 7);
                    break;
                case 2:
                    //shotgun
                    SetBaseAttributes(1000, 56.2f, 12.1f, 30.2f, 7);
                    break;
                case 3:
                    //assult rifle
                    SetBaseAttributes(1000, 56.2f, 12.1f, 30.2f, 7);
                    break;
                case 4:
                    //sniper
                    SetBaseAttributes(1000, 56.2f, 12.1f, 30.2f, 7);
                    break;
                default:
                    MessageBox.Show("Can't Read GunType");
                    break;
            }
        }
        private void ManufactureRange(float min, float max)
        {
            _ManufacturerMin = min;
            _ManufacturerMax = max;
        }
        public void SetManufactureRandomRange(int idx)
        {
            if (idx == -1) return;
            switch (idx)
            {
                case 0:
                    //jackob
                    ManufactureRange(10,15);
                    break;
                case 1:
                    //TEDIORE
                    ManufactureRange(10, 15);
                    break;
                case 2:
                    //MALIWAN
                    ManufactureRange(10, 15);
                    break;
                case 3:
                    //DAHL
                    ManufactureRange(10, 15);
                    break;
                case 4:
                    //HYPERION
                    ManufactureRange(10, 15);
                    break;
                default:
                    MessageBox.Show("Invalid indx");
                    break;
            }
        }
        private void SetBaseAttributes(int damage, float accuracy, float fire, float reload, int mag)
        {
            _baseDamage = damage;
            _baseMagazine = mag;
            _baseAccuracy = accuracy;
            _baseFireRate = fire;
            _baseReloadSpeed = reload;
        }
        public void RerollStats()
        {
            Damage = _baseDamage + RandomInt((int)_ManufacturerMin, (int)_ManufacturerMax);
            Accuracy = _baseAccuracy + RandomFloat(_ManufacturerMin, _ManufacturerMax);
            FireRate = _baseFireRate + RandomFloat(_ManufacturerMin, _ManufacturerMax);
            ReloadSpeed = _baseReloadSpeed + RandomFloat(_ManufacturerMin, _ManufacturerMax);
            Magazine = _baseMagazine + RandomInt((int)_ManufacturerMin, (int)_ManufacturerMax);
        }
        public int RandomInt(int min, int max)
        {
            Random rng = new Random();
            return rng.Next(min, max);
        }
        public float RandomFloat(float min, float max)
        {
            Random rng = new Random();
            float ret = (float)rng.NextDouble() * (max - min) + min;
            return ret;
        }
    }
}
