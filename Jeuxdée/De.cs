using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeuxdée
{
    internal class De : Controleur
    {
        private int nbface;

        //private Random rNb = new Random();
        private int deNb;

        private string type;

        public De(int nbface)
        {
            Nbface = nbface;
            //RNb = rNb;
        }

        // private;

        public int Nbface { get => nbface; set => nbface = value; }

        public int Generer()
        {
            deNb = rNb.Next(1, nbface);
            MessageBox.Show(deNb.ToString());
            return deNb;
        }

        public override void ImageDe(PictureBox pictureBox, Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}