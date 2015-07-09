using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AliensOnEarth.ExportFiles;

namespace AliensOnEarth
{
    /*
    Author: Avinash
    Company:Multunus Software
    This is the Main Home Class where it calls the other Classes and Methods.
    */
    class AliensMain
    {
           static void Main(string[] args)
        {
            Console.WriteLine("Alien Records Registry Tool \n");
            AlienInformation alienDetails = new AlienInformation();
            ReadAlienDetails.ReadAlienInput(alienDetails);
            FormatAlienRecord.FormatAlienData(alienDetails);
            AlienRecordsDisplay.AlienDataDisplay(FormatAlienRecord.FormatAlienData(alienDetails));
            Console.ReadLine();
         // ExportToPDF.GenerateFile(FormatAlienRecord.FormatAlienData(alienDetails));
          //  ExportToTXT.GenerateFile(FormatAlienRecord.FormatAlienData(alienDetails));
            ExportFile.CheckFormat(alienDetails);
            Console.ReadLine();
        
        }
    }
}
 