using iTextSharp.text;

namespace velocitaApi.Services.PdfService.Helpers
{
    public class PdfSenderAndReceiver
    {
        public static void AddSenderAndReceiver(Document pdfDoc)
        {
            Font boldFont = new Font(Font.FontFamily.HELVETICA, 13, Font.BOLD, BaseColor.BLACK);

            pdfDoc.Add(new Paragraph("Afzender", boldFont)
            {
                SpacingAfter = 5,
                SpacingBefore = 0
            });

            pdfDoc.Add(new Paragraph("Adres: Straatnaam 123, 1234 AB, Plaatsnaam"));
            pdfDoc.Add(new Paragraph("Telefoon: 012-3456789"));
            pdfDoc.Add(new Paragraph("Email: klantenservice@velocitacars.nl"));

            pdfDoc.Add(new Paragraph("Aan", boldFont)
            {
                SpacingAfter = 5,
                SpacingBefore = 15
            });
            pdfDoc.Add(new Paragraph($"Datum: {System.DateTime.Now.ToString("yyyy-MM-dd")}"));
            pdfDoc.Add(new Paragraph($"Klant Naam: Jan Jansen"));
            pdfDoc.Add(new Paragraph($"Bestelnummer: 12345")
            {
                SpacingAfter = 5
            });

        }
    }
}