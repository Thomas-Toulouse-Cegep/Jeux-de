using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            deNb = rNb.Next(1, NbFace);
            if (deNb <= 3)
            {
                deNb = deNb * 2;
                //deNb  = rNb.Next(1, NbFace) * 2;
                MessageBox.Show(deNb.ToString());
               
            }
            else
            {
               
                //deNb = rNb.Next(1, NbFace);
                MessageBox.Show(deNb.ToString());
            }
            Type = "Pipé";
            Pointage();
            return deNb;
        }

        public override int Pointage()
        {
            Point = deNb + Point;
            return Point;
        }
    }
}