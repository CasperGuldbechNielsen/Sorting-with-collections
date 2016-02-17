using System;
using System.Collections;
using System.Collections.Generic;

namespace Sorting_with_collections
{
    public class CarYearComparator : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.Year > y.Year)
                return 1;
            if (x.Year < y.Year)
                return -1;
            else
                return 0;
        }
    }
}