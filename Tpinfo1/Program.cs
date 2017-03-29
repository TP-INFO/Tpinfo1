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
            // il lfaut   tester que les entree sont valides:
            // tester que args n'est pas vide, args. length = 1 ou 2

            if (args.Length >= 1)
            {

                switch (args[0])
                {
                    case "help":
                        // afficher un text de help
                        ChiffreMethods.Afficherhelp(ChiffreMethods.messageduHelp);
                        break;
                    case "version":
                        // afficher la version du programme
                        ChiffreMethods.Version(ChiffreMethods.lemessagedeversion);
                        break;
                    case "alea":
                        ChiffreMethods.jeu1();
                        // lancer le jeu ou pc genere et utilisateur devine
                        break;
                    case "new":
                        //lancer le jeu ou l'utulisateur genere est l'ordinateur devine

                        if (args.Length >= 2)
                        {
                            ChiffreMethods.creenouvellepartie(args[1]);
                        }

                        else

                        {
                            Console.WriteLine("entrez une valeur ");
                        }

                        break;
                }
            }
            else

            {
                ChiffreMethods.Afficherhelp("Utilisation:\n" + ChiffreMethods.messageduHelp);
                Console.WriteLine("ce programme fonctionne en mode console: invite de commande - cd-copier le chemin - dir - chiffre.exe -operation ");
            }


        }
    }
}
