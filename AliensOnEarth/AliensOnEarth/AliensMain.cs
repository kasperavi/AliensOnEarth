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
               //Taking input from the User
            ReadAlienDetails.ReadAlienInput(alienDetails);
               //Formatting the input using hashtable key value pairs
            FormatAlienRecord.FormatAlienData(alienDetails);
               //Displaying the Details to the User on Screen
            AlienRecordsDisplay.AlienDataDisplay(FormatAlienRecord.FormatAlienData(alienDetails));
            Console.ReadLine();
               //Exporting the Alien records to the user specified format (uses Reflection)
            ExportFile.CheckFormat(alienDetails);
            Console.ReadLine();
        
        }
    }
}
 