using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_24_06
{
    internal struct Date
    {
        public int year;
        public int month;
        public int day;

        public Date (int d,int m,int y)
        {
            year = y;
            month = m;
            day = d;
        }

        public override string ToString()
        {
            return $"{day}:{month}:{year}";
        }
    }
}
