
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace velocitaApi.models
{
    public class Car
    {
        public int id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Mileage { get; set; }

        [ForeignKey("categoryId")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("brandId")]
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }

        [JsonIgnore]
        public ICollection<Order> Orders { get; set; }

        [JsonIgnore]
        public ICollection<CarOption> CarOptions { get; set; }

        [JsonIgnore]
        public ICollection<CarSpec> CarSpecs { get; set; }
    }
}
