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
    public partial class P4_P3_3 : UserControl
    {
        public P4_P3_3(List<String> P4_R1, List<String> P4_R2, List<String> P4_R3, int Index, Double Amount)
        {
            String[] P4_Res1;
            String[] P4_Res2;
            String[] P4_Res3;
            InitializeComponent();
            P4_Res1 = new String[P4_R1.Count];
            P4_Res2 = new String[P4_R2.Count];
            P4_Res3 = new String[P4_R3.Count];

            for (int i = 0; i < P4_R1.Count; i++)
                P4_Res1[i] = P4_R1[i];
            for (int i = 0; i < P4_R2.Count; i++)
                P4_Res2[i] = P4_R2[i];
            for (int i = 0; i < P4_R3.Count; i++)
                P4_Res3[i] = P4_R3[i];

            List<Image> P4_R1Imgs = new List<Image>();
            List<Image> P4_R2Imgs = new List<Image>();
            List<Image> P4_R3Imgs = new List<Image>();
            Stream ImgStream = null;
            FinalLabel.Text = P4_R1[0];
            R1Label.Text = P4_R1[1];
            R2Label.Text = P4_R2[1];
            R3Label.Text = P4_R3[1];

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
            R1_P2_3Img.Image = P4_R1Imgs[12];
            R1_P2_3_P1_1Img.Image = P4_R1Imgs[13];
            R1_P2_3_P1_1_RMImg.Image = P4_R1Imgs[14];
            R1_P2_3_P1_2Img.Image = P4_R1Imgs[15];
            R1_P2_3_P1_2_RMImg.Image = P4_R1Imgs[16];
        }
    }
}
