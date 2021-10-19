namespace _8.ChapterEightWeb
{
    public interface IPDFConverter
    {
        void ConvertToPDF(string filePath);
        string GetSessionInfo();
    }
}