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
    public partial class P3_3 : UserControl
    {
        public P3_3(List<String> RawMaterial, int index, Double Amount)
        {
            List<Image> ResourceImg = new List<Image>();
            Stream ImgStream = null;
            InitializeComponent();

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
            Resource3Label.Text = RawMaterial[11];
            Resource3_P1_1Label.Text = RawMaterial[12];
            Resource3_P1_1_RMLabel.Text = RawMaterial[13];
            Resource3_P1_2Label.Text = RawMaterial[14];
            Resource3_P1_2_RMLabel.Text = RawMaterial[15];
            Arrow1.Image = Properties.Resources._9_64_6;
            Arrow2.Image = Properties.Resources._9_64_6;
            Arrow3.Image = Properties.Resources._9_64_6;
            Arrow4.Image = Properties.Resources._9_64_6;

            for (int i = 0; i < RawMaterial.Count; i++)
            {
                try
                {
                    ImgStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[i] + ".png");
                    ResourceImg.Add(Image.FromStream(ImgStream, true, true));
                }
                catch (ArgumentException) { ResourceImg.Add(null); }
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
            P2_2Pic.Image = ResourceImg[11];
            P1_4Pic.Image = ResourceImg[12];
            P0_4Pic.Image = ResourceImg[13];
            P1_5Pic.Image = ResourceImg[14];
            P0_5Pic.Image = ResourceImg[15];

            if (index == 0)
            {
                if (Amount % 3 == 0)
                {
                    double P2, P1, RM;
                    FinalAmount.Text = String.Format("{0:n}", Amount) + "u";
                    P2 = (Amount / 3) * 10;
                    P1 = (P2 / 5) * 40;
                    RM = (P1 / 20) * 3000;
                    P2Amount.Text = String.Format("{0:n}", P2) + "u";
                    P2Box1Amount.Text = P2Amount.Text;
                    P2Box2Amount.Text = P2Amount.Text;
                    P1Amount.Text = String.Format("{0:n}", P1) + "u";
                    P1_1Amount.Text = P1Amount.Text;
                    P1_2Amount.Text = P1Amount.Text;
                    RMAmount.Text = String.Format("{0:n}", RM) + "u";
                    RM_1Amount.Text = RMAmount.Text;
                    RM_2Amount.Text = RMAmount.Text;
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
                P2Box1Amount.Text = P2Amount.Text;
                P2Box2Amount.Text = P2Amount.Text;
                P1Amount.Text = String.Format("{0:n}", Math.Round(P1, 2)) + "u";
                P1_1Amount.Text = P1Amount.Text;
                P1_2Amount.Text = P1Amount.Text;
                RMAmount.Text = String.Format("{0:n}", RM) + "u";
                RM_1Amount.Text = RMAmount.Text;
                RM_2Amount.Text = RMAmount.Text;
            }
        }
    }
}
