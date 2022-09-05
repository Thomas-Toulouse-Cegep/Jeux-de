namespace Jeuxdée
{
    public partial class Form1 : Form
    {
        private int pointTotal;
        private De de = new De(7, "normal", 0);
        private DePipe dePipe = new DePipe(7, "Pipé", 50);

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
                de.LancerDeDe();
                de.ImageDe(picBoxDe, picBoxDe.Image);
                pointTotal = pointTotal + de.Point;
                txtType.Text = de.Type;
            }
            else
            {
                dePipe.LancerDeDe();
                dePipe.ImageDe(picBoxDe, picBoxDe.Image);
                pointTotal = pointTotal + dePipe.Point;
                txtType.Text = dePipe.Type;
            }
            txtPoint.Text = pointTotal.ToString();
        }

        private void btnBrasser_Click(object sender, EventArgs e)
        {
            creerDe();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBoxDe.Image = Properties.Resources._1;
            txtPoint.Text = 0.ToString();
        }
    }
}