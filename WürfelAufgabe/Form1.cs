using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WürfelAufgabe
{
    public partial class Form1 : Form
    {
        Wuerfel wuerfel = new Wuerfel();
        public Form1()
        {
            InitializeComponent();
        }


        private void WuerfelnButton_Click_1(object sender, EventArgs e)
        {

                    int Wurf = wuerfel.Werfen();
                    WurfLable.Text = Wurf.ToString();
                    letzterWurfLable.Text = wuerfel.LetzterWurf.ToString();
        }
    }
}

