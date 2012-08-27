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
        private Boolean BarrenToggle = true;
        private Boolean GasToggle = true;
        private Boolean IceToggle = true;
        private Boolean LavaToggle = true;
        private Boolean OceanicToggle = true;
        private Boolean PlasmaToggle = true;
        private Boolean StormToggle = true;
        private Boolean TemperateToggle = true;
        public ResourceWindow()
        {
            InitializeComponent();

        }

        private void NewIndustryInter_Click(object sender, EventArgs e)
        {
            ResourcePanel.Controls.Clear();
            ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
        }

        private void Barren_Click(object sender, EventArgs e)
        {
            if (BarrenToggle == true)
            {
                BarrenToggle = false;
                Barren.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (BarrenToggle == false)
            {
                BarrenToggle = true;
                Barren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Gas_Click(object sender, EventArgs e)
        {
            if (GasToggle == true)
            {
                GasToggle = false;
                Gas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (GasToggle == false)
            {
                GasToggle = true;
                Gas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Ice_Click(object sender, EventArgs e)
        {
            if (IceToggle == true)
            {
                IceToggle = false;
                Ice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (IceToggle == false)
            {
                IceToggle = true;
                Ice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Lava_Click(object sender, EventArgs e)
        {
            if (LavaToggle == true)
            {
                LavaToggle = false;
                Lava.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (LavaToggle == false)
            {
                LavaToggle = true;
                Lava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Oceanic_Click(object sender, EventArgs e)
        {
            if (OceanicToggle == true)
            {
                OceanicToggle = false;
                Oceanic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (OceanicToggle == false)
            {
                OceanicToggle = true;
                Oceanic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Plasma_Click(object sender, EventArgs e)
        {
            if (PlasmaToggle == true)
            {
                PlasmaToggle = false;
                Plasma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (PlasmaToggle == false)
            {
                PlasmaToggle = true;
                Plasma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Storm_Click(object sender, EventArgs e)
        {
            if (StormToggle == true)
            {
                StormToggle = false;
                Storm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (StormToggle == false)
            {
                StormToggle = true;
                Storm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Temperate_Click(object sender, EventArgs e)
        {
            if (TemperateToggle == true)
            {
                TemperateToggle = false;
                Temperate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (TemperateToggle == false)
            {
                TemperateToggle = true;
                Temperate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Barren_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
