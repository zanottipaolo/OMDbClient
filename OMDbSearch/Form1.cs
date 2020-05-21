using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OMDbSearch.Models;
using System.Text.RegularExpressions;
using static OMDbSearch.Search_Movie;
using System.Drawing;

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

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Size size = new Size(106, 157);
            pictureBox1.Location = new Point(38, 12);
            pictureBox1.Size = size;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = list_film[0].Poster;
            Size size = new Size(98, 149);
            pictureBox1.Location = new Point(42, 16);
            pictureBox1.Size = size;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Size size = new Size(106, 157);
            pictureBox2.Location = new Point(225, 12);
            pictureBox2.Size = size;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = list_film[1].Poster;
            Size size = new Size(98, 149);
            pictureBox2.Location = new Point(229, 16);
            pictureBox2.Size = size;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            Size size = new Size(106, 157);
            pictureBox3.Location = new Point(410, 12);
            pictureBox3.Size = size;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = list_film[2].Poster;
            Size size = new Size(98, 149);
            pictureBox3.Location = new Point(414, 16);
            pictureBox3.Size = size;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            Size size = new Size(106, 157);
            pictureBox4.Location = new Point(595, 12);
            pictureBox4.Size = size;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = list_film[3].Poster;
            Size size = new Size(98, 149);
            pictureBox4.Location = new Point(599, 16);
            pictureBox4.Size = size;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            Size size = new Size(106, 157);
            pictureBox5.Location = new Point(774, 12);
            pictureBox5.Size = size;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = list_film[4].Poster;
            Size size = new Size(98, 149);
            pictureBox5.Location = new Point(778, 16);
            pictureBox5.Size = size;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            Size size = new Size(106, 157);
            pictureBox6.Location = new Point(38, 204);
            pictureBox6.Size = size;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.ImageLocation = list_film[5].Poster;
            Size size = new Size(98, 149);
            pictureBox6.Location = new Point(42, 208);
            pictureBox6.Size = size;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            Size size = new Size(106, 157);
            pictureBox7.Location = new Point(225, 204);
            pictureBox7.Size = size;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.ImageLocation = list_film[6].Poster;
            Size size = new Size(98, 149);
            pictureBox7.Location = new Point(229, 208);
            pictureBox7.Size = size;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            Size size = new Size(106, 157);
            pictureBox8.Location = new Point(410, 204);
            pictureBox8.Size = size;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.ImageLocation = list_film[7].Poster;
            Size size = new Size(98, 149);
            pictureBox8.Location = new Point(414, 208);
            pictureBox8.Size = size;
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            Size size = new Size(106, 157);
            pictureBox9.Location = new Point(595, 204);
            pictureBox9.Size = size;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.ImageLocation = list_film[8].Poster;
            Size size = new Size(98, 149);
            pictureBox9.Location = new Point(599, 208);
            pictureBox9.Size = size;
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            Size size = new Size(106, 157);
            pictureBox10.Location = new Point(774, 204);
            pictureBox10.Size = size;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.ImageLocation = list_film[9].Poster;
            Size size = new Size(98, 149);
            pictureBox10.Location = new Point(778, 208);
            pictureBox10.Size = size;
        }
    }
}
