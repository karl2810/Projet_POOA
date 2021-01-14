using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POOA
{
    class Boisson
    {
        private string nom;
        private int volume;

        public Boisson (string nom,int volume)
        {
            this.nom = nom;
            this.volume = volume;
        }
        public string Nom
        {
            get { return this.nom; }
        }
        public int Volume
        {
            get { return this.volume; }
        }

        public double GetPrix()
        {
            if (volume == 33)
            {
                return 1;
            }
            else if (volume == 50)
            {
                return 1.5;
            }
            else
            {
                return 2;
            }
        }
    }
}
