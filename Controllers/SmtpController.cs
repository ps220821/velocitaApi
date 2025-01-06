
using Microsoft.AspNetCore.Mvc;
using velocitaApi.Services.Smtp;



namespace velocitaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SmtpController : ControllerBase
    {
        private readonly SmtpService smtpService;

        public SmtpController(SmtpService smtpService)
        {
            this.smtpService = smtpService;
        }

        [HttpPost("send-email")]
        public async Task<IActionResult> SendEmail()
        {
            try
            {
                await smtpService.SendEmailAsync(
                    "inancozdm@gmail.com",
                    "Test Email Subject",
                    "<h1>This is a test email</h1>");

                return Ok("Email sent successfully!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Failed to send email: {ex}");
            }
        }
    }
}