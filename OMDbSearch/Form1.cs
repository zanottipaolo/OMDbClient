using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OMDbSearch.Models;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace OMDbSearch
{
    public partial class Form1 : Form
    {
        //public int PageNumber { set; get; }

        public static List<Search> list_film = new List<Search>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = textBox_search;
        }

        /// <summary>
        ///  Quando si è posizionati all'interno della textBox_search è possibile fare una ricerca 
        ///  premendo il tasto 'Invio' sulla tastiera per simulare il click sul button_search
        /// </summary>
        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_search_Click(this, new EventArgs());
        }

        /// <summary>
        /// Chiama il metodo Search_Movie.consumeWebService() e 
        /// associa alle PictureBox e alle Label i risultati trovati
        /// </summary>
        private void button_search_Click(object sender, EventArgs e)
        {
            string filmName = "";
            int PageNumber = 1;
            

            Regex reg = new Regex("^[a-zA-Z0-9]");

            bool checkName = reg.IsMatch(textBox_search.Text);
            
            if (filmName != textBox_search.Text)
            {
                PageNumber = 1;
                filmName = textBox_search.Text;
            }

            #region
            PictureBox[] pic = {
                  pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10
              };

            Label[] lab = {
                  label_film1, label_film2, label_film3, label_film4, label_film5, label_film6, label_film7, label_film8, label_film9, label_film10
              };
            #endregion
            
            if (textBox_search.Text != "" && checkName)
            {
                //Search_Movie.consumeWebService(filmName, PageNumber, list_film);
                Search_Movie _Movie = new Search_Movie();

                _Movie.consumeWebService(filmName, PageNumber, list_film);

                /*string query = "https://www.omdbapi.com/?s=" + filmName + "&page=" + PageNumber.ToString() + "&apikey=771ba633";
                int totalResults;

                using (var client = new HttpClient())
                {
                    string risp_JSON = await client.GetStringAsync(query);

                    Rootobject film_des = JsonConvert.DeserializeObject<Rootobject>(risp_JSON);

                    list_film.Clear();

                    if (film_des.Response == "True")
                    {
                        Total = film_des.totalResults;
                        Response = "True";

                        for (int k = 0; k < 10; k++)
                        {
                            Search movie = new Search
                            {
                                Title = film_des.Search[k].Title,
                                Poster = film_des.Search[k].Poster,
                            };

                            list_film.Add(movie);
                        }
                    }
                    else
                    {
                        Response = "False";
                    }
                }*/

                //if (Search_Movie.Response == "True")
                //{
                /*for (int i = 0; i < 10; i++)
                {
                    pic[i].Visible = true;
                    //pic[i].ImageLocation = "";
                    lab[i].Visible = true;
                    //lab[i].Text = "Harry Potter and the Deathly Allows";

                    foreach (Search film in list_film)
                    {
                        pic[i].ImageLocation = film.Poster;
                        lab[i].Text = film.Title;
                    }
                }*/

                for (int j=0; j<10; j++)
                    {
                    pic[j].Visible = true;
                    lab[j].Visible = true;
                    }

                    int i = 0;
                    foreach(Search film in list_film)
                    {
                        //pic[i].Visible = true;
                        pic[i].ImageLocation = film.Poster;
                        //lab[i].Visible = true;
                        lab[i].Text = film.Title;
                        i++;
                    }

                    label_pageNumber.Text = PageNumber.ToString();
                    label_pageNumber.Visible = true;
                //}
               //else
                  //  MessageBox.Show("Film non trovato", "Ci dispiace...", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("Nome del film non valido", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_search.Clear();
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_control_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_pagina_dopo_Click(object sender, EventArgs e)
        {
            /*if(PageNumber < Search_Movie.Total / 10)
            {
                PageNumber++;
                button_search_Click(this, new EventArgs());
            }*/
        }

        private void button_pagina_prima_Click(object sender, EventArgs e)
        {
            /*if (PageNumber > 1)
            {
                PageNumber--;

                button_search_Click(this, new EventArgs());
            }
            else
                MessageBox.Show("Impossibile tornare indietro", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
        }

        private void label_pageNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
