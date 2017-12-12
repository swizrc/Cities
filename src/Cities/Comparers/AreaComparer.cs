using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    public class AreaComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            // return -1 if y > x
            // return 0 if x == y
            // return 1 if x > y
            if (x.Area > y.Area)
            {
                return 1;
            }
            else if (y.Area > x.Area)
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
