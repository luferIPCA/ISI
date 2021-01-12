using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace Data_to_API_Job.Helpers
{
    public static class Descompress
    {
        public static async Task GZ(FileInfo fileToDecompress)
        {
            await using (var originalFileStream = fileToDecompress.OpenRead())
            {
                var currentFileName = fileToDecompress.FullName;
                var newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                await using (var decompressedFileStream = System.IO.File.Create(newFileName))
                {
                    await using (var decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        await decompressionStream.CopyToAsync(decompressedFileStream);
                    }
                }
            }
        }
    }
}