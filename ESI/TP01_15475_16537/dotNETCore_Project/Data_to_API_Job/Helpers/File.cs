using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Data_to_API_Job.Models;

namespace Data_to_API_Job.Helpers
{
    public static class File
    {
        public static async Task SaveJSON(List<Data> listFilmes)
        {
            await using var json = System.IO.File.Create("resultado.json");
            await JsonSerializer.SerializeAsync(json, listFilmes);
            await json.DisposeAsync();
        }

        public static async Task SaveXML(List<Data> listFilmes)
        {
            var fs = new FileStream("resultado.xml", FileMode.Create);
            var xs = new XmlSerializer(typeof(List<Data>));
            xs.Serialize(fs, listFilmes);
            fs.Close();
            await fs.DisposeAsync();
        }
    }
}