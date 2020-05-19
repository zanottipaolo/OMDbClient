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
        }
    }
}
