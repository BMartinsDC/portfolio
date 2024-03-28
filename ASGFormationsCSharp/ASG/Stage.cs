using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG
{
    public class Stage
    {
        private Formation laFormationConcerne;
        private DateTime dateDebut;
        private DateTime dateFin;

        //Les méthodes à écrire
        public Stage(Formation uneFormation, DateTime uneDateDebut, DateTime uneDateFin)
        {
            this.laFormationConcerne = uneFormation;
            this.dateDebut = uneDateDebut;
            this.dateFin = uneDateFin;
        }

        public Formation getFormation()
        {
            return this.laFormationConcerne;
        }

        public DateTime getDateDebut()
        {
            return this.dateDebut;
        }

        public DateTime getDateFin()
        {
            return this.dateFin;
        }
    }
}
