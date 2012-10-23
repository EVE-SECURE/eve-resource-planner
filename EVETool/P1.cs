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
    public partial class P1 : UserControl
    {
        public P1(List<String> P1Resources, int Index, Double Amount)
        {   
            List<Image> ResourceImg = new List<Image>();
	        InitializeComponent();
            Stream ResourceStream = null;

            Result.Text = P1Resources[0];
            RMLabel.Text = P1Resources[1];
            
	        for (int i = 0; i < P1Resources.Count; i++)
            {
	            try
                {
                    // Pulls the image by the name of the resource stored in list from running assembly.
                    ResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + P1Resources[i] + ".png");
                    ResourceImg.Add(Image.FromStream(ResourceStream, true, true));
                }
                catch (ArgumentException){ResourceImg.Add(null);}
	        }

	        P1Pic.Image = ResourceImg[0];
            P0Pic.Image = ResourceImg[1];

            if (Index == 0) {
                if (Amount % 20 == 0) {
                    double RM;
                    RM = (Amount / 20) * 3000;
                    ResultAmount.Text = Convert.ToString(Amount) + "u";
                    RMAmount.Text = Convert.ToString(RM) + "u";
                }
                else {
                    Popup error = new Popup("Invalid Entry", "The entered value must be a number divisible by 20");
                    error.Show();
                }
            }
            if (Index == 1) {
                double P1, RM;
                P1 = Math.Truncate(Amount / 0.38);
                RM = (P1 / 20) * 3000;
                ResultAmount.Text = String.Format("{0:n}", P1) + "u";
                RMAmount.Text = String.Format("{0:n}", RM) + "u";
            }
        }
    }
}