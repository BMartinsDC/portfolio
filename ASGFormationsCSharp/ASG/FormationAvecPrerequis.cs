using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASG
{
    public class FormationAvecPrerequis : Formation
    {
        private Formation lePrerequis;

        //Les méthodes à écrire

        public FormationAvecPrerequis(String pIntitule, int pNbj, Formation unPrerequis) : base(pIntitule, pNbj)
        {
            this.lePrerequis = unPrerequis;
        }

        public Formation getPrerequis()
        {
            return this.lePrerequis;
        }
    }
}
