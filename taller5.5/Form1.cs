using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller5._5
{
    public partial class Form1 : Form
    {

        int x = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSegundos.Text = x.ToString();
            x--;

            if (x < 0) {
                timer1.Stop();
            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
