using System.ComponentModel.DataAnnotations;
using velocitaApi.models;

namespace velocitaApi.Dtos.Account;

public class RegisterDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}

