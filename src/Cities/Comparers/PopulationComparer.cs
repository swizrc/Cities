using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    public class PopulationComparer : IComparer<City>
    {
        public int Compare(City x, City y) //x-y
        {
            // return -1 if y > x
            // return 0 if x == y
            // return 1 if x > y
            if (x.Population > y.Population)
            {
                return 1;
            }
            else if (y.Population > x.Population)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
