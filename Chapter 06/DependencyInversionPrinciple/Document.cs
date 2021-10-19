using System;
using System.Collections.Generic;
using System.Text;

namespace _6.ChapterSix6._1.DependencyInversionPrinciple
{
    class Document
    {
        private IDocumentConversion pdfConverter;
        private IDocumentConversion excelConveter;

        public Document(IDocumentConversion pdfConverter, IDocumentConversion excelConverter)
        {
            this.pdfConverter = pdfConverter;
            this.excelConveter = excelConveter;
        }

        public void GetPdfFormat()
        {
            var pdf = this.pdfConverter.Convert(this);
        }

        public void GetExcelFormat()
        {
            var excel = this.excelConveter.Convert(this);
        }
    }
}
