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
    public partial class P2 : UserControl
    {
        public P2(List<String> Resources, int Index, Double Amount)
        {
            List<Image> ResourceImg = new List<Image>();
	        InitializeComponent();
	        Stream ResourceStream = null;
            
            Final.Text = Resources[0];
            P1_1Label.Text = Resources[1];
            P1_1_RMLabel.Text = Resources[2];
            P1_2Label.Text = Resources[3];
            P1_2_RMLabel.Text = Resources[4];
            
            for(int i = 0; i < Resources.Count; i++)
            {
	            try
                {
                    ResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + Resources[i] + ".png");
                    ResourceImg.Add(Image.FromStream(ResourceStream, true, true));  
                }
                catch (ArgumentException){ResourceImg.Add(null);}
	        }

	        P2Pic.Image = ResourceImg[0];
            P1Pic.Image = ResourceImg[1];
            P0Pic.Image = ResourceImg[2];
            P1_1Pic.Image = ResourceImg[3];
            P0_1Pic.Image = ResourceImg[4];

            if (Index == 0)
            {
                if (Amount % 5 == 0)
                {
                    double P1, RM;
                    P1 = (Amount / 5) * 40;
                    RM = (P1 / 20) * 3000;
                    FinalAmount.Text = String.Format("{0:n}", Amount) + "u";
                    P1Amount.Text = String.Format("{0:n}", P1) + "u";
                    RMAmount.Text = String.Format("{0:n}", RM) + "u";
                }
                else
                {
                    Popup error = new Popup("Invalid Entry", "The entered value must be a number divisible by 5");
                    error.Show();
                }
            }
            if (Index == 1)
            {
                double P2, P1, RM;
                P2 = Math.Truncate(Amount / 1.5);
                P1 = (P2 / 5) * 40;
                RM = (P1 / 20) * 3000;
                FinalAmount.Text = String.Format("{0:n}", P2) + "u";
                P1Amount.Text = String.Format("{0:n}", Math.Round(P1, 2)) + "u";
                RMAmount.Text = String.Format("{0:n}", Math.Round(RM, 2)) + "u";
            }
        }
    }
}