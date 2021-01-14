using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_POOA
{
    class Pizza
    {
        private string taille;
        private string type;

        public Pizza (string taille, string type)
        {
            this.taille = taille;
            this.type = type;
        }

        public string Taille
        {
            get { return this.taille; }
        }

        public string Type
        {
            get { return this.type; }
        }
        

        public string ToString()
        {
            return "Taille :" + " " + taille + '\n' + "Type :" + " " + type ;
        }

        public double calcul_prix()
        {
            double prix = 0;
            if (type == "Margueritta" || type == "Vegetarienne")
            {
                if (taille == "petite")
                {
                    prix = 9;
                }
                else if (taille == "moyenne")
                {
                    prix = 11;
                }
                else if (taille == "grande")
                {
                    prix = 14;
                }
                else
                {
                    Console.Write("impossible");
                }
            }
            else if (type=="4 Formage")
            {
                if (taille == "petite")
                {
                    prix = 9.5;
                }
                else if (taille == "moyenne")
                {
                    prix = 11.5;
                }
                else if (taille == "grande")
                {
                    prix = 14.5;
                }
                else
                {
                    Console.Write("impossible");
                }
            }
            else if (type=="Avec garniture")
            {
                if (taille == "petite")
                {
                    prix = 10;
                }
                else if (taille == "moyenne")
                {
                    prix = 12.5;
                }
                else if (taille == "grande")
                {
                    prix = 15.5;
                }
                else
                {
                    Console.Write("impossible");
                }
            }
            else
            {
                Console.Write("impossible");
            }
            return prix;
        }
    }
}
