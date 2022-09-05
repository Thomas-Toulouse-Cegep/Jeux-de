namespace Jeuxdée
{
    internal abstract class DeControleur
    {
        private int nbFacePlusUn;
        private string type;
        private int chance;
        private int point;

        public DeControleur(int nbFacePlusUn, string type, int chance)
        {
            this.nbFacePlusUn = nbFacePlusUn;
            this.type = type;
            this.Chance = chance;
        }

        public int NbFace { get => nbFacePlusUn; set => nbFacePlusUn = value; }
        public string Type { get => type; set => type = value; }
        public int Point { get => point; set => point = value; }
        public int Chance { get => chance; set => chance = value; }

        public abstract void ImageDe(PictureBox pictureBox, Image image);

        public abstract int LancerDeDe();

        public abstract int Pointage();
    }
}