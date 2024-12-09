using System.Text.Json.Serialization;
namespace velocitaApi.models
{
    public class Brand
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Country { get; set; }

        [JsonIgnore]
        public ICollection<Car> Cars { get; set; }
    }
}
