using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_02_22_TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double version = 1.0;
            string arg = null;
            while(arg!="chiffre version")
            {
                Console.WriteLine("Bienvenue dans votre jeu : voici le menu: \n 1. 'chiffre help' \n 2. 'chiffre alea' \n 3. 'chiffre new' (votre chiffre) \n 4. 'chiffre version'");
                arg = Console.ReadLine();
                switch (arg)
                {
                    case "chiffre help":
                        Console.WriteLine("Les arguments possibles sont : \n 1. 'chiffre help' \n 2. 'chiffre alea' \n 3. 'chiffre new' (votre chiffre) \n 4. 'chiffre version'");
                        break;
                    case "chiffre alea":
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
                    case "chiffre new":
                        Console.WriteLine("Rentrez votre nombre :");
                        int nombrePourOrdi = Convert.ToInt32(Console.ReadLine());
                        int alea = Alea(0, 100, nombrePourOrdi, 1);
                        Console.WriteLine(alea);
                        break;
                    case "chiffre version":
                        Console.WriteLine("version : {0}", version+1.0);
                        break;
                    default:
                        Console.WriteLine("Veuillez rentrer une des 4 options indiquées");
                        break;
                }
            }

        }

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
    }
}
