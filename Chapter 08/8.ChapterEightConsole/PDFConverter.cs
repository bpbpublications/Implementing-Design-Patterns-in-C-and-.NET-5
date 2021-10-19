using System;
using System.Collections.Generic;
using System.Text;

namespace _8.ChapterEightConsole
{
    public class PDFConverter : IPDFConverter
    {
        private Session _session;
        private PDFService _pdfService;

        private static PDFConverter instance;

        public static PDFConverter GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new PDFConverter();
                }

                return instance;
            }
        }
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
