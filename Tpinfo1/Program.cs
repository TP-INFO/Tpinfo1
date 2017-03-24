using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo1
{
    class Program
    {
        /// <summary>
        /// Définit la valeur de ma version actuelle.
        /// </summary>
        const string version = "0.1";

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine(args.Length);

            }

            //l'ordinateur génère un nombre aléatoire.

            //RETOUR : Belle utilisation du try catch avec ta propre exception...
            try
            {
                Console.WriteLine("Générer un nombre aléatoire par l'ordinateur");
                trouverUnNombre();
            }
            catch (NombreSaisiException nse)
            {
                Console.WriteLine(nse);
            }

        }

        //RETOUR : Penser à aérer le code (ne pas coller les fonctions 
        //RETOUR : documenter le code, notamment les fonctions 
        public static void trouverUnNombre()
        {
            Random nbre = new Random();
            int nbreAlea = nbre.Next(30);
            int nbreSaisi = -1;
            int count = 0;
            while (nbreSaisi != nbreAlea)
            {
                Console.WriteLine("Saisissez un nombre compris en 0 et 30");
                nbreSaisi = Convert.ToInt32(Console.ReadLine());
                if (nbreSaisi < 0 || nbreSaisi > 30)
                {
                    NombreSaisiException nse = new NombreSaisiException();
                    throw nse;
                }
                count++;

            }
            Console.WriteLine("Tu as gagné en {0} coups. Veux-tu essayer une fois de plus ?", count);
        }
    }
 
    }
}
