using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class Animal
    {
        //Attributs
        protected int nbPattes;
        protected string espece;

        //Constructeur
        public Animal(int nbp, string esp)
        {
            this.nbPattes = nbp;
            this.espece = esp;
        }

        //Accesseurs
        public int getNbPattes()
        {
            return this.nbPattes;
        }
        public string getEspece()
        {
            return this.espece;
        }
        public virtual string manger()
        {
            return "Je mange chaque jour.";
        }
        public string dormir()
        {
            return "Je dors chaque nuit.";
        }

    }
}
