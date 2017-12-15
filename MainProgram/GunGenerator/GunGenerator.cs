using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;

namespace GunGenerator
{
    public partial class frmGunGenerator : Form
    {
        Image[] PistolBarrel = System.IO.Directory.GetFiles("../Debug/pic/Pistle/Pistle_Barrels").Select(f => Image.FromFile(f)).ToArray();
        Image[] PistolGrip = System.IO.Directory.GetFiles("../Debug/pic/Pistle/Pistle_Grips").Select(f => Image.FromFile(f)).ToArray();
        Image PistolBody = Image.FromFile(@"../Debug/pic/Pistle/Pistle_Body.png");

        Image[] RifleBarrel = System.IO.Directory.GetFiles("../Debug/pic/Rifle/Assault_Rifle_Barrel").Select(f => Image.FromFile(f)).ToArray();
        Image[] RifleGrip = System.IO.Directory.GetFiles("../Debug/pic/Rifle/Assault_Rifle_Grips").Select(f => Image.FromFile(f)).ToArray();
        Image[] RifleStock = System.IO.Directory.GetFiles("../Debug/pic/Rifle/Assault_Rifle_Stocks").Select(f => Image.FromFile(f)).ToArray();
        Image RifleBody = Image.FromFile(@"../Debug/pic/Rifle/Assault_Rifle_Body.png");

        Image[] RPGBarrel = System.IO.Directory.GetFiles("../Debug/pic/RPG/RPG_Barrel").Select(f => Image.FromFile(f)).ToArray();
        Image[] RPGGrip = System.IO.Directory.GetFiles("../Debug/pic/RPG/RPG_Grip").Select(f => Image.FromFile(f)).ToArray();
        Image[] RPGExhaust = System.IO.Directory.GetFiles("../Debug/pic/RPG/RPG_Exhaust").Select(f => Image.FromFile(f)).ToArray();
        Image RPGBody = Image.FromFile(@"../Debug/pic/RPG/RPG_Body.png");

        Image[] ShotgunBarrel = System.IO.Directory.GetFiles("../Debug/pic/Shotgun/Shotgun_Barrel").Select(f => Image.FromFile(f)).ToArray();
        Image[] ShotgunStock = System.IO.Directory.GetFiles("../Debug/pic/Shotgun/Shotgun_Stock").Select(f => Image.FromFile(f)).ToArray();
        Image ShotgunBody = Image.FromFile(@"../Debug/pic/Shotgun/Shotgun_Body.png");

        Image[] SniperBarrel = System.IO.Directory.GetFiles("../Debug/pic/Sniper/Sniper_Barrel").Select(f => Image.FromFile(f)).ToArray();
        Image[] SniperGrip = System.IO.Directory.GetFiles("../Debug/pic/Sniper/Sniper_Grip").Select(f => Image.FromFile(f)).ToArray();
        Image[] SniperStock = System.IO.Directory.GetFiles("../Debug/pic/Sniper/Sniper_Stock").Select(f => Image.FromFile(f)).ToArray();
        Image SniperBody = Image.FromFile(@"../Debug/pic/Sniper/Sniper_Body.png");


        private void DisplayRifle()
        {
            Image img = new Bitmap(RifleBarrel[0].Width, RifleBarrel[0].Height);
            using (Graphics gr = Graphics.FromImage(img))
            {
                gr.DrawImage(RifleBarrel[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(RifleGrip[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(RifleStock[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(RifleBody, new Point(0, 0));
            }
            img.Save("output.png", ImageFormat.Png);
            picBox1.ImageLocation = @"../Debug/output.png";
            picBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void DisplayPistol()
        {
            Image img = new Bitmap(PistolBarrel[0].Width, PistolBarrel[0].Height);
            using (Graphics gr = Graphics.FromImage(img))
            {
                gr.DrawImage(PistolBarrel[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(PistolGrip[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(PistolBody, new Point(0, 0));
            }
            img.Save("output.png", ImageFormat.Png);
            picBox1.ImageLocation = @"../Debug/output.png";
            picBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void DisplayRPG()
        {
            Image img = new Bitmap(RPGBarrel[0].Width, RPGBarrel[0].Height);
            using (Graphics gr = Graphics.FromImage(img))
            {
                gr.DrawImage(RPGBarrel[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(RPGGrip[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(RPGExhaust[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(RPGBody, new Point(0, 0));
            }
            img.Save("output.png", ImageFormat.Png);
            picBox1.ImageLocation = @"../Debug/output.png";
            picBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void DisplayShotgun()
        {
            Random rng = new Random();

            Image img = new Bitmap(ShotgunBarrel[0].Width, ShotgunBarrel[0].Height);
            using (Graphics gr = Graphics.FromImage(img))
            {
                gr.DrawImage(ShotgunBarrel[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(ShotgunStock[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(ShotgunBody, new Point(0, 0));
            }
            img.Save("output.png", ImageFormat.Png);
            picBox1.ImageLocation = @"../Debug/output.png";
            picBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void DisplaySniper()
        {
            Image img = new Bitmap(SniperBarrel[0].Width, SniperBarrel[0].Height);
            using (Graphics gr = Graphics.FromImage(img))
            {
                gr.DrawImage(SniperBarrel[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(SniperGrip[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(SniperStock[cmboxManufacturer.SelectedIndex], new Point(0, 0));
                gr.DrawImage(SniperBody, new Point(0, 0));
            }
            img.Save("output.png", ImageFormat.Png);
            picBox1.ImageLocation = @"../Debug/output.png";
            picBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        public frmGunGenerator()
        {
            InitializeComponent();
            LoadManufacturerData();
            LoadGunTypeData();
        }
        private void LoadManufacturerData()
        {
            if (cmboxManufacturer.Items.Count == 0)
            {// read
                try
                {
                    using (StreamReader sr = new StreamReader(@"...\Debug\Data\Manufacturer.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            cmboxManufacturer.Items.Add(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void LoadGunTypeData()
        {
            if (cmboxGunType.Items.Count == 0)
            {// read
                try
                {
                    using (StreamReader sr = new StreamReader(@"...\Debug\Data\Weapon.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            cmboxGunType.Items.Add(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
        }
        private void cmboxGunType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MyWeapon != null)
            {
                int selectedGunType = cmboxGunType.SelectedIndex;
                MyWeapon.GunType = selectedGunType;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string gunName = txtGunName.Text;
            if (!string.IsNullOrEmpty(gunName) && cmboxManufacturer.SelectedIndex != -1 && cmboxGunType.SelectedIndex != -1)
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
                    txtDamage.Text += "  <-";
                    break;
                case 1:
                    txtReload.Text += "  <-";
                    break;
                case 2:
                    txtFireRate.Text += "  <-";
                    break;
                case 3:
                    txtAccuracy.Text += "  <-";
                    break;
                case 4:
                    txtMagazine.Text += "  <-";
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
            if (cmboxManufacturer.SelectedIndex != -1 && cmboxGunType.SelectedIndex != -1)
            {
                switch (cmboxGunType.SelectedIndex)
                {
                    case 0:
                        DisplayPistol();
                        break;
                    case 1:
                        DisplayRPG();
                        break;
                    case 2:
                        DisplayShotgun();
                        break;
                    case 3:
                        DisplayRifle();
                        break;
                    case 4:
                        DisplaySniper();
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (MyWeapon != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Json File|.json|All files (*.*)|*.*";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter str = new StreamWriter(saveFileDialog1.FileName))
                    {
                        str.Write(MyWeapon);
                    }
                }
                MessageBox.Show("Export Sucess!");
            }
            else
            {
                MessageBox.Show("Weapon Not Created");
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
                    SetBaseAttributes(1000, 90.0f, 1.5f, 2.0f, 7);
                    break;
                case 1:
                    //RPG
                    SetBaseAttributes(300000, 85.0f, 2.5f, 12.5f, 6);
                    break;
                case 2:
                    //shotgun
                    SetBaseAttributes(30000, 20.0f, 0.3f, 3.5f, 4);
                    break;
                case 3:
                    //assult rifle
                    SetBaseAttributes(3000, 80.0f, 4.0f, 2.5f, 30);
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
