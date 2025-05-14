using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM_ASSIGNMENT
{
    enum daysoftheweek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
    internal class DayCalender
    {

        public static bool IsWeekend(daysoftheweek theday)
        {
            return theday == daysoftheweek.Friday || theday == daysoftheweek.Thursday;
        }
    }
    
}
