using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_22_TP1
{
    class Program
    {
        /// <summary>
        /// N° de version actuelle
        /// </summary>
        const double version = 3.1;
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bienvenue dans votre jeu : voici le menu: ");
            AfficherMenu();
            string arg = Console.ReadLine();
            while (arg!="exit")
            {
                switch (arg)
                {
                    case "help":
                        Console.WriteLine("Les arguments possibles sont : (entrez exit pour sortir)");
                        AfficherMenu();
                        break;
                    case "alea":
                        Random random = new Random();
                        int nombreATrouver = random.Next(100);
                        int compte = 0;
                        Console.WriteLine("Veuillez rentrer un nombre entre 1 et 100!");
                        int nombre = Convert.ToInt32(Console.ReadLine());
                        do
                        {
                            compte++;
                            if (nombre > nombreATrouver)
                            {
                                Console.WriteLine("C'est moins!");
                                Console.WriteLine("Veuillez rentrer un nombre entre 1 et 100!");
                                nombre = Convert.ToInt32(Console.ReadLine());
                            }
                            else if (nombre < nombreATrouver)
                            {
                                Console.WriteLine("C'est plus!");
                                Console.WriteLine("Veuillez rentrer un nombre entre 1 et 100!");
                                nombre = Convert.ToInt32(Console.ReadLine());
                            }

                        } while (nombre != nombreATrouver);
                        Console.WriteLine("Bravo vous avez trouvé en {0} coups le nombre {1}!", compte + 1, nombreATrouver);
                        break;
                    case "new":
                        Console.WriteLine("Rentrez votre nombre :");
                        int nombrePourOrdi = Convert.ToInt32(Console.ReadLine());
                        int alea = Alea(0, 100, nombrePourOrdi, 1);
                        Console.WriteLine(alea);
                        break;
                    case "version":
                        Console.WriteLine("version : {0}", version);
                        break;
                    default:
                        Console.WriteLine("Veuillez rentrer une des 4 options indiquées");
                        break;
                }
                Console.WriteLine("Veuillez indiquer votre choix : ");
                
                arg = Console.ReadLine();
            }

        }
        /// <summary>
        /// Affiche le N° de version
        /// </summary>
        static void AfficherVersion()
        {
            Console.WriteLine($"version : {version}");
        }
        /// <summary>
        /// Recherche par l'ordinateur d'un chiffre, de manière aléatoire.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="aTrouver"></param>
        /// <param name="coups"></param>
        /// <returns></returns>
        static int Alea(int min, int max, int aTrouver, int coups)
        {

            Random random = new Random();
            int nRentre = random.Next(min, max);
            Console.WriteLine(nRentre);
            if (nRentre < aTrouver)
            {
                coups++;
                return Alea(nRentre+1, max, aTrouver, coups);

            }
            else if (nRentre > aTrouver)
            {
                coups++;
                return Alea(min, nRentre-1, aTrouver, coups);

            }
            else
                return coups;
        }
        /// <summary>
        /// Permet d'afficher les options du menu
        /// </summary>
        public static void AfficherMenu()
        {
            Console.WriteLine("help");
            Console.WriteLine("alea");
            Console.WriteLine("new");
            Console.WriteLine("version");
        }
    }
}
