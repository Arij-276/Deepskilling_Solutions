// Program.cs
class Program
{
    static void Main()
    {
        // Create factories
        DocumentFactory wordFactory = new WordFactory();
        DocumentFactory pdfFactory = new PdfFactory();
        DocumentFactory excelFactory = new ExcelFactory();

        // Create documents using factories
        IDocument wordDoc = wordFactory.CreateDocument();
        IDocument pdfDoc = pdfFactory.CreateDocument();
        IDocument excelDoc = excelFactory.CreateDocument();

        // Test document operations
        Console.WriteLine("Testing Word Document:");
        wordDoc.Open();
        wordDoc.Save();
        wordDoc.Close();

        Console.WriteLine("\nTesting PDF Document:");
        pdfDoc.Open();
        pdfDoc.Save();
        pdfDoc.Close();

        Console.WriteLine("\nTesting Excel Document:");
        excelDoc.Open();
        excelDoc.Save();
        excelDoc.Close();
    }
}
