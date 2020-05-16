using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using OMDbSearch.Models;

namespace OMDbSearch
{
    public class Search_Movie
    {
        public int Total { set; get; }
        public string Response { set; get; }

        ///<summary>
        /// Effettua la chiamata al Web Service, deserializza i dati e aggiunge gli oggetti creati alla lista list_film. 
        /// Riceve il nome del film, il numeri di pagina e la lista come parametri.
        /// </summary>
        /// <param name="filmName">Contenuto della textBox_search</param>
        /// <param name="pageNumber">Numero di pagina iniziale da visualizzare</param>
        /// <param name="list_film">Lista principale che contiene i risultati della ricerca</param>
        public async void consumeWebService(string filmName, int pageNumber, List<Search> list_film)
        {
            string query = "https://www.omdbapi.com/?s=" + filmName + "&page=" + pageNumber.ToString() + "&apikey=771ba633";
            //int totalResults;

            using (var client = new HttpClient())
            {
                string risp_JSON = await client.GetStringAsync(query);

                Rootobject film_des = JsonConvert.DeserializeObject<Rootobject>(risp_JSON);

                list_film.Clear();

                if (film_des.Response == "True")
                {
                    Total = film_des.totalResults;
                    Response = "True";

                    for (int i = 0; i < 10; i++)
                    {
                        Search movie = new Search
                        {
                            Title = film_des.Search[i].Title,
                            Poster = film_des.Search[i].Poster,
                        };

                        list_film.Add(movie);
                    }
                }
                else
                {
                    Response = "False";
                }
            }
        }
    }
}
