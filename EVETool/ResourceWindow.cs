using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVETool
{
    public partial class ResourceWindow : Form
    {
        public ResourceWindow()
        {
            InitializeComponent();
        }

        private void NewIndustryInter_Click(object sender, EventArgs e)
        {
            ResourcePanel.Controls.Clear();
            ResourcePanel.Controls.Add(new Resources());
        }
    }
}
