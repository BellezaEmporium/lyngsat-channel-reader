using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Metier.Entities;

namespace Metier
{
    public class Model
    {
        // Writes formatted channel list to JSON
        public static void WriteChannels(List<LyngSatStructure> list)
        {
            var jsonData = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText("channels_formatted.json", jsonData);
        }
    }
}

