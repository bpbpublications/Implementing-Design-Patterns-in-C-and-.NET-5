using System;
using System.Collections.Generic;

namespace ChapterOneLoopsAndIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileExample();
            DoWhileExample();
            ForExample();
            ForEachExample();
        }

        static void WhileExample()
        {
            int timesExecuted = 0;

            while(timesExecuted < 25)
            {
                Console.WriteLine("Time(s)" + timesExecuted);
                timesExecuted++;
            }
        }

        static void DoWhileExample()
        {
            int timesExecuted = 0;

            do
            {
                Console.WriteLine("Times(s)" + timesExecuted);
                timesExecuted++;
            }
            while (timesExecuted < 25);
        }

        static void ForExample()
        {
            for (int timesExecuted = 0; timesExecuted < 25; timesExecuted++)
            {
                Console.WriteLine("Time(s)" + timesExecuted);
            }
        }

        static void ForEachExample()
        {
            List<string> daysOfWeek = new List<string>();
            daysOfWeek.Add("Monday");
            daysOfWeek.Add("Tuesday");
            daysOfWeek.Add("Wednesday");
            daysOfWeek.Add("Thursday");
            daysOfWeek.Add("Friday");
            daysOfWeek.Add("Saturday");
            daysOfWeek.Add("Sunday");

            foreach(string day in daysOfWeek)
            {
                Console.WriteLine("Days of Week" + day);
            }

        }

    }
}
