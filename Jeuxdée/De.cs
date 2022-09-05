namespace Jeuxdée
{
    internal class De : DeControleur
    {
        private Random rNb = new Random();

        private int deNb;

        private string type = "normal";

        public De(int nbFacePlusUn, string type, int chance) : base(nbFacePlusUn, type, chance)
        {
            type = "normale";
        }

        public override int Generer()
        {
            deNb = rNb.Next(1, NbFace);
            MessageBox.Show(deNb.ToString());
            Type = "normale";

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
            Point = deNb + Point;
            return Point;
        }
    }
}