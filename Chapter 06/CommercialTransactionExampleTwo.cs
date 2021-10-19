using System;
using System.Collections.Generic;
using System.Text;

namespace _6.ChapterSix6._1
{
    public class CommercialTransactionExampleTwo
    {
        public void CompleteTransaction()
        {
            new Document().ConvertToPDF(@"C:\desktop\myDocument.docx");
            new Email().Send();
            new LogTransaction().RecordTransaction("Transaction finished at " + DateTime.UtcNow.ToString());

        }
        
    }

    internal class Document
    {
        public void ConvertToPDF(string path)
        {

        }
    }

    internal class Email
    {
        public void Send()
        {

        }
    }
}
