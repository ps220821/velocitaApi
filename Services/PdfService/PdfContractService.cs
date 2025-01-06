using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using velocitaApi.Services.PdfService.Helpers;

namespace velocitaApi.Services.PdfService
{
    public class PdfContractService
    {
        public byte[] GeneratePdf(string content)
        {
            using var memoryStream = new MemoryStream();
            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
            PdfWriter.GetInstance(pdfDoc, memoryStream);
            pdfDoc.Open();

            // styling
            Font headerFont = new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD, BaseColor.BLACK);
            Font subHeaderFont = new Font(Font.FontFamily.HELVETICA, 14, Font.BOLD, BaseColor.DARK_GRAY);
            Font bodyFont = new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL, BaseColor.BLACK);
            Font boldFont = new Font(Font.FontFamily.HELVETICA, 13, Font.BOLD, BaseColor.BLACK);

            PdfHeaderWithLogo.addPdPdfHeaderWithLogo(pdfDoc);
            PdfSenderAndReceiver.AddSenderAndReceiver(pdfDoc);
            lineSeparator.AddlineSeparator(pdfDoc);

            // message
            pdfDoc.Add(new Paragraph("Geachte heer/mevrouw", boldFont)
            {
                SpacingBefore = 15,
                SpacingAfter = 5
            });
            pdfDoc.Add(new Paragraph("Bedankt voor je aankoop bij Velocita Cars! We zijn blij je als klant te mogen verwelkomen."));
            Paragraph paragraphWarning = new Paragraph();
            paragraphWarning.Add(new Phrase("Let op: ", boldFont));
            paragraphWarning.Add("het contract dient binnen 2 weken ondertekend geretourneerd te worden. Na deze periode vervalt het contract. Heb je vragen? Neem gerust contact met ons op!");
            pdfDoc.Add(paragraphWarning);

            // Bestelinformatie
            var OrderInformationTitle = new Paragraph("Bestelinformatie", subHeaderFont)
            {
                SpacingBefore = 15,
                SpacingAfter = 5
            };

            pdfDoc.Add(OrderInformationTitle);
            pdfDoc.Add(new Paragraph($"Voertuig Merk: Audi"));
            pdfDoc.Add(new Paragraph($"Voertuig Model: A4"));
            pdfDoc.Add(new Paragraph($"Service Beschrijving: Onderhoud en reparatie"));
            pdfDoc.Add(new Paragraph($"Totale Kosten: €750,00"));
            pdfDoc.Add(new Paragraph($"Bestelstatus: In Afwachting"));

            pdfDoc.Add(new Paragraph($"Opmerking:", boldFont)
            {
                SpacingBefore = 15,
                SpacingAfter = 5
            });
            pdfDoc.Add(new Paragraph("De klant heeft aangegeven interesse te hebben in het upgraden van de remmen en het vervangen van de motorolie bij de volgende servicebeurt.", bodyFont));

            var conditionsTitle = new Paragraph("Algemene Voorwaarden", subHeaderFont)
            {
                SpacingBefore = 15,
                SpacingAfter = 10
            };

            pdfDoc.Add(conditionsTitle);
            pdfDoc.Add(new Paragraph("1. De klant erkent dat Velocita Cars de overeengekomen diensten naar beste vermogen uitvoert..."));
            pdfDoc.Add(new Paragraph("2. De klant blijft verantwoordelijk voor het voertuig totdat het in de werkplaats wordt afgeleverd..."));
            pdfDoc.Add(new Paragraph("3. Velocita Cars is niet verantwoordelijk voor schade aan het voertuig die buiten de overeengekomen werkzaamheden valt..."));

            // Handtekeningen sectie 
            pdfDoc.Add(new Paragraph("")
            {
                SpacingBefore = 15,
                SpacingAfter = 10
            });

            PdfSignatures.AddSignatures(pdfDoc);
            pdfDoc.Close();
            return memoryStream.ToArray();
        }
    }
}
