using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MavlonbekExamProjectSecond;
using MavlonbekExamProjectSecond.Service.Helpers;

namespace MavlonbekExamProjectSecond.Domain.Common
{
    public class Auditable : Base
    {
        public DateTime CreateAt { get; set; } = TimeHelper.GetDateTime();
        public DateTime UpdateAt { get; set; } = TimeHelper.GetDateTime();
    }
}
