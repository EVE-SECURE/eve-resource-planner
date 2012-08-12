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
            InitializeComponent();
            Stream P1Stream = null;
            Stream P0Stream = null;
            Image P1img = null;
            Image P0img = null;
            Result.Text = P1Resources[0];
            RMLabel.Text = P1Resources[1];
            try
            {
                // Pulls the image by the name of the resource stored in list from running assembly.
                P1Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + P1Resources[0] + ".png");
                P1img = Image.FromStream(P1Stream, true, true);
                P1Pic.Image = P1img;
            }
            catch (ArgumentException)
            {
                if (P1img != null)
                    P1img.Dispose();

                if (P1Stream != null)
                    P1Stream.Dispose();

                P1Pic.Image = null;
            }
            try
            {
                // Pulls the image by the name of the resource stored in list from running assembly.
                P0Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + P1Resources[1] + ".png");
                P0img = Image.FromStream(P0Stream, true, true);
                P0Pic.Image = P0img;
            }
            catch (ArgumentException)
            {
                if (P0img != null)
                    P0img.Dispose();

                if (P0Stream != null)
                    P0Stream.Dispose();

                P0Pic.Image = null;
            }



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
