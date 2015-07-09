using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AliensOnEarth
{
    /*
     Author: Avinash
     Company:Multunus Software
     This Class is to get and set Alien Information
     */
    class AlienInformation
    {
        String codeName;
        String bloodColor;
        int noOfAntennas;
        int noOfLegs;
        String homePlanet;
        String dataFormat;

        public String getCodeName()
        {
            return codeName;
        }
        public void setCodeName(String codeName)
        {
            this.codeName = codeName;
        }
        public int getNoOfAntennas()
        {
            return noOfAntennas;
        }
        public void setNoOfAntennas(int noOfAntennas)
        {
            this.noOfAntennas = noOfAntennas;
        }
        public int getNoOfLegs()
        {
            return noOfLegs;
        }
        public void setNoOfLegs(int noOfLegs)
        {
            this.noOfLegs = noOfLegs;
        }
        public String getHomePlanet()
        {
            return homePlanet;
        }
        public void setHomePlanet(String homePlanet)
        {
            this.homePlanet = homePlanet;
        }
        public String getBloodColor()
        {
            return bloodColor;
        }
        public void setBloodColor(String bloodColor)
        {
            this.bloodColor = bloodColor;
        }
        public String getDataFormat()
        {
            return dataFormat;
        }
        public void setDataFormat(String dataFormat)
        {
            this.dataFormat = dataFormat.ToUpper();
        }
    }
}
