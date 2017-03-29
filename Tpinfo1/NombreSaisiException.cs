using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo1
{
    class NombreSaisiException : Exception
    {
        public NombreSaisiException()
        {
        }

        public override string ToString()
        {
            return "Tu ne vois pas que le nombre saisi est hors intervalle ? Recommence Tudieu avec un nombre entier positif !";
        }

    }
}
