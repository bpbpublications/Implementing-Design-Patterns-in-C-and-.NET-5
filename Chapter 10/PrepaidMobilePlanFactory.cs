using System;
using System.Collections.Generic;
using System.Text;

namespace _10.ChapterTen
{
    public class PrepaidMobilePlanFactory : BaseMobilePlanFactory
    {
        public override IMobilePlan CreateMobilePlan()
        {
            PrepaidMobilePlan prepaidMobilePlan = new PrepaidMobilePlan();

            prepaidMobilePlan.ConnectionSpeed = new ConnectionSpeed()
            {
                Name = "Low Connection Speed",
                Velocity = 50
            };

            prepaidMobilePlan.TextMessage = new TextMessage()
            {
                Name = "Prepaid Text Message",
                QuantityPerMonth = 2000

            };

            prepaidMobilePlan.PrepaidIntegration();

            return prepaidMobilePlan;
        }



    }
}
