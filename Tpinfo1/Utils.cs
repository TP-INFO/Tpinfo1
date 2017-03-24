using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo1 {
  static class Utils {


    static public string helpMessage = "arg1:\n" +
                           "\t- help\n" +
                           "\t- version\n" +
                           "\t- aleatoire\n" +
                           "\t- new <number>";
    static public string usageMessage = $"Usage: {System.AppDomain.CurrentDomain.FriendlyName} <arg1> <arg2 optional>\n";


    internal static void DisplayHelp(string msg) {
      Console.WriteLine(msg);
                                
    }

    internal static void Validateinput(string[] args) {
      throw new NotImplementedException();
    }

    internal static void DisplayVersion() {
      Console.WriteLine("Version 1.0");
    }

    internal static void ParseOneArg(string[] args) {

      

    }


    /// <summary>
    /// New game where Pc generates number , and user guesses 
    /// </summary>

    internal static void UserGuess() {
      Random rnd = new Random();
      int min = 0, max = 50; // TODO : may be ask the user for the interval 
      int nbTofind = rnd.Next(0, 50);
      Console.WriteLine("Nb to find {0}", nbTofind);
      int uGuess, ntries = 0;
      bool onGoing = true;

      Console.WriteLine("Please enter a value beween {0} and {1}", min, max);

      do {

        string inputStr = Console.ReadLine();
        try {
          uGuess = Convert.ToInt32(inputStr);
          ++ntries;
          if (uGuess == nbTofind) {
            Console.WriteLine("You found the hidden number: {0}, in {1} tires", nbTofind, ntries);

            // TODO: Add : would you like to play again
            Console.WriteLine("Would you like to play again");
            inputStr = Console.ReadLine().ToUpper();
            if (inputStr == "Y") {

            }
            else {
              Console.WriteLine("Bye");
              onGoing = false;
            }
             
          }
          else {
            Console.WriteLine("try again");
            
            //TODO : add possibility to end game  
          }

        }
        catch (FormatException ) {
          Console.WriteLine("invalid input");          
        }
        catch(OverflowException) {
          Console.WriteLine("To biiiiiiig number");
        }
        catch (Exception) {
          Console.WriteLine("Unknown error has occured. quitting...");
          System.Environment.Exit(0);
        }






      } while (onGoing);





    }












  }
}
