using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POOA
{
    class Commis : Personne
    {
        private DateTime embauche;
        private string etat_commis;

        public Commis(string nom, string prenom, int telephone, string adresse, DateTime embauche, string etat_commis) : base(nom, prenom, telephone, adresse)
        {
            this.embauche = embauche;
            this.etat_commis = etat_commis;
        }

        public DateTime Embauche
        {
            get { return this.embauche; }
        }
        public string Etat_commis
        {
            get { return this.etat_commis; }
        }

        public override string ToString()
        {
            return base.ToString() + '\n' + "Date d'embauche :" + " " + embauche.ToShortDateString() + '\n' + "Etat du commis : " + " " + etat_commis ;
        }

    }
}
