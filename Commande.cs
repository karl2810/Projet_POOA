using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POOA
{
    class Commande
    {
        private int no_commande;
        private DateTime date;
        private Pizza[] pizzas;
        private Boisson[] boissons;
        private string etat_commande;
        private string nom_client;
        private string nom_commis;
        private string solde;

        public Commande(int no_commande,DateTime date, Pizza[] pizzas, Boisson [] boissons, string nom_client, string nom_commis, string etat_commande, string solde)
        {
            this.no_commande = no_commande;
            this.date = date;
            this.pizzas = pizzas;
            this.boissons = boissons;
            this.nom_client = nom_client;
            this.nom_commis = nom_commis;
            this.etat_commande = etat_commande;
            this.solde = solde;
        }

        public int No_commande
        {
            get { return this.no_commande; }
        }
        public DateTime Date
        {
            get { return this.date; }
        }
        public Pizza[] Pizzas
        {
            get { return this.pizzas; }
            set { this.pizzas = value; }
        }

        public Boisson[] Boissons
        {
            get { return this.boissons; }
            set { this.boissons = value; }
        }
        public string Nom_client
        {
            get { return this.nom_client; }
        }
        public string Nom_commis
        {
            get { return this.nom_commis; }
        }
        public string Etat_commande
        {
            get { return this.etat_commande; }
            set { this.etat_commande = value; }
        }
        public string Solde
        {
            get { return this.solde; }
            set { this.solde = value; }
        }


        public double facture()
        {
            double somme_pizza = 0;
            double somme_boisson = 0;
            for (int i = 0; i < pizzas.Length; i++)
            {
                somme_pizza = somme_pizza + pizzas[i].calcul_prix();
            }
            for (int i = 0; i < boissons.Length; i++)
            {
                somme_boisson = somme_boisson + boissons[i].GetPrix();
            }

            return somme_pizza+somme_boisson;
        }


    }
}
