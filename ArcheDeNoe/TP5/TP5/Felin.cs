using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class Felin : Animal
    {
        public Felin(int nbp,string esp) : base(4, esp)
        {
            this.espece = esp;
        }
    }
}
