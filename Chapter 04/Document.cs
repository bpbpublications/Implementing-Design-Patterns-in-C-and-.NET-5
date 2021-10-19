using System;
using System.Collections.Generic;
using System.Text;

namespace _4.ChapterFour
{
    public class Document
    {
        private IDocumentConverter _pdfConverter;
        private IDocumentConverter _excelConverter;

        public Document (IDocumentConverter pdfConverter, IDocumentConverter excelConverter)
        {
            _pdfConverter = pdfConverter;
            _excelConverter = excelConverter;
        }

        public void ConvertDocumentToPdf(int documentId)
        {
            this._pdfConverter.Converter(documentId);
        }

        public void ConvertDocumentToExcel(int documentId)
        {
            this._excelConverter.Converter(documentId);
        }
    }
}
