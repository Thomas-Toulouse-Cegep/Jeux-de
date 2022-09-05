namespace Jeuxdée
{
    internal class DePipe : DeControleur
    {
        private Random rNb = new Random();

        private int deNb;

        public DePipe(int nbFacePlusUn, string type, int chance) : base(nbFacePlusUn, type, chance)
        {
            type = "pipe";
        }

        public override int Generer()
        {
            Random randomchance = new Random();
            randomchance.Next(0, 100);
            deNb = rNb.Next(1, NbFace);
            if (Chance <= 50)
            {
                MessageBox.Show(deNb.ToString());
            }
            else
            {
                MessageBox.Show(deNb.ToString());
            }
            Type = "Pipé";
            Pointage();
            return deNb;
        }

        public override void ImageDe(PictureBox pictureBox, Image image)
        {
            switch (deNb)
            {
                case 1:
                    pictureBox.Image = Properties.Resources._1;
                    break;

                case 2:
                    pictureBox.Image = Properties.Resources._2;
                    break;

                case 3:
                    pictureBox.Image = Properties.Resources._3;
                    break;

                case 4:
                    pictureBox.Image = Properties.Resources._4;
                    break;

                case 5:
                    pictureBox.Image = Properties.Resources._5;
                    break;

                case 6:
                    pictureBox.Image = Properties.Resources._6;
                    break;
            }
        }

        public override int Pointage()
        {
            Random randomchance = new Random();
            randomchance.Next(0, 100);
            if (Chance <= 50)
            {
                deNb = deNb * 2;
                Point = (deNb + Point);
            }
            else
            {
                Point = deNb + Point;
            }

            return Point;
        }
    }
}