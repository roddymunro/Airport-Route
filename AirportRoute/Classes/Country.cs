using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportRoute
{
    public class Country
    {
        public String countryCode, name, continent;

        public Country()
        {

        }

        public void setContinent(String continentCode)
        {
            if (continentCode.Equals("AF"))
            {
                continent = "Africa";
            }
            else if (continentCode.Equals("AN"))
            {
                continent = "Antartica";
            }
            else if (continentCode.Equals("AS"))
            {
                continent = "Asia";
            }
            else if (continentCode.Equals("EU"))
            {
                continent = "Europe";
            }
            else if (continentCode.Equals("NA"))
            {
                continent = "North America";
            }
            else if (continentCode.Equals("OC"))
            {
                continent = "Oceania";
            }
            else if (continentCode.Equals("SA"))
            {
                continent = "South America";
            }
        }
    }
}
