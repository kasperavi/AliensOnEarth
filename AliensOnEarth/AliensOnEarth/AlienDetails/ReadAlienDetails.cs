using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensOnEarth
{
    class ReadAlienDetails
    {
        public static void ReadAlienInput(AlienInformation alienDetails)
        {
          

            try
            {
                Console.WriteLine("Enter the Details of the Alien \n");
                Console.WriteLine("Enter Alien's Code Name");
                alienDetails.setCodeName(Console.ReadLine());
                
                Console.WriteLine("Enter Alien's Home Planet");
                alienDetails.setHomePlanet(Console.ReadLine());

                Console.WriteLine("Enter Alien's No of Antennas");
                alienDetails.setNoOfAntennas(int.Parse(Console.ReadLine()));

                Console.WriteLine("Enter Alien's Blood Color");
                alienDetails.setBloodColor(Console.ReadLine());

                Console.WriteLine("Enter Alien's No of Legs");
                alienDetails.setNoOfLegs(int.Parse(Console.ReadLine()));

                Console.WriteLine("Enter the Format to export the Alien's Data   (TXT,PDF)");
                alienDetails.setDataFormat(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
