using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReiseMond
{
    public partial class Form1 : Form
    {
        Mondreise mondreise = new Mondreise(1500);

            public Form1()
            {
                InitializeComponent();
            }

            


        private void berechnenButton_Click(object sender, EventArgs e)
        {
            double seepdkmh = Convert.ToDouble(kmTextBox.Text);
            double result;
            if (selectStunden.Checked == true)
            {
                result = mondreise.getTravelDurationHours(seepdkmh);

            }
            else
            {
                result = mondreise.getTravelDurationDays(seepdkmh);
            }
            AusgabeTextBox.Text = result.ToString();
        }
    }
}