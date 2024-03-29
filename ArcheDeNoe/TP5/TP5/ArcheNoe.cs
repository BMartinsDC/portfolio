using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class ArcheNoe
    {
        //Attributs
        private List<Animal> lesAnimaux;

        //Contructeur
        public ArcheNoe()
        {
            this.lesAnimaux = new List<Animal>();
        }

        //Accesseurs
        public List<Animal> getLesAnimaux()
        {
            return this.lesAnimaux;
        }

        //Methodes
        public void ajouterAnimal(Animal animal)
        {
            this.lesAnimaux.Add(animal);
        }
        public void supprimerAnimal(Animal animal)
        {
            this.lesAnimaux.Remove(animal);
        }
        public int nbrAnimaux()
        {
            return this.lesAnimaux.Count();
        }
        public int nbrOiseaux()
        {
            int nBoi = 0;
            foreach (Animal unAnimal in this.lesAnimaux)
            {
                if (unAnimal is Oiseau)
                {
                    nBoi++;
                }
            }
            return nBoi;
        }
        public int nbrChats()
        {
            int nbChat = 0;
            foreach (Animal unChat in this.lesAnimaux)
            {
                if (unChat is Chat)
                {
                    nbChat++;
                }
            }
            return nbChat;
        }
    }
}
