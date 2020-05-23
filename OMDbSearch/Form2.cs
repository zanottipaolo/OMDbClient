using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using OMDbSearch.Models;
using static OMDbSearch.Search_Movie;

namespace OMDbSearch
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// Film selezionato
        /// </summary>
        private Rootobject2 Movie = new Rootobject2 { };

        /// <summary>
        /// imdbID del film selezionato
        /// </summary>
        private string imdbID { set; get; }

        public Form2(string Id)
        {
            InitializeComponent();
            imdbID = Id;
        }

        // imposto i colori dei controlli e associo le informazioni
        // del film alle label/Text/PictureBox 
        private async void Form2_Load(object sender, EventArgs e)
        {
            button_star1.ForeColor = SystemColors.Control;
            button_star2.ForeColor = SystemColors.Control;
            button_star3.ForeColor = SystemColors.Control;
            button_star4.ForeColor = SystemColors.Control;
            button_star5.ForeColor = SystemColors.Control;

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

            // Converto l'imdbRating in /5, poi lo arrotondo
            Decimal Star = 0;

            if(Movie.imdbRating != "N/A")
                Star = Decimal.Round(5 * decimal.Parse(Movie.imdbRating, CultureInfo.InvariantCulture.NumberFormat) / 10);

            // cambio il colore alle stelle in base al risultato
            if (Star >= 1)
                button_star1.BackColor = Color.Gold;
            if (Star >= 2)
                button_star2.BackColor = Color.Gold;
            if (Star >= 3)
                button_star3.BackColor = Color.Gold;
            if (Star >= 4)
                button_star4.BackColor = Color.Gold;
            if (Star == 5)
                button_star5.BackColor = Color.Gold;
        }

        // quando il mouse passa sopra la stella 'n' coloro i bordi
        // fino di tutte le stelle fino alla 'n'
        private void button_star1_MouseEnter(object sender, EventArgs e)
        {
            button_star1.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star1.FlatAppearance.BorderSize = 2;
        }

        // quando il mouse si sposta il bordo torna come prima
        private void button_star1_MouseLeave(object sender, EventArgs e)
        {
            button_star1.FlatAppearance.BorderColor = Color.Black;
            button_star1.FlatAppearance.BorderSize = 0;
        }

        private void button_star2_MouseEnter(object sender, EventArgs e)
        {
            button_star1.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star1.FlatAppearance.BorderSize = 2;
            button_star2.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star2.FlatAppearance.BorderSize = 2;
        }

        private void button_star2_MouseLeave(object sender, EventArgs e)
        {
            button_star1.FlatAppearance.BorderColor = Color.Black;
            button_star1.FlatAppearance.BorderSize = 0;
            button_star2.FlatAppearance.BorderColor = Color.Black;
            button_star2.FlatAppearance.BorderSize = 0;
        }

        private void button_star3_MouseEnter(object sender, EventArgs e)
        {
            button_star1.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star1.FlatAppearance.BorderSize = 2;
            button_star2.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star2.FlatAppearance.BorderSize = 2;
            button_star3.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star3.FlatAppearance.BorderSize = 2;
        }

        private void button_star3_MouseLeave(object sender, EventArgs e)
        {
            button_star1.FlatAppearance.BorderColor = Color.Black;
            button_star1.FlatAppearance.BorderSize = 0;
            button_star2.FlatAppearance.BorderColor = Color.Black;
            button_star2.FlatAppearance.BorderSize = 0;
            button_star3.FlatAppearance.BorderColor = Color.Black;
            button_star3.FlatAppearance.BorderSize = 0;
        }

        private void button_star4_MouseEnter(object sender, EventArgs e)
        {
            button_star1.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star1.FlatAppearance.BorderSize = 2;
            button_star2.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star2.FlatAppearance.BorderSize = 2;
            button_star3.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star3.FlatAppearance.BorderSize = 2;
            button_star4.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star4.FlatAppearance.BorderSize = 2;
        }

        private void button_star4_MouseLeave(object sender, EventArgs e)
        {
            button_star1.FlatAppearance.BorderColor = Color.Black;
            button_star1.FlatAppearance.BorderSize = 0;
            button_star2.FlatAppearance.BorderColor = Color.Black;
            button_star2.FlatAppearance.BorderSize = 0;
            button_star3.FlatAppearance.BorderColor = Color.Black;
            button_star3.FlatAppearance.BorderSize = 0;
            button_star4.FlatAppearance.BorderColor = Color.Black;
            button_star4.FlatAppearance.BorderSize = 0;
        }

        private void button_star5_MouseEnter(object sender, EventArgs e)
        {
            button_star1.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star1.FlatAppearance.BorderSize = 2;
            button_star2.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star2.FlatAppearance.BorderSize = 2;
            button_star3.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star3.FlatAppearance.BorderSize = 2;
            button_star4.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star4.FlatAppearance.BorderSize = 2;
            button_star5.FlatAppearance.BorderColor = Color.SteelBlue;
            button_star5.FlatAppearance.BorderSize = 2;
        }

        private void button_star5_MouseLeave(object sender, EventArgs e)
        {
            button_star1.FlatAppearance.BorderColor = Color.Black;
            button_star1.FlatAppearance.BorderSize = 0;
            button_star2.FlatAppearance.BorderColor = Color.Black;
            button_star2.FlatAppearance.BorderSize = 0;
            button_star3.FlatAppearance.BorderColor = Color.Black;
            button_star3.FlatAppearance.BorderSize = 0;
            button_star4.FlatAppearance.BorderColor = Color.Black;
            button_star4.FlatAppearance.BorderSize = 0;
            button_star5.FlatAppearance.BorderColor = Color.Black;
            button_star5.FlatAppearance.BorderSize = 0;
        }
    }
}
