using System;

namespace _8.ChapterEightConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePathDocumentOne = @"C:\Temp\file1.docx";
            PDFConverter pDFConverterFirstDocument = PDFConverter.GetInstance;
            pDFConverterFirstDocument.ConvertToPDF(filePathDocumentOne);

            pDFConverterFirstDocument.GetSessionInfo();

            string filePathDocumentTwo = @"C:\Temp\file2.docx";
            PDFConverter pDFConverterSecondDocument = PDFConverter.GetInstance;
            pDFConverterSecondDocument.ConvertToPDF(filePathDocumentTwo);

            pDFConverterSecondDocument.GetSessionInfo();

            Console.ReadLine();
        }
    }
}
