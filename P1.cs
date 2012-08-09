using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVETool
{
    public partial class P1 : UserControl
    {
        public P1(List<String> P1Resources, int Index, Double Amount)
        {
            InitializeComponent();
            Result.Text = P1Resources[0];
            RMLabel.Text = P1Resources[1];

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

                ResultAmount.Text = Convert.ToString(Math.Truncate(Amount / 0.38)) + "u";
                RMAmount.Text = Convert.ToString((Math.Truncate((Amount / 0.38)) / 20) * 3000) + "u";
            }
        }
    }
}
