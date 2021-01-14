using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POOA
{
    abstract class Personne
    {
        protected string nom;
        protected string prenom;
        protected int telephone;
        protected string adresse;

        public Personne(string nom, string prenom, int telephone, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.adresse = adresse;
        }

        public string Nom
        {
            get { return this.nom; }
        }
        public string Prenom
        {
            get { return this.prenom; }
        }
        public int Telephone
        {
            get { return this.telephone; }
        }
        public string Adresse
        {
            get { return this.adresse; }
        }

        public virtual string ToString()
        {
            return "Nom :" + " " + nom + '\n' + "Prenom :" + " " + prenom + '\n' + "Telephone :" + " " + telephone + '\n' + "Adresse : " + " " + adresse ;
        }
    }
}
