using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13DayCount
{
    public class DayService : IDayService
    {
        public int DayCount(int year)
        {
            int count = 0;
            for (int yea = year; yea <= year; yea++)
            {
                for (int month = 1; month < 13; month++)
                {
                    DateTime date = new DateTime(yea, month, 13);
                    if (date.DayOfWeek == DayOfWeek.Friday)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
