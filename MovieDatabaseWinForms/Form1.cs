using Newtonsoft.Json;
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
    public partial class Form1 : Form
    {
        public List<Movie> MovieList = new List<Movie>();
    
        WebClient wc = new WebClient
        {
            Encoding = Encoding.UTF8
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rtxtName.Text != "")
            {
                MovieList.Clear();
                var result = wc.DownloadString($"http://www.omdbapi.com/?s={rtxtName.Text}&apikey=45a7689c&type=movie&page=1");
               // object movie = JsonConvert.DeserializeObject(result) as JObject;
                var data = JObject.Parse(result);

                foreach (var item in data["Search"])
                {
                    Movie movie = new Movie
                    {
                        ID = (string)item["imdbID"],
                        Title = (string)item["Title"],
                        Year = (string)item["Year"]
                    };
                    MovieList.Add(movie);
                }

                //for (int iter = 0; iter < 10; iter++) 
                //{
                //    ListMovie movie = new ListMovie();
                //    movie.ID = (string)data["Search"][iter]["imdbID"];
                //    movie.Title = (string)data["Search"][iter]["Title"];
                //    movie.Year = (int)data["Search"][iter]["Year"];
                //    MovieList.Add(movie);
                //}
                listBox1.DataSource = null;
                listBox1.DataSource = MovieList;

                //MovieList.Add();

                //foreach (var item in result)
                //{
                //    listBox1.Items.Add(result);
                //}
            }
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // MovieList[listBox1.SelectedIndex].ID

                var wnd = new FormMoreInfo(MovieList, listBox1);
                var res = wnd.ShowDialog();

                


            }
            catch { }
        }
    }
}
