using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POOA
{
    class Client : Personne
    {
        
        private List<Commande> liste_commande;

        public Client(string nom, string prenom, int telephone,string adresse, List<Commande> liste_commande): base(nom,prenom,telephone,adresse)
        {
            this.liste_commande = liste_commande;
        }

        public List<Commande> Liste_commande
        {
            get { return this.liste_commande; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        // Verifier si les pizzas ont ete livrees
        public bool Verification()
        {

        }
    }
}
