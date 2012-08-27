using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace EVETool
{
    public partial class P4_P1 : UserControl
    {
        public P4_P1(List<String> P4_R1, List <String> P4_R2, List<String>P4_R3, int index, double Amount)
        {
            InitializeComponent();
            List<Image> P4_R1Imgs = new List<Image>();
            List<Image> P4_R2Imgs = new List<Image>();
            List<Image> P4_R3Imgs = new List<Image>();
            Stream ImgStream = null;
            FinalLabel.Text = P4_R1[0];
            R1Label.Text = P4_R1[1];
            R2Label.Text = P4_R3[1];
            R2_P0Label.Text = P4_R3[2];
            R3Label.Text = P4_R2[1];

            for (int i = 0; i < P4_R1.Count; i++)
            {
                try
                {
                    ImgStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + P4_R1[i] + ".png");
                    P4_R1Imgs.Add(Image.FromStream(ImgStream, true, true));
                }
                catch (ArgumentException) { P4_R1Imgs.Add(null); }
            }

            for (int i = 1; i < P4_R2.Count; i++)
            {
                try
                {
                    ImgStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + P4_R2[i] + ".png");
                    P4_R2Imgs.Add(Image.FromStream(ImgStream, true, true));
                }
                catch (ArgumentException) { P4_R2Imgs.Add(null); }
            }

            for (int i = 1; i < P4_R3.Count; i++)
            {
                try
                {
                    ImgStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EVETool.Resources." + P4_R3[i] + ".png");
                    P4_R3Imgs.Add(Image.FromStream(ImgStream, true, true));
                }
                catch (ArgumentException) { P4_R3Imgs.Add(null); }
            }
            
            FinalImg.Image = P4_R1Imgs[0];
            R1Img.Image = P4_R1Imgs[1];
            R1_P2_1Img.Image = P4_R1Imgs[2];
            R1_P2_1_P1_1Img.Image = P4_R1Imgs[3];
            R1_P2_1_P1_1_RMImg.Image = P4_R1Imgs[4];
            R1_P2_1_P1_2Img.Image = P4_R1Imgs[5];
            R1_P2_1_P1_2_RMImg.Image = P4_R1Imgs[6];
            R1_P2_2Img.Image = P4_R1Imgs[7];
            R1_P2_2_P1_1Img.Image = P4_R1Imgs[8];
            R1_P2_2_P1_1_RMImg.Image = P4_R1Imgs[9];
            R1_P2_2_P1_2Img.Image = P4_R1Imgs[10];
            R1_P2_2_P1_2_RMImg.Image = P4_R1Imgs[11];
            R2Img.Image = P4_R3Imgs[0];
            R2_P0Img.Image = P4_R3Imgs[1];
            R3Img.Image = P4_R2Imgs[0];
            R3_P2_1Img.Image = P4_R2Imgs[1];
            R3_P2_1_P1_1Img.Image = P4_R2Imgs[2];
            R3_P2_1_P1_1_RMImg.Image = P4_R2Imgs[3];
            R3_P2_1_P1_2Img.Image = P4_R2Imgs[4];
            R3_P2_1_P1_2_RMImg.Image = P4_R2Imgs[5];
            R3_P2_2Img.Image = P4_R2Imgs[6];
            R3_P2_2_P1_1Img.Image = P4_R2Imgs[7];
            R3_P2_2_P1_1_RMImg.Image = P4_R2Imgs[8];
            R3_P2_2_P1_2Img.Image = P4_R2Imgs[9];
            R3_P2_2_P1_2_RMImg.Image = P4_R2Imgs[10];
        }
    }
}
