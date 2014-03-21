using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PortableLeagueAPI.Test.Responses
{
    internal abstract class Responses : IResponses
    {
        private readonly string _folder;
        private static readonly Dictionary<string, string> Cache = new Dictionary<string, string>();

        protected Responses(string folder)
        {
            _folder = folder;
        }

        protected async Task<string> ReadResponse(string fileName)
        {
            if (fileName == null) return null;

            var filePath = Path.Combine(
                "Responses",
                _folder,
                string.Concat(fileName, ".json"));

            if (!Cache.ContainsKey(filePath))
            {

                var sb = new StringBuilder();
                using (var sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = await sr.ReadLineAsync()) != null)
                    {
                        sb.AppendLine(line);
                    }
                }

                Cache[filePath] = sb.ToString();
            }

            return Cache[filePath];
        }

        public async Task<string> GetResponse(string pathAndQuery)
        {
            return await ReadResponse(GetFile(pathAndQuery));
        }

        public abstract string GetFile(string pathAndQuery);
    }
}
