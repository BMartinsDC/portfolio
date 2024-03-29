using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class Oiseau : Animal
    {
        protected string couleurPlumes;
        public Oiseau(string couleur, int nbp, string esp) : base(2,"Oiseau")
        {
            this.couleurPlumes = couleur;
        }

        public string getcouleurPlumes()
        {
            return this.couleurPlumes;
        }
        public override string manger()
        {
            return "Je mange mes graines.";
        }
        public new string dormir()
        {
            return "Je dors sur une patte.";
        }

    }
}
