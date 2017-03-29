using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo1
{
    class Exceptionintervalle : Exception
    {
        public Exceptionintervalle() : base()
        {

        }
        public override string Message
        {
            get
            {
                return "donner un chiffre dans l'intervalle de votre jeu [0..10] ";
            }
        }
    }
}