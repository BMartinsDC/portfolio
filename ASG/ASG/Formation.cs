using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG
{
    public class Formation
    {
        private String intitule;
        private int nbjMinimum; //Nombre de jours minimum de formation (entre 1 et 5)

        //Les méthodes à écrire
        public Formation(String pIntitule, int pnbj)
        {
            intitule = pIntitule;
            nbjMinimum = pnbj;
        }

        public String getIntitule()
        {
            return this.intitule;
        }

        public int getNbj()
        {
            return this.nbjMinimum;
        }
        //Compare les attributs de 2 objets Formation
        public bool egal(Formation uneFormation)
        {
            if (this.intitule == uneFormation.getIntitule() && this.nbjMinimum == uneFormation.getNbj())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
