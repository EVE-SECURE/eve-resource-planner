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
            InitializeComponent();
            Stream P3Stream = null;
            Stream P2Stream = null;
            Stream P2_1Stream = null;
            Stream P2_2Stream = null;
            Stream P1Stream = null;
            Stream P1_1Stream = null;
            Stream P1_2Stream = null;
            Stream P1_3Stream = null;
            Stream P1_4Stream = null;
            Stream P1_5Stream = null;
            Stream P0Stream = null;
            Stream P0_1Stream = null;
            Stream P0_2Stream = null;
            Stream P0_3Stream = null;
            Stream P0_4Stream = null;
            Stream P0_5Stream = null;
            Image P3img = null;
            Image P2img = null;
            Image P2_1img = null;
            Image P2_2img = null;
            Image P1img = null;
            Image P1_1img = null;
            Image P1_2img = null;
            Image P1_3img = null;
            Image P1_4img = null;
            Image P1_5img = null;
            Image P0img = null;
            Image P0_1img = null;
            Image P0_2img = null;
            Image P0_3img = null;
            Image P0_4img = null;
            Image P0_5img = null;
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


            try
            {
                P3Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[0] + ".png");
                P3img = Image.FromStream(P3Stream, true, true);
                P3Pic.Image = P3img;
            }

            catch (ArgumentException)
            {
                if (P3img != null)
                    P3img.Dispose();

                if (P3Stream != null)
                    P3Stream.Dispose();

                P3Pic.Image = null;
            }

            try
            {
                P2Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[1] + ".png");
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
                P1Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[2] + ".png");
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
                P0Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[3] + ".png");
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
                P1_1Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[4] + ".png");
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
                P0_1Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[5] + ".png");
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

            try
            {
                P2_1Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[6] + ".png");
                P2_1img = Image.FromStream(P2_1Stream, true, true);
                P2_1Pic.Image = P2_1img;
            }

            catch (ArgumentException)
            {
                if (P2_1img != null)
                    P2_1img.Dispose();

                if (P2_1Stream != null)
                    P2_1Stream.Dispose();

                P2_1Pic.Image = null;
            }

            try
            {
                P1_2Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[7] + ".png");
                P1_2img = Image.FromStream(P1_2Stream, true, true);
                P1_2Pic.Image = P1_2img;
            }

            catch (ArgumentException)
            {
                if (P1_2img != null)
                    P1_2img.Dispose();

                if (P1_2Stream != null)
                    P1_2Stream.Dispose();

                P1_2Pic.Image = null;
            }

            try
            {
                P0_2Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[8] + ".png");
                P0_2img = Image.FromStream(P0_2Stream, true, true);
                P0_2Pic.Image = P0_2img;
            }

            catch (ArgumentException)
            {
                if (P0_2img != null)
                    P0_2img.Dispose();

                if (P0_2Stream != null)
                    P0_2Stream.Dispose();

                P0_2Pic.Image = null;
            }

            try
            {
                P1_3Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[9] + ".png");
                P1_3img = Image.FromStream(P1_3Stream, true, true);
                P1_3Pic.Image = P1_3img;
            }

            catch (ArgumentException)
            {
                if (P1_3img != null)
                    P1_3img.Dispose();

                if (P1_3Stream != null)
                    P1_3Stream.Dispose();

                P1_3Pic.Image = null;
            }

            try
            {
                P0_3Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[10] + ".png");
                P0_3img = Image.FromStream(P0_3Stream, true, true);
                P0_3Pic.Image = P0_3img;
            }

            catch (ArgumentException)
            {
                if (P0_3img != null)
                    P0_3img.Dispose();

                if (P0_3Stream != null)
                    P0_3Stream.Dispose();

                P0_3Pic.Image = null;
            }

            try
            {
                P2_2Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[11] + ".png");
                P2_2img = Image.FromStream(P2_2Stream, true, true);
                P2_2Pic.Image = P2_2img;
            }

            catch (ArgumentException)
            {
                if (P2_2img != null)
                    P2_2img.Dispose();

                if (P2_2Stream != null)
                    P2_2Stream.Dispose();

                P2_2Pic.Image = null;
            }
            
            try
            {
                P1_4Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[12] + ".png");
                P1_4img = Image.FromStream(P1_4Stream, true, true);
                P1_4Pic.Image = P1_4img;
            }

            catch (ArgumentException)
            {
                if (P1_4img != null)
                    P1_4img.Dispose();

                if (P1_4Stream != null)
                    P1_4Stream.Dispose();

                P1_4Pic.Image = null;
            }

            try
            {
                P0_4Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[13] + ".png");
                P0_4img = Image.FromStream(P0_4Stream, true, true);
                P0_4Pic.Image = P0_4img;
            }

            catch (ArgumentException)
            {
                if (P0_4img != null)
                    P0_4img.Dispose();

                if (P0_4Stream != null)
                    P0_4Stream.Dispose();

                P0_4Pic.Image = null;
            }

            try
            {
                P1_5Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[14] + ".png");
                P1_5img = Image.FromStream(P1_5Stream, true, true);
                P1_5Pic.Image = P1_5img;
            }

            catch (ArgumentException)
            {
                if (P1_5img != null)
                    P1_5img.Dispose();

                if (P1_5Stream != null)
                    P1_5Stream.Dispose();

                P1_5Pic.Image = null;
            }

            try
            {
                P0_5Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + RawMaterial[15] + ".png");
                P0_5img = Image.FromStream(P0_5Stream, true, true);
                P0_5Pic.Image = P0_5img;
            }

            catch (ArgumentException)
            {
                if (P0_5img != null)
                    P0_5img.Dispose();

                if (P0_5Stream != null)
                    P0_5Stream.Dispose();

                P0_5Pic.Image = null;
            }



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
