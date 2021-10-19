using System;
using System.Collections.Generic;
using System.Text;

namespace _8.ChapterEightConsole
{
    public interface IPDFConverter
    {
        void ConvertToPDF(string filePath);
        string GetSessionInfo();
    }
}
