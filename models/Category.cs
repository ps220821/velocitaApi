using System.Text.Json.Serialization;

namespace velocitaApi.models
{
    public class Category
    {
        public int id { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }

        [JsonIgnore]
        public ICollection<Car> Cars { get; set; }
    }
}
