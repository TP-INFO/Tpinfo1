using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo1
{
    class Program
    {
        const double version = 0.1;

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
                        //TODO :  vérifier le type de l'argument 2 (doit être un entier) 
                        if (args.Length >= 2)
                        {
                            creerNouvellePartie(args[1]);
                        }
                        else
                        {
                            Console.WriteLine("Rentrez une valeur ");
                        }
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
            Console.WriteLine("Trouver le chiffre proposé par l'ordinateur");
        }


        /// <summary>
        /// Lance une nouvelle partie où l'ordinateur doit trouver le chiffre de l'utilisateur
        /// </summary>
        /// <param name="v"></param>
        private static void creerNouvellePartie(string chiffreATrouver)
        {
            Console.WriteLine("nouvelle partie avec la valeur : {0}", chiffreATrouver);
        }

        /// <summary>
        /// Afficher le menu d'aide 
        /// </summary>
        private static void afficherHelp()
        {
            Console.WriteLine("aidez moi");
        }


        /// <summary>
        /// Afficher le numéro de version
        /// </summary>
        private static void afficherVersion()
        {
            Console.WriteLine("Version : {0}", version);
        }