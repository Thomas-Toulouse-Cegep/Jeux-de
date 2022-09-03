using System;

namespace Jeuxdée
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnBrasser_Click(object sender, EventArgs e)
        {
            De de = new De(7, "poenis", 0);
            de.Generer();
            //de.Pointage();

            txtPoint.Text = de.Point.ToString();
        }
    }
}