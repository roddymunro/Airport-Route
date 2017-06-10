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
    public partial class AddRoute : Form
    {
        GetRoute gr;

        public AddRoute(GetRoute oldScr)
        {
            InitializeComponent();
            addBtn.Enabled = false;

            gr = oldScr;
        }

        private void resetFormBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            String origin = "", destination = "";

            for (int i = 0; i < gr.getNoOfAirports(); i++)
            {
                if (originBox.SelectedItem.ToString().Equals(gr.getAirport(i).name))
                {
                    origin = gr.getAirport(i).code;
                }

                if (destinationBox.SelectedItem.ToString().Equals(gr.getAirport(i).name))
                {
                    destination = gr.getAirport(i).code;
                }
            }

            String outboundRoute = "\n" + origin + "\t" + destination;
            String returnRoute = "\n" + destination + "\t" + origin;

            File.AppendAllText("routes.dat", outboundRoute);
            File.AppendAllText("routes.dat", returnRoute);

            Route R = new Route();
            for (int i = 0; i < gr.getNoOfAirports(); i++)
            {
                if (originBox.SelectedItem.ToString().Equals(gr.getAirport(i).name))
                    R.origin = gr.getAirport(i);
                else if (destinationBox.SelectedItem.ToString().Equals(gr.getAirport(i).name))
                    R.destination = gr.getAirport(i);
            }

            gr.addRoute(R);

            this.Hide();
        }

        private void AddRoute_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gr.getNoOfAirports(); i++)
            {
                if (!originBox.Items.Contains(gr.getAirport(i).country.name))
                {
                    originBox.Items.Add(gr.getAirport(i).country.name);
                }

                if (!destinationBox.Items.Contains(gr.getAirport(i).country.name))
                {
                    destinationBox.Items.Add(gr.getAirport(i).country.name);
                }
            }
            originBox.Sorted = true;
            destinationBox.Sorted = true;
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

        private void destSearchBtn_Click(object sender, EventArgs e)
        {
            String search = destSearchTxt.Text;

            for (int i = destinationBox.Items.Count - 1; i >= 0; i--)
            {
                if (!destinationBox.Items[i].ToString().ToLower().Contains(search.ToLower()))
                    destinationBox.Items.RemoveAt(i);
            }
        }

        private void showAirportsBtn_Click(object sender, EventArgs e)
        {
            showAirportsBtn.Enabled = false;
            if ((originBox.SelectedItem != null) && (destinationBox.SelectedItem != null))
            {
                String originCity = originBox.SelectedItem.ToString();
                String destinationCity = destinationBox.SelectedItem.ToString();

                originBox.Items.Clear();
                destinationBox.Items.Clear();

                for (int i = 0; i < gr.getNoOfAirports(); i++)
                {
                    if ((originCity.Equals(gr.getAirport(i).city) || (originCity.Equals(gr.getAirport(i).country.name))))
                    {
                        originBox.Items.Add(gr.getAirport(i).name);
                    }
                    else if ((destinationCity.Equals(gr.getAirport(i).city) || (destinationCity.Equals(gr.getAirport(i).country.name))))
                    {
                        destinationBox.Items.Add(gr.getAirport(i).name);
                    }
                }
            }
            addBtn.Enabled = true;
        }
    }
}
