using System;

namespace Jeuxdée
{
    public partial class Form1 : Form
    {
        private int pointTotal;
        private De de = new De(7, "i", 0);
        private DePipe dePipe = new DePipe(7, "p", 50);

        public Form1()

        {
            InitializeComponent();
        }

        private void creerDe()
        {
            int i = 0;
            Random random = new Random();
            i = random.Next(1, 3);
            if (i == 1)
            {
                de.Generer();
                pointTotal += de.Point;
                txtType.Text = de.Type;
            }
            else
            {
                dePipe.Generer();
                pointTotal += dePipe.Point;
                txtType.Text = dePipe.Type;
                // DePipe dePipe = new DePipe(7, "p", 50);
            }
            txtPoint.Text = pointTotal.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnBrasser_Click(object sender, EventArgs e)
        {
            //de.Generer();
            creerDe();
            //txtPoint.Text = de.Point.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPoint.Text = 0.ToString();
        }
    }
}