using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace WpfApplication1.Models
{
    public class InterOpsLibrary
    {
        private static readonly string FilePath = Path.Combine(Environment.CurrentDirectory, @"..\..\Models\Profiles.json");

        public static void SaveConfig(IList<RadialMenuConfig> config)
        {
            using (var file = File.CreateText(FilePath))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, config);
            }
        }

        public static IList<RadialMenuConfig> ReadMenuConfig()
        {
            var json = File.ReadAllText(FilePath);

            var profiles = JsonConvert.DeserializeObject<IList<RadialMenuConfig>>(json);

            return profiles ?? new List<RadialMenuConfig>();
        }
    }
}
