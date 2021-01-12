using System;
using System.IO;
using Data_to_API_Job.Helpers;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Data_to_API_Job
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            const string path = "Download";

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            while (!stoppingToken.IsCancellationRequested)
            {
                var client = new WebClient();
                client.DownloadFile("https://datasets.imdbws.com/title.basics.tsv.gz", path + "\\imdb.tsv.gz");

                await Descompress.GZ(new FileInfo(path + "\\imdb.tsv.gz"));

                var listFilme = await Deserialize.ReadFile(path);

                await Helpers.File.SaveJSON(listFilme);
                await Helpers.File.SaveXML(listFilme);
                await API.postFilmeAPI(listFilme);

                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}
