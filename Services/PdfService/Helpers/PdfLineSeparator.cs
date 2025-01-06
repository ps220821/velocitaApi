using iTextSharp.text;
using iTextSharp.text.pdf.draw;



namespace velocitaApi.Services.PdfService.Helpers
{
    public class lineSeparator
    {
        public static void AddlineSeparator(Document pdfDoc)
        {
            LineSeparator lineSeparator = new LineSeparator(1f, 100f, BaseColor.LIGHT_GRAY, Element.ALIGN_CENTER, -1)
            {
                LineWidth = 1,
                Percentage = 100,
            };
            pdfDoc.Add(lineSeparator);

        }
    }
}