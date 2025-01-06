using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;


namespace velocitaApi.Services.PdfService.Helpers
{
    public class PdfHeaderWithLogo
    {
        public static void addPdPdfHeaderWithLogo(Document pdfDoc)
        {
            Font headerFont = new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD, BaseColor.BLACK);

            PdfPTable headerTable = new PdfPTable(2);
            headerTable.WidthPercentage = 100;
            headerTable.GetRowHeight(0);
            headerTable.SetWidths(new float[] { 3f, 1f });
            PdfPCell titleCell = new PdfPCell(new Phrase("Velocita Cars – Auto Service & Verkoop Contract", headerFont))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_LEFT,  // Align title to the left
                VerticalAlignment = Element.ALIGN_MIDDLE,  // Center the text vertically
            };
            headerTable.AddCell(titleCell);

            // Add the logo (aligned to the right)
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "Images", "Velicita.jpg");
            Image logo = Image.GetInstance(imagePath);
            logo.ScaleToFit(80, 80);  // Adjust the size of the logo

            PdfPCell logoCell = new PdfPCell(logo)
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                VerticalAlignment = Element.ALIGN_MIDDLE,
            };
            headerTable.AddCell(logoCell);
            pdfDoc.Add(headerTable);
        }
    }
}