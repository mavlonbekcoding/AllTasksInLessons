using MavlonbekExamProjectSecond.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MavlonbekExamProjectSecond.Domain.Entities.Salons
{
    public class Salon : Auditable
    {
        public int UserId { get; set; }
        public string SalonName { get; set; }
        public string SalonPhoneNumber { get; set; }
    }
}
