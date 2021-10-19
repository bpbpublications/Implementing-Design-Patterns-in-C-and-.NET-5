using System;

namespace _7.ChapterSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobilePlanClient = new MobilePlanClient(MobilePlan.Prepaid);
            Console.WriteLine(mobilePlanClient.Describe());

            mobilePlanClient = new MobilePlanClient(MobilePlan.Postpaid);
            Console.WriteLine(mobilePlanClient.Describe());

            Console.ReadLine();
        }
    }
}
