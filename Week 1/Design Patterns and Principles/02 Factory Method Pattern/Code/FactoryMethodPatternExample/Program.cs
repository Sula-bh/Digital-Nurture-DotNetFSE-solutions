using FactoryMethodPatternExample.Documents;
using FactoryMethodPatternExample.Factories;

DocumentFactory pdfFactory = new PdfDocumentFactory();
IDocument pdf = pdfFactory.CreateDocument();
pdf.Open();

DocumentFactory wordFactory = new WordDocumentFactory();
IDocument word = wordFactory.CreateDocument();
word.Open();

DocumentFactory excelFactory = new ExcelDocumentFactory();
IDocument excel = excelFactory.CreateDocument();
excel.Open();