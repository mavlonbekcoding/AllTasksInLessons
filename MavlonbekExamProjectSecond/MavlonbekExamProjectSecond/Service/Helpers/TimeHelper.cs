using MavlonbekExamProjectSecond.Data.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavlonbekExamProjectSecond.Service.Helpers
{
    public class TimeHelper
    {
        public static DateTime GetDateTime()
        {
            var datetime = DateTime.UtcNow;
            datetime = datetime.AddHours(TimeConstants.UTC);
            return datetime;
        }
    }
}
