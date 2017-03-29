using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo1
{
    class Execptionformat : Exception
    {
        public Execptionformat() : base()
        {

        }

        public override string Message
        {
            get
            {
                return " format incorecte .entrer un numero svp ...merci";
            }
        }
    }


}
