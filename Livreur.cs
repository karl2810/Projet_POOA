using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POOA
{
    class Livreur : Personne
    {
        private int no_livreur;
        private string moyen_transport;
        private string etat_livreur;

        public Livreur(string nom, string prenom, int telephone, string adresse, int no_livreur, string moyen_transport,string etat_livreur) : base(nom, prenom, telephone, adresse)
        {
            this.no_livreur = no_livreur;
            this.moyen_transport = moyen_transport;
            this.etat_livreur = etat_livreur;
        }

        public int No_livreur
        {
            get { return this.no_livreur; }
        }
        public string Moyen_transport
        {
            get { return this.moyen_transport; }
        }
        public string Etat_livreur
        {
            get { return this.etat_livreur; }
        }

        public override string ToString()
        {
            return base.ToString() + '\n' + "Numero du livreur : " + " " + no_livreur + '\n' + "Moyen de transport : " + " " + moyen_transport + '\n' + "Etat du livreur : " + " " + etat_livreur ;
        }
    }
}
