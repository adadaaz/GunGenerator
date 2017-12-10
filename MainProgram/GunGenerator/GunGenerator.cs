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
                string selectedManufacturer = cmboxManufacturer.SelectedItem.ToString();
                MyWeapon.Manufacturer = selectedManufacturer;
                MyWeapon.SetManufactureRandomRange(cmboxManufacturer.SelectedIndex);
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
            if (txtGunName.Text != null && cmboxManufacturer.SelectedIndex != -1 && cmboxGunType.SelectedIndex != -1)
            {
                string name = txtGunName.Text;
                txtGunName.ReadOnly = true;
                //assign value to gun
                if (MyWeapon == null)
                {
                    MyWeapon = new Weapon();
                    MyWeapon.Name = name;
                    MyWeapon.Manufacturer = cmboxManufacturer.SelectedItem.ToString();
                    MyWeapon.GunType = cmboxGunType.SelectedIndex;
                    MyWeapon.SetGun();
                    MyWeapon.SetManufactureRandomRange(cmboxManufacturer.SelectedIndex);
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
            switch (cmboxManufacturer.SelectedIndex)
            {
                case 0:
                    txtDamage.Text += "  *";
                    break;
                case 1:
                    txtReload.Text += "  *";
                    break;
                case 2:
                    txtFireRate.Text += "  *";
                    break;
                case 3:
                    txtAccuracy.Text += "  *";
                    break;
                case 4:
                    txtMagazine.Text += "  *";
                    break;
                default:
                    break;
            }
        }

        private void btnReroll_Click(object sender, EventArgs e)
        {
            if (MyWeapon != null)
            {
                MyWeapon.RerollStats();
                TextBoxDisplay();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

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

        private int _baseDamageMin;
        private int _baseDamageMax;
        private float _baseAccuracyMin;
        private float _baseAccuracyMax;
        private float _baseFireRateMin;
        private float _baseFireRateMax;
        private float _baseReloadSpeedMin;
        private float _baseReloadSpeedMax;
        private int _baseMagazineMin;
        private int _baseMagazineMax;

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
                    SetBaseAttributes(8000, 85.0f, 1.5f, 2.0f, 7);
                    break;
                case 1:
                    //submachine
                    SetBaseAttributes(8000, 85.0f, 3.5f, 2.5f, 13);
                    break;
                case 2:
                    //shotgun
                    SetBaseAttributes(300000, 20.0f, 0.3f, 3.5f, 4);
                    break;
                case 3:
                    //assult rifle
                    SetBaseAttributes(8000, 80.0f, 4.0f, 2.5f, 15);
                    break;
                case 4:
                    //sniper
                    SetBaseAttributes(70000, 90.0f, 2.0f, 4.0f, 4);
                    break;
                default:
                    MessageBox.Show("Can't Read GunType");
                    break;
            }
        }

        public void SetManufactureRandomRange(int idx)
        {
            _baseDamageMin = 10;
            _baseDamageMax = 5000;
            _baseAccuracyMin = 0.0f;
            _baseAccuracyMax = 8.0f;
            _baseFireRateMin = 0.0f;
            _baseFireRateMax = 1.5f;
            _baseReloadSpeedMin = 0.0f;
            _baseReloadSpeedMax = 1.0f;
            _baseMagazineMin = 0;
            _baseMagazineMax = 20;

            if (idx == -1) return;
            switch (idx)
            {
                case 0:
                    //jackob
                    _baseDamageMin = 3000;
                    _baseDamageMax = 10000;
                    break;
                case 1:
                    //TEDIORE
                    _baseReloadSpeedMin = 0.8f;
                    _baseReloadSpeedMax = 1.7f;
                    break;
                case 2:
                    //MALIWAN
                    _baseFireRateMin = 1.0f;
                    _baseFireRateMax = 2.5f;
                    break;
                case 3:
                    //DAHL
                    _baseAccuracyMin = 5.0f;
                    _baseAccuracyMax = 12.0f;
                    break;
                case 4:
                    //HYPERION
                    _baseMagazineMin = 15;
                    _baseMagazineMax = 35;
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
            Damage = _baseDamage + RandomInt((int)_baseDamageMin, (int)_baseDamageMax);
            Accuracy = _baseAccuracy + RandomFloat(_baseAccuracyMin, _baseAccuracyMax);
            FireRate = _baseFireRate + RandomFloat(_baseFireRateMin, _baseFireRateMax);
            ReloadSpeed = _baseReloadSpeed - RandomFloat(_baseReloadSpeedMin, _baseReloadSpeedMax);
            Magazine = _baseMagazine + RandomInt((int)_baseMagazineMin, (int)_baseMagazineMax);
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
