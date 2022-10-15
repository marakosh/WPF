using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Movie_Information.Model;

namespace Movie_Information.Services
{
    internal class DeserializeService
    {
        // public static Task<Rootobject?> Deserialize(string json)
        public static Rootobject? Deserialize(string json)
        {

            return JsonSerializer.Deserialize<Rootobject?>(json);
        }
    }
}
