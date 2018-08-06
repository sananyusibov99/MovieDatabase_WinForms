using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseWinForms
{
    public partial class FormMoreInfo : Form
    {
        WebClient wc = new WebClient
        {
            Encoding = Encoding.UTF8
        };


        public FormMoreInfo(List<Movie> MovieList, ListBox listBox1)
        {
            InitializeComponent();
            var result = wc.DownloadString($"http://www.omdbapi.com/?i={MovieList[listBox1.SelectedIndex].ID}&apikey=45a7689c&type=movie&page=1");
            var data = JObject.Parse(result);
            labelTitle.Text = (string)data["Title"];
            labelRated.Text = (string)data["Rated"];
            labelReleased.Text = (string)data["Released"];
            labelRuntime.Text = (string)data["Runtime"];
            labelGenre.Text = (string)data["Genre"];

            labelDirector.Text += "\n" + (string)data["Director"];
            labelWriter.Text += "\n" + (string)data["Writer"];
            labelActors.Text += "\n" + (string)data["Actors"];
            labelPlot.Text += "\n" + (string)data["Plot"];

            labelRating.Text += (string)data["imdbRating"];

            pictureBox1.Load((string)data["Poster"]);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
