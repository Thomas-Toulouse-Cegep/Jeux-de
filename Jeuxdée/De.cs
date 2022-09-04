using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override int Pointage()
        {
            Point = deNb + Point;
            return Point;
        }
    }
}