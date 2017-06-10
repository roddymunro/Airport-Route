using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportRoute
{
    public class Airport
    {
        public int airportID, noofneighbours = 0, growby = 1;
        public String name, city, code;
        public double latitude, longitude, gscore, fscore;
        public Airport[] neighbours = new Airport[1];
        public Airport parent;
        public Country country;

        public Airport()
        {

        }

        public int getNoOfNeighbours()
        {
            return noofneighbours;
        }

        public Airport getNeighbour(int index)
        {
            return neighbours[index];
        }

        public void setNeighbour(Airport neighbour)
        {
            if (!neighbours.Contains(neighbour))
            {
                neighbours[noofneighbours++] = neighbour;
                Array.Resize(ref neighbours, neighbours.Length + growby);
            }
        }
    }
}
