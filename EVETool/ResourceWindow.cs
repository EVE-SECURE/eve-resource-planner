using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVETool
{
    public partial class ResourceWindow : Form
    {
        private Boolean BarrenImg = true;
        private Boolean GasImg = true;
        private Boolean IceImg = true;
        private Boolean LavaImg = true;
        private Boolean OceanicImg = true;
        private Boolean PlasmaImg = true;
        private Boolean StormImg = true;
        private Boolean TemperateImg = true;
        public ResourceWindow()
        {
            InitializeComponent();

        }

        private void NewIndustryInter_Click(object sender, EventArgs e)
        {
            ResourcePanel.Controls.Clear();
            ResourcePanel.Controls.Add(new ResourcePanel());
        }

        private void Barren_Click(object sender, EventArgs e)
        {
            if (BarrenImg == true)
            {
                BarrenImg = false;
                Barren.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (BarrenImg == false)
            {
                BarrenImg = true;
                Barren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Gas_Click(object sender, EventArgs e)
        {
            if (GasImg == true)
            {
                GasImg = false;
                Gas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (GasImg == false)
            {
                GasImg = true;
                Gas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Ice_Click(object sender, EventArgs e)
        {
            if (IceImg == true)
            {
                IceImg = false;
                Ice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (IceImg == false)
            {
                IceImg = true;
                Ice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Lava_Click(object sender, EventArgs e)
        {
            if (LavaImg == true)
            {
                LavaImg = false;
                Lava.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (LavaImg == false)
            {
                LavaImg = true;
                Lava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Oceanic_Click(object sender, EventArgs e)
        {
            if (OceanicImg == true)
            {
                OceanicImg = false;
                Oceanic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (OceanicImg == false)
            {
                OceanicImg = true;
                Oceanic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Plasma_Click(object sender, EventArgs e)
        {
            if (PlasmaImg == true)
            {
                PlasmaImg = false;
                Plasma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (PlasmaImg == false)
            {
                PlasmaImg = true;
                Plasma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Storm_Click(object sender, EventArgs e)
        {
            if (StormImg == true)
            {
                StormImg = false;
                Storm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (StormImg == false)
            {
                StormImg = true;
                Storm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Temperate_Click(object sender, EventArgs e)
        {
            if (TemperateImg == true)
            {
                TemperateImg = false;
                Temperate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (TemperateImg == false)
            {
                TemperateImg = true;
                Temperate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }
    }
}
