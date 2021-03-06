﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OMDbSearch.Models;

namespace OMDbSearch
{
    public class Search_Movie
    {
        /// <summary>
        /// Risultati totali della ricerca
        /// </summary>
        public static int Total { set; get; }

        /// <summary>
        /// Numero massimo di film per pagina
        /// </summary>
        public static int MaxFilmPage { set; get; }

        /// <summary>
        /// Risposta della ricerca: 'true' se sono stati trovati dei risultati,
        /// 'false' no
        /// </summary>
        public static bool Response { set; get; }

        ///<summary>
        /// Effettua la chiamata al Web Service in base al nome cercato, deserializza i dati 
        /// e aggiunge gli oggetti creati alla lista temp_list.
        /// </summary>
        /// <param name="FilmName">Contenuto della textBox_search</param>
        /// <param name="PageNumber">Numero di pagina iniziale da visualizzare</param>
        /// <param name="Type">Tipo (Movie, Series, Episode e Game)</param>
        /// <param name="Year">Anno di uscita</param>
        public static async Task<List<Search>> SearchList(string FilmName, int PageNumber, string Type, int Year) 
        {
            List<Search> temp_list = new List<Search>();

            MaxFilmPage = 10;

            string query = "";

            if(Type == "" && Year == 0)
                query = "https://www.omdbapi.com/?s=" + FilmName + "&page=" + PageNumber + "&apikey=528b5586";
            else if(Type != "" && Year == 0)
                query = "https://www.omdbapi.com/?s=" + FilmName + "&type=" + Type + "&page=" + PageNumber + "&apikey=528b5586";
            else if(Year != 0 && Type == "")
                query = "https://www.omdbapi.com/?s=" + FilmName + "&y=" + Year + "&page=" + PageNumber + "&apikey=528b5586";
            else if (Year != 0 && Type != "")
                query = "https://www.omdbapi.com/?s=" + FilmName + "&y=" + Year + "&type=" + Type + "&page=" + PageNumber + "&apikey=528b5586";

            using (var client = new HttpClient())
            {
                string risp_JSON = await client.GetStringAsync(query);

                Rootobject1 list_des = JsonConvert.DeserializeObject<Rootobject1>(risp_JSON);

                temp_list.Clear();

                if(list_des.totalResults < 10)
                    MaxFilmPage = list_des.totalResults;

                if (list_des.Response == "True")
                {
                    Total = list_des.totalResults;
                    Response = true;

                    for (int i = 0; i < MaxFilmPage; i++)
                    {
                        Search Movie_list = new Search
                        {
                            Title = list_des.Search[i].Title,
                            Poster = list_des.Search[i].Poster,
                            imdbID = list_des.Search[i].imdbID,
                        };
                        temp_list.Add(Movie_list);
                    }

                    // per eliminare i film con lo stesso imdbID                                          
                    // (è commentato perché non risulta chiaro che dopo ci siano altre pagine disponibili)
                    // es: 'Pokemon'
                    // temp_list = temp_list.GroupBy(m => m.imdbID).Select(group => group.First()).ToList();
                }
                else
                {
                    Response = false;
                }
            }
            return temp_list;
        }

        ///<summary>
        /// Effettua la chiamata al Web Service in base all'imdbID del film, deserializza i dati 
        /// e restituisce l'oggetto film.
        /// </summary>
        /// <param name="imdbID">imdbID del film selezionato</param>
        public static async Task<Rootobject2> SearchFilm(string imdbID)
        {
            string query = "https://www.omdbapi.com/?i=" + imdbID + "&apikey=528b5586";
            Rootobject2 Movie_temp = new Rootobject2 { };

            using (var client = new HttpClient())
            {
                string risp_JSON = await client.GetStringAsync(query);

                Rootobject2 film_des = JsonConvert.DeserializeObject<Rootobject2>(risp_JSON);

                if (film_des.Response == "True")
                {
                    Movie_temp.Title = film_des.Title;
                    Movie_temp.Year = film_des.Year;
                    Movie_temp.Rated = film_des.Rated;
                    Movie_temp.Released = film_des.Released;
                    Movie_temp.Runtime = film_des.Runtime;
                    Movie_temp.Genre = film_des.Genre;
                    Movie_temp.Director = film_des.Director;
                    Movie_temp.Writer = film_des.Writer;
                    Movie_temp.Actors = film_des.Actors;
                    Movie_temp.Plot = film_des.Plot;
                    Movie_temp.Language = film_des.Language;
                    Movie_temp.Country = film_des.Country;
                    Movie_temp.Awards = film_des.Awards;
                    Movie_temp.Poster = film_des.Poster;
                    Movie_temp.imdbID = film_des.imdbID;
                    Movie_temp.BoxOffice = film_des.BoxOffice;
                    Movie_temp.Type = film_des.Type;
                    Movie_temp.imdbRating = film_des.imdbRating;
                }
            }
            return Movie_temp;
        }
    }
}
