using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AliensOnEarth
{
    /*
    Author: Avinash
    Company:Multunus Software
    This Class is used to display the Alien Record on the Screen
    */
    class AlienRecordsDisplay
    {
        public static void AlienDataDisplay(Hashtable alienInfo)
        {
            
            Console.WriteLine();
            foreach (DictionaryEntry records in alienInfo)
            {
                Console.WriteLine(records.Key + " " + records.Value);
            }
        }
        
    }
}
