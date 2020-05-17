using System.Collections.Generic;
using System.Linq;
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
        /// 'false' se è stato trovato un errore
        /// </summary>
        public static bool Response { set; get; }

        ///<summary>
        /// Effettua la chiamata al Web Service, deserializza i dati e aggiunge gli oggetti creati alla lista list_film. 
        /// Riceve il nome del film, il numeri di pagina e la lista come parametri.
        /// </summary>
        /// <param name="FilmName">Contenuto della textBox_search</param>
        /// <param name="PageNumber">Numero di pagina iniziale da visualizzare</param>
        public static async Task<List<Search>> ConsumeWebService(string FilmName, int PageNumber) 
        {  
            List<Search> temp_list = new List<Search>();

            MaxFilmPage = 10;

            string query = "https://www.omdbapi.com/?s=" + FilmName + "&page=" + PageNumber.ToString() + "&apikey=771ba633";

            using (var client = new HttpClient())
            {
                string risp_JSON = await client.GetStringAsync(query);

                Rootobject film_des = JsonConvert.DeserializeObject<Rootobject>(risp_JSON);

                temp_list.Clear();

                if(film_des.totalResults < 10)
                    MaxFilmPage = film_des.totalResults;

                if (film_des.Response == "True")
                {
                    Total = film_des.totalResults;
                    Response = true;

                    for (int i = 0; i < MaxFilmPage; i++)
                    {
                        Search movie = new Search
                        {
                            Title = film_des.Search[i].Title,
                            Poster = film_des.Search[i].Poster,
                            imdbID = film_des.Search[i].imdbID,
                        };
                        temp_list.Add(movie);
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
    }
}
