

using System.Text.Json.Serialization;
using velocitaApi.models;

public class CarImages
{
    public int id { get; set; }
    public string ImageUrl { get; set; }
    public string ImageDescription { get; set; }
    public int? CarId { get; set; }

    [JsonIgnore]
    public Car Car { get; set; }
}