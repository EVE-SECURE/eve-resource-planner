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
            InitializeComponent();
            Stream P2Stream = null;
            Stream P1Stream = null;
            Stream P1_1Stream = null;
            Stream P0Stream = null;
            Stream P0_1Stream = null;
            Image P2img = null;
            Image P1img = null;
            Image P1_1img = null;
            Image P0img = null;
            Image P0_1img = null;
            
            Final.Text = Resources[0];
            P1_1Label.Text = Resources[1];
            P1_1_RMLabel.Text = Resources[2];
            P1_2Label.Text = Resources[3];
            P1_2_RMLabel.Text = Resources[4];
            
            try
            {
                P2Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + Resources[0] + ".png");
                P2img = Image.FromStream(P2Stream, true, true);
                P2Pic.Image = P2img;
            }

            catch (ArgumentException)
            {
                if (P2img != null)
                    P2img.Dispose();

                if (P2Stream != null)
                    P2Stream.Dispose();

                P2Pic.Image = null;
            }

            try
            {
                P1Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + Resources[1] + ".png");
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
                P0Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + Resources[2] + ".png");
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

            try
            {
                P1_1Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + Resources[3] + ".png");
                P1_1img = Image.FromStream(P1_1Stream, true, true);
                P1_1Pic.Image = P1_1img;
            }

            catch (ArgumentException)
            {
                if (P1_1img != null)
                    P1_1img.Dispose();

                if (P1_1Stream != null)
                    P1_1Stream.Dispose();

                P1_1Pic.Image = null;
            }

            try
            {
                P0_1Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + Resources[4] + ".png");
                P0_1img = Image.FromStream(P0_1Stream, true, true);
                P0_1Pic.Image = P0_1img;
            }

            catch (ArgumentException)
            {
                if (P0_1img != null)
                    P0_1img.Dispose();

                if (P0_1Stream != null)
                    P0_1Stream.Dispose();

                P0_1Pic.Image = null;
            }

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
