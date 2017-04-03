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
        /// Définit la valeur de ma version actuelle
        /// </summary>
        static short version = 1;

        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {


                switch (args[0])
                {
                    case "help":
                        AfficherHelp();
                        break;

                    case "alea":
                        LancerAlea();
                        break;

                    case "new":
                        LancerNew();
                        break;

                    case "version":
                        AfficherVersion();
                        break;

                    default:
                        Console.WriteLine("l'option demandée n'existe pas");
                        break;
                }
            }
        }

        /// <summary>
        /// Méthode Help - Afficher le Menu 
        /// </summary>
        public static void AfficherHelp()
        {
            Console.WriteLine("++++++++MENU AIDE+++++++++++ \n * Alea - tapez [1] \n * New - tapez [2]\n+++++++++++++++++++++++");
            Console.WriteLine();
            string menu = Console.ReadLine();
            int choixMenu = Convert.ToInt32(menu);



        }

        /// <summary>
        /// Méthode Alea - trouver le chiffre généré aléatoirement
        /// </summary>
        /// 
        public static void LancerAlea()
        {
            /* générer chiffre aléatoire*/
            Random rnd = new Random();
            int chiffreAleatoire = rnd.Next(1, 10);
            Console.WriteLine(chiffreAleatoire);
            int count = 1;
            int chiffre;

            /*Trouver le chiffre aléatoire*/
            do
            {
                Console.WriteLine("Entrer un chiffre entre 1 et 10 :");
                string chiffre2 = Console.ReadLine();
                chiffre = Convert.ToInt32(chiffre2);

                if (chiffre != chiffreAleatoire)
                {
                    Console.WriteLine("Essaie encore" + count++);
                }
                else
                {
                    Console.WriteLine("tu es un winner");
                }

            }
            while (chiffre != chiffreAleatoire);


        }

        /// <summary>
        /// Méthode New - l'ordi cherche le chiffre fixé par l'User
        /// </summary>
        public static void LancerNew()
        {


            Console.WriteLine("Entrer un chiffre :");
            string chiffreFixe = Console.ReadLine();
            int Fixe = Convert.ToInt32(chiffreFixe);

            Console.Clear(); //Efface l'affichage console

            int chiffrePC;
            Random rnd = new Random();

            do
            {

                chiffrePC = rnd.Next(1, 30);
                Console.WriteLine(chiffrePC);

                if (chiffrePC != Fixe)
                {
                    Console.WriteLine("Essaie encore");
                }
                else
                {
                    Console.WriteLine("tu es un winner");
                }

            }
            while (chiffrePC != Fixe);

        }

        /// <summary>
        /// Methode Version - Afficher la version du programme
        /// </summary>
        public static void AfficherVersion()
        {
            Console.WriteLine("Version {0}", version);
        }


    }
}
