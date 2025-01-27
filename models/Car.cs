﻿
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
        public string Description { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("BrandId")]
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }

        [JsonIgnore]
        public ICollection<Order> Orders { get; set; }

        [JsonIgnore]
        public ICollection<CarOption> CarOptions { get; set; }

        [JsonIgnore]
        public ICollection<CarSpec> CarSpecs { get; set; }

        [JsonIgnore]
        public ICollection<CarImages> CarImages { get; set; }
    }
}
