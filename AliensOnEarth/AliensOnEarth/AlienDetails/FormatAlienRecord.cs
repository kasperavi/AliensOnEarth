using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AliensOnEarth
{ /*
     Author: Avinash
     Company:Multunus Software
     This Class is used to Format the Users Input on Alien's Record so that it can be exported easily
     */
    class FormatAlienRecord
    {
        public static Hashtable FormatAlienData(AlienInformation alienDetails)
        {
            Hashtable alienInfo = new Hashtable();
            alienInfo.Add("Code Name :",alienDetails.getCodeName());
            alienInfo.Add("Home Planet :", alienDetails.getHomePlanet());
            alienInfo.Add("No of Antennas :", alienDetails.getNoOfAntennas());
            alienInfo.Add("Blood Color :", alienDetails.getBloodColor());
            alienInfo.Add("No of Legs :", alienDetails.getNoOfLegs());
           

            return alienInfo;
            
        }
        
        
    }
}
