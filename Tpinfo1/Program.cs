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
        /// Définit la version du Programme
        /// </summary>
        const string version = "1.0b";

        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                switch (args[0])
                {
                    case "version":
                        afficherVersion();
                        break;
                    case "help":
                        afficherHelp();
                        break;
                    case "new":
                        //ToDo == Verif nombre d'arguments.
                        donnerChiffre(args[1]);                        
                        break;
                    case "alea":
                        trouverChiffre();
                        break;
                    default:
                        break;
                }
            }



        }//End of Main


        /// <summary>
        /// L'ordinateur lance une nouvelle partie où l'utilisateur doit trouver le chiffre
        /// </summary>
        private static void trouverChiffre()
        {
            int compt = 0;
            Console.WriteLine("Trouver un chiffre entre 0 et 50 :\n");

            Random rnd = new Random();
            int nbAlea = rnd.Next(0, 50);

            int UserInput = Convert.ToInt32(Console.ReadLine());

            while (UserInput != nbAlea)
            {
                if (UserInput > nbAlea)
                {
                    Console.WriteLine("C'est plus petit !\n");
                    ++compt;
                }
                else if (UserInput < nbAlea)
                {
                    Console.WriteLine("C'est plus grand !\n");
                    ++compt;
                }
                 
                Console.WriteLine("Essayer encore ..\n" +
                                  "Trouver le nombre entre 0 et 50 :\n");
                UserInput = Convert.ToInt32(Console.ReadLine());

                ++compt;
            }
            Console.WriteLine("Bien joué ! Vous avez trouvé le nombre en {0}\n", compt);

            if (compt > 10)
            {
                Console.WriteLine("Il va falloir muscler votre jeu la prochaine fois !");
            }
            else
            {
                Console.WriteLine("Vous êtes un pro des nombres !");
            }

        }//End of TrouverChiffre


        /// <summary>
        /// Lance une nouvelle partie où l'ordinateur doit trouver le chiffre de l'utilisateur
        /// </summary>
        /// <param name="v"></param>
        private static void donnerChiffre(string UserInput)
        {
            Console.WriteLine("");
            Console.WriteLine("Nouvelle partie contre la machine avec le chiffre : {0} ", UserInput);

            int minVal = int.MinValue;
            int maxVal = int.MaxValue;

            bool trouver = false;

            int compt = 0;

            Random rnd = new Random();
            int nbAlea;

            int nbUser = Convert.ToInt32(UserInput);

            do
            {
                ++compt;
                nbAlea = rnd.Next(minVal, maxVal);

                if (nbAlea < nbUser)
                {
                    minVal = nbAlea;
                }
                else if (nbAlea > nbUser)
                {
                    maxVal = nbAlea;
                }
                else
                {
                    trouver = true;
                }

                Console.WriteLine(nbAlea);

            } while (!trouver);

            Console.WriteLine("Computer Wins il a trouvé {0} ! Il a mit {1} coups pour parvenir au résultats !", nbAlea, compt);




        }//End of method

        /// <summary>
        /// Afficher le menu d'aide 
        /// </summary>
        private static void afficherHelp()
        {
            Console.WriteLine("\t \n" +
                              "Commands Help :\n" +
                              "\t \n" +
                              "\thelp - Show help\n" +
                              "\tversion - Show app current version\n" +
                              "\tnew - Start new game with a number you have to find\n" +
                              "\talea - Start new game with a number the computer have to find\n");
        }//End of Methods


        /// <summary>
        /// Afficher le numéro de version
        /// </summary>
        private static void afficherVersion()
        {
            Console.WriteLine("Version : {0}", version);
        }

    }
}