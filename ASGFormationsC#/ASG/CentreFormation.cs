using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG
{
    public class CentreFormation
    {
        private List<Formation> lesFormations;
        private List<Stage> lesStages;
        private int nbrSalles;

        //Les méthodes
        public CentreFormation(int pNbreSalles)
        {
            this.lesFormations = new List<Formation>();
            this.lesStages = new List<Stage>();
            this.nbrSalles = pNbreSalles;
        }

        public void jeuEssaiFormations()
        {
            Formation uneFormation = new Formation("C#", 3);
            this.lesFormations.Add(uneFormation);
            FormationAvecPrerequis uneFormationApprofondie = new FormationAvecPrerequis("C# approfondi", 2, uneFormation);

            this.lesFormations.Add(uneFormationApprofondie);

            uneFormation = new Formation("Java", 4);
            this.lesFormations.Add(uneFormation);
            uneFormationApprofondie = new FormationAvecPrerequis("Java Android", 2, uneFormation);
            this.lesFormations.Add(uneFormationApprofondie);
        }

        public List<Formation> getLesFormations()
        {
            return this.lesFormations;
        }

        public Formation uneFormation(int i)
        {
            return this.lesFormations.ElementAt(i);
        }
        public List<Stage> getLesStages()
        {
            return this.lesStages;
        }

        // Méthode privée renvoyant vrai si, à la date passée en paramètre,
        //il reste au moins une salle disponible, faux sinon
        private bool SalleDisponible(DateTime uneDate)
        {
            int countSalle = 0;
            foreach(Stage unStage in this.lesStages)
            {
                if (uneDate <= unStage.getDateFin() && uneDate >= unStage.getDateDebut())
                {
                    countSalle++;
                }
            }
            if (this.nbrSalles - countSalle > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Méthode publique renvoyant vrai si, à la période passée en paramètre,
        //il reste au moins une salle disponible, faux sinon
        public bool SalleDispoPeriode(DateTime unDebut, DateTime uneFin)
        {
            List<DateTime> lesDates = new List<DateTime>();
            while (unDebut <= uneFin)
            {
                lesDates.Add(unDebut);
                unDebut.AddDays(1);
            }
            bool uneSalleDisponible = true;
            foreach (DateTime uneDate in lesDates)
            {
                if (SalleDisponible(uneDate) == false)
                {
                    uneSalleDisponible = false;
                }
            }
            return uneSalleDisponible;
        }

        // Méthode renvoyant vrai si le stage a été ajouté, faux sinon
        //(cas d'un stage necessitant un prerequis pour lequel il n'a pas été prévu de stage
        // où dont la date de fin n'est pas antérieure à la date de début du nouveau stage)
        public bool ajouterStage(Stage unStage)
        {
            bool exist = false;
            foreach (Formation uneFormation in lesFormations)
            {
                if (unStage.getFormation().egal(uneFormation))
                {
                    exist = true;
                }
            }
            if (exist == true && unStage.getDateDebut() < unStage.getDateFin())
            {
                lesStages.Add(unStage);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
