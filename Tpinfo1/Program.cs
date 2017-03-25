/**
Program description 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tpinfo1
{
  class Program
  {
    static string version = "1.0";

    static void Main(string[] args)
    {



      // validate user input
      //Utils.Validateinput(args);
      if (args.Length == 0)
      {
        Utils.DisplayHelp(Utils.usageMessage + Utils.helpMessage);
        System.Environment.Exit(0);
      }

      switch (args[0].ToUpper())
      {
        case "HELP":
          Utils.DisplayHelp(Utils.helpMessage);
          break;
        case "VERSION":
          Utils.DisplayVersion(version);
          break;
        case "ALEATOIRE":
          Utils.UserGuess();
          break;
        case "NEW":
          Utils.PCGuess(args);
          break; 
        default:
          Console.WriteLine("Input error");
          Utils.DisplayHelp(Utils.usageMessage);
          break;
      }










    }
  }
}
