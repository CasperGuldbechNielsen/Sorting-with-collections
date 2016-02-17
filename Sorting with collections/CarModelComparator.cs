using System;
using System.Collections;
using System.Collections.Generic;

namespace Sorting_with_collections
{
    public class CarModelComparator : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}