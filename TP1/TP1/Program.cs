using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        const string version = "Version 1.00";
        static void Main(string[] args)
        {



            Console.WriteLine("Jouons un peu ! Deviner un chiffre donné par l'ordinateur, ou faire deviner à l'ordinateur un chiffre !");
            Console.WriteLine(
                "****************************************************************" +
                "\nchiffre help : afficher l'aide\nchiffre alea : lance une partie où il faut deviner le nombre\nchiffre new : lance une partie où l'ordinateur devine un nombre\nchiffre version : affiche la version du jeu" +
                "\n****************************************************************");



            string help = "****************************************************************" +
                          "\nalea : deviner un entier positif entre 0 et 100\nnew nombre : entrer un entier positif entre 0 et 100\nversion : affiche la version du jeu :)" +
                          "\n****************************************************************";
            

            Random Rd = new Random();
            int nb = Rd.Next(101);
            bool t = false;
            int count = 1;
            if (args.Length > 0)
            {


                switch (args[0])
                {
                    case "help":
                        Console.WriteLine(args.ToString());
                        break;

                    case "alea":
                        while (t == false)
                        {
                            Console.WriteLine("Entrer un nombre entre 0 et 100");
                            int nombre = Convert.ToInt32(Console.ReadLine());

                            if (nombre == nb)
                            {
                                t = true;
                                Console.WriteLine("Bien joué, vous avez trouvé en {0} tentative(s) !", count);
                                break;
                            }
                            Console.WriteLine("Essaie encore");
                            count++;

                        }
                        break;

                    case "new":
                        int nbo = Convert.ToInt32(args[1]);
                        do
                        {
                            Random rdo = new Random();
                            int roudourou = rdo.Next(101);
                            if (roudourou == nbo)
                            {
                                Console.WriteLine("L'ordinateur propose {0}", roudourou);
                                Console.WriteLine("L'ordinateur a trouvé ! en {0} tentative(s)", count);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("L'ordinateur propose {0}\nWrong !", roudourou);

                                count++;
                            }

                        } while (t == false);
                        break;

                    case "version":
                        Console.WriteLine(version);
                        break;
                    default:
                        Console.WriteLine("Taper help pour de l'aide");
                        break;

                }
            }








        }

    }
}

