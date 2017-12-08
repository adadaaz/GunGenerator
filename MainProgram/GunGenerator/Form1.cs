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

namespace GunGenerator
{
    public partial class frmGunGenerator : Form
    {
        int pdamage;//pistal
        int paccuracy;
        int pfirerate;
        int preloadspeed;
        int pmagazine;



        public frmGunGenerator()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int index1Selected = comboxManufacturer.SelectedIndex;
            int index2Selected = cmboxGunType.SelectedIndex;
            Random rnd = new Random();


            //txtDamage.Text = index1Selected.ToString();
            switch (index1Selected)// Manufacturer
            {
                case 0:
                    switch (index2Selected)
                    {
                        case 0:
                            txtDamage.Text = (pdamage * 1.5 * 1).ToString();
                            break;
                        case 1:
                            txtAccuracy.Text = (paccuracy * 1).ToString();
                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                        default:
                            break;
                    }
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                default:
                    break;
            }
        }

    }
}
