using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Information.Services
{
    internal class DownloadService
    {
        private static string key = "7098bc10";
        private static string url = @"https://www.omdbapi.com/?t=";
        public static async Task<string> FindMovie(string name)
        {
            WebClient client = new();
            return await client.DownloadStringTaskAsync($@"{url}{name}&apikey={key}");
        }
    }
}
