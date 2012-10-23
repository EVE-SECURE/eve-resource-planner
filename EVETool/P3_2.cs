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
using System.Reflection;

namespace EVETool
{
    public partial class P3_2 : UserControl
    {
        public P3_2(List<String> RawMaterial, int index, Double Amount)
        {
            List<Image> ResourceImg = new List<Image>();
	        InitializeComponent();
	        Stream ResourceStream = null;

            FinalLabel.Text = RawMaterial[0];
            Resource1Label.Text = RawMaterial[1];
            Resource1_P1_1Label.Text = RawMaterial[2];
            Resource1_P1_2_RMLabel.Text = RawMaterial[5];
            Resource1_P1_2Label.Text = RawMaterial[4];
            Resource1_P1_1_RMLabel.Text = RawMaterial[3];
            Resource2Label.Text = RawMaterial[6];
            Resource2_P1_1Label.Text = RawMaterial[7];
            Resource2_P1_1_RMLabel.Text = RawMaterial[8];
            Resource2_P1_2Label.Text = RawMaterial[9];
            Resource2_P1_2_RMLabel.Text = RawMaterial[10];

	        for (int i = 0; i < RawMaterial.Count; i++){
                try
                {
                    ResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[i] + ".png");
                    ResourceImg.Add(Image.FromStream(ResourceStream, true, true));
                }
                catch (ArgumentException){ResourceImg.Add(null);}
	        }

	        P3Pic.Image = ResourceImg[0];
            P2Pic.Image = ResourceImg[1];
            P1Pic.Image = ResourceImg[2];
            P0Pic.Image = ResourceImg[3];
            P1_1Pic.Image = ResourceImg[4];
            P0_1Pic.Image = ResourceImg[5];
            P2_1Pic.Image = ResourceImg[6];
            P1_2Pic.Image = ResourceImg[7];
            P0_2Pic.Image = ResourceImg[8];
            P1_3Pic.Image = ResourceImg[9];
            P0_3Pic.Image = ResourceImg[10];
         
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