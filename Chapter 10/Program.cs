using System;

namespace _10.ChapterTen
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseMobilePlanFactory prepaidFactory = new PrepaidMobilePlanFactory();
            IMobilePlan prepaidMobilePlan = prepaidFactory.GetMobilePlan();

            BaseMobilePlanFactory postpaidFactory = new PostpaidMobilePlanFactory();
            IMobilePlan postpaidMobilePlan = postpaidFactory.GetMobilePlan();

            Console.WriteLine("**************PREPAID MOBILE PLAN**************");
            Console.WriteLine("Prepaid Mobile plan speed:" + prepaidMobilePlan.ConnectionSpeed.Velocity);
            Console.WriteLine("Prepaid Mobile plan text message:" + prepaidMobilePlan.TextMessage.QuantityPerMonth);



            Console.WriteLine("**************POSTPAID MOBILE PLAN**************");
            Console.WriteLine("Postpaid Mobile plan speed:" + postpaidMobilePlan.ConnectionSpeed.Velocity);
            Console.WriteLine("Postpaid Mobile plan text message:" + postpaidMobilePlan.TextMessage.QuantityPerMonth);

            Console.WriteLine();
        }
    }
}
