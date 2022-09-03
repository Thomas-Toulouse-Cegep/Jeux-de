using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeuxdée
{
    internal class DePipe : DeControleur
    {
        public DePipe(int nbFacePlusUn, string type, int chance, int deNb) : base(nbFacePlusUn, type, chance)
        {
        }

        public override int Generer()
        {
            //MessageBox.Show(DeNb.ToString());

            return 1;
        }
    }
}