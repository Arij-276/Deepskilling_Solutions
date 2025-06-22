// DocumentFactory.cs
public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

// WordFactory.cs
public class WordFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new WordDocument();
}

// PdfFactory.cs
public class PdfFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new PdfDocument();
}

// ExcelFactory.cs
public class ExcelFactory : DocumentFactory
{
    public override IDocument CreateDocument() => new ExcelDocument();
}
