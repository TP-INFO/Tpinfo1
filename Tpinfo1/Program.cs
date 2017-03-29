using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo1
{
    class Program
    {
       static void Main(string[] args)
        {               
            if (args.Length >= 1)
            {
                Console.WriteLine(args.Length);
                switch (args[0])
                {
                    case "help":
                        AfficherAide();
                        break;
                    case "alea":
                        Console.WriteLine("Générer un nombre aléatoire par l'ordinateur");
                        TrouverUnNombre(args[0]);
                        break;
                    case "new":
                        if (args.Length >= 2)
                        {                           
                            Console.WriteLine("Ton ami l'ordinateur va trouver le nombre que tu auras choisi");
                            FaireTrouverUnNombre(args[1]);                            
                        }
                        else
                        {
                            Console.WriteLine("Recommencer en rentrant une valeur de la forme 'new valeur' ");
                        }
                        break;
                    case "version":
                        AfficherVersion();
                        break;
                    default:
                        break;
                }
            }

        }

        /// <summary>
        /// Méthode d'affichage de la version
        /// </summary>
        private static void AfficherVersion()
        {
            const double version = 0.1;
            Console.WriteLine("Version : {0}", version);
        }
        /// <summary>
        /// Méthode d'affichage de l'aide
        /// </summary>
        public static void AfficherAide()
        {
            Console.WriteLine("Comment faire fonctionner l'application ?");
            Console.WriteLine("Tapez 'Alea' pour lancer le programme");
            Console.WriteLine("Tapez 'New ' pour lancer le programme");
            Console.WriteLine("Tapez 'Version' pour afficher la Version du programme");

        }

        /// Méthode TrouverUnNombre : l'utilisateur doit trouver le nombre aléatoire généré dans un intervalle déterminé
        /// Exception en cas de saisi d'un nombre négatif.
        /// </summary>
        /// <param name="nbreF"></param>
        public static void TrouverUnNombre(string nbreF)
        {
            //RETOUR : Belle utilisation du try catch avec ta propre exception...
            try
            {
                Console.WriteLine("choisissez l'intervalle maximum : ");
                int nbreMax = Convert.ToInt32(Console.ReadLine());
                Random nbre = new Random();
                int nbreAlea = nbre.Next(nbreMax);
                int nbreSaisi = -1;
                int count = 0;
                while (nbreSaisi != nbreAlea)
                {
                    Console.WriteLine("Saisissez un nombre compris en 0 et {0}", nbreMax);
                    nbreSaisi = Convert.ToInt32(Console.ReadLine());
                    if (nbreSaisi < 0 || nbreSaisi > nbreMax)
                    {
                        NombreSaisiException nse = new NombreSaisiException();
                        throw nse;
                    }
                    if (nbreSaisi < nbreAlea)
                    {
                        Console.WriteLine("Plus grand");
                    }
                    if (nbreSaisi > nbreAlea)
                    {
                        Console.WriteLine("Plus petit");
                    }
                    count++;

                }
                Console.WriteLine("Tu as gagné en {0} coups. Veux-tu essayer une fois de plus ?", count);
            }
            catch
            {
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Méthode    FaireTrouverUnNombre : l'utilisateur rentre un nombre que l'ordinateur doit déterminer
        /// Prise en compte de l'erreur si le nombre rentré est décimal.
        /// </summary>
        /// <param name="nbreF"></param>
        public static void FaireTrouverUnNombre(string nbreF)
        {
            Console.WriteLine("faire trouver un nombre");
        }

        //RETOUR : Penser à aérer le code (ne pas coller les fonctions 
        //RETOUR : documenter le code, notamment les fonctions 
        public static void trouverUnNombre()
        {
            try
            {
                int nbreMin = 0;
                int nbreMax = int.MaxValue;                         
                int nbreAlea = -1;
                int count = 0;
                int nbreFixe = Convert.ToInt32(nbreF);
                while (nbreAlea != nbreFixe)
                {
                    Random nbre = new Random();
                    nbreAlea = nbre.Next(nbreMin, nbreMax);
                    Console.WriteLine(nbreAlea);
                    if (nbreAlea > nbreFixe)
                    {
                        nbreMax = nbreAlea;
                    }
                    if (nbreAlea < nbreFixe)
                    {
                        nbreMin = nbreAlea;
                        nbreMin = nbreMin + 1;
                    }
                    count++;
                }
                Console.WriteLine("Ami ordinateur, tu as gagné en {0} coups.", count);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
           
            Console.WriteLine("Tu as gagné en {0} coups. Veux-tu essayer une fois de plus ?", count);
        }
    }
   
 
}
