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
            return "On t'a dit de rentrer un nombre entre 0 et 30 !";
        }
    }
}
