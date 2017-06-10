using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//  http://ourairports.com/data/

    // NEW FEATURES
    // search by airport code
    // display by continents
    // go from country to country
    // country to city/city to country??
    // make it more graphical

namespace AirportRoute.Interface
{
    public partial class GetRoute : Form
    {
        Country[] countries = new Country[50];
        Airport[] airports = new Airport[500];
        int noofcountries = 0, noofairports = 0, noofroutes = 0, growby = 1;
        Route[] routes = new Route[1000];
        double miles = 0, kilometres = 0, nauticalMiles = 0;
        LinkedList<Airport> open = new LinkedList<Airport>();
        LinkedList<Airport> closed = new LinkedList<Airport>();
        String displayChoice = "";
        Airport originAirport = null;
        Airport destinationAirport = null;
        char measurementChoice = ' ';

        public GetRoute()
        {
            InitializeComponent();
        }

        public void addCountry(Country C)
        {
            if (countries.Length != noofcountries)
            {
                countries[noofcountries++] = C;
            }
            else
            {
                Array.Resize(ref countries, countries.Length + growby);
                countries[noofcountries++] = C;
            }
        }

        public void sortVectors()
        {
            Array.Sort(airports,
                delegate (Airport x, Airport y) { return x.city.CompareTo(y.city); });

            Array.Sort(routes,
                delegate (Route x, Route y) { return x.origin.code.CompareTo(y.origin.code); });
        }

        public void addAirport(Airport A)
        {
            if (airports.Length != noofairports)
            {
                airports[noofairports++] = A;
            }
            else
            {
                Array.Resize(ref airports, airports.Length + growby);
                airports[noofairports++] = A;
            }
        }

        public void addRoute(Route R)
        {
            if (routes.Length != noofroutes)
            {
                routes[noofroutes++] = R;
            }
            else
            {
                Array.Resize(ref routes, routes.Length + growby);
                routes[noofroutes++] = R;
            }
        }

        public void setDisplayChoice(String choice)
        {
            displayChoice = choice;
        }

        public void addNeighbours()
        {
            for (int i = 0; i < noofairports; i++)
            {
                for (int j = 0; j < noofroutes; j++)
                {
                    if (routes[j].origin == airports[i])
                    {
                        airports[i].setNeighbour(routes[j].destination);
                    }
                }
            }
        }

        private void showAirportsBtn_Click(object sender, EventArgs e)
        {
            showAirportsBtn.Enabled = false;
            if ((originBox.SelectedItem != null) && (destinationBox.SelectedItem != null))
            {
                outputBox1.Text = "";

                String selectedOrigin = originBox.SelectedItem.ToString();
                String selectedDestination = destinationBox.SelectedItem.ToString();

                originBox.Items.Clear();
                destinationBox.Items.Clear();

                for (int i = 0; i < noofairports; i++)
                {
                    if ((selectedOrigin.Equals(airports[i].city) || (selectedOrigin.Equals(airports[i].country.name)) || selectedOrigin.Equals(airports[i].country.continent)))
                    {
                        originBox.Items.Add(airports[i].name);
                    }
                    else if ((selectedDestination.Equals(airports[i].city) || (selectedDestination.Equals(airports[i].country.name)) || selectedDestination.Equals(airports[i].country.continent)))
                    {
                        destinationBox.Items.Add(airports[i].name);
                    } 
                }
            }
            getRouteBtn.Enabled = true;
            distanceChoice.Enabled = true;
        }

        private void getRouteBtn_Click(object sender, EventArgs e)
        {
            getRouteBtn.Enabled = false;
            distanceChoice.Enabled = false;

            if (milesChoice.Checked == true)
                measurementChoice = 'M';
            else if (kmChoice.Checked == true)
                measurementChoice = 'K';
            else if (nmChoice.Checked == true)
                measurementChoice = 'N';

            for (int i = 0; i < noofairports; i++)
            {
                if (airports[i].name.Equals(originBox.SelectedItem.ToString()))
                {
                    originAirport = airports[i];
                }
                else if (airports[i].name.Equals(destinationBox.SelectedItem.ToString()))
                {
                    destinationAirport = airports[i];
                }
            }

            if ((originAirport == null) || (destinationAirport == null))
            {
                outputBox1.Text = "Route not found";
                return;
            }

            open.AddFirst(originAirport);

            originAirport.gscore = 0;
            originAirport.fscore = originAirport.gscore + HeuristicFunction(originAirport, destinationAirport);

            Airport currentAirport = null;

            while (open.Count > 0)
            {
                currentAirport = open.First.Value;

                getRoute(currentAirport, destinationAirport);
            }
        }

        private void getRoute(Airport currentAirport, Airport destinationAirport)
        {
            if (currentAirport == destinationAirport)
            {
                open.Clear();
                outputData(currentAirport, measurementChoice);
                originSearchTxt.Text = "";
                destSearchTxt.Text = "";
                originBox.Items.Clear();
                destinationBox.Items.Clear();
                loadListboxes();
                showAirportsBtn.Enabled = true;

            }
            else
            {
                closed.AddFirst(currentAirport);
                open.RemoveFirst();

                for (int i = 0; i < currentAirport.getNoOfNeighbours(); i++)
                {
                    Airport neighbour = currentAirport.getNeighbour(i);
                    if (!closed.Contains(neighbour))
                    {
                        neighbour.gscore = currentAirport.gscore + currentAirport.fscore;
                        neighbour.fscore = currentAirport.gscore + HeuristicFunction(currentAirport.getNeighbour(i), destinationAirport);
                        neighbour.parent = currentAirport;

                        if (!open.Contains(neighbour))
                        {
                            open.AddFirst(neighbour);
                        }

                    }
                    int listLength = open.Count;
                    Airport[] temp = new Airport[listLength];
                    for (int j = 0; j < listLength; j++)
                    {
                        temp[j] = open.First.Value;
                        open.RemoveFirst();
                    }
                    Array.Sort(temp, delegate (Airport x, Airport y)
                    {
                        return x.fscore.CompareTo(y.fscore);
                    });
                    for (int j = 0; j < listLength; j++)
                    {
                        open.AddLast(temp[j]);
                    }
                }
            }
        }

        private double HeuristicFunction(Airport current, Airport end)
        {
            return distance(current.latitude, current.longitude, end.latitude, end.longitude, 'M');
        }

        private void outputData(Airport currentAirport, char measurementChoice)
        {
            Airport[] route = new Airport[1];
            int noofstops = 0;
            route[noofstops++] = currentAirport;
            while (currentAirport.parent != null)
            {
                Array.Resize(ref route, route.Length + growby);
                route[noofstops++] = currentAirport.parent;

                miles = miles + distance(currentAirport.latitude, currentAirport.longitude, currentAirport.parent.latitude,
                    currentAirport.parent.longitude, 'M');
                kilometres = kilometres + distance(currentAirport.latitude, currentAirport.longitude, currentAirport.parent.latitude,
                    currentAirport.parent.longitude, 'K');
                nauticalMiles = nauticalMiles + distance(currentAirport.latitude, currentAirport.longitude, currentAirport.parent.latitude,
                    currentAirport.parent.longitude, 'N');

                currentAirport = currentAirport.parent;
            }

            outputBox1.Text = "--------------FULL FLIGHT INFO--------------";
            outputBox1.AppendText("\r\n" + route[noofstops - 1].name + " -> " + route[0].name);
            outputBox1.AppendText("\r\nNumber of stops: " + (noofstops - 2));
            if (measurementChoice == 'M')
                outputBox1.AppendText("\r\nMiles: " + Math.Round(miles, 2));
            else if (measurementChoice == 'K')
                outputBox1.AppendText("\r\nKilometres: " + Math.Round(kilometres, 2));
            else if (measurementChoice == 'N')
                outputBox1.AppendText("\r\nNautical Miles: " + Math.Round(nauticalMiles, 2));

            int legNo = 1;
            for (int i = noofstops - 1; i > 0; i--)
            {
                outputBox1.AppendText("\r\n\r\n--------------LEG NUMBER " + legNo + "--------------");
                outputBox1.AppendText("\r\n" + route[i].name + " -> " + route[i - 1].name);
                if (measurementChoice == 'M')
                    outputBox1.AppendText("\r\nMiles: " + Math.Round(distance(route[i].latitude, route[i].longitude, route[i - 1].latitude, route[i - 1].longitude, 'M'), 2));
                if (measurementChoice == 'K')
                    outputBox1.AppendText("\r\nKilometres: " + Math.Round(distance(route[i].latitude, route[i].longitude, route[i - 1].latitude, route[i - 1].longitude, 'K'), 2));
                if (measurementChoice == 'N')
                    outputBox1.AppendText("\r\nNautical Miles: " + Math.Round(distance(route[i].latitude, route[i].longitude, route[i - 1].latitude, route[i - 1].longitude, 'N'), 2));
                legNo++;
            }

        }

        private double distance(double lat1, double lon1, double lat2, double lon2, char unit)
        {
            double theta = lon1 - lon2;
            double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * 60 * 1.1515;
            if (unit == 'K')
            {
                dist = dist * 1.609344;
            }
            else if (unit == 'N')
            {
                dist = dist * 0.8684;
            }
            return (dist);
        }

        private double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        private double rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }

        private void searchOriginBtn_Click(object sender, EventArgs e)
        {
            String search = originSearchTxt.Text;

            for (int i = originBox.Items.Count - 1; i >= 0; i--)
            {
                if (!originBox.Items[i].ToString().ToLower().Contains(search.ToLower()))
                    originBox.Items.RemoveAt(i);
            }
        }

        public int getNoOfRoutes()
        {
            return noofroutes;
        }

        public Route getRoute(int index)
        {
            return routes[index];
        }

        public int getNoOfAirports()
        {
            return noofairports;
        }

        public void setNoOfAirports()
        {
            noofairports++;
        }

        public Airport getAirport(int index)
        {
            return airports[index];
        }

        public int getNoOfCountries()
        {
            return noofcountries;
        }

        public Country getCountry(int index)
        {
            return countries[index];
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            string path = string.Concat(Environment.CurrentDirectory, @"\Route Data\"+ originAirport.code + "-" + destinationAirport.code +".txt");

            File.WriteAllText(path, outputBox1.Text);
        }

        private void returnInfoBtn_Click(object sender, EventArgs e)
        {
            Airport temp = originAirport;
            originAirport = destinationAirport;
            destinationAirport = temp;

            //open.Clear();
            //closed.Clear();

            open.AddFirst(originAirport);

            originAirport.gscore = 0;
            originAirport.fscore = originAirport.gscore + HeuristicFunction(originAirport, destinationAirport);

            Airport currentAirport = null;

            while (open.Count > 0)
            {
                currentAirport = open.First.Value;

                getRoute(currentAirport, destinationAirport);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public String getCountryCode(string name)
        {
            for (int i = 0; i < noofcountries; i++)
            {
                if (countries[i].name.Equals(name))
                {
                    return countries[i].countryCode;
                }
            }
            return "none";
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (displayChoice.Equals("Airports"))
            {
                showAirportsBtn.Enabled = false;
                getRouteBtn.Enabled = true;
                distanceChoice.Enabled = true;
            }
            else
            {
                showAirportsBtn.Enabled = true;
                getRouteBtn.Enabled = false;
                distanceChoice.Enabled = false;
            }
            loadListboxes();
        }

        private void destSearchBtn_Click(object sender, EventArgs e)
        {
            String search = destSearchTxt.Text;

            for (int i = destinationBox.Items.Count - 1; i >= 0; i--)
            {
                if (!destinationBox.Items[i].ToString().ToLower().Contains(search.ToLower()))
                    destinationBox.Items.RemoveAt(i);
            }
        }

        private void loadListboxes()
        {
            for (int i = 0; i < noofairports; i++)
            {
                if ((!originBox.Items.Contains(airports[i].country.continent) && (displayChoice.Equals("Continents"))))
                {
                    originBox.Items.Add(airports[i].country.continent);
                }
                else if ((!originBox.Items.Contains(airports[i].city) && (displayChoice.Equals("Cities"))))
                {
                    originBox.Items.Add(airports[i].city);
                }
                else if ((!originBox.Items.Contains(airports[i].country.name) && (displayChoice.Equals("Countries"))))
                {
                    originBox.Items.Add(airports[i].country.name);
                }
                else if ((!originBox.Items.Contains(airports[i].name) && (displayChoice.Equals("Airports"))))
                {
                    originBox.Items.Add(airports[i].name);
                }

                if ((!destinationBox.Items.Contains(airports[i].country.continent) && (displayChoice.Equals("Continents"))))
                {
                    destinationBox.Items.Add(airports[i].country.continent);
                }
                else if ((!destinationBox.Items.Contains(airports[i].city) && (displayChoice.Equals("Cities"))))
                {
                    destinationBox.Items.Add(airports[i].city);
                }
                else if ((!destinationBox.Items.Contains(airports[i].country.name) && (displayChoice.Equals("Countries"))))
                {
                    destinationBox.Items.Add(airports[i].country.name);
                }
                else if ((!destinationBox.Items.Contains(airports[i].name) && (displayChoice.Equals("Airports"))))
                {
                    destinationBox.Items.Add(airports[i].name);
                }
            }
            originBox.Sorted = true;
            destinationBox.Sorted = true;
        }
    }
}
