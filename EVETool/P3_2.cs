using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EVETool
{
    public partial class P3_2 : UserControl
    {
        public P3_2(List<String> RawMaterial, int index, Double Amount)
        {
            InitializeComponent();
            Stream P2Stream = null;
            Stream P2_1Stream = null;
            Stream P1Stream = null;
            Stream P1_1Stream = null;
            Stream P1_2Stream = null;
            Stream P1_3Stream = null;
            Stream P0Stream = null;
            Stream P0_1Stream = null;
            Stream P0_2Stream = null;
            Stream P0_3Stream = null;
            Image P2img = null;
            Image P2_1img = null;
            Image P1img = null;
            Image P1_1img = null;
            Image P1_2img = null;
            Image P1_3img = null;
            Image P0img = null;
            Image P0_1img = null;
            Image P0_2img = null;
            Image P0_3img = null;
            FinalLabel.Text = RawMaterial[0];
            Resource1Label.Text = RawMaterial[1];
            Resource1_P1_1Label.Text = RawMaterial[2];
            Resource1_P1_1_RMLabel.Text = RawMaterial[3];
            Resource1_P1_2Label.Text = RawMaterial[4];
            Resource1_P1_2_RMLabel.Text = RawMaterial[5];
            Resource2Label.Text = RawMaterial[6];
            Resource2_P1_1Label.Text = RawMaterial[7];
            Resource2_P1_1_RMLabel.Text = RawMaterial[8];
            Resource2_P1_2Label.Text = RawMaterial[9];
            Resource2_P1_2_RMLabel.Text = RawMaterial[10];

            if (index == 0)
            {
                if (Amount % 3 == 0)
                {
                    double P2, P1, RM;
                    FinalAmount.Text = Convert.ToString(Amount) + "u";
                    P2 = (Amount / 3) * 10;
                    P1 = (P2 / 5) * 40;
                    RM = (P1 / 20) * 3000;
                    P2Amount.Text = String.Format("{0:n}", P2) + "u";
                    P1Amount.Text = String.Format("{0:n}", P1) + "u";
                    P1_1Amount.Text = P1Amount.Text;
                    RMAmount.Text = String.Format("{0:n}", RM) + "u";
                    RM_1Amount.Text = RMAmount.Text;
                }
                else
                {
                    Popup error = new Popup("Invalid Entry", "The entered value must be a number divisible by 3");
                    error.Show();
                }
            }
            else if (index == 1)
            {
                double P3, P2, P1, RM;
                P3 = Math.Truncate(Amount / 6);
                P2 = (P3 / 3) * 10;
                P1 = (P2 / 5) * 40;
                RM = (P1 / 20) * 3000;
                FinalAmount.Text = String.Format("{0:n}", P3) + "u";
                P2Amount.Text = String.Format("{0:n}", Math.Round(P2, 2)) + "u";
                P1Amount.Text = String.Format("{0:n}", Math.Round(P1, 2)) + "u";
                P1_1Amount.Text = P1Amount.Text;
                RMAmount.Text = String.Format("{0:n}", Math.Round(RM, 2)) + "u";
                RM_1Amount.Text = RMAmount.Text;
            }
        }
    }
}
