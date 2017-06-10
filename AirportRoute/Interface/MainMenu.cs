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

namespace AirportRoute.Interface
{
    public partial class MainMenu : Form
    {
        GetRoute gr = new GetRoute();

        public MainMenu()
        {
            LoadData();
            InitializeComponent();
        }

        private void addAirportBtn_Click(object sender, EventArgs e)
        {
            AddAirport aa = new AddAirport(gr);
            aa.ShowDialog();
        }

        private void addRouteBtn_Click(object sender, EventArgs e)
        {
            AddRoute ar = new AddRoute(gr);
            ar.ShowDialog();
        }

        private void getRouteBtn_Click(object sender, EventArgs e)
        {
            if (continentsChoice.Checked == true)
                gr.setDisplayChoice("Continents");
            else if (countriesChoice.Checked == true)
                gr.setDisplayChoice("Countries");
            else if (citiesChoice.Checked == true)
                gr.setDisplayChoice("Cities");
            else if (airportsChoice.Checked == true)
                gr.setDisplayChoice("Airports");
            
            gr.ShowDialog();
        }

        private void LoadData()
        {
            using (StreamReader myFile = new StreamReader("countries.dat"))
            {
                while (!myFile.EndOfStream)
                {
                    Country C = new Country();
                    string[] lines = myFile.ReadLine().Split('\t');
                    C.countryCode = lines[1];
                    C.name = lines[2];
                    C.continent = lines[3];

                    gr.addCountry(C);
                }
            }

            using (StreamReader myFile = new StreamReader("airports.dat"))
            {
                while (!myFile.EndOfStream)
                {
                    Airport A = new Airport();
                    string[] lines = myFile.ReadLine().Split('\t');
                    A.airportID = Int32.Parse(lines[0]);
                    A.name = lines[1];
                    A.latitude = double.Parse(lines[2], CultureInfo.InvariantCulture);
                    A.longitude = double.Parse(lines[3], CultureInfo.InvariantCulture);
                    A.city = lines[5];
                    A.code = lines[6];

                    for (int i = 0; i < gr.getNoOfCountries(); i++)
                    {
                        if (lines[4].Equals(gr.getCountry(i).countryCode))
                            A.country = gr.getCountry(i);
                    }

                    gr.addAirport(A);
                }
            }

            using (StreamReader myFile = new StreamReader("routes.dat"))
            {
                while (!myFile.EndOfStream)
                {
                    string[] lines = myFile.ReadLine().Split('\t');

                    Route R = new Route();
                    for (int i = 0; i < gr.getNoOfAirports(); i++)
                    {
                        if (lines[0].Equals(gr.getAirport(i).code))
                            R.origin = gr.getAirport(i);
                        else if (lines[1].Equals(gr.getAirport(i).code))
                            R.destination = gr.getAirport(i);
                    }

                    gr.addRoute(R);
                }
            }

            gr.sortVectors();

            gr.addNeighbours();
        }
    }
}
