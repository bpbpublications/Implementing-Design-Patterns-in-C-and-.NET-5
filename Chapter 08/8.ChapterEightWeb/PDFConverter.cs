using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8.ChapterEightWeb
{
    public class PDFConverter : IPDFConverter
    {
        private Session _session;
        private PDFService _pdfService;


        private PDFConverter()
        {
            _pdfService = new PDFService();
            _session = _pdfService.StartSession();
        }

        public void ConvertToPDF(string filePath)
        {
            _pdfService.Convert(filePath, _session);
        }

        public string GetSessionInfo()
        {
            return "Session Info: " + _session.Id;
        }
    }
}
