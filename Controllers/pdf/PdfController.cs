using Microsoft.AspNetCore.Mvc;
using velocitaApi.Services.PdfService;

namespace velocitaApi.Controllers.pdf
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfController : ControllerBase
    {
        private readonly PdfContractService _pdfService;

        public PdfController(PdfContractService pdfService)
        {
            _pdfService = pdfService;
        }

        [HttpPost("generate")]
        public IActionResult PostPdf([FromBody] PdfRequest request)
        {
            var pdfBytes = _pdfService.GeneratePdf(request.Content);
            return File(pdfBytes, "application/pdf", "GeneratedPdf.pdf");
        }
    }

    public class PdfRequest
    {
        public string Content { get; set; }
    }
}
