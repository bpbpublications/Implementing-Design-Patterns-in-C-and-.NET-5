﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _15.ChapterFifteen
{
    public class CityStrategyMethod
    {
        public ICityStrategy SetCityStrategy(string cityPrefix)
        {
            ICityStrategy cityStrategy;

            switch (cityPrefix)
            {
                case "NYC":
                    cityStrategy = new NewYorkStrategy();
                    break;
                case "LAC":
                    cityStrategy = new LosAngelesStrategy();
                    break;
                case "SPC":
                    cityStrategy = new SaoPauloStrategy();
                    break;
                default:
                    cityStrategy = new NewYorkStrategy();
                    break;
            }

            return cityStrategy;
        }
    }
}
