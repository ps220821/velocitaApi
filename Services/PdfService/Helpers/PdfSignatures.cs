using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace velocitaApi.Services.PdfService.Helpers
{
    public class PdfSignatures
    {
        public static void AddSignatures(Document pdfDoc)
        {
            // Maak een vetgedrukte font voor de handtekeningen
            Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);

            // Maak de tabel voor de handtekeningen (twee kolommen)
            PdfPTable signatureTable = new PdfPTable(2);
            signatureTable.WidthPercentage = 100; // Zet de tabel om de volledige breedte te gebruiken
            signatureTable.SetWidths(new float[] { 1f, 1f }); // Zorg ervoor dat beide kolommen gelijk zijn

            // Voeg de "Klant Handtekening" tekst toe in de eerste cel
            PdfPCell clientSignatureCell = new PdfPCell(new Paragraph("Klant Handtekening:", boldFont))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                PaddingBottom = 10 // Voeg wat ruimte onder de tekst toe
            };
            signatureTable.AddCell(clientSignatureCell);

            // Voeg de "Garage Handtekening" tekst toe in de tweede cel
            PdfPCell garageSignatureTextCell = new PdfPCell(new Paragraph("Garage Handtekening:", boldFont))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_LEFT,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                PaddingBottom = 10 // Voeg wat ruimte onder de tekst toe
            };
            signatureTable.AddCell(garageSignatureTextCell);

            // Voeg de onderstreping voor de klant toe
            PdfPCell clientSignatureLineCell = new PdfPCell(new Paragraph(new string('_', 30)))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_LEFT,
                PaddingTop = 55,  // Zorg voor voldoende ruimte tussen de tekst en de onderstreping
                FixedHeight = 0 // Stel de hoogte van de cel expliciet in om consistentie te garanderen
            };
            signatureTable.AddCell(clientSignatureLineCell);

            // Pad naar de afbeelding van de garage handtekening
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "Images", "Signature.png");
            Image garageSignatureImage = Image.GetInstance(imagePath);
            garageSignatureImage.ScaleToFit(60, 60); // Pas de grootte van de afbeelding aan naar wens

            // Voeg de afbeelding van de garagehandtekening toe in de tweede rij
            PdfPCell garageSignatureImageCell = new PdfPCell(garageSignatureImage)
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_CENTER, // Centraal uitlijnen
                VerticalAlignment = Element.ALIGN_MIDDLE,
                FixedHeight = 60 // Zorg ervoor dat de afbeelding geen onbedoelde impact heeft op de lay-out
            };
            signatureTable.AddCell(garageSignatureImageCell);

            // Voeg de onderstreping voor de garage toe
            PdfPCell garageSignatureLineCell = new PdfPCell(new Paragraph(new string('_', 30)))
            {
                Border = 0,
                HorizontalAlignment = Element.ALIGN_LEFT,
                FixedHeight = 0
            };
            signatureTable.AddCell(garageSignatureLineCell);

            // Voeg de tabel met de handtekeningen toe aan het document
            pdfDoc.Add(signatureTable);
        }
    }
}
