using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class Chat : Felin
    {
        private string nom;
        public Chat(int nbp, string esp, string pnom) : base(4,"Chat")
        {
            this.nom = pnom;
        }

        public string getNom()
        {
            return this.nom;
        }
        public override string manger()
        {
            return "Je mange ma pâté.";
        }
        public new string dormir()
        {
            return "Je dors les pattes en rond.";
        }
    }
}
