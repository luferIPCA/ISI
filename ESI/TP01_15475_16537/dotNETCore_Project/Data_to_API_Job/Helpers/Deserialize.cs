using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CsvHelper;
using Data_to_API_Job.Models;

namespace Data_to_API_Job.Helpers
{
    public static class Deserialize
    {
        public static async Task<List<Data>> ReadFile(string path)
        {
            var textReader = System.IO.File.OpenText(path + "\\imdb.tsv");
            var csv = new CsvReader(textReader);

            csv.Configuration.HasHeaderRecord = true;
            csv.Configuration.Delimiter = "\t";

            var listFilmesTemp = csv.GetRecords<Data>();

            var listFilmes = new List<Data>();


            foreach (var filme in listFilmesTemp)
            {
                filme.tconst = Regex.Replace(filme.tconst, "([a-zA-Z]+)", "");
                filme.primaryTitle = Regex.Replace(filme.primaryTitle, "[\\u0000]+", "");
                filme.originalTitle = Regex.Replace(filme.originalTitle, "[\\u0000]+", "");
                filme.startYear = Regex.Replace(filme.startYear, "([\\\\][N])", "null");
                filme.runtimeMinutes = Regex.Replace(filme.runtimeMinutes, "([\\\\][N])", "null");
                filme.genres = Regex.Replace(filme.genres, "([\\\\][N])", "null");
                filme.endYear = Regex.Replace(filme.endYear, "([\\\\][N])", "null");

                listFilmes.Add(filme);
            }

            textReader.Dispose();
            csv.Dispose();

            return listFilmes; 
        }
    }
}