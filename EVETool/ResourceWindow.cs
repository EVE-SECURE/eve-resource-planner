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
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
            else if (BarrenToggle == false)
            {
                BarrenToggle = true;
                Barren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
        }

        private void Gas_Click(object sender, EventArgs e)
        {
            if (GasToggle == true)
            {
                GasToggle = false;
                Gas.BorderStyle = System.Windows.Forms.BorderStyle.None;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
            else if (GasToggle == false)
            {
                GasToggle = true;
                Gas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
        }

        private void Ice_Click(object sender, EventArgs e)
        {
            if (IceToggle == true)
            {
                IceToggle = false;
                Ice.BorderStyle = System.Windows.Forms.BorderStyle.None;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
            else if (IceToggle == false)
            {
                IceToggle = true;
                Ice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
        }

        private void Lava_Click(object sender, EventArgs e)
        {
            if (LavaToggle == true)
            {
                LavaToggle = false;
                Lava.BorderStyle = System.Windows.Forms.BorderStyle.None;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
            else if (LavaToggle == false)
            {
                LavaToggle = true;
                Lava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
        }

        private void Oceanic_Click(object sender, EventArgs e)
        {
            if (OceanicToggle == true)
            {
                OceanicToggle = false;
                Oceanic.BorderStyle = System.Windows.Forms.BorderStyle.None;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
            else if (OceanicToggle == false)
            {
                OceanicToggle = true;
                Oceanic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
        }

        private void Plasma_Click(object sender, EventArgs e)
        {
            if (PlasmaToggle == true)
            {
                PlasmaToggle = false;
                Plasma.BorderStyle = System.Windows.Forms.BorderStyle.None;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
            else if (PlasmaToggle == false)
            {
                PlasmaToggle = true;
                Plasma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
        }

        private void Storm_Click(object sender, EventArgs e)
        {
            if (StormToggle == true)
            {
                StormToggle = false;
                Storm.BorderStyle = System.Windows.Forms.BorderStyle.None;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
            else if (StormToggle == false)
            {
                StormToggle = true;
                Storm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
        }

        private void Temperate_Click(object sender, EventArgs e)
        {
            if (TemperateToggle == true)
            {
                TemperateToggle = false;
                Temperate.BorderStyle = System.Windows.Forms.BorderStyle.None;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
            else if (TemperateToggle == false)
            {
                TemperateToggle = true;
                Temperate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                if (ResourcePanel.Controls != null)
                {
                    ResourcePanel.Controls.Clear();
                    ResourcePanel.Controls.Add(new ResourcePanel(BarrenToggle, GasToggle, IceToggle, LavaToggle, OceanicToggle, PlasmaToggle, StormToggle, TemperateToggle));
                }
            }
        }

        private void Barren_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Barren";
        }

        private void Barren_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel.Text = "";
        }

        private void Gas_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Gas";
        }

        private void Gas_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel.Text = "";
        }

        private void Ice_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Ice";
        }

        private void Ice_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel.Text = "";
        }

        private void Lava_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Lava";
        }

        private void Lava_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel.Text = "";
        }

        private void Oceanic_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Oceanic";
        }

        private void Oceanic_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel.Text = "";
        }

        private void Plasma_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Plasma";
        }

        private void Plasma_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel.Text = "";
        }

        private void Storm_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Storm";
        }

        private void Storm_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel.Text = "";
        }

        private void Temperate_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Temperate";
        }

        private void Temperate_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel.Text = "";
        }

    }
}
