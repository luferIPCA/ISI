using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Data_to_API_Job.Models;
using Newtonsoft.Json;

namespace Data_to_API_Job.Helpers
{
    public static class API
    {
        public static async Task postFilmeAPI(IEnumerable<Data> dataFilmes)
        {
            var urlFilmes = "http://localhost:59449/api/Filmes";
            var urlGeneros = "http://localhost:59449/api/Generos";
            var urlFilmeGeneros = "http://localhost:59449/api/FilmeGeneroes";

            foreach (var dataFilme in dataFilmes)
            {
                if (dataFilme.startYear == "null")
                    dataFilme.startYear = null;

                if (dataFilme.endYear == "null")
                    dataFilme.endYear = null;

                if (dataFilme.runtimeMinutes == "null")
                    dataFilme.runtimeMinutes = null;

                var filme = new Filme
                {
                    TitleType = dataFilme.titleType,
                    PrimaryTitle = dataFilme.primaryTitle,
                    OriginalTitle = dataFilme.originalTitle,
                    IsAdult = Convert.ToBoolean(Convert.ToInt32(dataFilme.isAdult)),
                    StartYear = Convert.ToInt32(dataFilme.startYear),
                    EndYear = Convert.ToInt32(dataFilme.endYear),
                    RuntimeMinutes = Convert.ToInt32(dataFilme.runtimeMinutes),
                    Tconst = Convert.ToInt32(dataFilme.tconst)
                };

                await httpClient(filme, urlFilmes);

                var genres = dataFilme.genres.Split(',');

                foreach (var genre in genres)
                {
                    await httpClient(genre, urlGeneros);

                    var filGen = new FilmeGeneroTemp
                    {
                        Genero = genre,
                        Tconst = filme.Tconst
                    };
                    await httpClient(filGen, urlFilmeGeneros);
                }
            }
            
        }

        private static async Task httpClient(object o, string url)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(o);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                await client.PostAsync(url, data);
            }
        }
    }
}