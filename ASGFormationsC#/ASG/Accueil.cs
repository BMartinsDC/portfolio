using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASG
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            //On va déclarer et instancier un objet de la classe CentreFormation
            CentreFormation monCentre = new CentreFormation(500);
            //On va déclarer et instancier une liste de formations qui va contenir kes firlations issues de la classe CentreFormation
            List<Formation> maListeFormation = new List<Formation>();
            //On va remplir la liste avec les formations avec les jeux d'essaie
            monCentre.jeuEssaiFormations();
            //On récupère la liste remplie des formations
            maListeFormation = monCentre.getLesFormations();
            //On va parcourir avec un foreach toutes les formations
            foreach (Formation cetteFormation in maListeFormation)
            {
                //On ajoute la formation au datagridview
                //Si la formation nécéssite un prérequis :
                if (cetteFormation is FormationAvecPrerequis)
                {
                    //On va créer yb ebfabt de type enfant et forcer la formation à devenir un enfant
                    FormationAvecPrerequis cetteFormationEnfant = (FormationAvecPrerequis)cetteFormation;
                    dgvMesFormations.Rows.Add(cetteFormation.getIntitule(), cetteFormation.getNbj(), cetteFormationEnfant.getPrerequis().getIntitule());
                }
                else
                {
                    dgvMesFormations.Rows.Add(cetteFormation.getIntitule(), cetteFormation.getNbj());
                }

            }


        }

        private void dgvMesFormations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
