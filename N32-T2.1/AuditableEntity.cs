using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T2._1
{
    public abstract class AuditableEntity
    {
        public DateTime createdDate { get; set; }
        public DateTime modifieldDate { get; set; }
    }
}
