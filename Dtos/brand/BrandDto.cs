using System.ComponentModel.DataAnnotations;
using velocitaApi.models;

namespace velocitaApi.Dtos.brand
{
    public class BrandDto
    {
        [Required(ErrorMessage = "name is required")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Country { get; set; }
    }
}
