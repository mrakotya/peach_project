using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace peach_project_
{
    class PitFileMode
    {
        public static void PitFileMode_main(String logsPath, int population, String PathOfPitPopulation, String originalPitFile, String peachTestRange )
         {
          /*   Parser CommandLine = new Parser(args);

            // Look for specific arguments values and display 
            // them if they exist (return null if they don't)
            if (CommandLine["LogPath"] != null)
            {
                Console.WriteLine("LogPath value: " +
                    CommandLine["LogPath"]);
                logPath = CommandLine["LogPath"];
            }
            else
                Console.WriteLine("Param1 not defined !");

            if (CommandLine["height"] != null)
                Console.WriteLine("Height value: " +
                    CommandLine["height"]);
            else
                Console.WriteLine("Height not defined !");

            if (CommandLine["width"] != null)
                Console.WriteLine("Width value: " +
                    CommandLine["width"]);
            else
                Console.WriteLine("Width not defined !");

            if (CommandLine["size"] != null)
                Console.WriteLine("Size value: " +
                    CommandLine["size"]);
            else
                Console.WriteLine("Size not defined !");

            if (CommandLine["debug"] != null)
                Console.WriteLine("Debug value: " +
                    CommandLine["debug"]);
            else
                Console.WriteLine("Debug not defined !");*/

            GAFramework gaf = new GAFramework();
            gaf.start(population, logsPath, PathOfPitPopulation, originalPitFile, peachTestRange);


         }



    }
}
