using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo1 {
  static class Utils {
    /// <summary>
    /// Default values for guess interval 
    /// </summary>
    static int minVal = 0;  
    static int maxVal = 50;
    static public string helpMessage = "arg1:\n" +
                           "\t- help [display this help message]\n" +
                           "\t- version [get game version]\n" +
                           "\t- aleatoire [starts new game: User guesses value]\n" +
                           "\t- new [Pc guesses value]\n " + 
                           "optional args:\n" + 
                           "\t nb1 nb2 nb3\n"
      ;
    static public string usageMessage = $"Usage: {System.AppDomain.CurrentDomain.FriendlyName} <arg1> <optional args>\n";


    internal static void DisplayHelp(string msg) {
      Console.WriteLine(msg);

    }

    internal static void Validateinput(string[] args) {
      throw new NotImplementedException();
    }

    internal static void DisplayVersion(string ver) {
      Console.WriteLine("Version" + ver);
    }

    internal static void PCGuess(string[] args) {
      // we expect two arguments: new + int 
      // TODO: add edit default range values by entreing 3 numbers 
      if (args.Length != 2) {
        DisplayErrorMessage("Invalid input: Second argument must be int");
        System.Environment.Exit(0);
      }
      int uInputNb;
      try {
        uInputNb =  Convert.ToInt32(args[1]);
        if (uInputNb < minVal || uInputNb > maxVal)
          throw new ArgumentOutOfRangeException(uInputNb.ToString(), $"Input out off range: [{minVal},{maxVal}]");

        int iTries = 0;
        
        bool found = false;

        // pc guesses the uInputh using a random generator. to help converge faster 
        // we update the interval of random generator according to the comparison 
        // with uInput 
        Random rnd = new Random();
        int Guess;
        int start = minVal, stop = maxVal; // start with the largest interval
        do {
          ++iTries;
          Guess = rnd.Next(start, stop);
          if (Guess < uInputNb)
            start = Guess;
          else if (Guess > uInputNb)
            stop = Guess;
          else
            found = true;

        } while (!found);

        Console.WriteLine("I found the hidden number: {0}, in {1} tires", Guess, iTries);








      }
      catch (FormatException) {
        DisplayErrorMessage("Invalid input: guess value must be integer");
        System.Environment.Exit(0);
      }
      catch(ArgumentOutOfRangeException e) {
        Console.WriteLine(e.Message);
      }
      catch(Exception ) {
        DisplayErrorMessage("Unknown error.");
        System.Environment.Exit(0);
      }








    }



    
    internal static void DisplayErrorMessage(string msg) {
      Console.WriteLine("Error: "+ msg);
    }
    /// <summary>
    /// New game where Pc generates number , and user guesses 
    /// </summary>

    internal static void UserGuess() {

      bool session = true;

      while (session) { // TODO : is do while better ? 

        Random rnd = new Random();
        // TODO : may be ask the user for the interval
        int nbTofind = rnd.Next(minVal, maxVal);
        Console.WriteLine("Nb to find {0}", nbTofind); // for testing perposes only. toberemoved / TODO
        int uGuess, ntries = 0;
        bool onGoing = true;

        Console.WriteLine("Please enter a value beween {0} and {1}", minVal, maxVal);

        do {

          string inputStr = Console.ReadLine();
          try {
            uGuess = Convert.ToInt32(inputStr);
            ++ntries;// update tries after insuring success reads
            if (uGuess == nbTofind) {
              Console.WriteLine("You found the hidden number: {0}, in {1} tires", nbTofind, ntries);

              // TODO: Add : would you like to play again
              Console.WriteLine("Would you like to play again");
              inputStr = Console.ReadLine().ToUpper();
              if (inputStr == "Y") {
                session = true;
                break;
              }
              else {
                Console.WriteLine("Bye");
                onGoing = false;
                session = false;
              }

            }
            else {
              Console.WriteLine("try again");

              //TODO : add possibility to end game  
            }

          }
          catch (FormatException) {
            Console.WriteLine("invalid input");
          }
          catch (OverflowException) {
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
}
