using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication173
{
    class Salarie
    {/// <summary>
     ///  declarer les attribut 
     /// </summary>
        public int matricule;
        public int categorie;
        public int service;
        public string nom;
        public double salaire;

        public Salarie(string lenom, double lesalire)
        {
            nom = lenom;
            salaire = lesalire;
        }
        public String  Calculesalire()
        {
            return $"le salaire de {nom } et de {salaire}"; 
        }

    }
}
