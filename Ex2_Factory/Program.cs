using System;

public interface IDocument
{
    void Open();
    void Close();
}

public class WordDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening Word document");
    public void Close() => Console.WriteLine("Closing Word document");
}

public class PdfDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening PDF document");
    public void Close() => Console.WriteLine("Closing PDF document");
}

public class ExcelDocument : IDocument
{
    public void Open() => Console.WriteLine("Opening Excel document");
    public void Close() => Console.WriteLine("Closing Excel document");
}

public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
    public void ProcessDocument()
    {
        IDocument doc = CreateDocument();
        doc.Open();
        doc.Close();
    }
}

public class WordDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new WordDocument();
}

public class PdfDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new PdfDocument();
}

public class ExcelDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new ExcelDocument();
}

class Program
{
    static void Main()
    {
        DocumentFactory wordFactory = new WordDocumentFactory();
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        DocumentFactory excelFactory = new ExcelDocumentFactory();

        Console.WriteLine("Processing Word Document:");
        wordFactory.ProcessDocument();

        Console.WriteLine("\nProcessing PDF Document:");
        pdfFactory.ProcessDocument();

        Console.WriteLine("\nProcessing Excel Document:");
        excelFactory.ProcessDocument();

        Console.WriteLine("\nDirect document creation:");
        IDocument wordDoc = wordFactory.CreateDocument();
        wordDoc.Open();
        wordDoc.Close();
    }
}
