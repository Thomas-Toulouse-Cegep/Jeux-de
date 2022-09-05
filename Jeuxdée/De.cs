namespace Jeuxdée
{
    internal class De : DeControleur
    {
        private Random randomNbr = new Random();

        private int deNbr;

        public De(int nbFacePlusUn, string type, int chance) : base(nbFacePlusUn, type, chance)
        {
        }

        public override int LancerDeDe()
        {
            deNbr = randomNbr.Next(1, NbFace);
            

            Pointage();

            return deNbr;
        }

        public override void ImageDe(PictureBox pictureBox, Image image)
        {
            switch (deNbr)
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
            Point = deNbr;
            return Point;
        }
    }
}