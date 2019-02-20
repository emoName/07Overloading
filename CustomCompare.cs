using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Overloading
{
    class CustomCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            //Angle a = (Angle)x;
            //Angle b = (Angle)y;

            if (x is Angle a && y is Angle b)
            {
                if (a.Minutes > b.Minutes) return 1;
                if (a.Minutes < b.Minutes) return -1;
                return 0;
            }
            else
                throw new InvalidCastException();




        }
    }
}
