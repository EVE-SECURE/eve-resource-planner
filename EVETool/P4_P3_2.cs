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
    public partial class P4_P3_2 : UserControl
    {
        String[] P4_Res1;
        String[] P4_Res2;
        String[] P4_Res3;
        public P4_P3_2(List<String> P4_R1, List<String> P4_R2, List<String> P4_R3, int Index, Double Amount)
        {
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
            R2Img.Image = P4_R2Imgs[0];
            R2_P2_1Img.Image = P4_R2Imgs[1];
            R2_P2_1_P1_1Img.Image = P4_R2Imgs[2];
            R2_P2_1_P1_1_RMImg.Image = P4_R2Imgs[3];
            R2_P2_1_P1_2Img.Image = P4_R2Imgs[4];
            R2_P2_1_P1_2_RMImg.Image = P4_R2Imgs[5];
            R2_P2_2Img.Image = P4_R2Imgs[6];
            R2_P2_2_P1_1Img.Image = P4_R2Imgs[7];
            R2_P2_2_P1_1_RMImg.Image = P4_R2Imgs[8];
            R2_P2_2_P1_2Img.Image = P4_R2Imgs[9];
            R2_P2_2_P1_2_RMImg.Image = P4_R2Imgs[10];
            R3Img.Image = P4_R3Imgs[0];
            R3_P2_1Img.Image = P4_R3Imgs[1];
            R3_P2_1_P1_1Img.Image = P4_R3Imgs[2];
            R3_P2_1_P1_1_RMImg.Image = P4_R3Imgs[3];
            R3_P2_1_P1_2Img.Image = P4_R3Imgs[4];
            R3_P2_1_P1_2_RMImg.Image = P4_R3Imgs[5];
            R3_P2_2Img.Image = P4_R3Imgs[6];
            R3_P2_2_P1_1Img.Image = P4_R3Imgs[7];
            R3_P2_2_P1_1_RMImg.Image = P4_R3Imgs[8];
            R3_P2_2_P1_2Img.Image = P4_R3Imgs[9];
            R3_P2_2_P1_2_RMImg.Image = P4_R3Imgs[10];

            if (Index == 0)
            {
                if (Amount % 1 == 0)
                {
                    double P1, P3, P2, RM;
                    FinalAmount.Text = String.Format("{0:n}", Amount) + "u";
                    P3 = (Amount * 6);
                    P2 = (P3 / 3) * 40;
                    P1 = (P2 / 5) * 40;
                    RM = (P1 / 20) * 3000;

                    R1Amount.Text = String.Format("{0:n}", P3) + "u";
                    R2Amount.Text = R1Amount.Text;
                    R3Amount.Text = R1Amount.Text;
                    R1_P2Amount.Text = String.Format("{0:n}", P2) + "u";
                    R2_P2Amount.Text = R1_P2Amount.Text;
                    R3_P2Amount.Text = R1_P2Amount.Text;
                    R1_P1Amount.Text = String.Format("{0:n}", P1) + "u";
                    R2_P1Amount.Text = R1_P1Amount.Text;
                    R3_P1Amount.Text = R1_P1Amount.Text;
                    R1_P0Amount.Text = String.Format("{0:n}", RM) + "u";
                    R2_P0Amount.Text = R1_P0Amount.Text;
                    R3_P0Amount.Text = R1_P0Amount.Text;

                }
                else
                {
                    Popup error = new Popup("Invalid Entry", "The entered value must be a number divisible by 1");
                    error.Show();
                }
            }
            else if (Index == 1)
            {

                double P4, P1, P3, P2, RM;
                P4 = Math.Truncate(Amount / 100);
                P3 = (P4 * 6);
                P2 = (P3 / 3) * 40;
                P1 = (P2 / 5) * 40;
                RM = (P1 / 20) * 3000;
                
                
                FinalAmount.Text = String.Format("{0:n}", P4) + "u";
                R1Amount.Text = String.Format("{0:n}", P3) + "u";
                R2Amount.Text = R1Amount.Text;
                R3Amount.Text = R1Amount.Text;
                R1_P2Amount.Text = String.Format("{0:n}", P2) + "u";
                R2_P2Amount.Text = R1_P2Amount.Text;
                R3_P2Amount.Text = R1_P2Amount.Text;
                R1_P1Amount.Text = String.Format("{0:n}", P1) + "u";
                R2_P1Amount.Text = R1_P1Amount.Text;
                R3_P1Amount.Text = R1_P1Amount.Text;
                R1_P0Amount.Text = String.Format("{0:n}", RM) + "u";
                R2_P0Amount.Text = R1_P0Amount.Text;
                R3_P0Amount.Text = R1_P0Amount.Text;

            }

        }

        private void R1_P2_1Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res1[2], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R1_P2_1_P1_1Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res1[3], this, B.X + 10, B.Y + 15, 3000);
        }

         private void R1_P2_1_P1_1_RMImg_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res1[4], this, B.X + 10, B.Y + 15, 3000);
        }
       
        private void R1_P2_1_P1_2Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res1[5], this, B.X + 10, B.Y + 15, 3000);
        }
        private void R1_P2_1_P1_2_RMImg_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res1[6], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R1_P2_2Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res1[7], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R1_P2_2_P1_1Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res1[8], this, B.X + 10, B.Y + 15, 3000);
        }
        
        private void R1_P2_2_P1_1_RMImg_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res1[9], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R1_P2_2_P1_2Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res1[10], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R1_P2_2_P1_2_RMImg_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res1[11], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R2_P2_1Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res2[2], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R2_P2_1_P1_1Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res2[3], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R2_P2_1_P1_1_RMImg_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res2[4], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R2_P2_1_P1_2Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res2[5], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R2_P2_1_P1_2_RMImg_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res2[6], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R2_P2_2Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res2[7], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R2_P2_2_P1_1Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res2[8], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R2_P2_2_P1_1_RMImg_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res2[9], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R2_P2_2_P1_2Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res2[10], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R2_P2_2_P1_2_RMImg_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res2[11], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R3_P2_1Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res3[2], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R3_P2_1_P1_1Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res3[3], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R3_P2_1_P1_1_RMImg_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res3[4], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R3_P2_1_P1_2Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res3[5], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R3_P2_1_P1_2_RMImg_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res3[6], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R3_P2_2Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res3[7], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R3_P2_2_P1_1Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res3[8], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R3_P2_2_P1_1_RMImg_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res3[9], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R3_P2_2_P1_2Img_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res3[10], this, B.X + 10, B.Y + 15, 3000);
        }

        private void R3_P2_2_P1_2_RMImg_MouseHover(object sender, EventArgs e)
        {
            Point B = PointToClient(Cursor.Position);
            ResourceName.Show(P4_Res3[11], this, B.X + 10, B.Y + 15, 3000);
        }
    }
}
