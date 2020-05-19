using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OMDbSearch.Models;
using static OMDbSearch.Search_Movie;

namespace OMDbSearch
{
    public partial class Form2 : Form
    {
        private Rootobject2 Movie = new Rootobject2 { };
        private string imdbID { set; get; }

        public Form2(string Id)
        {
            InitializeComponent();
            imdbID = Id;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            Movie = await SearchFilm(imdbID);
            Text = Movie.Title;
            pictureBox_Poster.ImageLocation = Movie.Poster;
            label_year.Text = Movie.Year;
            label_rated.Text = Movie.Rated;
            label_released.Text = Movie.Released;
            label_runtime.Text = Movie.Runtime;
            label_genre.Text = Movie.Genre;
            label_director.Text = Movie.Director;
            label_writer.Text = Movie.Writer;
            label_actors.Text = Movie.Actors;
            label_plot.Text = Movie.Plot;
            label_language.Text = Movie.Language;
            label_country.Text = Movie.Country;
            label_awards.Text = Movie.Awards;
            label_boxoffice.Text = Movie.BoxOffice;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
