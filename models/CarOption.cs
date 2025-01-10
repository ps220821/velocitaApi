using System.Text.Json.Serialization;

namespace velocitaApi.models
{
    public class CarOption
    {
        public int id { get; set; }
        public int CarId { get; set; }
        [JsonIgnore]
        public Car Car { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
    }
}
