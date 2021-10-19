using System;
using System.Collections.Generic;
using System.Text;

namespace _10.ChapterTen
{
    public class PostpaidMobilePlanFactory : BaseMobilePlanFactory
    {
        public override IMobilePlan CreateMobilePlan()
        {
            PostpaidMobilePlan postpaidMobilePlan = new PostpaidMobilePlan();

            postpaidMobilePlan.ConnectionSpeed = new ConnectionSpeed()
            {
                Name = "High Connection Speed",
                Velocity = 100
            };

            postpaidMobilePlan.TextMessage = new TextMessage()
            {
                Name = "Postpaid Text Message",
                QuantityPerMonth = 5000

            };

            postpaidMobilePlan.PostPaidIntegration();

            return postpaidMobilePlan;
        }
    }
}
