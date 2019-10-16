using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    public class Refrigerator
    {
        public double MaxWeight { set; get; }
        public int NumberOfItem { set; get; }
        public double UnitWeight {set; get; }

        public double currentWeight = 0;

        public double CurrentWeight()
        {
            return currentWeight += NumberOfItem * UnitWeight;
             //CurrentWeight();
        }

        public double RemainingWeight()
        {
            return MaxWeight - currentWeight;
        }
    }
}
