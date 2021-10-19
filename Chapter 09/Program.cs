using System;

namespace _9.ChapterNine
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerPlan planVersionOne = new CustomerPlan()
            {
                Name = "Plan Version 1",
                Price = 100,
                Version = new PlanVersion() { Version = 1 }
            };

            CustomerPlan planVersionTwo = (CustomerPlan)planVersionOne.DeepCopy();


            planVersionTwo.Price = 200;
            planVersionTwo.Name = "Plan Version 2";
            planVersionTwo.Version = new PlanVersion() { Version = 2 };

            Console.WriteLine("Plan 1 - Price:" + planVersionOne.Price);
            Console.WriteLine("Plan 2 - Price:" + planVersionTwo.Price);

            Console.ReadLine();
        }
    }
}
