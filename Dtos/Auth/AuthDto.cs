using System.ComponentModel.DataAnnotations;

namespace velocitaApi.Dtos.Auth
{
    public class AuthDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
