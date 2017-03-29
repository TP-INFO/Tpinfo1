using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo1
{
    static class ChiffreMethods
    {

        static public string messageduHelp = "chiffre <arg1> <arg2>";
        static public string lemessagedeversion = "la nouvelle version est 1.1";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        internal static void Afficherhelp(string message)
        {
            Console.WriteLine(message);
        }

        internal static void Version(string messagedeversion)
        {
            Console.WriteLine(messagedeversion);
        }


        internal static void jeu1()
        {
            // b est une varibale intermediare qqui sert a afficher le noomnbre aleatroire proposer par l'ordi 

            int COUNT = 0;
            int b;

            // rnd est le numero aletoire choisit par l'odinateur 

            Random RND = new Random();
            int RND1 = RND.Next(10);

            // a est l entier tapez par l'utulisateur 

            int a;
            do

            {
                kk: try

                {
                    Console.WriteLine("donner un numero entre 0 et 10 ");
                    a = Convert.ToInt16(Console.ReadLine());
                    if (a > 10)
                    {

                        throw new Exceptionintervalle();
                    }

                }

                catch (Exception k)

                {
                    Console.WriteLine(k.Message);
                    goto kk;
                }


                COUNT++;

            }

            while (a != RND1);

            Console.WriteLine("bravo vous avez reussit a trouver le bon numero  ");
            Console.WriteLine("vous avez fait  {0} ESSAI  pour trouver le bonne numero ", COUNT);
        }

        internal static void creenouvellepartie(string v)
        {

            // pense a le mettre dans un block try cat
            try
            {
                int numeroutulisateur = Convert.ToInt32(v);
                Console.WriteLine("je donne un numero entre 0  et 10 ");
                numeroutulisateur = Convert.ToInt16(Console.ReadLine());

                if (numeroutulisateur > 100)
                {
                    throw new Exceptionintervalle();
                }


                // debut de la recherche du numero tapez par l'utulisateur ::

                Console.WriteLine("recherche en cours");
                int compteur = 0;
                int b;

                do
                {
                    Random alea = new Random();
                    b = alea.Next(0, 101);
                    Console.WriteLine(b);
                    compteur++;
                }

                while (b != numeroutulisateur);

                {
                    Console.WriteLine("j'ai trouver !!");
                    Console.WriteLine("le pc a trouver au bout de {0} tentative ", compteur);
                }

            }
            catch (Execptionformat j)
            {

                Console.WriteLine(j.Message);
            }
            catch (Exceptionintervalle e)

            {
                Console.WriteLine(e.Message);

            }

        }
    }
}

