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
using static OMDbSearch.Search_Movie;

namespace OMDbSearch
{
    public partial class Form1 : Form
    {
        private int PageNumber { set; get; }
        private string FilmName { set; get; }

        private List<Search> list_film = new List<Search>();

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
        ///  premendo il tasto 'Invio' oppure cambiare pagina con i tasti freccia sx - freccia dx
        /// </summary>
        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_search_Click(this, new EventArgs());
            if (e.KeyCode == Keys.Left)
                button_pagina_prima_Click(this, new EventArgs());
            if (e.KeyCode == Keys.Right)
                button_pagina_dopo_Click(this, new EventArgs());
        }

        /// <summary>
        /// Chiama il metodo Search_Movie.ConsumeWebService() e 
        /// associa alle PictureBox e alle Label i risultati trovati
        /// </summary>
        private async void button_search_Click(object sender, EventArgs e)
        {
            #region
            PictureBox[] pic = {
                  pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10
              };

            Label[] lab = {
                  label_film1, label_film2, label_film3, label_film4, label_film5, label_film6, label_film7, label_film8, label_film9, label_film10
              };
            #endregion

            // se una ricerca produce meno di 10 risultati nelle picturebox e nelle label che avanzano
            // rimangono ancora i dati della ricerca precedente, modifico quindi i valori
            for (int k = 0; k < 10; k++)
            {
                pic[k].Visible = false;
                lab[k].Visible = false;
                pic[k].ImageLocation = null;
                lab[k].Text = "";
            }

            // se sto cercando il film imposto i valori inziali, se invece 
            // sto cambiando pagina tengo conto dei valori precedenti
            if (FilmName != textBox_search.Text)
            {
                PageNumber = 1;
                FilmName = textBox_search.Text;
            }

            // controllo che il nome del film non inizi con un carattere speciale
            Regex reg = new Regex("^[a-zA-Z0-9]");

            bool checkName = reg.IsMatch(textBox_search.Text);
            
            if (textBox_search.Text != "" && checkName)
            {
                list_film = await SearchList(FilmName, PageNumber);

                if (Response)
                {
                    for (int j = 0; j < list_film.Count(); j++)
                    {
                        pic[j].Visible = true;
                        lab[j].Visible = true;
                    }

                    int i = 0;
                    foreach (Search film in list_film)
                    {
                        pic[i].ImageLocation = film.Poster;
                        lab[i].Text = film.Title;
                        i++;
                    }

                    label_pageNumber.Text = PageNumber.ToString();
                    label_pageNumber.Visible = true;
                }
                else
                {
                    label_pageNumber.Visible = false;
                    MessageBox.Show("Film non trovato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_search.Clear();
                }
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

        /// <summary>
        /// Aumenta il numero di pagina e richiama il metodo 'button_search_Click'
        /// </summary>
        private void button_pagina_dopo_Click(object sender, EventArgs e)
        {
            if (PageNumber < Total / 10)
            {
                PageNumber++;
                button_search_Click(this, new EventArgs());
            }
            else
                MessageBox.Show("Impossibile andare avanti", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Diminuisce il numero di pagina e richiama il metodo 'button_search_Click'
        /// </summary>
        private void button_pagina_prima_Click(object sender, EventArgs e)
        {
            if (PageNumber > 1)
            {
                PageNumber--;

                button_search_Click(this, new EventArgs());
            }
            else
                MessageBox.Show("Impossibile tornare indietro", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label_pageNumber_Click(object sender, EventArgs e)
        {

        }

        private void label_film4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.ImageLocation != null && label_film4.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[3].imdbID);
                settingsForm.Show();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != null && label_film1.Text != "") {
                Form2 settingsForm = new Form2(list_film[0].imdbID);
                settingsForm.Show();
            }
        }

        private void label_film1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != null && label_film1.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[0].imdbID);
                settingsForm.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.ImageLocation != null && label_film2.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[1].imdbID);
                settingsForm.Show();
            }
        }

        private void label_film2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.ImageLocation != null && label_film2.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[1].imdbID);
                settingsForm.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.ImageLocation != null && label_film3.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[2].imdbID);
                settingsForm.Show();
            }
        }

        private void label_film3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.ImageLocation != null && label_film3.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[2].imdbID);
                settingsForm.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.ImageLocation != null && label_film4.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[3].imdbID);
                settingsForm.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.ImageLocation != null && label_film5.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[4].imdbID);
                settingsForm.Show();
            }
        }

        private void label_film5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.ImageLocation != null && label_film5.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[4].imdbID);
                settingsForm.Show();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.ImageLocation != null && label_film6.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[5].imdbID);
                settingsForm.Show();
            }
        }

        private void label_film6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.ImageLocation != null && label_film6.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[5].imdbID);
                settingsForm.Show();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.ImageLocation != null && label_film7.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[6].imdbID);
                settingsForm.Show();
            }
        }

        private void label_film7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.ImageLocation != null && label_film7.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[6].imdbID);
                settingsForm.Show();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.ImageLocation != null && label_film8.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[7].imdbID);
                settingsForm.Show();
            }
        }

        private void label_film8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.ImageLocation != null && label_film8.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[7].imdbID);
                settingsForm.Show();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.ImageLocation != null && label_film9.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[8].imdbID);
                settingsForm.Show();
            }
        }

        private void label_film9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.ImageLocation != null && label_film9.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[8].imdbID);
                settingsForm.Show();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.ImageLocation != null && label_film10.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[9].imdbID);
                settingsForm.Show();
            }
        }

        private void label_film10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.ImageLocation != null && label_film10.Text != "")
            {
                Form2 settingsForm = new Form2(list_film[9].imdbID);
                settingsForm.Show();
            }
        }
    }
}
