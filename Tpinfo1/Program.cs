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

		const string version = "0.1";

		static void Main(string[] args)
		{

			////TODO : tester si le ou les arguments existent
			foreach (string parametre in args)
			{
			Console.WriteLine(parametre);
			}

			//TODO : En fonction de l'argument passé en mode console 
			// - appeler une fonction interne
			// OU 
			// - instancier un nouvel objet
			//Console.ReadLine();

			// choix de l'appel d'une fonction interne

			foreach (string Parametre in args)
				switch (Parametre)
				{
					case "chiffre help":
						Print.AfficherMenu();
						break;
					case "chiffre alea":
						Deviner.User_DevinerNbre();
						break;
					case "chiffre new 25":
						Deviner.CPC_DevinerNbre();
						break;
					case "chiffre version":
						Print.AfficherVersion();
						break;
				}
		}

		/// <summary>
		/// création d'une classe Print
		/// </summary>
		private class Print
		{
			public static void AfficherMenu()
			{
				/// (j'ai tenté de mettre un foreach (string Parametre in args)
				/// Console.WriteLine'args) mais échec: lecture uniquement du 1er Parametre seul!!!)
				Console.WriteLine("chiffre help");
				Console.WriteLine("chiffre alea");
				Console.WriteLine("chiffre version");
				Console.WriteLine("chiffre new 25");
			}

			public static void AfficherVersion()
			{
				Console.WriteLine($"La version du programme est: {version}");
			}
		}

		/// <summary>
		/// création d'une classe private pour appel direct depuis le Main
		/// sans avoir à instancier un objet
		/// </summary>
		private class Deviner
		{
			/// <summary>
			/// Le USER devine le nombre caché
			/// </summary>
			public static void User_DevinerNbre()
			{

				// le USER doit deviner le nbre caché...
				// 
				// génération d'un nombre entier aléatoire par le CPC compris dans l'écart min/max
				Random rnd = new Random();
				int nbreMin = 0;
				int nbreMax = 100;
				int randomNumber = rnd.Next(nbreMin, nbreMax+1);

				// logique pour trouver le randomNumber
				Console.WriteLine($"Devinez le nombre caché par le CPC  entre {nbreMin} et {nbreMax}.");
				Console.Write($"Entrez un nombre: ");
				int nbreEntré = Convert.ToInt32(Console.ReadLine());

				int count = 1;
				while (nbreEntré != randomNumber)
				{
					if (nbreEntré > randomNumber)
					{
						Console.Write("Loupé! Nbre trop grand! Réssayez encore! Entrez un nombre: ");
						nbreEntré = Convert.ToInt32(Console.ReadLine());
					}
					else
					{
						Console.Write("Loupé! Nbre trop petit! Réssayez encore! Entrez un nombre: ");
						nbreEntré = Convert.ToInt32(Console.ReadLine());
					}
					count++;
				}
				Console.WriteLine($"Félicitations! Vous avez réussi en {count} coup(s)");
			}

			// le CPC doit deviner le nombre caché selon la valeur de la ligne de commande...
			//
			public static void CPC_DevinerNbre()
			{
				int nbreàDeviner;
				int i = 0;
				string args3 = "chiffre new 25";
				string[] args3String = System.Text.RegularExpressions.Regex.Split(args3, @"\D+");
				foreach (string value in args3String)
				{
					if (!string.IsNullOrEmpty(value))
					{
						i = int.Parse(value);
					}
				}
				nbreàDeviner = i;
				Console.WriteLine(i);

				Random rnd = new Random();
				int rnd1 = rnd.Next();
				// Console.WriteLine(rnd1); // print du nbre random initialisé
				int count = 1;
				int rnd2 = rnd1;

				while (rnd1 != nbreàDeviner)
				{
					if (rnd1 > nbreàDeviner)
					{
						rnd1 = rnd.Next(rnd1);
					}
					else // if (rnd1 < NbreàDeviner)
					{
						rnd1 = rnd.Next(rnd1, rnd2);
					}
					count++;
					Console.WriteLine(rnd1); // print du nbre successif réinitialisé
				}
				Console.WriteLine($"Le nombre à deviner était {rnd1}");
				Console.WriteLine($"Il a été deviné en {count} coups!");
			}
		}
	}
}


