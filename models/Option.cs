using System.Text.Json.Serialization;

namespace velocitaApi.models
{
    public class Option
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public ICollection<CarOption> CarOptions { get; set; }
    }
}
