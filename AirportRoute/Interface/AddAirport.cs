using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportRoute.Interface
{
    public partial class AddAirport : Form
    {
        GetRoute gr;

        public AddAirport(GetRoute oldScr)
        {
            InitializeComponent();

            gr = oldScr;
        }

        private void searchCountryBtn_Click(object sender, EventArgs e)
        {
            String search = countrySearchTxt.Text;

            for (int i = countryBox.Items.Count - 1; i >= 0; i--)
            {
                if (!countryBox.Items[i].ToString().ToLower().Contains(search.ToLower()))
                    countryBox.Items.RemoveAt(i);
            }
        }

        private void resetFormBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            String newEntry = ("\n" + (gr.getNoOfAirports()+1) + "\t" + nameTxt.Text + "\t" + latitudeTxt.Text + "\t" + longitudeTxt.Text
                + "\t" + gr.getCountryCode(countryBox.SelectedItem.ToString()) + "\t" + cityTxt.Text + "\t" + airportCodeTxt.Text);

            File.AppendAllText("airports.dat", newEntry);

            Airport A = new Airport();
            A.airportID = gr.getNoOfAirports() + 1;
            A.name = nameTxt.Text;
            A.latitude = double.Parse(latitudeTxt.Text);
            A.longitude = double.Parse(longitudeTxt.Text);

            for (int i = 0; i < gr.getNoOfCountries(); i++)
            {
                if (countryBox.SelectedItem.ToString().Equals(gr.getCountry(i).name))
                    A.country = gr.getCountry(i);
            }

            A.city = cityTxt.Text;
            A.code = airportCodeTxt.Text;

            gr.addAirport(A);

            this.Hide();
        }

        private void AddAirport_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gr.getNoOfCountries(); i++)
            {
                countryBox.Items.Add(gr.getCountry(i));
            }
        }
    }
}
